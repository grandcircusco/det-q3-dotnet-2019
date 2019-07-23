using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = ReadIntegers("Give me your first number.");
            int num2 = ReadIntegers("Give me your second number.");

            //int result1 = FindMax(4, 6);
            //int result2 = FindMax(7, 5);
            //int result3 = FindMax(5, 5);

            //Console.WriteLine($"4, 6: expected 6. Actual: {result1}");
            //Console.WriteLine($"7, 5: expected 7. Actual: {result2}");
            //Console.WriteLine($"5, 5: expected 5. Actual: {result3}");

            int max = FindMax(num1, num2);

        }

        //Create a static method called ReadIntegers that takews in a string message
        //as a parameter. The method should take in user input, convert it to an integer,
        //and return the number.
        public static int ReadIntegers(string message)
        {
            //input
            //prompt
            Console.WriteLine(message);
            //retrieve
            string input = Console.ReadLine();
            //processing
            int num = int.Parse(input);
            //output
            return num;
        }

        //Createa  public static method called FindMax that takes in two parameters: int num1, int num2.
        //The method should compare those two numbers an return the greater of the two.
        public static int FindMax(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
