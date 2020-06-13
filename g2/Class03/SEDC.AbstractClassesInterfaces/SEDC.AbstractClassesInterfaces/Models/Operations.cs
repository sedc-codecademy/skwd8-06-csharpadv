using SEDC.AbstractClassesInterfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AbstractClassesInterfaces.Models
{
    public class Operations : Human, IOperations
    {
        public List<string> Projects { get; set; } = new List<string>();

        public Operations(string fullName, int age, long phone, List<string> projects)
            :base(fullName, age, phone)
        {
            this.Projects = projects;
        }

        public bool CheckInfrastructure(int status)
        {
            if (status.ToString().StartsWith("4"))
            {
                return false;
            }
            return true;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - Currently working on {Projects.Count} projects!";
        }
    }
}
