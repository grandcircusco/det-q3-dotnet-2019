using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class Pets
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Species { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
