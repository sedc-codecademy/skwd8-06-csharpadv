using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._01.AbstractClasses.Entities
{
	// This class implements 2 interfaces because the DevOps role requires both Developer and Operations features
	public class DevOps : Human, IDeveloper, IOperations
	{
		public bool AWSCertified { get; set; }
		public bool AzureCertified { get; set; }
		public DevOps(string fullName, int age, long phone, bool aws, bool azure)
			: base(fullName, age, phone)
		{
			AWSCertified = aws;
			AzureCertified = azure;
		}
		public bool CheckInfrastructure(int status)
		{
			List<int> okStatuses = new List<int>() { 200, 202, 204 };
			if (okStatuses.Contains(status)) return true;
			return false;
		}

		public void Code()
		{
			Console.WriteLine("Tak tak tak...");
			Console.WriteLine("*Opens StackExchange DevOps...");
			Console.WriteLine("Tak tak tak tak tak...");
		}

		public override string GetInfo()
		{
			string result = $"{FullName} ({Age}) - Has:";
			// Short for if/else or Ternary operator
			// If the side before the ? is true, then return the left side of the :
			// If the side beore the ? is false, then return the right side of the :
			result += AWSCertified ? " AWS Certificate" : "";
			result += AzureCertified ? " Azure Certificate" : "";
			// && AND -> Will check if at least one of them is FALSE, so the whole thing will be FALSE
			// || OR -> Will check if at least one is TRUE , so that the whole thing will be TRUE
			// true || false -> ""
			// false || true -> ""
			// true || true -> "" ( Has both certificates )
			// false || false -> "No certifiates yet"
			result += AWSCertified || AzureCertified ? "" : "No certificates yet";
			result += AWSCertified && AzureCertified ? "ALL THE CERTIFICATES" : "";
			return result;
		}
	}
}
