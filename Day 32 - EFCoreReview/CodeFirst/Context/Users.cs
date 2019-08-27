using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Context
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage ="Max of 30 characters!")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }

        //two lists - one of pets, one of cars
        public virtual ICollection<Pets> Pets { get; set; }
        public virtual ICollection<Cars> Cars { get; set; }
    }
}
