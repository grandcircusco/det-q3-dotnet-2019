using System;
using System.Collections.Generic;
using System.Text;

namespace PersonStudentInherit
{
    public class Instructor : Person
    {
        public double Income { get; set; }

        public Instructor(double income, string firstName,
            string lastName, string bloodType, DateTime dob)
            :base(firstName, lastName, bloodType, dob)
        {
            this.Income = income;
        }
    }
}
