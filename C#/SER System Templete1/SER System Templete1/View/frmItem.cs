using System.Windows.Forms;

namespace SER_System_Templete1
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
            // txtCatShortName.Initialize(this);
        }

        private void frmItem_Paint(object sender, PaintEventArgs e)
        {
            // e.Graphics.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.DarkGray, 2),
            //              this.DisplayRectangle);
        }

        public string data(string str)
        {
            return "ACC,BB,HH,LL";
        }


    }
}
