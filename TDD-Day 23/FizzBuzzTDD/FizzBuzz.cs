using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTDD
{
    public class FizzBuzz
    {
        public static string FizzBuzzWoof(int number)
        {
            string resultString = "";

            if (number % 3 == 0 || number.ToString().Contains("3"))
            {
                resultString += "Fizz";
            }
            if (number % 5 == 0 || number.ToString().Contains("5"))
            {
                resultString += "Buzz";
            }
            if (number % 7 == 0 || number.ToString().Contains("7"))
            {
                resultString += "Woof";
            }
            if(resultString == "")
            {
                return number.ToString();
            }                        
            return resultString;
        }
    }
}
