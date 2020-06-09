using SEDC.Adv.Class01.AbstractInterface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class01.AbstractInterface.Entities
{
    public class Operations : Human, IOperations
    {
        public List<string> Projects { get; set; } = new List<string>();

        public Operations(string fullName, int age, long phone, List<string> projects)
            : base(fullName, age, phone)
        {
            Projects = projects;
        }
        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - Currently working on {Projects.Count} projects!";
        }

        public bool CheckInfrastructure(int status)
        {
            if (status.ToString().StartsWith("4"))
            {
                return false;
            }
            return true;
        }
    }
}
