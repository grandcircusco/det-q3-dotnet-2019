using System;

namespace ConditionalsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////input
            ////1. prompt
            //Console.Write("How old are you? ");
            ////2. Retrieve
            //string userInput = Console.ReadLine();

            ////processing
            //int age = int.Parse(userInput);
            //if((age >= 0) && (age <= 125))
            //{
            //    Console.WriteLine("That seems like an age someone could have.");
            //}

            //input
            Console.WriteLine("Give me an animal: cat or dog or elephant.");
            string userInput = Console.ReadLine();
            string sound;
            if(userInput == "cat")
            {
                sound = "meow";
            }
            else if(userInput == "dog")
            {
                sound = "woof";
            }
            else if (userInput == "elephant")
            {
                sound = "*trumpet*";
            }
            else
            {
                sound = "what?";
            }

            Console.WriteLine($"A {userInput} sounds like {sound}.");

            //if((userInput == "cat") || (userInput == "dog") || (userInput == "elephant"))
            //{
            //    Console.WriteLine($"You chose a {userInput}!");
            //}
            //else
            //{
            //    Console.WriteLine("That wasn't an option, silly.");
            //}
        }
    }
}
