using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.SubscriptionModel.Models
{
    //This class Market will be the publisher
    //This class sends messages to all objects that subscriebe for getting such messages
    // In our case, its a Market and it sends promotion materials to anyone that subscried for those
    // Users can also unsubscribe so they wont get any promotions in the future
    // The email is required for marketing purposes for the Market
    // Reason is required for unsubscribing so that the market knows why people are unsubscribing

    public class Market
    {
        // Delegates are like a type of method that is allowed to be subscribed for some event 
        // All methods that has that signature can be allowed as subscribers on the event
        public delegate void PromotionSender(ProductType product);
        public delegate void InformationSender(string message);

        // These are the events and they keep track of who is subscribed to listen to some message when it is sent
        // The events use delegates to only accept methods of that delegate signature
        public event PromotionSender PromotionsHandler;
        public event InformationSender InformationHandler;


        // Standard properties 
        public string Name { get; set; }
        public ProductType CurrentPromotion { get; set; }
        public List<string> ZhalbiIPoplaki { get; set; }
        public List<string> Emails { get; set; }

        // Standard constructor that instantiates lists
        public Market()
        {
            ZhalbiIPoplaki = new List<string>();
            Emails = new List<string>();
        }

        //A method that does some work -> Sends promotions
        //Thread.Sleep(3000) simulates that something is being done for 3 seconds
        public void SendPromotions()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{Name} is sending promotion for {CurrentPromotion}");
            Console.WriteLine("....Sending");
            Thread.Sleep(3000);
            Send();
        }

        public void SendInfo()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{Name} is sending information for working hours");
            Console.WriteLine("....Sending");
            InformationHandler("Working hours!");
        }

        //The event is executed here, informing all the methods that subscriebed with some value (currentPromotion in our case)
        private void Send()
        {
            PromotionsHandler(CurrentPromotion);
        }

        // A method that accepts a subscriber method that must follow the PromotionSender delegate
        // It also takes the email of the subscriber
        // This subscriber expects to get a promotion each time the market sends one
        public void SubscribeForPromotions(PromotionSender subscriber, string email)
        {
            PromotionsHandler += subscriber;
            Emails.Add(email);
        }

        // A method that accepts a subscriber method that must follow the InformationSender delegate
        // It also takes the email of the subscriber
        // This subscriber expects to get only relevant information each time the market sends one
        // This is used just as an example that we can have multiple events with different delegates for different business logic
        public void UnSubscribeForPromotions(PromotionSender subscriber, string reason)
        {
            PromotionsHandler -= subscriber;
            ZhalbiIPoplaki.Add(reason);
        }


        public void SubscribeForInfo(InformationSender subscriber, string email)
        {
            InformationHandler += subscriber;
            Emails.Add(email);
        }
        public void UnSubscribeForInfo(InformationSender subscriber, string reason)
        {
            InformationHandler -= subscriber;
            ZhalbiIPoplaki.Add(reason);
        }


        public void DisplayZhalbiIPoplaki()
        {
            Console.WriteLine($"[{Name}] ZHALBI I POPLAKI:");
            ZhalbiIPoplaki.ForEach(Console.WriteLine);
        }
    }

    public enum ProductType
    {
        Food = 1,
        Drinks,
        Cosmetics,
        Electornics,
        Other
    }
}
