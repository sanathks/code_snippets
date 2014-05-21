using System;
using System.Windows.Forms;
using dbexlib;

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
            
            if(DBConfig.checkDBConnection())
            Application.Run(new Splashscreen());
            else
            Application.Run(new DatabaseRegister());
        }
    }
}
