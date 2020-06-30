using Domain;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PubSubApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initialize platform with data
            Platform youtube = new Platform { Id = Guid.NewGuid(), Name = "YouTube", Users = new List<User>() };
            InitializeData(youtube);

            //// Another way that we can use InitializeData
            //Platform youtube = InitializeData(new Platform { Id = Guid.NewGuid(), Name = "YouTube", Users = new List<User>() });
            #endregion

            while (true)
            {
                StartUI(youtube);
            }
        }

        static void StartUI(Platform platform)
        {
            // Initialize Platform service to use "youtube" platform (NOTE: This service can only work with youtube platform)
            PlatformService platformService = new PlatformService(platform);

            Console.WriteLine("Enter a username");
            string usernameInput = Console.ReadLine();
            // Can add a login validation here, to check for password as well


            Channel channel = platformService.GetChannelByUserName(usernameInput);

            Console.WriteLine("Choose:");
            Console.WriteLine("1. Upload video");
            Console.WriteLine("2. Subscribe to channel");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Console.WriteLine("Enter a title for the video");
                string videoTitleInput = Console.ReadLine();
                Video video = platformService.CreateVideo(videoTitleInput, Guid.NewGuid().ToString());

                channel.UploadVideo(video);
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("Enter a channel's username to subscribe");
                string channelUserNameInput = Console.ReadLine();

                User user = platformService.GetUserByUserName(usernameInput);
                Channel channelToSubscribe = platformService.GetChannelByUserName(channelUserNameInput);
                channelToSubscribe.Subscribe(user);
            }
        }

        static Platform InitializeData(Platform platform)
        {
            Video ivanaVideo1 = new Video { Id = Guid.NewGuid(), Title = "My First Video", VideoData = Guid.NewGuid().ToString() };
            Video ivanaVideo2 = new Video { Id = Guid.NewGuid(), Title = "My Second Video", VideoData = Guid.NewGuid().ToString() };
            Channel ivanaChannel = new Channel { Id = Guid.NewGuid(), AlternativeName = "Ivana the best", Videos = new List<Video> { ivanaVideo1, ivanaVideo2 } };
            User ivana = new User { Id = Guid.NewGuid(), UserName = "ivana.stefanovska", Password = "123456", Channel = ivanaChannel };

            Video ivicaVideo1 = new Video { Id = Guid.NewGuid(), Title = "My First Video of Ivica", VideoData = Guid.NewGuid().ToString() };
            Channel ivicaChannel = new Channel { Id = Guid.NewGuid(), AlternativeName = "Ivica the best", Videos = new List<Video> { ivicaVideo1 } };
            User ivica = new User { Id = Guid.NewGuid(), UserName = "ivica.janevski", Password = "654321", Channel = ivicaChannel };

            Video viktorijaVideo1 = new Video { Id = Guid.NewGuid(), Title = "[Viktorija]My First Video", VideoData = Guid.NewGuid().ToString() };
            Video viktorijaVideo2 = new Video { Id = Guid.NewGuid(), Title = "[Viktorija]My Second Video", VideoData = Guid.NewGuid().ToString() };
            Channel viktorijaChannel = new Channel { Id = Guid.NewGuid(), AlternativeName = "Viktorija the best", Videos = new List<Video> { viktorijaVideo1, viktorijaVideo2 } };
            User viktorija = new User { Id = Guid.NewGuid(), UserName = "viktorija.gjuovska", Password = "123456", Channel = viktorijaChannel };



            ivanaChannel.Subscribe(ivica);
            ivanaChannel.Subscribe(viktorija);
            viktorijaChannel.Subscribe(ivana);
            ivicaChannel.Subscribe(viktorija);

            // This line will not working if Subscribers field in Channel class has an "event" keywork
            //viktorijaChannel.Subscribers(viktorijaChannel, viktorijaVideo1, "message from outside");

            platform.Users.Add(ivana);
            platform.Users.Add(ivica);
            platform.Users.Add(viktorija);

            return platform;
        }
    }
}
