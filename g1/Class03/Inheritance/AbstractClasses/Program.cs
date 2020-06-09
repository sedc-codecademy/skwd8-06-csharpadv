using AbstractClasses.Entities;
using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AbstractClasses
            // Compile time error - Cant create instance from abstract classes
            // User user = new User();
            //User student = new Student() { Name ="Vaska"};
            //User trainer = new Trainer();
            //User assistant = new Assistant();
            //Console.WriteLine(trainer.Age);
            //student.SayHi();
            #endregion
        }
    }
}
