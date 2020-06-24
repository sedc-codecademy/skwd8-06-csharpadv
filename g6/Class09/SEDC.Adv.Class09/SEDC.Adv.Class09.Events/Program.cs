using System;
using System.Diagnostics;
using System.Threading;

namespace SEDC.Adv.Class09.Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var blockBaseterStore = new BlockbasterStore(); // publisher
            var rentalStore = new RentalStore(); // publisher


            var emailService = new EmailService(); // subscriber
            var pushNotification = new PushNotifications(); // subscriber

            //rentalStore.NotifyUsers += emailService.SendMail;
            //rentalStore.NotifyUsers += pushNotification.SendPushNotifications;

            //rentalStore.NotifyUsersVideoEvent += emailService.SendMail;
            //rentalStore.NotifyUsersVideoEvent += pushNotification.SendPushNotifications;

            //blockBaseterStore.Notifications += emailService.SendMail;

            //blockBaseterStore.NewMovieRelase(new Movie() { Title = "Treto poluvreme" });
            //Thread.Sleep(4000);
            //rentalStore.AddNewMovie("SomeMovie");

            Console.ReadLine();
        }

        public static void TryingTimer()
        {
            // Example for using stopwatch
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            Console.WriteLine(stopwatch.Elapsed);
            Thread.Sleep(3000);
            Console.WriteLine(stopwatch.Elapsed);

            stopwatch.Stop();
        }
    }
}
