using System;

namespace RecursionValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            { 
                //program program program. does the thing

                //now we ask if the user wants to do it again
                cont = ValidateUserChoice("y", "n", "Continue? y/n");
                Console.WriteLine($"if 'y', expected: true, if 'n', expected: false, result: {cont}");
            }
        }

        public static bool ValidateUserChoice(string option1, string option2,  string message)
        {
            string input = GetUserInput(message);

            if(input == option1)
            {
                return true;
            }
            else if(input == option2)
            {
                return false;
            }
            else
            {
                return ValidateUserChoice(option1, option2, "Oops! Not an Option! Continue? y/n");
            }
        }

        public static string GetUserInput(string message)
        {
            //input
            //prompt
            Console.WriteLine(message);
            //retrieve
            string input = Console.ReadLine();
            //processing & output
            return input;
        }
    }
}
