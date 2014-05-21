using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace dbexlib
{
    public static class DBConnection
    {
        public static MySqlConnection con = null;

        public static MySqlConnection getConnection()
        {
            if (con == null)
                con = new MySqlConnection(DBConfig.getConnectionString());
            return con;
        }
        private static void setConnection()
        {
            if (con == null)
                con = new MySqlConnection(DBConfig.getConnectionString());
        }
        public static bool Open()
        {

            try
            {
                setConnection();
                con.Open();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }


        }

        public static void Close()
        {
            if (con != null)
                con.Close();
        }
    }
}
