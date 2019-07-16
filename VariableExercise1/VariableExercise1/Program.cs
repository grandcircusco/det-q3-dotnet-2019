using System;

namespace VariableExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input -- prompting & receiving 2 numbers
            //1. Prompted
            Console.WriteLine("Give me a number!");
            //2. Received
            string input1 = Console.ReadLine();

            Console.WriteLine("A second number, please.");
            string input2 = Console.ReadLine();

            //processing -- adding those two numbers together
            //Convert to int
            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            //add numbers together
            int sum = num1 + num2;
            //output -- displaying the sum
            Console.WriteLine(num1 + "+" + num2+"=" + sum);
        }
    }
}
