using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class PlatformService
    {
        public PlatformService(Platform platform)
        {
            _platform = platform;
        }

        private Platform _platform { get; set; }

        public User GetUserByUserName(string userName)
        {
            return _platform.Users.FirstOrDefault(user => user.UserName == userName);
        }

        public Channel GetChannelByUserName(string userName)
        {
            return _platform.Users.FirstOrDefault(user => user.UserName == userName).Channel;
        }

        public Video CreateVideo(string title, string videoData)
        {
            return new Video { Id = Guid.NewGuid(), Title = title, VideoData = videoData };
        }
    }
}
