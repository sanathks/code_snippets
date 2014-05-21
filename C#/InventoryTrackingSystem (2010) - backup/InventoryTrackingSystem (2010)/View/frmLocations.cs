using System.Windows.Forms;

namespace InventoryTrackingSystem
{
    public partial class frmLocations : Form
    {
        public frmLocations()
        {
            InitializeComponent();
        }

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        private bool isEdit = false;
        Location loc = new Location();
        public string exLocation(string code)
        {
            return loc.exLocation(code);
        }

        public void loadExData(string code)
        {
            var result = loc.checkExData(code);
            if (result != null)
            {
                string res = MessageBox.Show("Do you want load this recode ?", "Load existing recode !", MessageBoxButtons.YesNo).ToString();
                if (res == "Yes")
                {
                    txtShortName.Enabled = false;
                    txtShortName.Text = result.Code;
                    txtLocName.Text = result.Name;
                    txtLocDesc.Text = result.Description;
                    isEdit = true;
                    btnDelete.Enabled = true;
                }
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Fields data = new Fields();
            int err = 0;
            string errmsg = "";
            if ((data.Code = Data.Feed(txtShortName.Text, true)) == null)
            {
                errmsg += "Intert Short Name ! \n";
                err++;
            }
            if ((data.Name = Data.Feed(txtLocName.Text, true)) == null)
            {
                errmsg += "Intert Name ! \n";
                err++;
            }

            data.Description = Data.Feed(txtLocDesc.Text, false);

            if (err > 0)
            {
                ntLocation.ShowErr("Error !");
                MessageBox.Show(errmsg, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isEdit)
                {
                    if (loc.Update(data) > 0)
                    {
                        clr();
                        ntLocation.Show("Saved !");
                    }
                }
                else
                {

                    if (loc.Save(data) > 0)
                    {
                        clr();
                        ntLocation.Show("Saved !");
                    }
                }
            }
        }

        private void clr()
        {
            txtShortName.Text = "";
            txtLocName.Text = "";
            txtLocDesc.Text = "";
            txtShortName.Enabled = true;
            txtShortName.Focus();
            isEdit = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            string res = MessageBox.Show("Do you want to delete this recode ?", "Delete existing recode ?", MessageBoxButtons.YesNo,MessageBoxIcon.Warning ).ToString();
            if (res == "Yes")
            {
                if (loc.Delete(txtShortName.Text) > 0)
                {
                    clr();
                    ntLocation.Show("Deleted !");
                }
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            clr();
        }

        private void frmLocations_Load(object sender, System.EventArgs e)
        {
            txtShortName.Focus();
        }



    }
}
