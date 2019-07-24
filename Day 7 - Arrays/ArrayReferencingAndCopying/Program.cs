using System;

namespace ArrayReferencingAndCopying
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tvArray = { "Game of Thrones", "The Office", "Rick and Morty", "Stranger Things", "Cheers" };

            //This is creating a reference to tvArray called tvShowArray
            string[] tvShowArray = tvArray;
            //Any changes to tvArray will also affect the tvShowArray

            string[] copyTvArray = new string[tvArray.Length];
            tvArray.CopyTo(copyTvArray, 0);

            Array.Sort(tvArray);

            Console.WriteLine("This is our TvShowArray - the reference to tvArray:");
            foreach (string show in tvShowArray)
            {
                Console.WriteLine($"{show}, ");
            }
            Console.WriteLine("This is our copyTvArray - a copy of our tvArray: ");
            foreach(string show in copyTvArray)
            {
                Console.WriteLine($"{show}, ");
            }
        }
    }
}
