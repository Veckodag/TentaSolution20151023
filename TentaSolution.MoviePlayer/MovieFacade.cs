using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaSolution.MoviePlayer
{
    public static class MovieFacade
    {
        public static Movie Play(IPlayer myPlayer, string companyName, string movieName)
        {
            PlayerFactory myFactory = new PlayerFactory();
            myPlayer = myFactory.CreatePlayer(companyName);
            Movie myMovie = new Movie(movieName);
            myMovie.WatchedOn = myPlayer.PlayMovie(myMovie.Name);
            myMovie.HasBeenPlayed = true;
            return myMovie;

        }
    }
}
