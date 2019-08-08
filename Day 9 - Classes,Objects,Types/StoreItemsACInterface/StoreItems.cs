using System;
using System.Collections.Generic;
using System.Text;

namespace StoreItemsACInterface
{
    abstract class StoreItems
    {
        public string Location { get; set; }
        public string BarCode { get; set; }
        public int Quantity { get; set; }

        public StoreItems(string location, string barCode, int quantity)
        {
            Location = location;
            BarCode = barCode;
            Quantity = quantity;
        }


    }
}
