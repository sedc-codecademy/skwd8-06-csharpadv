using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Vehicle
    {
        public string Registration { get; set; }

        public override string ToString()
        {
            return $"Vehicle {Registration}"; 
        }
    }

    public class StudentVehicles
    {
        public List<Vehicle> Vehicles { get; set; }

        public string ClassName { get; set; }

        public string Lecturer { get; set; }

        public string Assistant { get; set; }

        public string PrintStudents()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class: {ClassName}");
            sb.AppendLine($"Lecturer: {Lecturer}");
            sb.AppendLine($"Assistant: {Assistant}");
            sb.AppendLine("Student vehicles:");

            foreach (var vehicle in Vehicles)
            {
                sb.AppendLine($" - {vehicle.Registration}");
            }
            return sb.ToString();
        }
    }
}
