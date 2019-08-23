using System;
using System.Collections.Generic;

namespace IdentityFramework.Models
{
    public partial class LibraryBooks
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime? DueDate { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
