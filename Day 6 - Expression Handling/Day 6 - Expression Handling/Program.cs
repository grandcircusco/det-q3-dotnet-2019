using System;

namespace Day_6___Expression_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = GetNumbers();
            int num2 = GetNumbers();
            int product = MultiplyNumbers(num1, num2);
            Console.WriteLine(product);
        }

        public static int GetNumbers()
        {
            int number = 0;
            while (number == 0)
            {
                Console.WriteLine("Enter a number!");
                string input = Console.ReadLine();
                number = ParseInt(input);
            }
            return number;
        }


        public static int ParseInt(string maybeNumber)
        {
            try
            {
                int number = int.Parse(maybeNumber);
                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("I think you entered bad info.");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number too big!");
                return 0; 
            }
            catch (Exception)
            {
                return 0;
            }
            
        }

        public static int MultiplyNumbers(int num1, int num2)
        {
            try
            {
                int product = num1 * num2;
                return product;
            }
            catch (OverflowException)
            {
                Console.WriteLine("I think that number might be too big.");
                return 0;
            }
        }
    }
}
