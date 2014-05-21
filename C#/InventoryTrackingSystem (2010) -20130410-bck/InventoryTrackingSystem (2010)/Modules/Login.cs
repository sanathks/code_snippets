using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using dbexlib;

namespace InventoryTrackingSystem
{
    class Login
    {
        
        public int checkLogin(string username,string password)
        {
            string qry = "SELECT id FROM users WHERE username='" + username + "' AND password='" + Encry.MD5(password) + "'";
            var res = DB.Select(qry);
           if (res.Count != 0)
           {
               return 1;
           }
           else
           {
               return 0;
           }
          
            
        }

        //public int checkLogin(string username, string password)
        //{
        //    string qry = "SELECT id FROM users WHERE username='" + username + "' AND password='" + password + "'";
        //    var res = DB.Select(qry);
        //    if (res.Count != 0)
        //    {
        //        foreach (var data in res)
        //        {
        //            string user = data["username"];
        //        }
        //    }
        //    else
        //    {
        //        return 0;
        //    }


        //}
    }
}
