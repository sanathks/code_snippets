using System.Windows.Forms;

namespace InventoryTrackingSystem
{
    public partial class frmTracker : Form
    {
        public frmTracker()
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
