using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Tim");
            dictionary.Add(2, "Fred");
            dictionary.Add(3, "Bill");

            foreach(KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key.ToString()}. - {kvp.Value.ToString()}");
            }
        }
    }
}
