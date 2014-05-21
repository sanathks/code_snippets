using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace SER_DataBridge
{
    public class MySQL_Bridge
    {

        
        private static MySqlConnection con;

        public static Boolean open()
        {
            try
            {
                con = Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
            
        }

        public static Boolean insert()
        {
            string qry = "INSERT INTO `user`(id,`desc`) VALUES (2,'abc')";
            MySqlCommand cmd= new MySqlCommand(qry);
            cmd.Connection = con;
            try
            {
                open();
                cmd.ExecuteNonQuery();
                return true;
            }catch(MySqlException ex){
                Console.Write(ex.Message);
            }
            
        }
       
    }
}
