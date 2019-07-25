using System;

namespace Reference_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type Example
            int num = 0;
            //num2 = 0;
            //creates new memory for the value of num2
            int num2 = num;
            //changing the data for num by adding 1 to it
            num++;
            //shows that changing the data in num does not directly affect
            //the data in num2
            Console.WriteLine(num2);

            //Reference Type Example
            int[] numbers = { 5, 6, 7, 8 };
            int[] numbers2 = numbers;
            //By changing numbers2 at index 0, we are changing the same
            //piece of memory as numbers at index 0.
            //both Arrays are referencing the same piece of memory
            numbers2[0] = 3;
            Console.WriteLine(numbers[0]); //3

            numbers[3] = 12;
            Console.WriteLine(numbers2[3]); //12


        }
    }
}
