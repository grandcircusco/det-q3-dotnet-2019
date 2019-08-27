using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_31___Web_APIs.Models
{
    public class Joke
    {
        public string Type { get; set; }

        public JokeContent Value {get; set;}
    }
}
