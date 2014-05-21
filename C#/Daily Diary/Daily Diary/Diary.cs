using System;
using System.Collections.Generic;
using System.Text;
using Finisar.SQLite;
using System.IO;

namespace Daily_Diary
{
    class Diary
    {
        public int Save(string var1, string var2, string var3, string var4, string var5)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=diary.db;Version=3;New=False;Compress=false;"))
            {
                string qry = "INSERT INTO data VALUES('1','" + var1 + "','" + var2 + "','" + var3 + "','" + var4 + "','" + var5 + "')";
                using (SQLiteCommand cmd = new SQLiteCommand(qry))
                {
                    cmd.Connection = con;
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }

                }
            }

        }

        public int Delete()
        {
            Backup();
            using (SQLiteConnection con = new SQLiteConnection("Data Source=diary.db;Version=3;New=False;Compress=false;"))
            {
                string qry = "DELETE FROM data";
                using (SQLiteCommand cmd = new SQLiteCommand(qry))
                {
                    cmd.Connection = con;
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    return 1;
                }
            }

        }

        public int Export(string path)
        {
            string data="";
           
            using (SQLiteConnection con = new SQLiteConnection("Data Source=diary.db;Version=3;New=False;Compress=false;"))
            {
                string qry = "SELECT * FROM data";
                using (SQLiteCommand cmd = new SQLiteCommand(qry))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SQLiteDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            data += datareader.GetString(0) + "," + datareader.GetString(1) + "," + datareader.GetString(2) + "," + datareader.GetString(3) + "," + datareader.GetString(4);
                            data += "\n";
                        }
                    }
                    
                }
            }

            using (StreamWriter w = new StreamWriter(path, false, Encoding.UTF8))
            {
                w.WriteLine("NO,Date,Project,Job,Job Description");
                w.WriteLine(data);
                return 1;
            }
           
        }

        public  string GetToAutocomplete(string table,string field,string value)
        {
            string qry = "SELECT " + field + " FROM " + table + " WHERE " + field + " LIKE '" + value + "%' GROUP BY " + field;
            string data = "";

            using (SQLiteConnection con = new SQLiteConnection("Data Source=diary.db;Version=3;New=False;Compress=false;"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(qry))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SQLiteDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            data += "," + datareader.GetString(0);
                        }
                    }
                }
            }
            data = data.Substring(1);
            return data;
        }
      

        private void Backup()
        {
            string file = System.Environment.CurrentDirectory+@"\bak\"+DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".bak";
            File.Copy("diary.db", file);
        }
    }
}
