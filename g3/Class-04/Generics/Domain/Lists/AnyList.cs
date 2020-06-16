using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    // This class is the Generics Implementation for a collection that should work with any type
    // We can tell that this class is a generic class by seeing the <> characters after the class name
    // NOTE: The logic of this class is identical with both IntList and StringList, nothing is changed from a logical perspective

    // NOTE: the line: "public class AnyList<T>" is a definition of the class, so we only define the "T" type parameter, in the body we are using it.
    public class AnyList<T> // The "T" here is a parameter name for passing a TYPE, NOT VALUE, very similar to method parameteres, but instead of passing a value we pass a type like int, string, Employee and so on... 
    {
        // Here starts the body of the class, here we USE the already defined "T" parameter in the definition of the class
        private T[] _anys; // Instead of strictly and directly defining an array of int or string, we are defining an array of a type that we will pass later(it could be anything). For ex: if we pass int in "T" parameter it will be an array of int

        public AnyList()
        {
            _anys = new T[0];
        }

        public int Count { get; set; }

        public int Add(T item) // In here we are using the "T" type parameter(which we will pass what type it will be, when we create an object of this class)
        {
            // The logic of this class is not affected by the type, so it will work with any type.
            int newSize = _anys.Length + 1;

            Array.Resize(ref _anys, newSize);
            _anys[newSize - 1] = item;

            Count = newSize;
            return newSize;
        }

        public void Print()
        {
            foreach (T item in _anys)
            {
                Console.WriteLine(item);
            }
        }
    }
}
