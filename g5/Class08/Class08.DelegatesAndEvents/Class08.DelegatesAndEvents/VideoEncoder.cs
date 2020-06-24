using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Class08.DelegatesAndEvents
{
    /// <summary>
    ///  PUBLISHER or Event sender class. VideoEncoder class with the new solution, doesn't know anything 
    ///  about MailService. If we want to extend our application and for example add functionallity for
    ///  sending a SMS message. We can just create a new class and subscribe to that VideoEncoded event.
    ///  That way, VideoEncoder doesn't need to be recompiled, because we are not changing the class
    ///  but just extending it with creating a new class.
    public class VideoEncoder
    {
        /// <summary>
        ///  An event is a mechanism for communication between objects. An even might be a button click,
        ///  menu selection and so forth. Something happens and you must respond to it. Other classes
        ///  will be interested in responding to some event. How they respond is not of interest to the
        ///  class raising the event. The button says "I was clicked" and the responding classes react 
        ///  appropriately. But, how does VideoEncoder notify his subscribers and how it knows which methods to be called?
        ///  We need agreement or contract between publisher and subscribers. Here comes the magic of delegates :) 
        ///  Delegate is contract betwwen Publisher and Subscribers and determines the signature of the event handler
        ///  in Subscriber. And thats the purpose of our delegate below,  when the video is encoded and we want to notify
        ///  subscribers you should have a method that is void and with the parameters that our delegate below has.
        /// </summary>
        // 1. Kreirame delegat
        // 2. Kreirame event od tip na ovoj delegat
        // 3. Kreirame metod sto go trigerira toj event

        public delegate void VideoEncodedEventHandler(object sender, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public VideoEncoder()
        {
            //_mailService = new MailService();
        }

        /// <summary>
        ///  This method is responsible for raising an event. By convetion int .Net framework 
        ///  the event publisher methods are protected, virtual and void. It is recommended also
        ///  to start with 'On' and then the name of the event (OnVideoEncoded).
        ///  With first line of code we check are there any subscribers to this event.
        /// </summar
        public void OnVideoEncoded()
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
        public void Encode(Video video)
        {
            // Video encoding logic

            Console.WriteLine($"Encoding {video.Title}...");
            Thread.Sleep(3000);

            // we just call a method called OnVideoEncoded. His purpose is
            // to notify the subscribers that event was raised.
            OnVideoEncoded();
           
        }
    }
}
