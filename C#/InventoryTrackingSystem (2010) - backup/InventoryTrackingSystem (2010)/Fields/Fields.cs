using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingSystem
{
     class Fields
    {
        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string location;
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        private string companies;
        public string Companies
        {
            get { return companies; }
            set { companies = value; }
        }

        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

    }
}
