using System;

namespace Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();

            PrintMessage("Hello World with a parameter");
        }

        public static void PrintMessage()
        {
            Console.WriteLine("Hello world!");
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
