using System;
using System.Collections.Generic;
using System.Text;

namespace StoreItemsACInterface
{
    interface IForSale
    {
        int StockIn();
        int StockOut();
        string DisplayMethod();
    }
}
