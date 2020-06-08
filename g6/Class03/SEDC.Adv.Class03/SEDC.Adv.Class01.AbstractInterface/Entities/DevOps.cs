using SEDC.Adv.Class01.AbstractInterface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class01.AbstractInterface.Entities
{
    public class DevOps : Human, IDeveloper, IOperations
    {
        public bool AWSCertified { get; set; }
        public bool AzureCertified { get; set; }

        public bool CheckInfrastructure(int status)
        {
            List<int> okStatuses = new List<int>() { 200, 202, 204 };
            // return okStatuses.Contains(status);
            if (okStatuses.Contains(status))
            {
                return true;
            }
            return false;
        }

        public DevOps(string fullName, int age, long phone, bool awsCert, bool azureCert)
            : base(fullName, age, phone)
        {
            AWSCertified = awsCert;
            AzureCertified = azureCert;
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("Opens Stack Overflow DevOps...");
            Console.WriteLine("tak tak tak tak tak tak...");
        }

        public override string GetInfo()
        {
            string result = $"{FullName} ({Age}) - Has: ";
            result += AWSCertified ? "AWS Certificate" : "";
            result += AzureCertified ? " Azure Certificate" : "";
            result += AWSCertified || AzureCertified ? "" : "No certificates yet";
            return result;
            // result = result + "something";
        }
    }
}
