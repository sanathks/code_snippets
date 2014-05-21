using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingSystem
{
    class TransFields:Fields
    {
        private string refNo;
        public string RefNo
        {
            get { return refNo; }
            set { refNo = value; }
        }

        private string transCode;
        public string TransCode
        {
            get { return transCode; }
            set { transCode = value; }
        }

        private string itemCat;
        public string ItemCategory
        {
            get { return itemCat; }
            set { itemCat = value; }
        }

        private string qty;
        public string Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        private string serial;
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        private string remark;
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        
    }
}
