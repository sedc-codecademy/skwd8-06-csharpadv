using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            while (true)
            {
                var choice = ShowMenu();
                switch (choice)
                {
                    case MenuOption.Play:
                        ShowGame(game);
                        break;
                    case MenuOption.Stats:
                        ShowStats(game);
                        break;
                    case MenuOption.Exit:
                        Console.WriteLine("Bye");
                        return;
                }
            }
        }

        private static void ShowStats(Game game)
        {
            if (game.TotalGames == 0)
            {
                Console.WriteLine("No stats available, play some games first");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"You have played a total of {game.TotalGames} games");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Player Wins:   {game.FirstWins}");
            Console.WriteLine($"Computer Wins: {game.SecondWins}");
            Console.WriteLine($"Ties:          {game.Ties}");
            Console.WriteLine("----------------------------------------");
            var winpct = (double)game.FirstWins / game.WonGames * 100;
            var losepct = (double)game.SecondWins / game.WonGames * 100;
            Console.WriteLine($"Player Win  percentage: {winpct}");
            Console.WriteLine($"Player Lose percentage: {losepct}");
            Console.WriteLine("----------------------------------------");
            Console.ReadLine();
        }

        private static void ShowGame(Game game)
        {
            var playerMove = GetPlayerMove();
            var computerMove = GetComputerMove();

            Console.WriteLine($"Player   chose {playerMove}");
            Console.WriteLine($"Computer chose {computerMove}");

            var result = game.Evaluate(playerMove, computerMove);

            switch (result)
            {
                case GameResult.FirstWin:
                    Console.WriteLine("The Player WINS!! Great Job!");
                    break;
                case GameResult.SecondWin:
                    Console.WriteLine("The Player brings shame to his family.");
                    break;
                case GameResult.Tie:
                    Console.WriteLine("It's a tie");
                    break;
            }

            game.RegisterResult(result);
            Console.ReadLine();
        }

        private static GameMove GetComputerMove()
        {
            Random r = new Random();
            return (GameMove)r.Next(5);
        }

        private static GameMove GetPlayerMove()
        {
            Console.Clear();
            Console.WriteLine("Choose a move");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
            Console.WriteLine("4) Lizard");
            Console.WriteLine("5) Spock");
            Console.Write("Enter 1 through 5: ");
            var move = Console.ReadLine();
            if (move == "1")
            {
                return GameMove.Rock;
            }
            if (move == "2")
            {
                return GameMove.Paper;
            }
            if (move == "3")
            {
                return GameMove.Scissors;
            }
            if (move == "4")
            {
                return GameMove.Lizard;
            }
            if (move == "5")
            {
                return GameMove.Spock;
            }
            return GetPlayerMove();
        }

        private static MenuOption ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Play");
            Console.WriteLine("2) Stats");
            Console.WriteLine("3) Exit");
            Console.Write("Enter 1, 2 or 3: ");
            var option = Console.ReadLine();
            if (option == "1")
            {
                return MenuOption.Play;
            }
            if (option == "2")
            {
                return MenuOption.Stats;
            }
            if (option == "3")
            {
                return MenuOption.Exit;
            }
            return ShowMenu();
        }
    }
}
