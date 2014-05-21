using System.Windows.Forms;

namespace InventoryTrackingSystem
{
    public partial class  frmReportShrNM : Form
    {
        public frmReportShrNM()
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

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (rbLocation.Checked)
            {
                rptGTN.ReportSource = @"rpt/location.rpt";
            }
            else if (rbCompany.Checked)
            {
                rptGTN.ReportSource = @"rpt/company.rpt";
            }
        }

        private void rptGTN_Load(object sender, System.EventArgs e)
        {

        }


    }
}
