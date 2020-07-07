using System;
using System.Collections.Generic;
using System.Text;

namespace Class12.XmlSerialization_plus_material_
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }
        public List<string> Skills { get; set; }

        public override string ToString()
        {
            return string.Format($"ID: {ID}, Name:{Name}, Gender: {Gender}, " +
                $"WorkPhone: {WorkPhone}, Address: {Address}, Skills: {Skills}");
        }
    }
}
