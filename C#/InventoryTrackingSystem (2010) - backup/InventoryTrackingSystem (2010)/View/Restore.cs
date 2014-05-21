using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using dbexlib;

namespace InventoryTrackingSystem
{
    public partial class Restore : Form
    {
        MySqlBackup mb;
        int curPercentage = 0;

        public Restore()
        {
            InitializeComponent();
        }

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnRestore_Click(object sender, System.EventArgs e)
        {
            btnRestore.Enabled = false;
            prgBar.Value = 0;
            timerRead.Start();
            mb.Connection = new MySqlConnection(DBConfig.getConnectionString());
            mb.ImportInfo.FileName = txtRestorePath.Text;
            mb.ImportInfo.EnableEncryption = true;
            mb.ImportInfo.EncryptionKey = "hec123";
            mb.Import(); 
        }

        private void Restore_Load(object sender, System.EventArgs e)
        {
            mb = new MySqlBackup();
            mb.ImportCompleted += new MySqlBackup.importComplete(mb_ImportCompleted);
            txtRestorePath.Text = "";
        }

        private void mb_ImportCompleted(object sender, ImportCompleteArg e)
        {
            curPercentage = 100;
            timerStop.Start();
            btnRestore.Enabled = false;
        }

        private void timerRead_Tick(object sender, EventArgs e)
        {
            prgBar.Value = curPercentage;
            lbPr.Text = "Progress " + curPercentage.ToString() + "%";
        }

        private void timerStop_Tick(object sender, EventArgs e)
        {
            timerRead.Stop();
            timerStop.Stop();
        }

        private void btnBrow_Click(object sender, EventArgs e)
        {
            digOpen.ShowDialog();
        }

        private void digOpen_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnRestore.Enabled = true;
            txtRestorePath.Text = digOpen.FileName;
        }


    }
}
