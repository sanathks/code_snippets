using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingSystem
{
    class EmpField:Fields
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string desig;
        public string Designation
        {
            get { return desig; }
            set { desig = value; }
        }

        private string compName;
        public string CompanyName
        {
            get { return compName; }
            set { compName = value; }
        }

        private string phoneNo;
        public string PhoneNumber
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
