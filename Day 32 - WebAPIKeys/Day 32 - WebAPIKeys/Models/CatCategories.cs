using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_32___WebAPIKeys.Models
{
    public class CatCategories
    {

        public class CatCategory
        {
            public Category[] Property1 { get; set; }
        }

        public class Category
        {
            public int id { get; set; }
            public string name { get; set; }
        }

    }
}
