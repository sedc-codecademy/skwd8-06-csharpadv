using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Entites
{
    public class QATester : Human, ISwimable, IFlyable // We can inherit only from one class(no matter if it's abstsract or normal), but from multiple interfaces
    {
        public QATester() { }

        public QATester(string name, string lastName, int paramIn, int bugsCatched) : base(name, lastName, paramIn) // NOTE: the constructor of Human is called only with "base" keywork as in here
        {
            BugsCatched = bugsCatched;
        }

        public int BugsCatched { get; set; }

        public override void Eat(string food) // In order to use Eat method(since it's abstract member of Human class) we must use override to add an implementation
        {
            Console.WriteLine($"Just eating, without any nerd stuff: {food}");
        }

        public void Fly() // We are forced to implement this method because of IFlyable interface
        {
            Console.WriteLine($"{Name} is flying and bached alot of bugs: {BugsCatched}");
        }

        public override void Jump() // Jump method is inherited from Human class which is implemented because of IJumpable, overriding is optional
        {
            Console.WriteLine($"{Name} {LastName} {IN} is jumping right now, and shaking the groud!");
        }

        public void Swim(string helpers) // We are forced to implement this method because of ISwimable interface
        {
            Console.WriteLine($"Swimming in the rain with or without {helpers}");
        }
    }
}
