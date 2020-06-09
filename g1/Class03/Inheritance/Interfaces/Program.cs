using Interfaces.Entities;
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Student user = new Student() { Name = "Ivan"};
            user.SayHi();
        }
    }
}
