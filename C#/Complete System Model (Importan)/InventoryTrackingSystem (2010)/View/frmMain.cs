using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using dbexlib;

namespace InventoryTrackingSystem
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
        frmLogin login = new frmLogin();
        private void frmMain_Load(object sender, EventArgs e)
        {
            _Disable();
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
            DBConnection.Open();
            openLoginWindow();
        }

        #region Login Setting
        private void openLoginWindow()
        {
            login.MdiParent = this;
            login.Show();
        }
        private void isLoggedin_Tick(object sender, EventArgs e)
        {
            if (Stat.LOGGED_IN)
            {
                _Enable();
                isLoggedin.Enabled = false;
            }
        }

        private void signout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isLoggedin.Enabled = true;
            _Disable();
            Stat.setLoggedout();
            login.Show();

        }
        private void _Disable()
        {
            menuXml.Enabled = false;
            toolBarGeneral.Enabled = false;
            miscContainerPanel.Enabled = false;
            signout.Enabled = false;
        }

        private void _Enable()
        {
            menuXml.Enabled = true;
            toolBarGeneral.Enabled = true;
            miscContainerPanel.Enabled = true;
            signout.Enabled = true;
        }
        #endregion

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
            e.Graphics.DrawRectangle(new Pen(Color.CornflowerBlue,2),miscPanel.DisplayRectangle);
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
            DBConnection.Close();
            Application.Exit();
        }

       

       
    }

}
