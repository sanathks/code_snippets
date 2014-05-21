using System.Windows.Forms;
using acclib;
using System;
using System.Collections.Generic;

namespace InventoryTrackingSystem
{
    public partial class frmGTNGen : Form
    {
        public frmGTNGen()
        {
            InitializeComponent();
        }

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        GenGTN _genGTN = new GenGTN();
        bool isEdit = false;

        private void frmGTNGen_Load(object sender, System.EventArgs e)
        {
            setTranseCode();
        }

        private void setTranseCode()
        {
            txtTransCode.Text = _genGTN.getCurrentCode();
        }

        #region Save

        private void btnSave_Click(object sender, System.EventArgs e)
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

                _data.RefNo = Data.Feed(txtRefNo.Text, false);

                _data.Description = Data.Feed(txtDescription.Text, false);

                _data.TableData = tableData();

                if (errMag != "")
                {
                    ntGTN.ShowErr("Error !");
                    MessageBox.Show(errMag);
                }
                else
                {
                    if (isEdit)
                    {
                        if (_genGTN.Update(_data) > 0)
                        {
                            clr();
                            ntGTN.Show("Saved !");
                        }
                        else
                        {
                            ntGTN.ShowErr("Try again !");
                        }
                    }
                    else
                    {
                        if (_genGTN.Save(_data) > 0)
                        {
                            clr();
                            ntGTN.Show("Saved !");
                        }
                        else
                        {
                            ntGTN.ShowErr("Try again !");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Data set !");
                ntGTN.ShowErr("Error !");
            }

        } 
        #endregion

        #region Table method
        private List<Dictionary<string, string>> tableData()
        {
            List<Dictionary<string, string>> collection = new List<Dictionary<string, string>>();
            DataGridViewRowCollection s = gvGTN.Rows;
            int cu = s.Count - 1;
            for (int x = 0; x < cu; x++)
            {

                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("item_name", s[x].Cells[0].Value.ToString());
                data.Add("ex_location", s[x].Cells[1].Value.ToString());
                data.Add("ex_company", s[x].Cells[2].Value.ToString());
                data.Add("qty", s[x].Cells[3].Value.ToString());
                data.Add("ne_location", s[x].Cells[4].Value.ToString());
                data.Add("ne_company", s[x].Cells[5].Value.ToString());
                data.Add("remark", s[x].Cells[6].Value.ToString());
                collection.Add(data);
            }

            return collection;
        }
        private bool isTableEmpty()
        {
            DataGridViewRowCollection s = gvGTN.Rows;
            int cu = s.Count - 1;
            return (cu == 0) ? true : false;
        }
        #endregion

        #region ACom
        public string getItemName(string code)
        {
            return _genGTN.getItemName(code);
        }
        public string getLocationEx(string code)
        {
            return _genGTN.GetLocation(code);
        }
        public string getComapanyEx(string code)
        {
            return _genGTN.GetCompanies(code);
        }
        public string getLocationNe(string code)
        {
            return _genGTN.GetLocation(code);
        }
        public string getComapanyNe(string code)
        {
            return _genGTN.GetCompanies(code);
        } 
        #endregion

        #region Add to Table

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string err = "";
            if (txtItemName.Text == "")
            {
                err += "Invalide Item Cat: !\n";
            }
            if (txtExLocation.Text == "")
            {
                err += "Invalide Ex:Location !\n";
            }
            if (txtExCompany.Text == "")
            {
                err += "Invalide Ex:Company !\n";
            }
            if (txtQty.Text == "")
            {
                err += "Invalide Qty !\n";
            }
            if (txtNewLocation.Text == "")
            {
                err += "Invalide Ne:Location !\n";
            }
            if (txtNewCompany.Text == "")
            {
                err += "Invalide Ne:Company !\n";
            }

            if (err != "")
            {
                ntGTN.ShowErr("Error !");
                MessageBox.Show(err);
            }
            else
            {
                if (dataValidate())
                {
                    gvGTN.Rows.Add(txtItemName.Text,
                                   txtExLocation.Text,
                                   txtExCompany.Text,
                                   txtQty.Text,
                                   txtNewLocation.Text,
                                   txtNewCompany.Text,
                                   txtRemark.Text
                                   );
                    tvalClr();
                    //ntGTN.Show("Added !");
                }
                else
                {
                    ntGTN.ShowErr("Error !");
                    MessageBox.Show("Invalide data on the table !");
                }
            }

        }

        private bool dataValidate()
        {
            return true;
        }

        private void gvGTN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string res = MessageBox.Show("Do you want to delete this recode ?", "Delete existing recode !", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    gvGTN.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        #endregion

        #region Clear Functions
        private void tvalClr()
        {
            txtItemName.Text = "";
            txtExLocation.Text = "";
            txtExCompany.Text = "";
            txtQty.Text = "";
            txtNewLocation.Text = "";
            txtNewCompany.Text = "";
            txtRemark.Text = "";
            txtItemName.Focus();
        }

        private void clr()
        {
            tvalClr();
            dDate.Value = DateTime.Now;
            txtRefNo.Text = "";
            txtDescription.Text = "";
            btnDelete.Enabled = false;
            setTranseCode();
            gvGTN.Rows.Clear();
            isEdit = false;
            txtTransCode.Enabled = true;
       
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            clr();

        }

        #endregion

    
        private void txtTranceCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var result = _genGTN.getDataByCode(txtTransCode.Text);
                if (result != null)
                {
                    string res = MessageBox.Show("Do you want load this recode ?", "Load existing recode !", MessageBoxButtons.YesNo).ToString();
                    if (res == "Yes")
                    {
                        txtTransCode.Enabled = false;
                        dDate.Value = Convert.ToDateTime(result[0]["dDate"]);
                        txtRefNo.Text = result[0]["ref_no"];
                        txtDescription.Text = result[0]["desc"];

                        foreach (var data in result)
                        {
                            gvGTN.Rows.Add(data["item_cat"],
                                           data["ex_location"],
                                           data["ex_company"],
                                           data["qty"],
                                           data["nw_location"],
                                           data["nw_company"],
                                           data["remarks"]
                                           );
                        }
                        isEdit = true;
                        btnDelete.Enabled = true;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             string res = MessageBox.Show("Do you want to delete this recode ?", "Delete existing recode ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
             if (res == "Yes")
             {
                 if (_genGTN.Delete(txtTransCode.Text) > 0)
                 {
                     clr();
                     ntGTN.Show("Deleted !");
                 }
                 else
                 {
                     ntGTN.ShowErr("Try Again !");
                 }
             }
        }

        

    }
}
