using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;

namespace InventoryTrackingSystem
{
    public partial class frmReportGDN : Form
    {
        public frmReportGDN()
        {
            InitializeComponent();
        }

        //private const int GWL_STYLE = -16;
        //private const int WS_CLIPSIBLINGS = 1 << 26;

        //[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowLong")]
        //public static extern IntPtr SetWindowLongPtr32(HandleRef hWnd, int nIndex, HandleRef dwNewLong);
        //[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowLong")]
        //public static extern IntPtr GetWindowLong32(HandleRef hWnd, int nIndex);

        //protected override void OnLoad(EventArgs e)
        //{
        //    int style = (int)((long)GetWindowLong32(new HandleRef(this, this.Handle), GWL_STYLE));
        //    SetWindowLongPtr32(new HandleRef(this, this.Handle), GWL_STYLE, new HandleRef(null, (IntPtr)(style & ~WS_CLIPSIBLINGS)));

        //    base.OnLoad(e);
        //}

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void frmReportGTN_Load(object sender, System.EventArgs e)
        {
           // this.WindowState = FormWindowState.Maximized;
        }


    }
}
