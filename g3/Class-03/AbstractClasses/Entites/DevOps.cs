using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Entites
{
    // NOTE: see QATester class for comments, same principles are in here aswell
    public class DevOps : Human
    {
        public DevOps() { }
        public DevOps(string name, string lastName, int paramIn) : base(name, lastName, paramIn) { }

        public void CheckInfrastructure(string data)
        {
            Console.WriteLine($"Infrastructure good: {data}");
        }

        public override void Eat(string food) // In order to use Eat method(since it's abstract member of Human class) we must use override to add an implementation
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Eating {i + 1} time. {food}");
            }
        }
    }
}
