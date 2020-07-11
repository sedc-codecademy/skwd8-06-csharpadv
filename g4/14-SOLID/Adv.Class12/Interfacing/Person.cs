using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Interfacing
{
    public class Person: IComparable, IComparable<Person>, IEquatable<Person>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }

        public int CompareTo([AllowNull] object obj)
        {
            Console.WriteLine("Called compare-to");
            if (!(obj is Person))
            {
                throw new Exception("Apples and oranges");
            }
            return CompareTo(obj as Person);
        }

        public int CompareTo([AllowNull] Person other)
        {
            Console.WriteLine("Called compare-to-person");
            var otherAge = other?.Age ?? 0;
            return Age - otherAge;
        }

        public bool Equals([AllowNull] Person other)
        {
            if (other == null)
            {
                return false;
            }
            if (Age != other.Age)
            {
                return false;
            }
            if (FirstName != other.FirstName)
            {
                return false;
            }
            if (LastName != other.LastName)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age})";
        }
    }
}
