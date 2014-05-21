using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class Tracker
    {
       
      
        private string locationCode;

        public string LocationCode
        {
            get { return locationCode; }
            set { locationCode = value; }
        }

        private string itemCategory;

        public string ItemCategory
        {
            get { return itemCategory; }
            set { itemCategory = value; }
        }

        private string companyCode;

        public string CompanyCode
        {
            get { return companyCode; }
            set { companyCode = value; }
        }

        private string subCat;

        public string SubCategory
        {
            get { return subCat; }
            set { subCat = value; }
        }

        private string empName;

        public string EmployeeName
        {
            get { return empName; }
            set { empName = value; }
        }
        
        
    }
}
