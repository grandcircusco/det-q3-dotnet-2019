using System;
using System.Collections.Generic;

namespace EFCoreMovieDbFirst.Models
{
    public partial class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int DirectorId { get; set; }
    }
}
