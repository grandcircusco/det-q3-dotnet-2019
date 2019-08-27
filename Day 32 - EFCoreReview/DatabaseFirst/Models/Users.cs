using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Users
    {
        public Users()
        {
            Cars = new HashSet<Cars>();
            Pets = new HashSet<Pets>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }

        public virtual ICollection<Cars> Cars { get; set; }
        public virtual ICollection<Pets> Pets { get; set; }
    }
}
