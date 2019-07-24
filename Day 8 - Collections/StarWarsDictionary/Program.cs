using System;
using System.Collections.Generic;

namespace StarWarsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> starWarsCharacters = new Dictionary<string, bool>
            {
                {"Jarjar Binks", false },
                {"Darth Bane", true },
                {"Rey's Parents", true },
                {"General Grievous", false },
                {"Yoda", true },
                {"Captain Needa", false }
            };

            //KeyValuePair<string,bool> keyValuePair
            foreach(var keyValuePair in starWarsCharacters)
            {
                PrintCharacters(keyValuePair);
            }
        }
        public static void PrintCharacters(KeyValuePair<string,bool> keyValuePair)
        {
            if (keyValuePair.Value == true)
            {
                Console.WriteLine($"{keyValuePair.Key} is a jedi");
            }
            else
            {
                Console.WriteLine($"{keyValuePair.Key} is not a jedi");
            }
        }
    }
}
