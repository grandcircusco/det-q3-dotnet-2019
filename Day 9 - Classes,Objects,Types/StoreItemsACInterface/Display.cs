using System;
using System.Collections.Generic;
using System.Text;

namespace StoreItemsACInterface
{
    class Display:StoreItems
    {
        public TimeSpan ShelfLife { get; set; }
        public int ItemAge { get; set; }

        public Display(TimeSpan shelfLife, int itemAge, 
            string location, string barcode, int quantity)
            :base(location, barcode, quantity)
        {
            ShelfLife = shelfLife;
            ItemAge = itemAge;
        }


    }
}
