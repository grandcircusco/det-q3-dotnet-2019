using System;
using System.Collections.Generic;

namespace WebApplication6.Models
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string DepName { get; set; }
        public double Budget { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
