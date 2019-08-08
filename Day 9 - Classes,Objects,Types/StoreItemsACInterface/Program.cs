using System;
using System.Collections.Generic;

namespace StoreItemsACInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StoreItems> storeItems = new List<StoreItems>
            {
                new Book("Name of the Wind", 1000, "Pat Rothfuss", "book department", "fjkdlflkjasfjdsjskal", 10),
                new Shoe("Shoe Department", "jkfkjlafj  aj k alj", 5, 9.0, "leather", "Birkenstock", "sandal"),
                new Book("The Hobbit", 250, "JRR Tolkein", "book department", "ljkj;l safjlk fda", 2)
            };

            foreach(var item in storeItems)
            {
                var bookItem = item as Book;

                if(bookItem != null)
                {
                    Console.WriteLine(bookItem.Title);
                }

            }
        }
    }
}
