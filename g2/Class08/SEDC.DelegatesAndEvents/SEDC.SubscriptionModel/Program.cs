using SEDC.SubscriptionModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace SEDC.SubscriptionModel
{
    class Program
    {
        #region Markets and Users

        public static Market Vero = new Market()
        {
            Name = "Vero",
            CurrentPromotion = ProductType.Food
        };
        public static Market Tinex = new Market()
        {
            Name = "Tinex",
            CurrentPromotion = ProductType.Drinks
        };
        public static Market TehnoMarket = new Market()
        {
            Name = "Tehno Market",
            CurrentPromotion = ProductType.Electornics
        };


        



        #endregion


        static void Main(string[] args)
        {
            User martin = new User() { Name = "Martin", Age = 26, FavoriteType = ProductType.Drinks };
            User dejan = new User() { Name = "Dejan", Age = 28, FavoriteType = ProductType.Food };
            User ivo = new User() { Name = "Ivo", Age = 30, FavoriteType = ProductType.Electornics };


            //Users subscribe to Vero for their promotions
            Vero.SubscribeForPromotions(martin.ReadPromotion, "martin@gmail.com");
            Vero.SubscribeForPromotions(dejan.ReadPromotion, "dejan@gmail.com");
            Vero.SubscribeForPromotions(ivo.ReadPromotion, "ivo@gmail.com");

            //Users subscribe to Tinex for their promotions
            Tinex.SubscribeForPromotions(martin.ReadPromotion, "martin@gmail.com");

            //Users subscribe to TehnoMarket for their promotions
            TehnoMarket.SubscribeForPromotions(dejan.ReadPromotion, "dejan@gmail.com");
            TehnoMarket.SubscribeForPromotions(ivo.ReadPromotion, "ivo@gmail.com");


            //Vero is sending promotions to all its subcribers
            Vero.SendPromotions();
            Vero.CurrentPromotion = ProductType.Drinks;
            Vero.UnSubscribeForPromotions(martin.ReadPromotion, "Boooring!");

            Console.WriteLine("========================================================");
            Tinex.SendPromotions();
            Tinex.CurrentPromotion = ProductType.Food;


            Console.WriteLine("=========================================================");
            TehnoMarket.SendPromotions();
            TehnoMarket.UnSubscribeForPromotions(dejan.ReadPromotion, "Promotion to often!");
            TehnoMarket.UnSubscribeForPromotions(ivo.ReadPromotion, "It is too expensive!");
            TehnoMarket.SubscribeForPromotions(martin.ReadPromotion, "martin@gmail.com");

            Thread.Sleep(4000);
            Console.Clear();

            Vero.SendPromotions();

            Console.WriteLine("=========================================================");
            Tinex.SendPromotions();

            Console.WriteLine("=========================================================");
            TehnoMarket.SendPromotions();

            Vero.DisplayZhalbiIPoplaki();
            Tinex.DisplayZhalbiIPoplaki();
            TehnoMarket.DisplayZhalbiIPoplaki();

            Console.Clear();
            Thread.Sleep(4000);
            Vero.SubscribeForInfo(martin.ReadInfo, "martin_panovski@gmail.com");
            Vero.SendInfo();


            //Requirements for homework
            //1.Implement a new event handler for informing all the subscribers for new locations about the markets
            //2.Implement a new listener methods that need to be subscriebed to the publisher event handler
            //3.Add new subscribers in Program.cs for that kind of information
            //4.Play with subscription and unsubscription of the event handler




            Console.ReadLine();
        }

    }
}
