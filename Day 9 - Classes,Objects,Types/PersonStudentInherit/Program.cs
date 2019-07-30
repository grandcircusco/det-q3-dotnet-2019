using System;
using System.Collections.Generic;

namespace PersonStudentInherit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>
            {
                new Student(4.2, "Grand Circus", "C#",
                "Ted", "Lindsey", "B+", new DateTime(1/1/1980)),

                new Instructor(10000000, "Kamel", "R", "O-", new DateTime(4/3/1981))

            };
        }
    }
}
