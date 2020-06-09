using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Entites
{
    // NOTE: see QATester class for comments, same principles are in here aswell
    public class Developer : Human, ISwimable
    {
        public Developer() { }

        public Developer(string name, string lastName, int paramIn, List<string> programmingLanguages, int yearsOfExp) : base(name, lastName, paramIn)
        {
            this.ProgrammingLanguages = programmingLanguages;
            YearsOfExp = yearsOfExp;
        }
        public List<string> ProgrammingLanguages { get; set; }
        public int YearsOfExp { get; set; }

        public override void Eat(string food) // In order to use Eat method(since it's abstract member of Human class) we must use override to add an implementation
        {
            bool hungry = true;

            while (hungry)
            {
                int ran = new Random().Next(0, 1);
                if (ran == 0) hungry = false;
                else hungry = true;

                Console.WriteLine($"Eating {food}");
            }
        }

        public override void SayHi()
        {
            //base.SayHi(); // since we are overriding SayHi, we could also call the Human.SayHi(), before we execeute any code the Developer.SayHi()
            Console.WriteLine($"Hi from developer! {this.Name}");
        }

        public void Swim(string helpers)
        {
            Console.WriteLine($"{Name} swimming with or without {helpers}");
        }
    }
}
