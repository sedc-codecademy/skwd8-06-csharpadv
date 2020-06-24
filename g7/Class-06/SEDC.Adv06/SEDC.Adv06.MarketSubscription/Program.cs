using System;

namespace SEDC.Adv06.MarketSubscription
{
    // Market app subscription model
	// * A user needs to be able to subscribe to a market promotion newsletter
	// * A user needs to be able to unsubscribe to a market promotion newsletter if they don't like it
	// * The market needs to have a system for notyifing all users that subscribed for the propmotion newsletter
	// * The market needs the user e-mail for marketing purposes
	// * The market needs a system for subscribing and unsubscribing
	// * If a user unsubscribes the user needs to provide a reason to the market in the SuggestionBox

	// Subscription model
	// In a subscription model we always need a publisher that sends notifications
	// And subscribers that are ready to subscribe to the publisher and get those notifications
	// The cool thing about this system is that it manages it self
	// The notifications are sent the same way, but they always notify only the people that were subscirbed at that moment
	// In our case the publisher is the Market class
	// The subscribers are the Users from the User class
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
            // STORY
            // Once upob a time in a distant land...

            // SuperMart market opens in the city
            // Bob, Jill and Greg are very excited and they opt for promotions from SuperMart

            // The 3 users want to subscribe for SuperMart and their promotions
            SuperMart.SubscribeForPromotions(Bob.ReadPromotion, "bob@gmail.com");
            SuperMart.SubscribeForPromotions(Jill.ReadPromotion, "jill@gmail.com");
            SuperMart.SubscribeForPromotions(Greg.ReadPromotion, "greg@gmail.com");

            // Another market opens with the name BestMart
            // Jill and Greg decide to opt for promotions there as well. Bob really doesn't like BestMart so he doesn't subscribe

            BestMart.SubscribeForPromotions(Jill.ReadPromotion, "jill@gmail.com");
            BestMart.SubscribeForPromotions(Greg.ReadPromotion, "greg@gmail.com");

            // Supermart decides to send promotional material for their current product type which is Food
            SuperMart.SendPromotions();

            // Supermart decides to change their product for promotion from Food to Cosmetics
            SuperMart.CurrentPromotion = ProductType.Cosmetics;

            // Greg decides that the promotion he got from Supermart was bad because he likes Electronics but the send Cosmetics
            // He decides to unsubscribe
            SuperMart.UnsubscribeForPromotions(Greg.ReadPromotion, "I don't really like the promotions. They are bad!");

            // BestMart decides to also send promotional material for their current product type which is Electronics
            BestMart.SendPromotions();

            // BestMart changes ther promotion product type from Electronics to Food
            BestMart.CurrentPromotion = ProductType.Food;

            // Jill is sick of getting promotions for electornics so she usubscribes from BestMart promotions
            BestMart.UnsubscribeForPromotions(Jill.ReadPromotion, "I am sick of electronics and also the design of the newsletter is horrible!");

            // SuperMart and BestMart decide both to send out promotions for some holiday special event
            BestMart.SendPromotions();
            SuperMart.SendPromotions();

            // An employee of SuperMart decides to see what is in the suggestion box
            SuperMart.ReadSuggestions();

            // An employee of BestMart also decides to see what is in the suggestion box
            BestMart.ReadSuggestions();

            // END OF STORY
            Console.ReadLine();
        }
	}
}
