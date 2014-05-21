using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace InventoryTrackingSystem
{
    public partial class frmGDN : Form
    {
        public frmGDN()
        {
            InitializeComponent();
        }

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        GTN _gtn = new GTN();
        GDN _gdn = new GDN();

        private string STOCK = "";
        private bool isEdit = false;
        private void frmGDN_Load(object sender, System.EventArgs e)
        {
            setTranseCode();
        }
        public void callback(string code)
        {
            if (STOCK == "FA")
            {
                var data = _gtn.GetDataFA(code);
                txtExLocation.Text = data.Location;
                txtExCompany.Text = data.Companies;
                txtValue.Text = data.Price;
                txtQty.Text = "1";
                txtQty.Enabled = false;
                /// txtExCurrentUser.Text = data.Current_User;
            }
            else if (STOCK == "EC")
            {
                var data = _gtn.GetDataEC(code);
                txtExLocation.Text = data.Location;
                txtExCompany.Text = data.Companies;
                txtValue.Text = data.Price;
                txtQty.Text = "1";
                txtQty.Enabled = false;
                //  txtExCurrentUser.Text = data.Current_User;
                // txtNeCode.Text = txtItemCode.Text;

            }

        }

        public string serialCode(string code)
        {
            return _gdn.GetSerialCode(code, STOCK);
        }

        private void setTranseCode()
        {
            txtTransCode.Text = _gdn.getCurrentCode();
        }

        public string exLocation(string code)
        {
            return _gtn.GetLocation(code);
        }
        public string exCompany(string code)
        {
            return _gtn.GetCompanies(code);
        }

        private List<Dictionary<string, string>> tableData()
        {
            List<Dictionary<string, string>> collection = new List<Dictionary<string, string>>();
            DataGridViewRowCollection s = gvGDN.Rows;
            int cu = s.Count - 1;
            for (int x = 0; x < cu; x++)
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("code", s[x].Cells[0].Value.ToString());
                data.Add("ex_location", s[x].Cells[1].Value.ToString());
                data.Add("ex_company", s[x].Cells[2].Value.ToString());
                data.Add("qty", s[x].Cells[3].Value.ToString());
                data.Add("value", s[x].Cells[4].Value.ToString());
                data.Add("remark", s[x].Cells[5].Value.ToString());
                collection.Add(data);
            }

            return collection;
        }

        private void cmdStock_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           
            if (cmdStock.SelectedIndex == 0)
            {
                STOCK = "GE";
                enableForGen();
            }
            else if (cmdStock.SelectedIndex == 1)
            {
                STOCK = "FA";
                disableForGen();
            }
            else if (cmdStock.SelectedIndex == 2)
            {
                STOCK = "EC";
                disableForGen();
            }

        }

        private void enableForGen()
        {
            txtExLocation.Enabled = true;
            txtExCompany.Enabled = true;
        }
        private void disableForGen()
        {
            txtExLocation.Enabled = false;
            txtExCompany.Enabled = false;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            clr();

        }

        private void clr()
        {
            cmdStock.Enabled = true;
            cmdStock.SelectedIndex = -1;
            gvGDN.Rows.Clear();
            setTranseCode();
            dDate.Value = DateTime.Now;
            btnDelete.Enabled = false;
            txtTransCode.Enabled = true;
            isEdit = false;
            tbclr();
        }

        private void tbclr()
        {
            txtItemCode.Text = "";
            txtExLocation.Text = "";
            txtExCompany.Text = "";
            txtQty.Text = "";
            txtValue.Text = "";
            txtDescription.Text = "";

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string err = "";

            if (txtItemCode.Text == "")
            {
                err += "Invalide Code !\n";
            }

            if (err != "")
            {
                ntGDN.ShowErr("Error !");
                MessageBox.Show(err);
            }
            else
            {


                gvGDN.Rows.Add(txtItemCode.Text,
                               txtExLocation.Text,
                               txtExCompany.Text,
                               txtQty.Text,
                               txtValue.Text,
                               txtDescription.Text
                               );
                tbclr();
                cmdStock.Enabled = false;
            }
        }

        private void gvGTN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string res = MessageBox.Show("Do you want to delete this recode ?", "Delete existing recode !", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    gvGDN.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        private bool isTableEmpty()
        {
            DataGridViewRowCollection s = gvGDN.Rows;
            int cu = s.Count - 1;
            return (cu == 0) ? true : false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Entity.GTN _data = new Entity.GTN();
            string errMag = "";


            if (!isTableEmpty())
            {
                _data.Date = dDate.Value.ToString("yyyy-MM-dd");
                if ((_data.TransCode = Data.Feed(txtTransCode.Text, true)) == null)
                {
                    errMag = "Invalide Trancs Code !\n";
                }

                if (isTableEmpty())
                {
                    errMag += "Add data to table !\n";
                }

                
                _data.Stock_Type = STOCK;

                _data.TableData = tableData();

                if (errMag != "")
                {
                    ntGDN.ShowErr("Error !");
                    MessageBox.Show(errMag);
                }
                else
                {
                    if (isEdit)
                    {
                        if (_gdn.Update(_data) > 0)
                        {
                            clr();
                            ntGDN.Show("Saved !");
                        }
                        else
                        {
                            ntGDN.ShowErr("Try again !");
                        }
                    }
                    else
                    {
                        if (_gdn.Save(_data) > 0)
                        {
                            clr();
                            ntGDN.Show("Saved !");
                        }
                        else
                        {
                            ntGDN.ShowErr("Try again !");
                        }
                    }
                }
            }
            else
            {
                ntGDN.ShowErr("Error !");
                MessageBox.Show("Empty Data set !");
            }
        }

        private void txtTransCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var result = _gdn.getDataByCode(txtTransCode.Text);
                if (result != null)
                {
                    string res = MessageBox.Show("Do you want load this recode ?", "Load existing recode !", MessageBoxButtons.YesNo).ToString();
                    if (res == "Yes")
                    {
                        txtTransCode.Enabled = false;
                       // dDate.Value = Convert.ToDateTime(result[0]["dDate"]);

                        foreach (var data in result)
                        {
                            gvGDN.Rows.Add(data["item_code"],
                                           data["ex_location"],
                                           data["ex_company"],
                                           data["qty"],
                                           data["value"],
                                           data["remark"]
                                           );
                            STOCK = data["stock_code"];
                        }

                        isEdit = true;
                        setStockCat(STOCK);
                        btnDelete.Enabled = true;
                    }
                }
            }
        }
         
        private void setStockCat(string code)
        {
            if (code == "GE")
            {
                cmdStock.SelectedIndex = 0;
                cmdStock.Enabled = false;
            }
            else if (code == "FA")
            {
                cmdStock.SelectedIndex = 1;
                cmdStock.Enabled = false;
            }
            else
            {
                cmdStock.SelectedIndex = 2;
                cmdStock.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string res = MessageBox.Show("Do you want to delete this recode ?", "Delete existing recode ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (res == "Yes")
            {
                if (_gdn.Delete(txtTransCode.Text,STOCK) > 0)
                {
                    clr();
                    ntGDN.Show("Deleted !");
                }
                else
                {
                    ntGDN.ShowErr("Try Again !");
                }
            }
        }

    }
}