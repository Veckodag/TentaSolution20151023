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
        public void PlayMovie(string movieName)
        {
           Debug.WriteLine("Watching " + movieName + " on SF");
        }
    }
}
