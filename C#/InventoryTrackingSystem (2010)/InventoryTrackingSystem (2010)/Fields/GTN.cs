using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class GTN : InventoryTrackingSystem.TransFields
    {
        private List<Dictionary<string, string>> table;
        public List<Dictionary<string, string>> TableData
        {
            get { return table; }
            set { table = value;}
        }

        private string ex_location;
        public string Ex_Location
        {
            get { return ex_location; }
            set { ex_location = value; }
        }
        private string stk_type;
        public string Stock_Type
        {
            get { return stk_type; }
            set { stk_type = value; }
        }

        private string ex_company;
        public string Ex_Company
        {
            get { return ex_company; }
            set { ex_company = value; }
        }

        private string ne_location;
        public string Ne_Location
        {
            get { return ne_location; }
            set { ne_location = value; }
        }

        private string ne_company;
        public string Ne_Company
        {
            get { return ne_company; }
            set { ne_company = value; }
        }

        private InventoryTrackingSystem.ECFieldData grnData;
        public InventoryTrackingSystem.ECFieldData GRNDATA
        {
            get { return grnData; }
            set { grnData = value; }
        }

    }
}
