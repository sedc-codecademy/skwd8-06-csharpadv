using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace SEDC.ClassDispose.Nullables
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Score { get; set; }
        public bool IsEmployeed { get; set; }
        public bool? HasPet { get; set; }
        public DateTime? StartEmploymentDate { get; set; }
        public DateTime? EndEmploymentDate { get; set; }

    }

    //Default DateTime value -> 01/01/0001 00:00:00

    class Program
    {

        public static void ReadFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                int? score1 = Convert.ToInt32(sr.ReadLine());
                int? score2 = Convert.ToInt32(sr.ReadLine());
                //int? score3 = Convert.ToInt32(sr.ReadLine());
                int? score4 = Convert.ToInt32(sr.ReadLine());

                List<int?> scores = new List<int?> { score1, score2, null, score4 };

                foreach (var score in scores)
                {
                    if (score.HasValue)
                    {
                        Console.WriteLine("The score is: " + score.Value);
                    }
                    else
                    {
                        Console.WriteLine("The score is NULL!");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.Id);
            Console.WriteLine(p.Score);

            //p.Id = null; // Cannot assign a null value to an int type
            p.Score = null; // This is allowed if Score is nullable type

            p.HasPet = null;
            //p.IsEmployeed = null; // Cannot assign a null value to a bool type
            Console.WriteLine(p.IsEmployeed);
            Console.WriteLine(p.Name);

            //Can cast from nullable int? to int by casting the value
            p.Score = 10;
            int score = (int)p.Score;
            Console.WriteLine("Casting nullable int to int value: " + score);


            if (p.Score.HasValue)
            {
                int score1 = p.Score.Value;
                Console.WriteLine(score1);
            }

            Console.Clear();
            Thread.Sleep(2000);

            #region Example 1
            string filePath = @"..\..\..\Text\text.txt";
            ReadFromFile(filePath);

            #endregion


            Console.ReadLine();
        }
    }
}
