using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(Rule).IsAssignableFrom(typeof(Rule)));
            Console.WriteLine(typeof(Rule).IsAssignableFrom(typeof(VelocityRule)));
            Console.WriteLine(typeof(Rule).IsAssignableFrom(typeof(QuorumRule)));

            var rules = new List<Rule>
            {
                new Rule { One = "еден", Two = "два", Three = "три"},
                new QuorumRule { One = "one", Two = "two", Three = "three", Four = 4},
                new VelocityRule { One = "אחת", Two = "שתים", Three = "שלש", Five = true},
            };
            Console.WriteLine(rules[0].GetType().Name);
            Console.WriteLine(rules[1].GetType().Name);
            Console.WriteLine(rules[2].GetType().Name);


            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new LowercaseContractResolver();
            settings.Formatting = Formatting.Indented;
            
            // No need for any extra converters, ugly json
            //settings.TypeNameHandling = TypeNameHandling.Auto;

            // extra scafolding needed, extensible and pretty json
            settings.Converters.Add(new RuleConverter());

            var result = JsonConvert.SerializeObject(rules, settings);
            Console.WriteLine(result);

            var roundtrip = JsonConvert.DeserializeObject<List<Rule>>(result, settings);
            Console.WriteLine(roundtrip[0].GetType().Name);
            Console.WriteLine(roundtrip[0].One);
            Console.WriteLine(roundtrip[1].GetType().Name);
            Console.WriteLine(roundtrip[1].One);
            Console.WriteLine(roundtrip[2].GetType().Name);
            Console.WriteLine(roundtrip[2].One);
        }
    }
}
