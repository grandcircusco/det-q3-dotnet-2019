using System;
using System.Collections.Generic;
using System.Text;

namespace PersonStudentInherit
{
    public class Student : Person
    {
        public double GPA { get; set; }
        public string School { get; set; }
        public string Major { get; set; }

        public Student(double gpa, string school, string major, 
            string firstName, string lastName, string bloodType, 
            DateTime dob)
            :base(firstName, lastName, bloodType, dob)
        {
            this.GPA = gpa;
            this.School = school;
            this.Major = major;
        }
    }
}
