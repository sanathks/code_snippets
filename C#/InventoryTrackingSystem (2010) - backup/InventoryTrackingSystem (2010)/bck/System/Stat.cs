using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingSystem
{
    public static class Stat
    {
        public static bool LOGGED_IN = false;

        public static void setLogin()
        {
            LOGGED_IN = true;
        }

        public static void setLoggedout()
        {
            LOGGED_IN = false;
        }
    }
}
