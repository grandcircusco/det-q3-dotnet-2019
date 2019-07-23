using System;
using System.Text.RegularExpressions;

namespace RegexMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            string input = Console.ReadLine();
            //we would call the UseRegex method
            string result = UseRegex(input, "//put regex pattern here");

        }

        public static string UseRegex(string input, string pattern)
        {
            bool isValid = Regex.IsMatch(input, pattern);
            if (isValid)
            {
                return "That worked!";
            }
            else
            {
                return "That didn't work.";
            }
        }
    }
}
