using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace SER_DataBridge
{
   public class Connection
    {
       private static String CON_STR = "server=localhost;User Id=root;database=ser_data_bridge";
       private static object syncRoot = new Object();
       private static MySqlConnection con=new MySqlConnection(CON_STR);
       private static Connection instance;

       private Connection(){}

       public static Connection Instance
       {
           get
           {
               if (instance == null)
               {
                   lock (syncRoot)
                   {
                       if (instance == null)
                           instance = new Connection();
                   }
               }

               return instance;
           }
       }

       public static MySqlConnection Open()
       {
           try
           {
               con.Open();

           }catch(MySqlException ex){
               con = null;
           }
           return con;
       }

       public static Boolean Close()
       {
           try
           {
               con.Close();
               return true;
           }
           catch (MySqlException ex)
           {
               return false;
           }
           
       }
    }
}
