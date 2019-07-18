using System;

namespace VoidMethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetUser("Anna");

            GreetUser("English", "Mitch");
            GreetUser("French", "Joe");
            GreetUser("Spanish", "Karey");
            GreetUser("Russian", "Steve");
        }

        //Create a static method called GreetUser 
        //that takes in a string name and prints a greeting to the console. 
        //Include the name in the greeting.
        public static void GreetUser(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        //Create a static method called GreetUser
        //that takes in a string name and a string language.
        //The method should print a phrase in the given language (include the name)
        //if that language is English, French, or Spanish. If not E, F, or S, print
        //the name with question marks.
        public static void GreetUser(string language, string name)
        {
            switch (language.ToLower())
            {
                case "english":
                    Console.WriteLine($"Hello, {name}");
                    break;
                case "french":
                    Console.WriteLine($"Bonjour, {name}");
                    break;
                case "spanish":
                    Console.WriteLine($"Hola, {name}");
                    break;
                default:
                    Console.WriteLine($"????? {name}");
                    break;
            }
        }

    }
}
