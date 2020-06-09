using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Entites
{
    // NOTE: abstract classes cannot be instantiated, that means we cannot create objects from them with the "new" keyword
    public abstract class Human : IJumpable
    {
        // NOTE2: constructors of abstract classes can be called only with the "base" keyword inside a class that inherits from Human
        public Human() { }

        public Human(string name, string lastName, int paramIn)
        {
            this.Name = name;
            this.LastName = lastName;
            this.IN = paramIn;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int IN { get; set; }

        public virtual void SayHi() // Just a normal virtual method.
        {
            Console.WriteLine("I am saying hiiiii!!!");
        }

        public abstract void Eat(string food); // Eat is an abstract member(in this case method), that means it can't have an implementation(body), NOTE: very similar to Interfaces

        public virtual void Jump() // This method is defined in the interface IJumpable, since Human inherits from IJumpable it must implement this method, another important thing here is that we defined this method as virtual, that's because we could want to change that method in another class that would inherit from Human to have a different behaviour than just Console.Write-ing FirstName LastName
        {
            Console.WriteLine($"{Name} {LastName} is jumping");
        }
    }
}
