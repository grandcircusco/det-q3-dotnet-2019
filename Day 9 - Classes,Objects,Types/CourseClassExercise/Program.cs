using System;
using System.Collections.Generic;

namespace CourseClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Course newCourse = 
                new Course("C#.Net", "Anna", 
                        new DateTime(7/15/2019), 
                        new DateTime(9/20/2019));

            List<Student> studentList = new List<Student>
            {
                new Student("Tom", "Jones", "CS", 4.0, 
                "tomjones@tomjones.com"),
                new Student("Berry", "White", "Undecided", 2.5, 
                "berrywhite@berrywhite.co"),
                new Student("Tony", "Stark", "Superhero Stuff", 7,
                "tony@starkenterprises.co")
            };

            newCourse.Students = studentList;

            foreach(Student student in newCourse.Students)
            {
                Console.WriteLine(student.FirstName);
            }
        }
    }
}
