using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> restaurants = new List<string>();
            restaurants.Add("Mario's");
            restaurants.Add("Dime Store");
            restaurants.Add("Cobb's Corner");
            restaurants.Add("Green Dot Stables");

            for(int i = 0; i < restaurants.Count; i++)
            {
                Console.WriteLine($"{i+1}. {restaurants[i]}");
            }
        }
    }
}
