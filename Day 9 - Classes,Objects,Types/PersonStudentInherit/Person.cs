using System;
using System.Collections.Generic;
using System.Text;

namespace PersonStudentInherit
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BloodType { get; set; }
        public DateTime DOB { get; set; }

        public Person(string firstName, string lastName,
            string bloodType, DateTime dob)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BloodType = bloodType;
            this.DOB = dob;
        }

    }
}
