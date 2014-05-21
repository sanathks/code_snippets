using System.Windows.Forms;
using System;


namespace InventoryTrackingSystem
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion
        Companies _companies = new Companies();
        Location  _location = new Location();
        Employee  _employee = new Employee();

        private bool isEdit = false;
        string company = "";
        string location = "";

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            EmpField _employeeFieldData = new EmpField();
            string errorMessage = "";

            _employeeFieldData.Title = cmbTitle.SelectedIndex.ToString();

            if ((_employeeFieldData.Code = Data.Feed(txtEmpCode.Text,true)) == null)
            {
                errorMessage += "Insert Employee Code ! \n";
            }
            if ((_employeeFieldData.Name = Data.Feed(txtEmpName.Text, true)) == null)
            {
                errorMessage += "Insert Employee Name ! \n";
            }

            _employeeFieldData.Designation = Data.Feed(txtDesingnation.Text, false);

            if (Data.Feed(txtComName.Text, true) == null)
            {
                errorMessage += "Insert Company Name ! \n";
            }
            else
            {
                _employeeFieldData.CompanyName = setCompany(txtComName.Text);
            }

            if (Data.Feed(txtLocation.Text, true) == null)
            {
                errorMessage += "Insert Location Name ! \n";
            }
            else
            {
                _employeeFieldData.Location = setLocation(txtLocation.Text);
            }

            _employeeFieldData.PhoneNumber = Data.Feed(txtPhoneNo.Text, false);

            if (txtEmpEmail.Text != "")
            {

                if ((Data.IsValidEmail(txtEmpEmail.Text)))
                {
                    _employeeFieldData.Email = txtEmpEmail.Text;
                }
                else
                {
                    errorMessage += "Insert Valid Email ! \n";
                }
            }

            if (errorMessage != "")
            {
                ntEmployee.ShowErr("Error !");
                MessageBox.Show(errorMessage);
            }
            else
            {
                if (isEdit)
                {
                    if (_employee.Update(_employeeFieldData) > 0)
                    {
                        clr();
                        ntEmployee.Show("Saved !");
                    }
                    else
                    {
                        ntEmployee.ShowErr("Try again !");
                    }
                }
                else
                {
                    if (_employee.Save(_employeeFieldData) > 0)
                    {
                        clr();
                        ntEmployee.Show("Saved !");
                    }
                    else
                    {
                        ntEmployee.ShowErr("Try again !");
                    }
                }
            }
            

            
        }

        public string getCompany(string code)
        {
            return _companies.CompaniesName(code);
        }

        public string setCompany(string comp)
        {
            var data = comp.Split('/');
            company = data[0];
            return data[0];
        }

        public string getLocation(string code)
        {
            return _location.LocationName(code);
        }

        public string setLocation(string code)
        {
            var data = code.Split('/');
            location = data[0];
            return data[0];
        }

        private void frmEmployee_Load(object sender, System.EventArgs e)
        {
            loadCurrentCode();
        }

        private void clr()
        {
            txtEmpCode.Text = "";
            txtEmpName.Text = "";
            cmbTitle.SelectedIndex = 0;
            txtDesingnation.Text = "";
            txtComName.Text = "";
            txtLocation.Text = "";
            txtPhoneNo.Text="";
            txtEmpEmail.Text = "";
            loadCurrentCode();
            txtEmpCode.Enabled = true;
            isEdit = false;
            company = "";
            location = "";
            txtEmpName.Focus();
            btnDelete.Enabled = false;
        }
        private void loadCurrentCode()
        {
            txtEmpCode.Text = _employee.empCurrentCode();
        }

        public void loadExData(string code)
        {
            var result = _employee.checkExData(code);
            if (result != null)
            {
                string res = MessageBox.Show("Do you want load this recode ?", "Load existing recode !", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    txtEmpCode.Enabled = false;
                    txtEmpCode.Text = result.Code;
                    txtEmpName.Text = result.Name;
                    cmbTitle.SelectedIndex = Convert.ToInt32(result.Title);
                    txtDesingnation.Text = result.Designation;
                    txtComName.Text = result.CompanyName+"/"+_companies.getCompany(result.CompanyName);
                    txtLocation.Text = result.Location + "/" + _location.getLocation(result.Location);
                    txtPhoneNo.Text = result.PhoneNumber;
                    txtEmpEmail.Text = result.Email;
                    isEdit = true;
                    btnDelete.Enabled = true;
                }
            }
        }

        public string exEmp(string key)
        {
            return _employee.exEmp(key);
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (_employee.Delete(txtEmpCode.Text) > 0)
            {
                ntEmployee.Show("Deleted !");
                clr();
            }
            else
            {
                ntEmployee.ShowErr("Try again !");
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Log.write("OK");
            clr();
        }

       
        private void txtEmpCode_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var result = _employee.getDataByCode(txtEmpCode.Text);
                if (result != null)
                {
                    string res = MessageBox.Show("Do you want load this recode ?", "Load existing recode !", MessageBoxButtons.YesNo).ToString();
                    if (res == "Yes")
                    {
                        txtEmpCode.Enabled = false;
                        txtEmpCode.Text = result.Code;
                        txtEmpName.Text = result.Name;
                        cmbTitle.SelectedIndex = Convert.ToInt32(result.Title);
                        txtDesingnation.Text = result.Designation;
                        txtComName.Text = result.CompanyName + "/" + _companies.getCompany(result.CompanyName);
                        txtLocation.Text = result.Location + "/" + _location.getLocation(result.Location);
                        txtPhoneNo.Text = result.PhoneNumber;
                        txtEmpEmail.Text = result.Email;
                        txtEmpEmail.Focus();
                        isEdit = true;
                        btnDelete.Enabled = true;
                    }
                }
            }
        }

    }
}
