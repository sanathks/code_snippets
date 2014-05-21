using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingSystem
{
    class ECFieldData:FixtAssetData
    {
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }
}
