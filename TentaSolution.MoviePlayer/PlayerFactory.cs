using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaSolution.MoviePlayer
{
    public class PlayerFactory
    {
        private IPlayer myPlayer;
        public IPlayer CreatePlayer(string companyName)
        {
            if (companyName == "SF")
            {
                myPlayer = new SFPlayer();
            }
            else if (companyName == "Netflix")
            {
                myPlayer = new NetflixPlayer();
            }

            return myPlayer;
        }
    }
}
