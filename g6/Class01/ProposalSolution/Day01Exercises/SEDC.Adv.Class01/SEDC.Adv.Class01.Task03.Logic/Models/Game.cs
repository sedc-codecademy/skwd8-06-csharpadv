using System.Collections.Generic;

namespace SEDC.Adv.Class01.Task03.Logic.Models
{
    // this is our base Game class
    public class Game
    {
        private int GamesPlayed { get; set; }
        protected bool IsActive { get; set; }

        public Game()
        {
            GamesPlayed = 0;
        }

        protected void IncreaseGamesPlayed()
        {
            GamesPlayed += 1;
        }

        protected int GetGamesPlayed()
        {
            return GamesPlayed;
        }
    }
}
