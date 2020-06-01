using System;

namespace RockPaperScissors
{
    internal class Game
    {
        public int TotalGames { get => FirstWins + SecondWins + Ties; }
        public int WonGames { get => FirstWins + SecondWins; }
        public int FirstWins { get; private set; } = 0;
        public int SecondWins { get; private set; } = 0;
        public int Ties { get; private set; } = 0;

        public Game()
        {

        }

        public void RegisterResult(GameResult result)
        {
            switch (result)
            {
                case GameResult.FirstWin:
                    FirstWins += 1;
                    break;
                case GameResult.SecondWin:
                    SecondWins += 1;
                    break;
                case GameResult.Tie:
                    Ties += 1;
                    break;
            }
        }

        internal GameResult Evaluate(GameMove first, GameMove second)
        {
            if (first == second)
            {
                return GameResult.Tie;
            }

            if (first == GameMove.Rock)
            {
                // rock crushes scissors and lizard
                if (second == GameMove.Scissors || second == GameMove.Lizard)
                {
                    return GameResult.FirstWin;
                }
                return GameResult.SecondWin;
            }

            if (first == GameMove.Paper)
            {
                // covers rock, disproves spock
                if (second == GameMove.Spock || second == GameMove.Rock)
                {
                    return GameResult.FirstWin;
                }
                return GameResult.SecondWin;
            }

            if (first == GameMove.Scissors)
            {
                // cuts lizard and paper
                if (second == GameMove.Lizard || second == GameMove.Paper)
                {
                    return GameResult.FirstWin;
                }
                return GameResult.SecondWin;
            }

            if (first == GameMove.Lizard)
            {
                // eats paper, poisons spock
                if (second == GameMove.Spock || second == GameMove.Paper)
                {
                    return GameResult.FirstWin;
                }
                return GameResult.SecondWin;
            }

            if (first == GameMove.Spock)
            {
                // smashes scissors, vaporizes rock
                if (second == GameMove.Scissors || second == GameMove.Rock)
                {
                    return GameResult.FirstWin;
                }
                return GameResult.SecondWin;
            }

            throw new ApplicationException($"The game evaluation between {first} and {second} failed");
        }
    }

    public enum GameMove
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2,
        Lizard = 3,
        Spock = 4,
    }

    public enum GameResult
    {
        FirstWin,
        SecondWin,
        Tie
    }
}