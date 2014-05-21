using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace InventoryTrackingSystem
{
    public static class Config
    {
        public static string getBackupPath()
        {
            string path = null;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config/currconfig.sys");
                XmlNode xmlBackup = doc.SelectSingleNode("//backup");

                if (xmlBackup.Attributes["lastPath"].Value != "")
                {
                    path = xmlBackup.Attributes["lastPath"].Value;
                }
                else
                {
                    path = @"\backup";
                }
               
            }
            catch (Exception)
            {

                throw;
            }
            return path;
        }

        public static void setBackupPath(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config/currconfig.sys");
                XmlNode xmlBackup = doc.SelectSingleNode("//backup");

                xmlBackup.Attributes["lastPath"].Value = path;
                doc.Save("config/currconfig.sys");
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static string getRestorePath()
        {
            string path = null;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config/currconfig.sys");
                XmlNode xmlBackup = doc.SelectSingleNode("//restore");

                if (xmlBackup.Attributes["lastPath"].Value != "")
                {
                    path = xmlBackup.Attributes["lastPath"].Value;
                }
                else
                {
                    path = @"\backup";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return path;
        }

        public static void setRestorePath(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config/currconfig.sys");
                XmlNode xmlBackup = doc.SelectSingleNode("//restore");

                xmlBackup.Attributes["lastPath"].Value = path;
                doc.Save("config/currconfig.sys");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
