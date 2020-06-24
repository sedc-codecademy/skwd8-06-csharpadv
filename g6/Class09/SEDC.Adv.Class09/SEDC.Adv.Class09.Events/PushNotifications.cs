using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class09.Events
{
    public class PushNotifications
    {
        public void SendPushNotifications(object source, EventArgs args)
        {
            Console.WriteLine("Sending push notifications.....");
        }

        public void SendPushNotifications(object source, MovieEventArgs args)
        {
            Console.WriteLine("Sending push notifications.....");
            Console.WriteLine($"Push notification: {args.MovieTitle} is available at the store.");
        }

        public void SendPushNotifications(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending push notifications.....");
            Console.WriteLine("VideoEventArgs");
            Console.WriteLine($"Push notification: {args.Movie.Title} is available at the store.");
        }
    }
}
