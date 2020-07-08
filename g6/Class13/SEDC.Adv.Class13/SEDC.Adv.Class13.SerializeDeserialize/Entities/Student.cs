using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SEDC.Adv.Class13.SerializeDeserialize.Entities
{
    //public class Student
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int Age { get; set; }
    //    public bool IsPartTime { get; set; }
    //}

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }

        public Student()
        {

        }

        // Method called on serializing
        [OnSerializing]
        public void OnSerializeMethod(StreamingContext context)
        {
            Console.WriteLine("WE ARE SERIALIZING A STUDENT");
        }

        // Method called on deserializing
        [OnDeserializing]
        public void OnDeserializeMethod(StreamingContext context)
        {
            Console.WriteLine("WE ARE DESERIALIZING A STUDENT");
        }
    }
}
