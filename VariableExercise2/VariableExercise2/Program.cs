using System;

namespace VariableExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input - name, city, age, pin
            //1. Prompt
            Console.Write("What is your name? ");
            //2. Receive
            string name = Console.ReadLine();
            Console.Write("What city do you live in? ");
            string city = Console.ReadLine();
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("What's your {fake} pin? ");
            string pin = Console.ReadLine();
            
            //processing  - find user's birth year
            int birthYear = DateTime.Now.Year - age;

            //output
            Console.WriteLine("Your Name is: " + name);
            Console.WriteLine("You live in: " + city);
            Console.WriteLine("You were born in: " + birthYear+" or " + (birthYear+1));
            Console.WriteLine("Your pin is: " + pin);
        }
    }
}
