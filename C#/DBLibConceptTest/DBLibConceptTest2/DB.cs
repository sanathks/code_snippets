using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DBLibConceptTest2
{
    class DB
    {
        public List<Dictionary<string, string>> SelectAll()
        {
            List<Dictionary<string, string>> a = new List<Dictionary<string, string>>();
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123;database=hairuec1_projects");
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * From gallery where gallery_id = 5";
            cmd.Connection = con;
            con.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
               Dictionary<string, string> dc = new Dictionary<string, string>();
                int fc = rd.FieldCount;
                for (int x = 0; x < fc; x++)
                {
                    dc.Add(rd.GetName(x),rd.GetString(x));
                }
                a.Add(dc);  
            }

            con.Close();
            return a;
        }
    }
}
