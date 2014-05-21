using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using MySql.Data.MySqlClient;

namespace dbexlib
{
    public static class DBConfig
    {
        public static string CON_STR = "";

        private static XmlNode xmlServer, xmlUsername, xmlPassword, xmlPort, xmlDatabase;
        public static bool isDBConfied()
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


        }

        public static bool checkDBConnection()
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

        public static string getConnectionString()
        {
            string password = "";
            if (isDBConfied())
            {
                if (xmlPassword.Attributes["text"].Value != "")
                    password = Crypto.Decrypt(xmlPassword.Attributes["text"].Value, "hec123");

                CON_STR = "server=" + xmlServer.Attributes["text"].Value
                                         + ";User Id=" + xmlUsername.Attributes["text"].Value
                                         + ";password=" + password
                                         + ";port=" + xmlPort.Attributes["text"].Value
                                         + ";database=" + xmlDatabase.Attributes["text"].Value + ";";
                return CON_STR;
            }
            else
            {
                return null;
            }
        }
    }
}
