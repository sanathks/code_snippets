using System.Windows.Forms;

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



    }
}
