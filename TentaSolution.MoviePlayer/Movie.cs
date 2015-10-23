using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaSolution.MoviePlayer
{
    public class Movie
    {
        public Movie(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public bool HasBeenPlayed { get; set; }
        public string WatchedOn { get; set; }
    }
}
