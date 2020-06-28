using System;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var champion = new Boxer("Tyson Fury", 124, 1000)
            {
                Strength = new Dictionary<PunchType, int>
                {
                    { PunchType.Cross, 30 },
                    { PunchType.Jab, 20 },
                    { PunchType.Uppercut, 35 },
                    { PunchType.Hook, 30 }
                },
                Agility = new Dictionary<PunchType, int>
                {
                    { PunchType.Cross, 15 },
                    { PunchType.Jab, 15 },
                    { PunchType.Uppercut, 30 },
                    { PunchType.Hook, 15 }
                }
            };
            var challenger = new Boxer("Andy Ruiz Jr.", 128, 1500)
            {
                Strength = new Dictionary<PunchType, int>
                {
                    { PunchType.Cross, 26 },
                    { PunchType.Jab, 16 },
                    { PunchType.Uppercut, 21 },
                    { PunchType.Hook, 16 }
                },
                Agility = new Dictionary<PunchType, int>
                {
                    { PunchType.Cross, 26 },
                    { PunchType.Jab, 26 },
                    { PunchType.Uppercut, 16 },
                    { PunchType.Hook, 21 }
                }
            };
            BoxingMatch bm = new BoxingMatch(champion, challenger, 500);
            bm.AttachDisplay(new ConsoleDisplay());
            bm.RunGame();
        }
    }
}
