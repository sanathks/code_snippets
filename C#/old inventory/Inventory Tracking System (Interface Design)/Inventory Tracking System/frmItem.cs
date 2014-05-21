using System.Windows.Forms;

namespace InventoryTrackingSystem
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        private void frmItem_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.DarkGray, 2),
                          this.DisplayRectangle);
        }
    }
}
