using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaSolution.MoviePlayer
{
    public class SFPlayer : IPlayer
    {
        public string PlayMovie(string movieName)
        {
           return "Watching " + movieName + " on SF";
        }
    }
}
