using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.Adv.Class09.Example
{
    public class MailService
    {
        public Dictionary<string, bool> usersSubscribed = new Dictionary<string, bool>
        {
            { "Trajan", true },
            { "Tosho", true  },
            { "Student1234", false },
            { "Trajan123123", true },
            { "Tosho3232", false  },
            { "Student112332", false },
            { "Trajan12321", true },
            { "Tosho323112", false  },
            { "Student1", false },
            { "Trajan32323", true },
            { "Tosho12123", true  },
            { "Student3331111", false },
        };

        public void SendMail(string str)
        {
            Console.WriteLine("Sending mail....");
            //Console.WriteLine($"There is new movie release {str}");
            foreach (var item in usersSubscribed)
            {
                if (item.Value)
                {
                    Console.WriteLine($"{item.Key} check it out. we have a new movie relase. {str} is out now.");
                }
                Thread.Sleep(2000);
            }

            Console.WriteLine("Finished sending mails");
        }
    }
}
