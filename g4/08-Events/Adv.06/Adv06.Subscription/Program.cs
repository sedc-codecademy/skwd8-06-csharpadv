using System;

namespace Adv06.Subscription
{
    class Program
    {
		#region Markets and Users
		public static Market SuperMart = new Market()
        {
            Name = "SuperMart",
            CurrentPromotion = ProductType.Food
        };
        public static Market BestMart = new Market()
        {
            Name = "BestMart",
            CurrentPromotion = ProductType.Electronics
        };
        public static User Bob = new User()
        {
            Name = "Bob Bobsky",
            Age = 21,
            FavoriteType = ProductType.Food
        };
        public static User Jill = new User()
        {
            Name = "Jill Wayne",
            Age = 28,
            FavoriteType = ProductType.Cosmetics
        };
        public static User Greg = new User()
        {
            Name = "Greg Gregsky",
            Age = 48,
            FavoriteType = ProductType.Electronics
        };
		#endregion
		static void Main(string[] args)
        {
            // Users subscribe to SuperMart for their promotions
            SuperMart.SubscribeForPromotions(Bob.ReadPromotion, "bob@gmail.com");
            SuperMart.SubscribeForPromotions(Jill.ReadPromotion, "jill@gmail.com");
            SuperMart.SubscribeForPromotions(Greg.ReadPromotion, "greg@gmail.com");

            // Users subscribe to BestMart for their promotions
            BestMart.SubscribeForPromotions(Jill.ReadPromotion, "jill@gmail.com");
            BestMart.SubscribeForPromotions(Greg.ReadPromotion, "greg@gmail.com");

            SuperMart.SendPromotions(); // This will send promotions to everyone who subscribed ( Will call the methods that were sent to the event )
            SuperMart.CurrentPromotion = ProductType.Cosmetics; // The promotion is changed 
            SuperMart.UnsubscribeForPromotions(Greg.ReadPromotion, "Boooring!"); // Greg unsubscribes because he hated the last promotion he got

            BestMart.SendPromotions(); // BestMart decides to send promotions as well to everyone who subscribed
            BestMart.CurrentPromotion = ProductType.Food;

            BestMart.UnsubscribeForPromotions(Greg.ReadPromotion, "Nothing great going on in the promotions!"); // Greg is not happy with BestMart promotions

            SuperMart.SendPromotions(); // Supermart sends another promotion
            SuperMart.UnsubscribeForPromotions(Bob.ReadPromotion, "Enough is enough"); // Bob is also not amused with the promotions so he unsubscribes
            SuperMart.CurrentPromotion = ProductType.Other; // SuperMart changes their promotion

            SuperMart.ReadZalbiIPoplaki(); // Supermart now reads the Zalbi i Poplaki box
            BestMart.ReadZalbiIPoplaki(); // BestMart now reads the Zalbi i Poplaki box

            Console.ReadLine();
        }
    }
}
