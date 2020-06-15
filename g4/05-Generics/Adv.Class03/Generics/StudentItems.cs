using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class StudentItems<T>
    {
        public List<T> Items { get; set; }

        public string ClassName { get; set; }

        public string Lecturer { get; set; }

        public string Assistant { get; set; }

        public string PrintStudentItems()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class: {ClassName}");
            sb.AppendLine($"Lecturer: {Lecturer}");
            sb.AppendLine($"Assistant: {Assistant}");
            sb.AppendLine("Student items:");

            foreach (var item in Items)
            {
                sb.AppendLine($" - {item}");
            }
            return sb.ToString();
        }
    }
}
