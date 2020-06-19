using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace OddsSods
{
    public class Person
    {
        public string Name { get; set; }
        public WithNull<bool> IsMarried { get; set; } = new WithNull<bool>();
        public WithNull<int> NumChildren { get; set; } = new WithNull<int>();

        private string GetMarriedString()
        {
            return IsMarried.HasValue ? IsMarried.Value.ToString() : "Unknown";
        }

        private string GetChildrenString()
        {
            return NumChildren.HasValue ? NumChildren.Value.ToString() : "Unknown";
        }


        public override string ToString()
        {
            return @$"Name: {Name}
IsMarried: {GetMarriedString()}
Children: {GetChildrenString()}";
        }
    }

    public class WithNull<T>
    {
        public T Value { get; private set; } = default(T);
        public bool HasValue { get; private set; } = false;

        public void SetValue(T value)
        {
            Value = value;
            HasValue = true;
        }

        public void SetToNull()
        {
            Value = default(T);
            HasValue = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var weko = new Person
            {
                Name = "Wekoslav Stefanovski",
            };
            weko.IsMarried.SetValue(true);
            weko.NumChildren.SetValue(1);

            Console.WriteLine(weko);

            var p2 = new Person
            {
                Name = "John Smith"
            };
            p2.IsMarried.SetToNull();
            p2.NumChildren.SetToNull();

            Console.WriteLine(p2);

            Console.WriteLine("-------------------------");

            List<int> nums = new List<int> { 1, 2, 3, 7, 6, 5, 8 };

            nums.Where(n => n % 2 == 1).Select(n => n * n).Print();
        }
    }
}
