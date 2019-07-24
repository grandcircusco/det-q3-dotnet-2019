using System;

namespace Day_7___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[4];
            array1[0] = 55;
            Console.WriteLine($"array1[0]: {array1[0]}");
            Console.WriteLine($"array1[1]: {array1[1]}");

            int arraySize = 4;
            int[] array2;
            array2 = new int[arraySize];

            string[] animalArray = {"cat", "dog", "rat", "snake,", "bunny" };

            ListOutArray(animalArray);
        }

        public static void ListOutArray(string[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}
