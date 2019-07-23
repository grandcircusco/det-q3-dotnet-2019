using System;

namespace InClassCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //prompt
            bool go = true;
            while(go)
            {
                double num1, num2;

                num1 = ReadDoubles("Number 1: ");
                num2 = ReadDoubles("Number 2: ");

                PrintMenu();

                //receive
                string userChoice = Console.ReadLine();
                //input -- getting numbers from the user

                //processing
                switch (userChoice.ToLower())
                {
                    case "1":
                    case "addition":                       
                        //processing
                        double sum = AddDoubles(num1, num2);
                        //output
                        Console.WriteLine($"{num1} + {num2} = {sum}");
                        break;
                    case "2":
                    case "subtraction":
                        //input/process/output
                        //double diff = SubtractDoubles(num1, num2);
                        break;
                    case "3":
                    case "multiplication":
                        //input/process/output
                        break;
                    case "4":
                    case "division":
                        //input/process/output
                        break;
                    case "5":
                    case "exit":
                        go = false;
                        break;
                    default:
                        Console.WriteLine("Not valid. Try again.");
                        break;
                }
            }
            //output
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
        }

        public static double ReadDoubles(string message)
        {
            //input
            //prompt
            Console.WriteLine(message);
            //retrieve
            string input = Console.ReadLine();
            //processing
            double num = double.Parse(input);
            //output
            return num;
        }

        public static double AddDoubles(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
