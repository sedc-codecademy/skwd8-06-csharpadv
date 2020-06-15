using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class StudentGrades
    {
        public List<int> Grades { get; set; }

        public string ClassName { get; set; }

        public string Lecturer { get; set; }

        public string Assistant { get; set; }

        public string PrintStudentGrades()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class: {ClassName}");
            sb.AppendLine($"Lecturer: {Lecturer}");
            sb.AppendLine($"Assistant: {Assistant}");
            sb.AppendLine("Students:");

            foreach (var grade in Grades)
            {
                sb.AppendLine($" - {grade}");
            }
            return sb.ToString();
        }
    }
}
