using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using MySql.Data.MySqlClient;

namespace InventoryTrackingSystem{

    class DBConfig
    {
        public string CON_STR = "";

        private XmlNode xmlServer, xmlUsername, xmlPassword, xmlPort, xmlDatabase;
        public bool isDBConfied() 
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config/cond.sys");
                xmlServer = doc.SelectSingleNode("//server");
                xmlUsername = doc.SelectSingleNode("//username");
                xmlPassword = doc.SelectSingleNode("//password");
                xmlPort = doc.SelectSingleNode("//port");
                xmlDatabase = doc.SelectSingleNode("//database");

                if (xmlServer.Attributes["text"].Value != "" &&
                    xmlUsername.Attributes["text"].Value != "" && 
                    xmlDatabase.Attributes["text"].Value != "")
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            return false;
        }

        public bool checkDBConnection()
        {
            if (isDBConfied())
            {
                MySqlConnection con = new MySqlConnection(getConnectionString());

                try
                {
                    con.Open();
                    return true;
                    con.Close();
                }
                catch (MySqlException e)
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
           
        }

        public string getConnectionString()
        {
            string password="";
            if(isDBConfied())
            {
                if (xmlPassword.Attributes["text"].Value != "")
                    password = Crypto.Decrypt(xmlPassword.Attributes["text"].Value, "hec123");

                this.CON_STR = "server=" + xmlServer.Attributes["text"].Value
                                         + ";User Id=" + xmlUsername.Attributes["text"].Value
                                         + ";password=" + password
                                         + ";port=" + xmlPort.Attributes["text"].Value
                                         + ";database=" + xmlDatabase.Attributes["text"].Value + ";";
                return this.CON_STR;
            }else{
            return null;
            }
        }

       // private 



    }
}
