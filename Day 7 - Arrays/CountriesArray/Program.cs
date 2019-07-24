using System;

namespace CountriesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = new string[3];
            for(int i = 0; i < countries.Length; i++)
            {
                countries[i] = GetUserInput($"Give me a country!");
            }

            //ListOutArray(countries);
            //countries[1] = "USA";
            //Console.ReadKey();
            //ListOutArray(countries);

            int index = ValidateRange("Which index would you like to see?", 0, countries.Length);

            Console.WriteLine(countries[index]);
        }
        public static int ValidateRange(string message, int min, int max)
        {
            int number = ParseUserInput(message);
            if(number >= min && number < max)
            {
                return number;
            }
            else
            {
                return ValidateRange(message, min, max);
            }
        }
        public static int ParseUserInput(string message)
        {
            //input -- GetUserInput
            string input = GetUserInput(message);
            //processing -- parse the input (TryParse)
            bool success = int.TryParse(input, out int number);
            //If parse unsuccessful, 
            if(success == false)
            {
                //call ParseUserInput again (recursion!)
                return ParseUserInput(message);
            }
            else
            {
                //output -- return our number
                return number;
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        public static void ListOutArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
