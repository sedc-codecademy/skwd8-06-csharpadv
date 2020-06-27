using System;

namespace SEDC.Adv.Class09.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoStore = new VideoStore(); // publisher - raises the event
            var mailService = new MailService(); // subscriber - listen to events

            videoStore.NotifyUsers += mailService.SendMail;

            videoStore.AddNewMovie("Terminator :)");

            Console.ReadLine();
        }
    }
}
