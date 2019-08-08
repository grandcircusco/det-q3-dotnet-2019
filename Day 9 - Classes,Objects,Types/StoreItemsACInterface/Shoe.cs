using System;
using System.Collections.Generic;
using System.Text;

namespace StoreItemsACInterface
{
    class Shoe : StoreItems, IForSale
    {
        public double Size { get; set; }
        public string Fabric { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }

        public Shoe(string location, string barcode, int quantity,
            double size, string fabric, string brand, string type)
            :base(location, barcode, quantity)
        {
            Size = size;
            Fabric = fabric;
            Brand = brand;
            Type = type;
        }

        public int StockIn()
        {
            return Quantity++;
        }

        public int StockOut()
        {
            return Quantity--;
        }

        public string DisplayMethod()
        {
            return "By Designer. Small sizes up top, larger towards bottom.";
        }
    }
}
