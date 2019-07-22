using System;

namespace Loops___Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = SumNumbers(2, 5);
            Console.WriteLine($"Expected: 14, result: {result}");
            int result2 = SumNumbers(4, 60);
            Console.WriteLine($"Expected: a very large number, Result: {result2}");
        }

        public static int SumNumbers(int num1, int num2)
        {
            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                //sum = i + num2;
                sum += i;
                //sum = sum + i;
            }

            return sum;
        }
    }
}
