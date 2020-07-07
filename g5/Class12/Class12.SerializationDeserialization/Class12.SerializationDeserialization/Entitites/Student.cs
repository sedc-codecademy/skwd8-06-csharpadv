using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Class12.SerializationDeserialization.Entitites
{
    //public class Student
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int Age { get; set; }
    //    public bool IsPartTime { get; set; }
    //}

    // Example with Newtonsoft Seriazlier
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }

        public Student()
        {

        }

        [OnSerializing]
        internal void OnSerializeMethod(StreamingContext context)
        {
            Console.WriteLine("We are seriazling a student!");
        }

        [OnDeserializing]
        internal void OnDeserializeMethod(StreamingContext context)
        {
            Console.WriteLine("We are deserializing a student!");
        }
    }
}
