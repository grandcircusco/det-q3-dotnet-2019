using System;

namespace IntValidationWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = ValidateIntegers("Gimme a number!");
            Console.WriteLine($"result: {result}");
        }

        public static int ValidateIntegers(string message)
        {
            string input = GetUserInput(message);
            int number;
            if(int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                return ValidateIntegers("Please input a correct number!");
            }
        }

        public static string GetUserInput(string message)
        {
            //input --- prompt & retrieve
            Console.WriteLine(message);
            string input = Console.ReadLine();
            //processing & output
            return input;
        }
    }
}
