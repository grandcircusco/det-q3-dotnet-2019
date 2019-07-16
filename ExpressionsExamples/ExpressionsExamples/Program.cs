using System;

namespace ExpressionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 12.2;
            float num2 = 1.0f;
            int num3 = 7;

            bool isEqual = (num1 == (num2 + num3));

            string var1 = "cat";
            string var2 = "dog";

            bool isEqual2 = (var1 == var2);

            Console.WriteLine($"{num1}=={num2} = {isEqual}");
            Console.WriteLine("isEqual2 = " + isEqual2);

            bool isEqual3 = !((num2 > num3) && (num1 > num2));
            Console.WriteLine(isEqual3);


        }
    }
}
