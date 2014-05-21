using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace dbexlib
{
    public static class DB
    {
        public static List<Dictionary<string, string>> SelectAllFrom(string tableName)
        {
            List<Dictionary<string, string>> res = new List<Dictionary<string, string>>();
            string qry = "SELECT * FROM " + tableName;
            try
            {
                MySqlCommand cmd = new MySqlCommand(qry, DBConnection.getConnection());
                MySqlDataReader datareader = cmd.ExecuteReader();
                while (datareader.Read())
                {
                    Dictionary<string, string> dc = new Dictionary<string, string>();
                    int fc = datareader.FieldCount;
                    for (int x = 0; x < fc; x++)
                    {
                        dc.Add(datareader.GetName(x), datareader.GetString(x));
                    }
                    res.Add(dc);
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static List<Dictionary<string, string>> Select(string query)
        {
            List<Dictionary<string, string>> res = new List<Dictionary<string, string>>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.getConnection());
                MySqlDataReader datareader = cmd.ExecuteReader();
                while (datareader.Read())
                {
                    Dictionary<string, string> dc = new Dictionary<string, string>();
                    int fc = datareader.FieldCount;
                    for (int x = 0; x < fc; x++)
                    {
                        dc.Add(datareader.GetName(x), datareader.GetString(x));
                    }
                    res.Add(dc);
                }
                cmd.Cancel();
                datareader.Close();
                return res;

            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {

            }


        }

        public static int Insert(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.getConnection());
                int res = cmd.ExecuteNonQuery();
                return res;
            }
            catch (MySqlException)
            {
                throw;
            }
        }

        public static int Update(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.getConnection());
                int res = cmd.ExecuteNonQuery();
                return res;
            }
            catch (MySqlException)
            {
                throw;
            }
        }

        public static int Delete(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, DBConnection.getConnection());
                int res = cmd.ExecuteNonQuery();
                return res;
            }
            catch (MySqlException)
            {
                throw;
            }
        }


    }


}
