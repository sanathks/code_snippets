using System.Windows.Forms;

namespace InventoryTrackingSystem
{
    public partial class frmGeneral : Form
    {
        public frmGeneral()
        {
            InitializeComponent();
        }

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void frmGeneral_Load(object sender, System.EventArgs e)
        {

        }

       

    }
}
