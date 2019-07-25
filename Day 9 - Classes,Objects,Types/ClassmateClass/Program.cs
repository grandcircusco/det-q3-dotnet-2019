using System;

namespace ClassmateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //with default constructor
            Classmate dave = new Classmate();
            Console.WriteLine("Before set: " + dave.Name);
            dave.Name = "Dave"; //set the Name property to Dave
            Console.WriteLine("After set: " + dave.Name); //get 

            //with overloaded constructor
            Classmate suzie = new Classmate("Suzie", "Baltimore", "Crab", 43);
            suzie.FavoriteFood = "Lobster";

            suzie.PrintInfo();
        }
    }
}
