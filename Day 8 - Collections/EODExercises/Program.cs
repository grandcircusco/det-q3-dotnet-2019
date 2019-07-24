using System;
using System.Collections.Generic;
using System.Linq;

namespace EODExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            { 5, 9, 5, 4, 2 }; 

            int num = ReturnMax(numbers);
            Console.WriteLine(num);
        }

        public static int ReturnMax(List<int> list)
        {
            //return list.Max();

            int max = 0;
            foreach(int number in list)
            {
                if(number > max)
                {
                    max = number;
                }
            }

            return max;
        }


    }
}
