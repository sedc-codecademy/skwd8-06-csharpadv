using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace ConsoleApp1
{

    public class Rule
    {
        static Rule()
        {
            RuleSetup.RegisterSubtype<Rule>("generic");
        }

        public string One { get; set; }
        public string Two { get; set; }
        public string Three { get; set; }
    }

    public class QuorumRule : Rule
    {
        static QuorumRule()
        {
            RuleSetup.RegisterSubtype<QuorumRule>("quorum");
        }
        public int Four { get; set; }
    }

    public class VelocityRule : Rule
    {
        static VelocityRule()
        {
            RuleSetup.RegisterSubtype<VelocityRule>("velocity");
        }
        public bool Five { get; set; }
    }

}
