using System;

namespace WhiteBoardExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create an array of 3 colors (you choose the colors).
            //2. Print out the third color to the console.
            //3. Print out the length of the array.
            //4. Add a line of code to change the second color to white.

            //5. Use a for-loop to print all three colors in reverse.
            //6. Use a foreach loop to print all three colors.

            int[] numbers = { 1, 14, -3, 49000000, 57 };

            Array.Sort(numbers);

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            string[] names = {"Joe", "Eugene", "Philip", "Stacey", "Margot", "Sandy" };

            Array.Sort(names);

            foreach(string name in names)
            {
                char[] letters = name.ToLower().ToCharArray();
                Array.Sort(letters);
                foreach(char letter in letters)
                {
                    Console.Write(letter);
                }
                Console.Write(" ");
            }

            for (int i = 0; i < names.Length; i++)
            {

                Console.WriteLine(names[i]);
            }
        }
    }
}
