using System;
using System.Collections.Generic;
using System.Text;

namespace Class08.DelegatesAndEvents
{
    public class TextService
    {
        public void SendSms(object sender, EventArgs e)
        {
            Console.WriteLine("Sending sms message to the user..");
        }
    }
}
