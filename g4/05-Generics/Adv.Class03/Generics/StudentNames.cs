using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class StudentNames
    {
        public List<string> Names { get; set; }

        public string ClassName { get; set; }

        public string Lecturer { get; set; }

        public string Assistant { get; set; }

        public string PrintStudents()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class: {ClassName}");
            sb.AppendLine($"Lecturer: {Lecturer}");
            sb.AppendLine($"Assistant: {Assistant}");
            sb.AppendLine("Students:");

            foreach (var name in Names)
            {
                sb.AppendLine($" - {name}");
            }
            return sb.ToString();
        }
    }
}
