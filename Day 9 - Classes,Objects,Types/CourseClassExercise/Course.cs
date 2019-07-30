using System;
using System.Collections.Generic;
using System.Text;

namespace CourseClassExercise
{
    public class Course
    {
        #region fields (otherwise known as Data Members)
        private string courseName;
        private string instructorName;
        private DateTime startDate;
        private DateTime endDate;
        private int courseSize;
        private List<Student> students;
        #endregion

        #region properties
        public string CourseName { get => courseName; set => courseName = value; }
        public string InstructorName { get => instructorName; set => instructorName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int CourseSize { get => courseSize; set => courseSize = value; }
        public List<Student> Students { get => students; set => students = value; }

        #endregion

        #region Constructors

        public Course()
        {
            courseName = "C#.Net";
        }

        public Course(string _courseName, string _instructorName, 
            DateTime _startDate, DateTime _endDate)
        {
            courseName = _courseName;
            instructorName = _instructorName;
            startDate = _startDate;
            endDate = _endDate;
        }
        #endregion

        #region Methods
        public int GetDurationOfDays()
        {
            return (int)(EndDate - StartDate).TotalDays;
        }
        #endregion
    }
}
