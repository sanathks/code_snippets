using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingSystem
{
    class FixtAssetData:TransFields
    {
        private string current_user;
        public string Current_User
        {
            get { return current_user; }
            set { current_user = value; }
        }

    }
}
