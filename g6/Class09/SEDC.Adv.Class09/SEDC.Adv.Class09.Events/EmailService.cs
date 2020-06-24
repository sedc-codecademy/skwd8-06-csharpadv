using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class09.Events
{
    public class EmailService
    {
        public void SendMail(object source, EventArgs args)
        {
            Console.WriteLine("Sending email ..... ");
        }

        public void SendMail(object source, MovieEventArgs args)
        {
            Console.WriteLine("Sending email ..... ");
            Console.WriteLine($"The movie {args.MovieTitle} is available at the store");
        }

        public void SendMail(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending email ..... ");
            Console.WriteLine("VideoEventArgs");
            Console.WriteLine($"The movie {args.Movie.Title} is available at the store");
        }
    }
}
