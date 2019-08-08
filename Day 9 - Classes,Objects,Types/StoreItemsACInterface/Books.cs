using System;
using System.Collections.Generic;
using System.Text;

namespace StoreItemsACInterface
{
    class Book : StoreItems, IForSale
    {
        public string Title { get; set; }
        public int NumOfPages { get; set; }
        public string Author { get; set; }

        public Book(string title, int numOfPages, string author,
            string location, string barCode, int quantity) 
            :base(location, barCode, quantity)
        {
            Title = title;
            NumOfPages = numOfPages;
            Author = author;
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
            return "Alphabetical Order by Author and Title";
        }
    }
}
