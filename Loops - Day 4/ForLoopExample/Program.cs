using System;

namespace ForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            RepeatHellos();

            RepeatHellos(3);
        }

        public static void RepeatHellos()
        {
            for(int i = 5; i > 0; i--)
            {
                Console.WriteLine($"{i}. Hello!");
            }
        }

        public static void RepeatHellos(int max, int min)
        {

        }
        public static void RepeatHellos(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i}. Hello again!");
            }
        }
    }
}
