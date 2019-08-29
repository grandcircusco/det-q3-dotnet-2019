using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakingAPIsMVC.Models
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }
        public int? departmentId { get; set; }
        public object department { get; set; }
    }

}
