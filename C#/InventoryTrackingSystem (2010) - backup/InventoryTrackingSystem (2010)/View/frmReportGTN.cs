using System.Windows.Forms;

namespace InventoryTrackingSystem
{
    public partial class frmReportGTN : Form
    {
        public frmReportGTN()
        {
            InitializeComponent();
        }

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void frmReportGTN_Load(object sender, System.EventArgs e)
        {
  
            rptGTN.ReportSource = @"rpt/GTN.rpt";
            this.WindowState = FormWindowState.Maximized;
        }


    }
}
