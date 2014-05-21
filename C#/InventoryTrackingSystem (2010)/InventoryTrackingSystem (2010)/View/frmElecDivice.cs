using System.Windows.Forms;
using System;

namespace InventoryTrackingSystem
{
    public partial class frmElecDivice : Form
    {
        public frmElecDivice()
        {
            InitializeComponent();
            txtValue.LostFocus += new System.EventHandler(txtValue_LostFocus);
        }

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Basic Function
        ElecDivice _elecDivice = new ElecDivice();

        private void frmElecDivice_Load(object sender, System.EventArgs e)
        {
            setTranceCode();
        }

        private void setTranceCode()
        {
            txtTransCode.Text = _elecDivice.getCurrentCode();
        }

        public string getItemCategory(string code)
        {
            return _elecDivice.GetItemCat(code);
        }

        public string getLocation(string code)
        {
            return _elecDivice.GetLocation(code);
        }

        public string getCompany(string code)
        {
            return _elecDivice.GetCompanies(code);
        }

        public string getCurrenUser(string code)
        {
            return _elecDivice.GetEmp(code);
        }
        public string getBrand(string code)
        {
           return _elecDivice.GetBrand(code);
        }
        public string getModel(string code)
        {
            return _elecDivice.GetModel(code);
        }


        private void btnCategoty_Click(object sender, System.EventArgs e)
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
            Stat.selected = 2;
            frmLoc.Show();
        }

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

        #endregion

        private bool isEdit = false;

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            string errMag = "";
            ECFieldData _ECData = new ECFieldData();

            _ECData.Date = Data.Feed(dDate.Text, false);
            _ECData.RefNo = Data.Feed(txtRefNo.Text, false);

            if ((_ECData.TransCode = Data.Feed(txtTransCode.Text, true)) == null)
            {
                errMag += "Incorrect Trance code !\n";
            }

            if ((_ECData.Serial = Data.Feed(txtSerial.Text, true))==null)
            {
                errMag += "Invalide Serial Number !\n";
            }

            if ((_ECData.ItemCategory = Data.Feed(txtCategory.Text, true)) == null)
            {
                errMag += "Add Item Category !\n";
            }

            _ECData.Brand = Data.Feed(txtBrand.Text, true);
            _ECData.Model = Data.Feed(txtModel.Text, true);
            _ECData.Price = Data.Feed(txtValue.Text, false);

            if ((_ECData.Location = Data.Feed(txtLocation.Text, true)) == null)
            {
                errMag += "Insert Item Location !\n";
            }

            if (txtCompany.Text == "") 
            {
                errMag += "Invalide Company !\n";
            }
            else
            {
                string[] comp = txtCompany.Text.Split('/');
                _ECData.Companies = Data.Feed(comp[0], true);
            }

            if (txtCurrentUser.Text == "")
            {
                errMag += "Add Current User !\n";
            }
            else
            {
                string[] cu = txtCurrentUser.Text.Split('-');
                _ECData.Current_User = Data.Feed(cu[1], true);
            }

            _ECData.Description = Data.Feed(txtDesc.Text, false);
            _ECData.Remark = Data.Feed(txtRemark.Text, false);

            if (errMag != "")
            {
                ntComDivice.ShowErr("Error !");
                MessageBox.Show(errMag);
            }
            else
            {
                if (isEdit)
                {
                    if (_elecDivice.Update(_ECData) > 0)
                    {
                        clr();
                        ntComDivice.Show("Saved !");
                    }
                    else
                    {
                        ntComDivice.ShowErr("Try again !");
                    }
                }
                else
                {
                    if (_elecDivice.Save(_ECData) > 0)
                    {
                        clr();
                        ntComDivice.Show("Saved !");
                    }
                    else
                    {
                        ntComDivice.ShowErr("Try again !");
                    }
                }
            }
        }


        private void clr()
        {
            dDate.Value = DateTime.Now;
            txtTransCode.Text = "";
            txtRefNo.Text = "";
            txtCategory.Text = "";
            txtSerial.Text = "";
            txtBrand.Text = "";
            txtModel.Text = "";
            txtValue.Text = "";
            txtCompany.Text = "";
            txtLocation.Text = "";
            txtCurrentUser.Text = "";
            txtDesc.Text = "";
            txtRemark.Text = "";
            btnDelete.Enabled = false;
            txtTransCode.Enabled = true;
            isEdit = false;
            setTranceCode();
            
        }

        private void loadDataByTransCode(string code)
        {
            var res = _elecDivice.getDataBy(code, 1);
            dDate.Value = Convert.ToDateTime(res.Date);
            txtRefNo.Text = res.RefNo;
            txtCategory.Text = res.ItemCategory;
            txtSerial.Text = res.Serial;
            txtBrand.Text = res.Brand;
            txtModel.Text = res.Model;
            txtValue.Text = res.Price;
            txtCompany.Text = res.Companies;
            txtLocation.Text = res.Location;
            txtCurrentUser.Text = res.Current_User;
            txtDesc.Text = res.Description;
            txtRemark.Text = res.Remark;
            btnDelete.Enabled = true;
            txtTransCode.Enabled = false;
            isEdit = true;
        }

        private void txtTransCode_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadDataByTransCode(txtTransCode.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clr();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           string res = MessageBox.Show("Do you want to delete this recode ?", "Delete existing recode ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
           if (res == "Yes")
           {
               if (_elecDivice.Delete(txtTransCode.Text) > 0)
               {
                   ntComDivice.Show("Deleted !");
                   clr();
               }
               else
               {
                   ntComDivice.ShowErr("Try again !");
               }
           }
        }




    }
}
