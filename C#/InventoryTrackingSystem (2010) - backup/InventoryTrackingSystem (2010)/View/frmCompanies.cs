using System.Windows.Forms;
using System.Drawing;

namespace InventoryTrackingSystem
{
    public partial class frmCompanies : Form
    {
        public frmCompanies()
        {
            InitializeComponent();
            
        }

        Companies com = new Companies();
        
        bool isEdit = false;
        public string exCompany(string key)
        {
          return com.exCompanies(key);
        }

        public void loadExData(string code)
        {
            var result= com.checkExData(code);
            if (result != null)
            {
                string res = MessageBox.Show("Do you want load this recode ?", "Load existing recode !", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    txtShortName.Enabled = false;
                    txtShortName.Text = result.Code;
                    txtComName.Text = result.Name;
                    txtCompDesc.Text = result.Description;
                    isEdit = true;
                    btnDelete.Enabled = true;
                }
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
           this.Close();
           
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Fields data = new Fields();
            int err = 0;
            string errmsg = "";
            if ((data.Code=Data.Feed(txtShortName.Text, true)) == null)
            {
                errmsg+="Intert Short Name ! \n";
                err++;
            }
            if ((data.Name=Data.Feed(txtComName.Text, true)) == null)
            {
                errmsg+= "Intert Name ! \n";
                err++;
            }

            data.Description=Data.Feed(txtCompDesc.Text,false);

            if (err > 0)
            {
               ntCompanies.ShowErr("Error !");
               MessageBox.Show(errmsg,"Error !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (isEdit)
                {
                    if (com.Update(data) > 0)
                    {
                        clr();
                        ntCompanies.Show("Saved !");
                    }
                }
                else
                {

                    if (com.Save(data) > 0)
                    {
                        clr();
                        ntCompanies.Show("Saved !");
                    }
                }
            }
           
        }

        private void clr()
        {
            txtShortName.Text = "";
            txtComName.Text = "";
            txtCompDesc.Text = "";
            txtShortName.Enabled = true;
            txtShortName.Focus();
            isEdit = false;
            btnDelete.Enabled = false;
        }

        private void txtShortName_KeyDown(object sender, KeyEventArgs e)
        {
            txtComName.Text = "";
            txtCompDesc.Text = "";
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            clr();
           
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            string res = MessageBox.Show("Do you want to delete this recode ?", "Delete existing recode ?", MessageBoxButtons.YesNo,MessageBoxIcon.Warning ).ToString();
            if (res == "Yes")
            {
                if (com.Delete(txtShortName.Text) > 0)
                {
                    clr();
                    ntCompanies.Show("Deleted !");
                }
            }
        }

        private void frmCompanies_Load(object sender, System.EventArgs e)
        {
            txtShortName.Focus();
        }


    }
}
