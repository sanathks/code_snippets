using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ConsoleSpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123;database=hairuec1_projects");
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * From gallery ";
            cmd.Connection = con;
            con.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Console.WriteLine(rd.GetString(0));
                Console.WriteLine(rd.GetString(1));
                Console.WriteLine(rd.GetString(2));
            }
            
            Console.ReadLine();
        }
    }
}
