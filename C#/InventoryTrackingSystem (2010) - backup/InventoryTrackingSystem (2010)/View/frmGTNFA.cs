using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace InventoryTrackingSystem
{
    public partial class frmGTNFA : Form
    {
        public frmGTNFA()
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
        bool isEdit = false;
        string STOCK = "";

        private void frmGTNFA_Load(object sender, System.EventArgs e)
        {
            setTransCode();
            diable();
        }

        private void setTransCode()
        {
            txtTransCode.Text =_gtn.getCurrentCode();
        }

        #region AutoComplete

        public string serialCode(string code)
        {
            return _gtn.GetSerialCode(code,STOCK);
        }
        public string exLocation(string code)
        {
            return _gtn.GetLocation(code);
        }
        public string exCompany(string code)
        {
            return _gtn.GetCompanies(code);
        }
        public string neCompany(string code)
        {
            return _gtn.GetCompanies(code);
        }
        public string neLocation(string code)
        {
            return _gtn.GetLocation(code);
        }
        public string exCurrentUser(string code)
        {
            return _gtn.GetEmp(code);
        }
        public string neCurrentUser(string code)
        {
            return _gtn.GetEmp(code);
        }
        #endregion

        #region Table CONF

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string err = "";

            if (txtItemCode.Text == "")
            {
                err += "Invalide Code: !\n";
            }
            if (txtExLocation.Text == "")
            {
                err += "Invalide Ex:Location !\n";
            }
            if (txtExCompany.Text == "")
            {
                err += "Invalide Ex:Company !\n";
            }
            if (txtNeLocation.Text == "")
            {
                err += "Invalide Ne:Location !\n";
            }
            if (txtNeCompany.Text == "")
            {
                err += "Invalide Ne:Company !\n";
            }
            if (txtNeCode.Text == "")
            {
                err += "Invalide Ne:Code !\n";
            }

            if (err != "")
            {
                ntGTN.ShowErr("Error !");
                MessageBox.Show(err);
            }
            else
            {
                if (txtNeCode.Text != txtItemCode.Text)
                {
                    if (!_gtn.NewCodeValidate(txtNeCode.Text))
                    {
                        ntGTN.ShowErr("Error !");
                        MessageBox.Show("New code already exist in system !");
                    }
                    else
                    {
                        gvGTN.Rows.Add(txtItemCode.Text,
                                       txtExLocation.Text,
                                       txtExCompany.Text,
                                       txtExCurrentUser.Text,
                                       txtNeCode.Text,
                                       txtNeLocation.Text,
                                       txtNeCompany.Text,
                                       txtNeCurrentUser.Text,
                                       txtRemark.Text
                                       );
                        tbClr();
                    }
                }
                else
                {
                    gvGTN.Rows.Add(txtItemCode.Text,
                                      txtExLocation.Text,
                                      txtExCompany.Text,
                                      txtExCurrentUser.Text,
                                      txtNeCode.Text,
                                      txtNeLocation.Text,
                                      txtNeCompany.Text,
                                      txtNeCurrentUser.Text,
                                      txtRemark.Text
                                      );
                    tbClr();
                }
                //ntGTN.Show("Added !");

            }
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

        private List<Dictionary<string, string>> tableData()
        {
            List<Dictionary<string, string>> collection = new List<Dictionary<string, string>>();
            DataGridViewRowCollection s = gvGTN.Rows;
            int cu = s.Count - 1;
            for (int x = 0; x < cu; x++)
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("code", s[x].Cells[0].Value.ToString());
                data.Add("ex_location", s[x].Cells[1].Value.ToString());
                data.Add("ex_company", s[x].Cells[2].Value.ToString());
                string[] a = s[x].Cells[3].Value.ToString().Split('-');
                data.Add("ex_currentUser", a[1]);
                data.Add("ne_code", s[x].Cells[4].Value.ToString());
                data.Add("ne_location", s[x].Cells[5].Value.ToString());
                data.Add("ne_company", s[x].Cells[6].Value.ToString());
                string[] b = s[x].Cells[7].Value.ToString().Split('-');
                data.Add("ne_currentUser",b[1]);
                data.Add("remark", s[x].Cells[8].Value.ToString());
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

        #region Basic

        private void tbClr()
        {
            txtItemCode.Text = "";
            txtExLocation.Text = "";
            txtExCompany.Text = "";
            txtExCurrentUser.Text = "";
            txtNeCode.Text = "";
            txtNeLocation.Text = "";
            txtNeCompany.Text = "";
            txtNeCurrentUser.Text = "";
            txtRemark.Text = "";
        }

        private void diable()
        {
            txtItemCode.Enabled = false;
            txtNeCode.Enabled = false;
            txtNeLocation.Enabled = false;
            txtNeCompany.Enabled = false;
            txtNeCurrentUser.Enabled = false;
            txtRemark.Enabled = false;
            btnAdd.Enabled = false;
            txtDesc.Enabled = false;
        }
        private void enable()
        {
            txtItemCode.Enabled = true;
            txtNeCode.Enabled = true;
            txtNeLocation.Enabled = true;
            txtNeCompany.Enabled = true;
            txtNeCurrentUser.Enabled = true;
            txtRemark.Enabled = true;
            btnAdd.Enabled = true;
            txtDesc.Enabled = true;
        } 
        #endregion

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

                _data.RefNo = Data.Feed(txtDesc.Text, false);
                _data.Stock_Type = STOCK;

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
                        if (_gtn.Update(_data) > 0)
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
                        if (_gtn.Save(_data) > 0)
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
                ntGTN.ShowErr("Error !");
                MessageBox.Show("Empty Data set !");
            }

        } 
        #endregion

        public void loadExData(string code)
        {
        
            if (STOCK == "FA")
            {
                var data= _gtn.GetDataFA(code);
                txtExLocation.Text = data.Location;
                txtExCompany.Text = data.Companies;
                txtExCurrentUser.Text = data.Current_User;
            }
            else
            {
                var data = _gtn.GetDataEC(code);
                txtExLocation.Text = data.Location;
                txtExCompany.Text = data.Companies;
                txtExCurrentUser.Text = data.Current_User;
                txtNeCode.Text = txtItemCode.Text;
                
            }
           
        }

       
        private void cmdStock_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            enable();
            if (cmdStock.SelectedIndex == 0)
            {
                STOCK = "FA";
            }
            else if (cmdStock.SelectedIndex == 1)
            {
                STOCK = "EC";
                txtNeCode.Enabled = false;
            }

            //clr();
            //tbClr();
        }

        private void clr()
        {
            gvGTN.Rows.Clear();
            txtDesc.Text = "";
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            txtTransCode.Text = "";
            txtTransCode.Enabled = true;
            setTransCode();
            cmdStock.SelectedIndex = -1;
            isEdit = false;
            STOCK = "";
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            clr();
            tbClr();
            cmdStock.SelectedIndex = -1;
            diable();
        }

        private void txtTransCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var result = _gtn.getDataByCode(txtTransCode.Text);
                if (result != null)
                {
                    string res = MessageBox.Show("Do you want load this recode ?", "Load existing recode !", MessageBoxButtons.YesNo).ToString();
                    if (res == "Yes")
                    {
                        txtTransCode.Enabled = false;
                        dDate.Value = Convert.ToDateTime(result[0]["dDate"]);
                        txtDesc.Text = result[0]["desc"];

                        foreach (var data in result)
                        {
                            gvGTN.Rows.Add(data["ex_serial_code"],
                                           data["ex_location"],
                                           data["ex_company"],
                                           data["ex_user"],
                                           data["nw_serial_code"],
                                           data["nw_location"],
                                           data["nw_company"],
                                           data["nw_user"],
                                           data["remarks"]
                                           );
                            STOCK = data["stock_code"];
                        }

                        isEdit = true;
                        setStockCat(STOCK);
                        btnDelete.Enabled = true;
                        btnPrint.Enabled = true;
                    }
                }
            }
        }

        private void setStockCat(string code)
        {
            if (code == "FA")
            {
                cmdStock.SelectedIndex = 0;
            }
            else
            {
                cmdStock.SelectedIndex = 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string res = MessageBox.Show("Do you want to delete this recode ?", "Delete existing recode ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (res == "Yes")
            {
                if (_gtn.Delete(txtTransCode.Text,STOCK) > 0)
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
