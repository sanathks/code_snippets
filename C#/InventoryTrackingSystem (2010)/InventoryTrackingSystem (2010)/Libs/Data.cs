using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingSystem
{
    public static class Data
    {
        public static string Feed(string val,Boolean comp)
        {
            
            if (comp)
            {
                if (val != "")
                {
                 return val.TrimStart().TrimEnd();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return val.TrimStart().TrimEnd();
            }
            
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
