using System.Windows.Forms;
using dbexlib;
using System;

namespace InventoryTrackingSystem
{
    public partial class frmFixtAsset : Form
    {
        public frmFixtAsset()
        {
            InitializeComponent();
            txtValue.LostFocus+=new System.EventHandler(txtValue_LostFocus);
        }
        FixtAssetGRN _fixtAssetGRN = new FixtAssetGRN();
        

        private bool isEdit = false;
    
        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void frmFixtAsset_Load(object sender, System.EventArgs e)
        {
            setTranceCode();
        }

        #region Basic Function
        private void setTranceCode()
        {
            txtTransCode.Text = _fixtAssetGRN.getCurrentCode();
        }
        
        //Autocomplete
        public string getItemCode(string code)
        {
            txtSerialNo.Text = "";
            return _fixtAssetGRN.GetItemCat(code);
        }

        public string getCompanies(string code)
        {
            return _fixtAssetGRN.GetCompanies(code);
        }

        public string getItemName(string code)
        {
            return _fixtAssetGRN.GetItemName(code);
        }

        public string getLocation(string code)
        {
            return _fixtAssetGRN.GetLocation(code);
        }

        public string getEmp(string code)
        {
            return _fixtAssetGRN.GetEmp(code);
        }
        //End Autocomplete
        private void txtValue_LostFocus(object sender, System.EventArgs e)
        {
            txtValue.AppendText(".00");
        }

        private void txtValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(txtValue, true, false, true, false);
            }
        }

        //serial number genarate
        public void setSerial(string code)
        {
            txtSerialNo.Text = code + "-" + _fixtAssetGRN.getSerial(code);
        }



        private void btnAddNew_Click(object sender, System.EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmItemCate))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmItemCate();
            frmLoc.MdiParent = this.ParentForm;
            Stat.selected = 1;
            frmLoc.Show();
        }

        #endregion

        #region Save
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            string errMag = "";
            FixtAssetData _fixtAssetData = new FixtAssetData();

            _fixtAssetData.Date = Data.Feed(dDate.Text, false);

            if ((_fixtAssetData.TransCode = Data.Feed(txtTransCode.Text, true)) == null)
            {
                errMag += "Incorrect Trance code !\n";
            }

            if ((_fixtAssetData.ItemCategory = Data.Feed(txtItemCategory.Text, true)) == null)
            {
                errMag += "Add Item Category !\n";
            }
            
            if (txtSerialNo.Text == "")
            {
                errMag += "Invalide Serial Number !\n";
            }
            else
            {
                string[] code = txtSerialNo.Text.Split('-');
                _fixtAssetData.Serial = Data.Feed(code[1], true);
            }

            _fixtAssetData.RefNo = Data.Feed(txtRefNo.Text, false);

            if ((_fixtAssetData.Name = Data.Feed(txtItemName.Text, true)) == null)
            {
                errMag += "Insert Item Name !\n";
            }
            
            if (txtCompany.Text == "")
            {
                errMag += "Invalide Company !\n";
            }
            else
            {
                string[] comp = txtCompany.Text.Split('/');
                _fixtAssetData.Companies = Data.Feed(comp[0], true);
            }

            if ((_fixtAssetData.Location = Data.Feed(txtLocation.Text, true)) == null)
            {
                errMag += "Insert Item Location !\n";
            }
            
            _fixtAssetData.Price = Data.Feed(txtValue.Text, false);
            
            if ( txtCurrentUser.Text== "")
            {
                errMag += "Add Current User !\n";
            }
            else
            {
                string[] cu = txtCurrentUser.Text.Split('-');
                _fixtAssetData.Current_User = Data.Feed(cu[1], true);
            }

            _fixtAssetData.Description = Data.Feed(txtDesc.Text, false);
            _fixtAssetData.Remark = Data.Feed(txtRemark.Text, false);

            if (errMag != "")
            {
                ntFA.ShowErr("Error !");
                MessageBox.Show(errMag);
            }
            else
            {
                if (isEdit)
                {
                    if (_fixtAssetGRN.Update(_fixtAssetData) > 0)
                    {
                        clr();
                        ntFA.Show("Saved !");
                    }
                    else
                    {
                        ntFA.ShowErr("Try again !");
                    }
                }
                else
                {
                    if (_fixtAssetGRN.Save(_fixtAssetData) > 0)
                    {
                        clr();
                        ntFA.Show("Saved !");
                    }
                    else
                    {
                        ntFA.ShowErr("Try again !");
                    }
                }
            }
        }
        #endregion


        private void clr()
        {

            dDate.Value = DateTime.Now;
            txtTransCode.Text = "";
            txtItemCategory.Text = "";
            txtSerialNo.Text = "";
            txtRefNo.Text = "";
            txtItemName.Text = "";
            txtCompany.Text = "";
            txtLocation.Text = "";
            txtValue.Text = "";
            txtCurrentUser.Text = "";
            txtDesc.Text = "";
            txtRemark.Text = "";
            isEdit = false;
            btnDelete.Enabled = false;
            txtTransCode.Enabled = true;
            setTranceCode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clr();
        }

        private void txtTransCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadDataFromTransCode(txtTransCode.Text);
            }
        }

        private void loadDataFromTransCode(string code)
        {
            var res = _fixtAssetGRN.getDataBy(code,1);
            dDate.Value = Convert.ToDateTime(res.Date);
            txtTransCode.Enabled = false;
            txtItemCategory.Text = res.ItemCategory;
            txtSerialNo.Text = res.Serial;
            txtRefNo.Text = res.RefNo;
            txtItemName.Text = res.Name;
            txtCompany.Text = res.Companies;
            txtLocation.Text = res.Location;
            txtValue.Text = res.Price;
            txtCurrentUser.Text = res.Current_User;
            txtDesc.Text = res.Description;
            txtRemark.Text = res.Remark;
            isEdit = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string res = MessageBox.Show("Do you want to delete this recode ?", "Delete existing recode ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (res == "Yes")
            {
                if (_fixtAssetGRN.Delete(txtTransCode.Text) > 0)
                {
                    ntFA.Show("Deleted !");
                    clr();
                }
                else
                {
                    ntFA.ShowErr("Try Again !");
                }
            }      
        }

        private void btnRefSer_Click(object sender, EventArgs e)
        {
            if (txtRefNo.Text != "")
            {
                loardDataWith(txtRefNo.Text);
            }
            else
            {
                MessageBox.Show("Invalide RefNo !");
            }
        }

        private void loardDataWith(string refNo)
        {
            var res = _fixtAssetGRN.getDataBy(refNo, 2);
            dDate.Value = Convert.ToDateTime(res.Date);
            txtTransCode.Enabled = false;
            txtTransCode.Text = res.TransCode;
            txtItemCategory.Text = res.ItemCategory;
            txtSerialNo.Text = res.Serial;
            txtRefNo.Text = res.RefNo;
            txtItemName.Text = res.Name;
            txtCompany.Text = res.Companies;
            txtLocation.Text = res.Location;
            txtValue.Text = res.Price;
            txtCurrentUser.Text = res.Current_User;
            txtDesc.Text = res.Description;
            txtRemark.Text = res.Remark;
            isEdit = true;
            btnDelete.Enabled = true;
        }
    }
}
