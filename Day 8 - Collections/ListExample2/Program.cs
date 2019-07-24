using System;
using System.Collections.Generic;

namespace ListExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>
            {
                "Sheboygan", "Cheboygan", "Miami", "Worchester", "Ann Arbor", "Dallas"
            };
            List<string> states = new List<string>
            {
                "Wisconsin", "Michigan", "Florida", "Massachusettes", "Michigan", "Texas"
            };

            //input
            //prompt & retrieve
            string city = GetUserInput("Gimme a city.");
            string state = GetUserInput("What state?");

            //processing
            cities = AddtoList(city, cities);
            states = AddtoList(state, states);

            //output
            PrintTwoLists(cities, states);

            //foreach(string listCity in cities)
            //{
            //    Console.WriteLine(listCity);
            //}

        }

        public static void PrintTwoLists(List<string> list1, List<string> list2)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine($"{list1[i]}, {list2[i]}");
            }
        }
        public static List<string> AddtoList(string input, List<string> list)
        {
            list.Add(input);
            return list;
        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
