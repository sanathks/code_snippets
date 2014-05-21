using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SER_System_Templete1
{
    public partial class frmMain : Form
    {
        [DllImport("user32")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int
        X, int Y, int cx, int cy, int uFlags);
        const int GWL_EXSTYLE = (-20);
        const int WS_EX_CLIENTEDGE = 0x00000200;
        const int SWP_FRAMECHANGED = 0x0020;
        const int SWP_NOSIZE = 0x0001;
        const int SWP_NOMOVE = 0x0002;
        const int SWP_NOZORDER = 0x0004;


        public frmMain()
        {

            InitializeComponent();
            MenuSetup menu = new MenuSetup();
            //menuXml.Font = new Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menu.InitializeMenu(this, menuXml);
            menuXml.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
            toolBarGeneral.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());

        }
        Splashscreen sp = new Splashscreen();
        private void frmMain_Load(object sender, EventArgs e)
        {
            sp.Hide();
            MdiClient mdi;
            foreach (Control ctl in Controls)
            {
                if (ctl is MdiClient)
                {
                    mdi = (MdiClient)ctl;
                    mdi.BackColor = this.BackColor;
                    //int ExStyle = GetWindowLong(mdi.Handle, GWL_EXSTYLE);
                    //ExStyl e ^= WS_EX_CLIENTEDGE;
                    //SetWindowLong(mdi.Handle, GWL_EXSTYLE, ExStyle);
                    //SetWindowPos(mdi.Handle, IntPtr.Zero, 0, 0, 0, 0, SWP_NOMOVE |
                    //SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED);
                }
            }
        }
        #region miscPanel Setting
        private void miscCloseButton_MouseHover(object sender, EventArgs e)
        {
            miscCloseButton.BackColor = Color.LightSlateGray;
        }

        private void miscCloseButton_MouseLeave(object sender, EventArgs e)
        {
            miscCloseButton.BackColor = Color.Transparent;
        }

        private void miscPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.CornflowerBlue, 2), miscPanel.DisplayRectangle);
        }

        private void miscCloseButton_Click(object sender, EventArgs e)
        {
            miscContainerPanel.Visible = false;
        }

        public void miscContainerPanel_show_hide()
        {
            if (miscContainerPanel.Visible == false)
            {
                miscContainerPanel.Visible = true;
            }
            else
            {
                miscContainerPanel.Visible = false;
            }

        }
        #endregion

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }

}
