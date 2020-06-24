using System;

namespace Class08.DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var video = new Video() { Title = "Odmor2019", Duration = 180, Type = VideoType.AVI };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var textservice = new TextService(); //subscriber

            //PUBLISH <-> SUBSCRIBE
            // Before we call the Encode method, we need to do the subscription..How we do that?
            // We start with the publisher, in our case 'encoder', if we press dot(.) 
            // we will see the event we defined in VideoEncoder class called VideoEncoded
            //  We use '+=' to register an event for that handler. Who is the handler?
            // Hanlder in our case is MailService class,
            // so we take mailNotificaition instance and call the Send method.
            // Also note that when we call the Send method we dont have the brackerts () which
            // we usually have when we are calling a method. We are just using tbe name of the method
            // Thats because it is a reference, a pointer 
            // to that method. VideoEncoded event is just a list of pointers to methods.
            // When the encoder wants to publish that event VideoEncoded, it looks in that list 
            // in VideoEncoder class, and if it is not empty that means someone

            videoEncoder.VideoEncoded += mailService.Send;
            videoEncoder.VideoEncoded += textservice.SendSms;

            videoEncoder.VideoEncoded -= mailService.Send;


            videoEncoder.Encode(video);
        }
    }
}
