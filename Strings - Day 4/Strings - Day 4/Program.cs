using System;

namespace Strings___Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string together = string.Concat("Hello ", "World");
            //together == "Hello World"

            int isSame = string.Compare("Hello", "hi");
            // will return 0 for true and 1 for false
            bool trueFalse = ConvertBinary(isSame);
            //converts the result of Compare (binary) into true or false

            bool isSame2 = together.Equals("Hello World");

            //Console.WriteLine($"{together} == {isSame2}");
            int index = together.IndexOf("or");
            //will check for the first instance of the string cluster "or"
            //and return the first index ("Hello World" -- 7)

            int lastIndex = together.LastIndexOf("l");
            //will check for the last instance of the string or string cluster
            //and return the last index ("Hello World" -- 9)

            bool endsWith = together.EndsWith("ld");
            //returns true or false dependent on whether the string ends with
            //the given string

            string newTogether = together.Replace("World", "Class");
            string otherNewTogether = together.Replace('o', 't');

            string[] togetherArray = together.Split(' '); 

            foreach(string word in togetherArray)
            {
                //Console.WriteLine(word);
            }

            int num = together.IndexOf('W');

            string smallTogether = together.Substring(num);
            string otherTogether = together.Substring(num, 4);

            Console.WriteLine(otherTogether);
        }

        public static bool ConvertBinary(int binaryNumber)
        {
            if(binaryNumber == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
