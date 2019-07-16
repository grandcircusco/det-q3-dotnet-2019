using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {

            //input

            Console.WriteLine("What's your birthday?");

            string userDOB = Console.ReadLine();

            Console.WriteLine("When does class start?");

            string userStart = Console.ReadLine();



            //processing -- convert & subtract

            DateTime DOB = DateTime.Parse(userDOB);

            DateTime startdate = DateTime.Parse(userStart);



            int age = startdate.Year - DOB.Year;



            //output

            Console.WriteLine(age);



        }
    }
}
