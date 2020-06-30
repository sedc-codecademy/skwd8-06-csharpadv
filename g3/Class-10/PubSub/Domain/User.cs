using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Channel Channel { get; set; }

        public void ReceiveNotification(Channel channel, Video video, string message)
        {
            Console.WriteLine($"{video.Title} is uploaded by {channel.AlternativeName}. {message}");
        }
    }
}
