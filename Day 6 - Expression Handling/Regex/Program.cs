using System;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = VerifyEmail("anna@grandcircus.co");
            Console.WriteLine(result);
        }
        //get user info

        public static bool VerifyEmail(string userEmail)
        {
            //add 
            bool works = Regex.IsMatch(userEmail, @"^([a-z]{4,20})@([a-z]{5,10})+\.+([a-z]{1,3})$");
            return works;
        }
    }
}
