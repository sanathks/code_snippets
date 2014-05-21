using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MakeDirToDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            string path = Environment.CurrentDirectory + "\\" + today.ToString("yyyy-MM-dd");
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    Console.ReadLine();
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", path);
                
               
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
                Console.ReadLine();
            }
            finally { }
        }
    }
}
