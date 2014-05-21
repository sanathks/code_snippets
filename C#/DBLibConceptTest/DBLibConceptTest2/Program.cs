using System;
using System.Collections.Generic;
using System.Text;

namespace DBLibConceptTest2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DB db = new DB();
            var d = db.SelectAll();
            foreach (var data in d)
            {
                Console.WriteLine("{0}", data["prj_id"]);
                Console.WriteLine("{0}", data["name"]);
                Console.WriteLine("{0}", data["description"]);

            }

            //Console.WriteLine("{0}", (d[0])["name"]);

            Console.ReadLine();
        }
    }
}
