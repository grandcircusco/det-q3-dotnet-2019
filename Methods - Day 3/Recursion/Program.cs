using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int result = SumNumbers(2, 5);
            Console.WriteLine($"Expected: 14, Actual: {result}");
        }

        public static int SumNumbers(int num1, int num2)
        {
            int sum = num1;
            if(num1 < num2)
            {
                num1++;
                sum += SumNumbers(num1, num2);
            }
            return sum;
        }
    }
}
