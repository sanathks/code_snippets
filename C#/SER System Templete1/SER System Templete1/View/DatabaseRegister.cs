using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace SER_System_Templete1
{
    public partial class DatabaseRegister : Form
    {
        private XmlNode xmlServer, xmlUsername, xmlPassword, xmlPort, xmlDatabase;
        public DatabaseRegister()
        {
            InitializeComponent();
        }

        public string data(string str)
        {
            return "localhost";
        }


        private bool checkCon()
        {

            string constr = "server=" + txtHostAddress.Text
                        + ";User Id=" + txtUsername.Text
                        + ";password=" + txtPassword.Text
                        + ";port=" + txtPort.Text
                        + ";database=" + txtDatabase.Text + ";";
            try
            {
                MySqlConnection con = new MySqlConnection(constr);

                con.Open();
                return true;
                con.Close();
            }
            catch (MySqlException e)
            {

                MessageBox.Show(e.Message);
                return false;
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string password = "";
            if (txtPassword.Text != "")
                password = Crypto.Encrypt(txtPassword.Text, "hec123");
            if (checkCon())
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config/cond.sys");
                xmlServer = doc.SelectSingleNode("//server");
                xmlUsername = doc.SelectSingleNode("//username");
                xmlPassword = doc.SelectSingleNode("//password");
                xmlPort = doc.SelectSingleNode("//port");
                xmlDatabase = doc.SelectSingleNode("//database");


                xmlServer.Attributes["text"].Value = txtHostAddress.Text;
                xmlUsername.Attributes["text"].Value = txtUsername.Text;
                xmlPassword.Attributes["text"].Value = password;
                xmlPort.Attributes["text"].Value = txtPort.Text;
                xmlDatabase.Attributes["text"].Value = txtDatabase.Text;
                doc.Save("config/cond.sys");

                Application.Restart();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtHostAddress.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtDatabase.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DatabaseRegister_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("config/cond.sys");
            xmlPort = doc.SelectSingleNode("//port");
            txtPort.Text = xmlPort.Attributes["text"].Value;
        }


    }
}
