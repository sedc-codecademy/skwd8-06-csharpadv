using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Domain
{
    public delegate void Subscribers(Channel channel, Video video, string message);

    public class Channel
    {
        public Guid Id { get; set; }
        public string AlternativeName { get; set; }
        public List<Video> Videos { get; set; }
        //public List<User> Subscribers { get; set; } // The non-delegate way. This way whole users information will be kept, but we only need the ReceiveNotifications methods
        //public Subscribers Subscribers; // same as below, but without "event" keyword, which means even outside of this class Subscribers can be called
        public event Subscribers Subscribers; // This way only the methods of ReceiveNotifications will be kept in Subscribers field, not whole users

        public void Subscribe(User user)
        {
            //Subscribers.Add(user); // The non-delegate way
            Subscribers += user.ReceiveNotification;
        }

        public void UploadVideo(Video video)
        {
            Videos.Add(video);

            SendNotification(video, "simple message");
        }

        public void SendNotification(Video video, string message)
        {
            // The non-delegate way
            //foreach (User user in Subscribers)
            //{
            //    user.ReceiveNotification(this, video, "simple message");
            //}

            Subscribers(this, video, message);
        }

        public void SendNotification(string message)
        {
            // The non-delegate way
            //foreach (User user in Subscribers)
            //{
            //    user.ReceiveNotification(this, null, "simple message");
            //}

            Subscribers(this, null, "even simpler message");
        }
    }
}
