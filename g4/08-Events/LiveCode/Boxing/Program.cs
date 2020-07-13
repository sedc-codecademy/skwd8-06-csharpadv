using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var champion = JsonConvert.DeserializeObject<Boxer>(File.ReadAllText("champion.json"));
            var challenger = JsonConvert.DeserializeObject<Boxer>(File.ReadAllText("challenger.json")); 
            BoxingMatch bm = new BoxingMatch(champion, challenger, 500);
            bm.AttachDisplay(new ConsoleDisplay());
            bm.RunGame();

            Console.ReadKey();
        }
    }
}
