using System;

namespace ConditionalsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //prompt
            Console.Write("Are you hungry?");
            //response
            string input = Console.ReadLine().ToLower();
            //processsing & output
            if(input == "yes" || input == "y")
            {
                //input
                string foodInput = "";
                while(foodInput != "cheeseburger" && foodInput != "salad" && foodInput != "quinoa")
                {
                    Console.WriteLine("Would you like a cheeseburger, a salad, or quinoa.");
                    foodInput = Console.ReadLine();
                }


                //processing & output
                switch (foodInput)
                {
                    case "cheeseburger":
                        Console.WriteLine("I thought were on a diet. Here's a bunless burger");
                        break;
                    case "salad":
                        string saladChoice = "";
                        while (saladChoice != "caesar" && saladChoice != "garden")
                        {
                            Console.WriteLine("Would you like a caesar salad or garden salad?");
                            saladChoice = Console.ReadLine().ToLower();
                        }
                        if (saladChoice == "caesar")
                        {
                            Console.WriteLine("Yum! The Romans loved it.");
                        }
                        else
                        {
                            Console.WriteLine("Great! I grew the vegetables myself.");
                        }
                        break;
                    case "quinoa":
                        Console.WriteLine("Good grains. It's a superfood.");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Go back to sleep");
            }
        }
    }
}
