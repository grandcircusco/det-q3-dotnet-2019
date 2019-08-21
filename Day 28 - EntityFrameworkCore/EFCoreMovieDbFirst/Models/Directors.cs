using System;
using System.Collections.Generic;

namespace EFCoreMovieDbFirst.Models
{
    public partial class Directors
    {
        public int DirectorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Genre { get; set; }
    }
}
