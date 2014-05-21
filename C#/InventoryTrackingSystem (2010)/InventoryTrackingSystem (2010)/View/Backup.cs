using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using dbexlib;

namespace InventoryTrackingSystem
{
    public partial class Backup : Form
    {
        MySqlBackup mb;
        int curPercentage=0;
        
        public Backup()
        {
            InitializeComponent();
          
        }

        #region System
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void mb_ExportCompleted(object sender, ExportCompleteArg e)
        {
            timerStop.Start();
            btnBackup.Enabled = false;
            curPercentage = 100;
            
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

        private void btnBackup_Click(object sender, EventArgs e)
        {
            prgBar.Value = 0;
            timerRead.Start();
            mb.Connection = new MySqlConnection(DBConfig.getConnectionString());
            mb.ExportInfo.FileName = txtBackupPath.Text;
            mb.ExportInfo.EnableEncryption = true;
            mb.ExportInfo.EncryptionKey = "hec123";
            mb.Export(); 
          
        }

        private void btnBackupBro_Click(object sender, EventArgs e)
        {
            digBackupSave.FileName = DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".sql";
            digBackupSave.Filter = "SQLDum|*.sql";
            digBackupSave.RestoreDirectory = true; 
            digBackupSave.ShowDialog();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            mb = new MySqlBackup();
            mb.ExportCompleted += new MySqlBackup.exportComplete(mb_ExportCompleted);
            txtBackupPath.Text = Config.getBackupPath() + "\\" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".sql";
        }

        private void digBackupSave_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string strFullPath = digBackupSave.FileName;
            int intLocation;
            intLocation = strFullPath.LastIndexOf("\\");
            Config.setBackupPath(strFullPath.Substring(0, intLocation));
          
            txtBackupPath.Text = digBackupSave.FileName;
        }

    }
}
