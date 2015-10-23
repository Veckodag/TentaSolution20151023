using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaSolution.MoviePlayer
{
    class NetflixPlayer : IPlayer
    {
        public string PlayMovie(string movieName)
        {
            return "Watching " + movieName + " on Netflix";
        }

    }
}
