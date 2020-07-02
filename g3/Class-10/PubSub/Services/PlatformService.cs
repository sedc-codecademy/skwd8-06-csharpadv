using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class PlatformService
    {
        public PlatformService(Platform platform, Logger logger)
        {
            _platform = platform;
            _logger = logger;
        }

        private Platform _platform { get; set; }
        private Logger _logger;

        public User GetUserByUserName(string userName)
        {
            return _platform.Users.FirstOrDefault(user => user.UserName == userName);
        }

        public Channel GetChannelByUserName(string userName)
        {
            try
            {
                return _platform.Users.FirstOrDefault(user => user.UserName == userName).Channel;
            }
            catch (NullReferenceException ex)
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(nameof(userName), userName);

                _logger.LogError(ex.Message, ex.StackTrace, parameters); // Logs an error when an exception will happend.
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex);
                return null;
            }
        }

        public Video CreateVideo(string title, string videoData)
        {
            return new Video { Id = Guid.NewGuid(), Title = title, VideoData = videoData };
        }
    }
}
