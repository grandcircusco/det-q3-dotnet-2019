using System;

namespace ConsoleClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //1. Prompt
            Console.WriteLine("Give me a number please.");

            //2. Receive
            string input = Console.ReadLine();

            //Processing
            int number = int.Parse(input);

            input = number.ToString();
            //Output
            Console.WriteLine(input);

            //casting ints
            Int64 num = number;
            Int16 num2 = (Int16)number;

            char letter = 'c';
            string newLetter = letter.ToString();
        }
    }
}
