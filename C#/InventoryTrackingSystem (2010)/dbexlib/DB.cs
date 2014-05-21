using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace dbexlib
{
    public static class DB
    {
        private static string data = "";
        private static string where = "";
        public static List<Dictionary<string, string>> SelectAllFrom(string tableName)
        {
            List<Dictionary<string, string>> res = new List<Dictionary<string, string>>();
            string qry = "SELECT * FROM `" + tableName +"`";
            if (where != "")
            {
                qry += where;
            }

            using (MySqlCommand cmd = new MySqlCommand(qry, DBConnection.getConnection()))
            {

                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        Dictionary<string, string> dc = new Dictionary<string, string>();
                        int fc = datareader.FieldCount;
                        for (int x = 0; x < fc; x++)
                        {
                            if (datareader.IsDBNull(x))
                            {
                                dc.Add(datareader.GetName(x), "");
                            }
                            else
                            {
                                dc.Add(datareader.GetName(x), datareader.GetString(x));
                            }
                           // dc.Add(datareader.GetName(x), datareader.GetString(x));
                        }
                        res.Add(dc);
                    }
                }
                where = "";
            }
                return res;
           

        }

        public static void Where(string field, string val)
        {
            where = " WHERE `" + field + "` ="+ Escape(val);
        }

        public static List<Dictionary<string, string>> Select(string query)
        {
            List<Dictionary<string, string>> res = new List<Dictionary<string, string>>();

            using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.getConnection()))
            {
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        Dictionary<string, string> dc = new Dictionary<string, string>();
                        int fc = datareader.FieldCount;
                        for (int x = 0; x < fc; x++)
                        {
                            if (datareader.IsDBNull(x))
                            {
                                dc.Add(datareader.GetName(x),"");
                            }
                            else
                            {
                                dc.Add(datareader.GetName(x), datareader.GetString(x));
                            }
                        }
                        res.Add(dc);
                    }
                   
                }
            }
                return res;
        }

        public static int Insert(string[] data,string table)
        {
            int res = 0;
            string query = "INSERT INTO "+table+" VALUES (";
            foreach (string val in data)
            {
                query +=val;
            }
            query += ")";
            using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.getConnection()))
            {
                res = cmd.ExecuteNonQuery();
            }
                return res;
           
        }

        public static int Update(string query)
        {
            int res = 0;
            using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.getConnection()))
            {
                res = cmd.ExecuteNonQuery();
            }
            return res;
        }

        public static int Delete(string table)
        {
            string query = "DELETE FROM `"+table+"`";
            int res = 0;

            if (where != "")
            {
                query += where;
              
                using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.getConnection()))
                {
                    res = cmd.ExecuteNonQuery();
                    where = "";
                }
            }
            return res;
        }

        public static int NonQuery(string query)
        {
            int res = 0;
           
            using (MySqlCommand cmd = new MySqlCommand(query, DBConnection.getConnection()))
            {
                res = cmd.ExecuteNonQuery();
            }
            return res;

        }

        public static string Escape(string str)
        {
            return "'" + str + "'";
        }

        public static string GetToAutocomplete(string table,string field,string value)
        {
            
            string qry = "SELECT "+field+" FROM "+table+" WHERE "+field+" LIKE '"+value+"%'";
            string data = "";
            
            using (MySqlCommand cmd = new MySqlCommand(qry, DBConnection.getConnection()))
            {
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        data += "," + datareader.GetString(0);
                    }
                }
            }
            data = data.Substring(1);
            return data;
        }

        public static string GetToAutocomplete(string table, string field1, string field2, string value)
        {

            string qry = "SELECT CONCAT("+field1+",'/',"+field2+") FROM " + table + " WHERE " + field1 + " LIKE '" + value + "%'";
            string data = "";

            using (MySqlCommand cmd = new MySqlCommand(qry, DBConnection.getConnection()))
            {
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        data += "," + datareader.GetString(0);
                      
                    }
                }
            }
            data = data.Substring(1);
            return data;
           
        }

        public static string GetToAutocomplete(string query)
        {
            string qry = query;
            string data = "";

            using (MySqlCommand cmd = new MySqlCommand(qry, DBConnection.getConnection()))
            {
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        data += "," + datareader.GetString(0);

                    }
                }
            }
            data = data.Substring(1);
            return data;
        }

        public static void setAutocompleteData(string val)
        {
            data += "," + val;
        }

        public static string getAutocompleteData()
        {
            data = data.Substring(1);
            return data;
        }

        public static int Start_Transaction()
        {
            int res=0;
            using (MySqlCommand cmd = new MySqlCommand("START TRANSACTION", DBConnection.getConnection()))
            {
                res = cmd.ExecuteNonQuery();
            }
            return res;
        }

        public static int End_Transaction()
        {
            int res = 0;
            using (MySqlCommand cmd = new MySqlCommand("COMMIT", DBConnection.getConnection()))
            {
                res = cmd.ExecuteNonQuery();
            }
            return res;
        }

        public static int Rollback()
        {
            int res = 0;
            using (MySqlCommand cmd = new MySqlCommand("ROLLBACK", DBConnection.getConnection()))
            {
                res = cmd.ExecuteNonQuery();
            }
            return res;
        }


    }


}
