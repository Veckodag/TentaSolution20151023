using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TentaSolution.MoviePlayer;

namespace TentaSolution.Test
{
    [TestClass]
    public class MoviePlayerTests
    {
        [TestMethod]
        public void TestNetflixPlayer()
        {
            IPlayer myPlayer = null;
            Movie myMovie = new Movie("Argo");
            myMovie = MovieFacade.Play(myPlayer, "Netflix", myMovie.Name);
            Debug.WriteLine(myMovie.WatchedOn);
            Assert.AreEqual(true, myMovie.HasBeenPlayed);
        }
        [TestMethod]
        public void TestSFPlayer()
        {
            IPlayer myPlayer = null;
            Movie myMovie = new Movie("Argo");
            myMovie = MovieFacade.Play(myPlayer, "SF", myMovie.Name);
            Debug.WriteLine(myMovie.WatchedOn);
            Assert.AreEqual(true, myMovie.HasBeenPlayed);
        }
    }
}
