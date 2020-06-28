using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Boxing
{
    public class ConsoleDisplay : IDisplay
    {
        public void InitateRound(int index)
        {
            Console.WriteLine($"Round {index} is starting");
        }

        public void ShowAttack(Boxer attacker, PunchType punchType, int strength)
        {
            Console.WriteLine($"{attacker.Name} throws a powerfull {punchType} with {strength} strength");
        }

        public void ShowDefence(Boxer attacker, Boxer defender, bool isHit, int damage)
        {
            if (isHit)
            {
                Console.WriteLine($"{attacker.Name} hits {defender.Name} for {damage} damage, leaving him with {(defender.Hitpoints > 0 ? defender.Hitpoints.ToString() : "no")} hitpoints");
            }
            else
            {
                Console.WriteLine($"{attacker.Name} shot goes wide as {defender.Name} ducks");
            }
        }

        public void ShowKnockout(Boxer hitter, Boxer sleeper)
        {
            Console.WriteLine($"Such a powerfull punch by {hitter.Name}");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"...{i+1}");
            }
            Console.WriteLine($"It's over, {sleeper.Name} can't get up");
        }

        public void ShowResults(Boxer champion, Boxer challenger)
        {
            Console.WriteLine("---------------");
            if (champion.Hitpoints == challenger.Hitpoints)
            {
                Console.WriteLine("And after all the punches thrown, the fight ends in a tie");
            } else if (challenger.Hitpoints > champion.Hitpoints)
            {
                Console.WriteLine($"And the upset victory goes to {challenger.Name}, leaving {champion.Name} eager for a rematch");
            } else
            {
                Console.WriteLine($"No surprises there, {challenger.Name} is down for the count, leaving {champion.Name} as the undisputed champion");
            }
        }
    }
}
