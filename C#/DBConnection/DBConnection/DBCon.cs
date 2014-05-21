using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace DBConnection
{
    public static class DBCon
    {
      public static  MySqlConnection con=null;
      static List<Dictionary<int, string>> cont = new List<Dictionary<int, string>>();
      static Dictionary<int, string> ads = new Dictionary<int, string>();
      
      public static MySqlConnection getConnection()
      {
          
          cont.Add(ads);
          if (con == null)
              con = new MySqlConnection("server=localhost;User Id=root;password=123;database=f");
         
         return con;
      }

    }
}
