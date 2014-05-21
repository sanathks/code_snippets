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

        public void miscContainerPanel_show()
        {
           miscContainerPanel.Visible = true;
        }
        #endregion


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnection.Close();
            Application.Exit();
        }

        #region ToolBarSettings
        private void tsNext_Click(object sender, EventArgs e)
        {
            int currentFormId = 0;
            int count=0;
            Form[] frm = this.MdiChildren;

            foreach (Form a in frm)
            {
                if (a.Name == this.ActiveMdiChild.Name)
                {
                    currentFormId = count;
                    Log.write("OK");
                }
                count++;
            }
          
            if (currentFormId == frm.Length)
            {
                currentFormId--;
                frm[currentFormId].Activate();
            }
            else
            {
                //currentFormId++;
                frm[currentFormId].Activate();
            }
           
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            //MessageBox.Show(frm.Name);
            if (frm != null)
            {
                frm.Close();
            }
           

        }

        #endregion

       
        private void showEmpTracker()
        {
            grpBTrackerLocation.Visible = false;
            grpBTrackerItemWise.Visible = false;
            grpBTrackerEmp.Visible = true;
        }

        private void showLocTracker()
        {
            grpBTrackerLocation.Location = new Point(10, 174);
            grpBTrackerLocation.Visible = true;
            grpBTrackerItemWise.Visible = false;
            grpBTrackerEmp.Visible = false;
        }

        private void showItemTracker()
        {
            grpBTrackerItemWise.Location = new Point(10, 174);
            grpBTrackerItemWise.Visible = true;
            grpBTrackerLocation.Visible = false;
            grpBTrackerEmp.Visible = false;
        }

        private void rdTrackerEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTrackerEmp.Checked == true)
            {
                showEmpTracker();
            }
        }

        private void rdTrackerLoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTrackerLoc.Checked == true)
            {
                showLocTracker();
                lbKey1.Text = "Location";
            }
        }

        private void rdTrackerCom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTrackerCom.Checked == true)
            {
                showLocTracker();
                lbKey1.Text = "Company";
            }
        }

        private void rdTrackerItem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTrackerItem.Checked == true)
            {
                showItemTracker();
            }
        }

        private void tsBackup_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Backup))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new Backup();
            frmLoc.MdiParent = this;
            frmLoc.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Restore))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new Restore();
            frmLoc.MdiParent = this;
            frmLoc.Show();
        }

        private void tsDatabaseregister_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(DatabaseRegister))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new DatabaseRegister();
            frmLoc.MdiParent = this;
            frmLoc.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            miscContainerPanel_show_hide(); 
        }

        private void tsSetting_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Options))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new Options();
            frmLoc.MdiParent = this;
            frmLoc.Show();
        }

        private void stSave_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            Module.Tracker _tr = new Module.Tracker();
            bool isDataSet = true;

            if (rdTrackerLoc.Checked)
            {
                if (_tr.Track(locationTrackerProperties(), "LOC"))
                {
                    isDataSet = true;
                }
            }
            else if (rdTrackerCom.Checked)
            {
                if (_tr.Track(companyTrackerProperties(), "COM"))
                {
                    isDataSet = true;
                }
            }
            else if (rdTrackerEmp.Checked)
            {
                if (_tr.Track(empTrackerProperties(), "EMP"))
                {
                    isDataSet = true;
                }
            }
            else if(rdTrackerItem.Checked)
            {
                if(_tr.Track(itemTrackerProperties(), "IT"))
                {
                    isDataSet = true;
                }
            }

            if (isDataSet)
            {
                showTrackerResult();
            }
            else
            {
                MessageBox.Show("Invalide searching parameter !");
            }

        }

        #region LocationTrackerProperties
        private Entity.Tracker locationTrackerProperties()
        {
            Entity.Tracker _trackerProperties = new Entity.Tracker();

            if ((_trackerProperties.LocationCode = Data.Feed(txtTrackerLocation.Text, true)) == null)
            {
                MessageBox.Show("Invalide Location Code !");
            }
            _trackerProperties.SubCategory = Data.Feed(txtTrackerLocaSubCat.Text, false);

            if (chkTrackerLocaAll.Checked)
            {
                _trackerProperties.ItemCategory = "ALL";

            }
            else if (chkTrackerEC.Checked)
            {
                _trackerProperties.ItemCategory = "EC";

            }
            else if (chkTrackerFA.Checked)
            {
                _trackerProperties.ItemCategory = "FA";

            }
            else if (chkTrackerGen.Checked)
            {
                _trackerProperties.ItemCategory = "GE";

            }
            return _trackerProperties;
        } 
        #endregion

        #region CompanyTrackerProperties
        private Entity.Tracker companyTrackerProperties()
        {
            Entity.Tracker _trackerProperties = new Entity.Tracker();

            if ((_trackerProperties.CompanyCode = Data.Feed(txtTrackerLocation.Text, true)) == null)
            {
                MessageBox.Show("Invalide Comapny Code !");
            }
            _trackerProperties.SubCategory = Data.Feed(txtTrackerLocaSubCat.Text, false);

            if (chkTrackerLocaAll.Checked)
            {
                _trackerProperties.ItemCategory = "ALL";

            }
            else if (chkTrackerEC.Checked)
            {
                _trackerProperties.ItemCategory = "EC";

            }
            else if (chkTrackerFA.Checked)
            {
                _trackerProperties.ItemCategory = "FA";

            }
            else if (chkTrackerGen.Checked)
            {
                _trackerProperties.ItemCategory = "GE";

            }
            return _trackerProperties;
        }
        #endregion

        #region ItemTrackerProperties
        private Entity.Tracker itemTrackerProperties()
        {
            Entity.Tracker _trackerProperties = new Entity.Tracker();

            _trackerProperties.SubCategory = Data.Feed(txtTrackerLocaSubCat.Text, false);

            if (chkTrackerLocaAll.Checked)
            {
                _trackerProperties.ItemCategory = "ALL";

            }
            else if (chkTrackerEC.Checked)
            {
                _trackerProperties.ItemCategory = "EC";

            }
            else if (chkTrackerFA.Checked)
            {
                _trackerProperties.ItemCategory = "FA";

            }
            else if (chkTrackerGen.Checked)
            {
                _trackerProperties.ItemCategory = "GE";

            }
            return _trackerProperties;
        }
        #endregion

        #region ItemTrackerProperties
        private Entity.Tracker empTrackerProperties()
        {
            Entity.Tracker _trackerProperties = new Entity.Tracker();
            if ((_trackerProperties.EmployeeName = Data.Feed(txtTrackerEmp.Text, true)) == null)
            {
                MessageBox.Show("Invalide Employee Name !");
            }
        
            return _trackerProperties;
        }
        #endregion

        private void showTrackerResult()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmReportTracker))
                {
                    form.Activate();
                    return;
                }
            }
            Form frmLoc = new frmReportTracker();
            frmLoc.MdiParent = this;
            frmLoc.Show();
        }

    }

}
