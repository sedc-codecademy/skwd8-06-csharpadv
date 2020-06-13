using SEDC.AbstractClassesInterfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AbstractClassesInterfaces.Models
{
    public class DevOps : Human, IDeveloper, IOperations
    {
        public bool AWSCertificated { get; set; }
        public bool AzureCertificated { get; set; }

        public DevOps(string fullName, int age, long phone, bool awsCer, bool azureCer)
            :base(fullName, age, phone)
        {
            this.AWSCertificated = awsCer;
            this.AzureCertificated = azureCer;
        }

        public void Code()
        {
            Console.WriteLine("Tak, tak, tak..... I am coding!");
            Console.WriteLine("Open StackOverflow..... I am stuck!");
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
            string result = $"{FullName} - Has: ";
            result += AWSCertificated ? "AWS Certificate" : "";
            result += AzureCertificated ? "Azure Certificate" : "";
            result += AWSCertificated || AzureCertificated ? "" : "No certificates yet!";
            return result;
        }
    }
}
