using System;
using System.Windows.Forms;

namespace InventoryTrackingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(new DBConfig().checkDBConnection())
            Application.Run(new Splashscreen());
            else
            Application.Run(new DatabaseRegister());
        }
    }
}
