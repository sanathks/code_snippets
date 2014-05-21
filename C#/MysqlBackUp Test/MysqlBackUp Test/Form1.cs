using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MysqlBackUp_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            save.Filter = "SQLDum|*.sql";
            save.Title = "Save a backup";
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //string constr = "server=localhost;user=root;pwd=123;database=hairuec1_projects;";
            //string file = "H:\\MyDumpFile.sql";
            //MySqlBackup mb = new MySqlBackup(constr);
            //mb.ExportInfo.FileName = file;
            //mb.ExportInfo.EnableEncryption = true;
            //mb.ExportInfo.EncryptionKey = "my secret password";
            //mb.Export();
           // DateTime now = new DateTime();

            save.FileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".sql";
            //save.DefaultExt = "C:\\";
            save.InitialDirectory = "C:\\";
            save.ShowDialog();
            //mb.ImportInfo.FileName = file;
            //mb.ImportInfo.EnableEncryption = true;
            //mb.ImportInfo.EncryptionKey = "my secret password";
            //mb.Import(); 
        }

        private void save_FileOk(object sender, CancelEventArgs e)
        {
            string constr = "server=localhost;user=root;pwd=123;database=hairuec1_projects;";
            string file = save.FileName;
            MySqlBackup mb = new MySqlBackup(constr);
            mb.ExportInfo.FileName = file;
            mb.ExportInfo.EnableEncryption = true;
            mb.ExportInfo.EncryptionKey = "my secret password";
            mb.Export();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            open.Filter = "SQLDum|*.sql";
            open.Title = "Open a backup";
            open.FileName = "";
            open.ShowDialog();
            open.InitialDirectory = "C:\\";
        }

        private void open_FileOk(object sender, CancelEventArgs e)
        {
            string constr = "server=localhost;user=root;pwd=123;database=hec_its_old;";
            string file = open.FileName;
            MySqlBackup mb = new MySqlBackup(constr);
            mb.ImportInfo.FileName = file;
            mb.ImportInfo.EnableEncryption = true;
            mb.ImportInfo.EncryptionKey = "hec123";
            mb.Import(); 
        }
    }
}
