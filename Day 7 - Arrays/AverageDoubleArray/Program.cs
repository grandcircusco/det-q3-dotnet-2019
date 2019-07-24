using System;

namespace AverageDoubleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = { 2.95, 12.75, 9.99, 18.12, 17.76, 19.44 };

            double average = AverageArray(prices);

            Console.WriteLine(average);
        }

        //create a method that takes in a double[]. 
        //the method should return the average
        //of all elements in the array.
        public static double AverageArray(double[] array)
        {
            double sum = 0;
            foreach(double number in array)
            {
                sum += number;
                //sum = sum + number;
            }
            double average = sum / array.Length;
            return average;
        }
    }
}
