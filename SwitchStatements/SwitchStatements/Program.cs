using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Welcome to the GC Burger Shop.");
            Console.WriteLine("1. Cheeseburger");
            Console.WriteLine("2. Double Cheeseburger");
            Console.WriteLine("3. Cheese Sammich");
            Console.WriteLine("4. Exit");

            string userInput = Console.ReadLine();
            string userInputLower = userInput.ToLower();
            //processing & output
            switch (userInputLower)
            {
                case "1":
                case "cheeseburger":
                    Console.WriteLine("yum");
                    break;
                case "2":
                case "double cheeseburger":
                    Console.WriteLine("yum. I ate too much.");
                    break;
                case "3":
                case "cheese sammich":
                    Console.WriteLine("I'm a vegetarian.");
                    break;
                default:
                    Console.WriteLine("Try again.");
                    break;
            }

        }
    }
}
