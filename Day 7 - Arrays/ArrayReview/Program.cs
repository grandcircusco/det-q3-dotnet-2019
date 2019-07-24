using System;

namespace ArrayReview
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruitArray = new string[6];

            fruitArray[0] = "banana";
            fruitArray[1] = "pomegranate";
            fruitArray[2] = "dragon fruit";
            fruitArray[3] = "tomato";

            int count = 1;
            foreach(string fruit in fruitArray)
            {
                //Console.WriteLine("foreach: " + count + fruit + "is forwards");
                Console.WriteLine($"foreach: {count}. {fruit} is forwards");
                count++;
            }

            for(int i = fruitArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"for:  {fruitArray[i]} is backwards");
                Console.WriteLine("for: " + fruitArray[i] + "is backwards");
            }


        }
    }
}
