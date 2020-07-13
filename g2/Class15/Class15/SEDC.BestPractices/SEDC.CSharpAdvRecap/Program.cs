using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdvRecap
{
    public class User
    {
        public delegate void NotifySubscribers(string message, string name);

        public event NotifySubscribers NotifySubsribersHandler;

        public string FullName { get; set; }
        public string ChannelLink { get; set; }
        public List<string> MyVideos { get; set; }

        public User()
        {
            MyVideos = new List<string>();
        }

        public void PublishNewVideo(DateTime time)
        {
            Console.WriteLine($"A new video is published at {time.ToLocalTime().AddMinutes(-5)} by {FullName}!");
            Console.WriteLine("-----------------------------------------------");
            NotifySubsribersHandler($"Check the new video by {FullName}", FullName);
        }

        public void SubscribeForVideo(NotifySubscribers subscriber)
        {
            NotifySubsribersHandler += subscriber;
        }
        public void UnSubscribeForVideo(NotifySubscribers subscriber)
        {
            NotifySubsribersHandler -= subscriber;
        }
    }


    public class Subcriber
    {
        public string Username { get; set; }
        public List<string> SubscribedChannels { get; set; }
        public List<string> LikedVideos { get; set; }


        public void VideoAnnouncement(string message, string name)
        {
            Console.WriteLine(message);
            Console.WriteLine($"Dear Mr/Ms: {Username}, the {name} youtuber has published new video right now! Check it out!");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            User martin = new User() { FullName = "Martinator", ChannelLink = "https://www.youtube.com/martinator", MyVideos = new List<string>() };

            Subcriber dejan = new Subcriber() { Username = "dejan_deki", LikedVideos = new List<string>(), SubscribedChannels = new List<string>() };
            Subcriber ivo = new Subcriber() { Username = "ivo_ivo", LikedVideos = new List<string>(), SubscribedChannels = new List<string>() };
            Subcriber dragan = new Subcriber() { Username = "drakso", LikedVideos = new List<string>(), SubscribedChannels = new List<string>() };

            List<Subcriber> subscribers = new List<Subcriber> { dejan, ivo, dragan };

            foreach (var sub in subscribers)
            {
                //Does the same thing. It subscribes new subscribers to the publisher!
                //martin.NotifySubsribersHandler += sub.VideoAnnouncement;
                martin.SubscribeForVideo(sub.VideoAnnouncement);
            }


            martin.PublishNewVideo(DateTime.Now);

            //Does the same thing. It unsubscribes the already subscribed user from the channel!
            //martin.NotifySubsribersHandler -= dejan.VideoAnnouncement;
            martin.UnSubscribeForVideo(dejan.VideoAnnouncement);


            Console.ReadLine();
        }
    }
}
