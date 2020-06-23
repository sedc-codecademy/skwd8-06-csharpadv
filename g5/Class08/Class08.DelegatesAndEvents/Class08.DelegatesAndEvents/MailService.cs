using System;
using System.Collections.Generic;
using System.Text;

namespace Class08.DelegatesAndEvents
{
    /// <summary>
    /// SUBSCRIBER calss that is responsible for sending an email
    /// </summary>
    public class MailService
    {
        public string ServerPath { get; set; }

        /// <summary>
        ///  Here we are defining a method that has the same signature as 
        ///  our delegate. Remember ? Needs to be void and to take
        ///  two parameters, the sender and EventArgs argument
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void Send(object sender, EventArgs e)
        {
            Console.WriteLine("Sending email..");
        }


    }
}
