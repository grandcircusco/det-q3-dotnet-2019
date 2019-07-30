namespace CourseClassExercise
{    public class Student
    {
        #region fields/Data Members
        private string firstName;
        private string lastName;
        private string major;
        private double _gpa;
        private string email;
        #endregion

        #region Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }
        public double GPA
        {
            get
            {
                return _gpa;
            }
            set
            {
                _gpa = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        #endregion

        #region constructors
        public Student()
        {
            major = "undeclared";
        }

        public Student(string _firstName, string _lastName,
            string _major, double _gpa, string _email)
        {
            firstName = _firstName;
            lastName = _lastName;
            major = _major;
            this._gpa = _gpa;
        }
        #endregion
    }
}