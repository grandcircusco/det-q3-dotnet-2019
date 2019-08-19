using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day_26___ModelValidation.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Must give a movie title!")]
        [StringLength(10, ErrorMessage ="The title must be less than 50 characters.")]
        [RegularExpression("", ErrorMessage ="Title must begin with a capital letter.")]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        [StringLength(5, MinimumLength = 1)]
        public string Rating { get; set; }
        [Required]
        public int RunTime { get; set; }
    }
}
