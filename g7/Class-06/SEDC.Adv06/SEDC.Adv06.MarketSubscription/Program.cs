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
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
