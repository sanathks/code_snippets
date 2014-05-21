using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingSystem
{
    class StockFields:Fields
    {
        private string stock;

        public string Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}
