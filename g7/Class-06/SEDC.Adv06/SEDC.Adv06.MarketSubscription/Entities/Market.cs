using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.Adv06.MarketSubscription
{
	// This is the publisher class
	// This class will send the messages to all the subscibers that subscribed and want to listen for those messages
	// In our business case the users subscribe to the market promotions so they can get promotions when the market sends them out

	public class Market
	{
		// This is just a type of method so we can constrain the event to only accept certain types of methods
		public delegate void PromotionSender(ProductType product);

		// This is the event
		// The event is sort of like a collection of methods
		// The event keeps track of all the methods that are stored in it and that will get executed when the event is triggered
		// This event only accepts methods of the type PromotionSender delegate
		// We don't care about who gets promotion or who doesn't, this event takes care of that
		// When we call it, it will call all the functions that until that point got stored automatically

		// 1. We create an event that stores methods ( those methods represent the subscribers action )
		// 2. When a method needs to be added in the event the event checks if it matches the delegate
		// 2.1. If it does, it stores it
		// 2.2. If it doesn't, it throws an error
		// 3. We can at any point call the event like a method of type of the delegate ( triger it ) -> PromotionUserbase(ProdutType.Food)
		// 4. When we cll the event as a method it actually calls all methods that it got stored in it at the same time
		// NOTE: The event does not hold the methods them selves in it. It keeps addresses to the methods that got accepted
		// Addresses -> The method will still get executed at the place it got declared
		private event PromotionSender PromotionUserbase;

		public string Name { get; set; }
		public ProductType CurrentPromotion { get; set; }
		public List<string> SuggestionBox { get; set; }
		public List<string> Emails { get; set; }

		// This also fixes the issue with the null reference
		// public List<string> SuggestionBox { get; set; } = new List<string>();
		// public List<string> Emails { get; set; } = new List<string>();

		// Somewhere in our code we do this: SuggestionBox.Add("You are awesome!"); -> It will throw an error ( Scenario 1 )
		// The error is thrown because we don't have an instance in the SuggestionBox and Emails properties, they are null
		// We can't call .Add() on null
		// That is why we make sure that we have instances in those properties right after the class is initiated

		// Scenario 1 [We don't have any extra code]: Somebody calls market.SuggestionBox.Add("stuff"); and we don't have an instance
		// Outcome 1: The code breaks

		// Scenario 2 [We add an instance in the constructor]: Somebody calls market.SuggestionBox.Add("stuff"); 
		// Outcome 2: The instance is created when the object market was created so the code works

		// Scenario 3 [We add an instance in the constructor]: Nobody calls or uses SuggestionBox
		// Outcome 3: The instance is created when the object market was created but it is never used

		// Scenario 4 [Custom get method on the property]: Somebody calls market.SuggestionBox.Add("stuff"); 
		// Outcome 4: When they try and use SuggestionBox the custom get method will automatically create an instance of the list and the code will work

		// Scenario 5 [Custom get method on the property]: Nobody calls or uses SuggestionBox
		// Outcome 5: Because nobody used SuggestionBox it will never create the instance of list and we will avoid a useless instance of the list hanging 
		
		// Custom getter and setter ( Scenario 4 and 5 )
		// This code is the same as public List<string> SuggestionBox { get; set; } but longer and customisable
		//private List<string> _suggestionBox;
		//public List<string> SuggestionBox
		//{
		//	// Default get and set 
		//	//get { return _suggestionBox; } // this is called when -> List<string> variable = market.SuggestionBox; / market.SuggestionBox.Add("stuff");
		//	//set { _suggestionBox = value; } // this is called when -> market.SuggestionBox = new List<string>();
		//	get 
		//	{
		//		// When somebody tries to use this property, it will check if it has an instance from the list
		//		// If it has it will act normally, if it doesn't it will create an instance of the lists
		//		if (_suggestionBox == null) _suggestionBox = new List<string>();
		//		return _suggestionBox;
		//	}
		//	set { _suggestionBox = value; }
		//}

		// Scenario 2 and 3
		public Market()
		{
			SuggestionBox = new List<string>();
			Emails = new List<string>();
		}

		// This is the method that sends out the promotions
		private void Send()
		{
			PromotionUserbase(CurrentPromotion);
		}

		// This is the method that will be called from the outside and does some processing and after that it sends the promotions
		public void SendPromotions()
		{
			Console.WriteLine("----------------------------------------------");
			Console.WriteLine($"{Name} is sending a promotion for {CurrentPromotion}");
			Console.WriteLine("...Sending");
			// This method stops the applicaton for 3 seconds
			// We are using it to simulate the the sending process takes some time 
			Thread.Sleep(3000);
			// After the work is done we call the Send() method that will send all the promotions to the users that subscribed
			// Send is private because we don't anyone to send promotions directly from the outside, without the processing of 3 seconds
			Send();
		}

		// This is the method that it is called to subscribe a user and it's method for reading promotions ( To get promotions from this point in time forward )
		public void SubscribeForPromotions(PromotionSender subscriber, string email)
		{
			// This is how we register a method to the event
			// In business logic this is where the person wants to subsribe and they sbuscribe to the market for promotions
			PromotionUserbase += subscriber;
			Emails.Add(email);
		}

		// This is the method that it is called to unsubscribe a user and it's method for reading promotions ( To no longer get promotions )
		public void UnsubscribeForPromotions(PromotionSender subscriber, string reason)
		{
			PromotionUserbase -= subscriber;
			SuggestionBox.Add(reason);
		}

		// This is the method that the company can call to see all the suggestions they got
		public void ReadSuggestions()
		{
			Console.WriteLine($"[{Name}] Suggestions:");
			foreach (string suggestion in SuggestionBox)
			{
				Console.WriteLine(suggestion);
			}
		}






















		// This is an example of how it will look like if it were in one method
		// The Send() method is separated usually so we can use it in multiple methods and have a cleaner code
		//public void SendPromotions()
		//{
		//	Console.WriteLine("----------------------------------------------");
		//	Console.WriteLine($"{Name} is sending a promotion for {CurrentPromotion}");
		//	Console.WriteLine("...Sending");
		//	// This method stops the applicaton for 3 seconds
		//	// We are using it to simulate the the sending process takes some time 
		//	Thread.Sleep(3000);
		//	// After the work is done we call the Send() method that will send all the promotions to the users that subscribed
		//	// Send is private because we don't anyone to send promotions directly from the outside, without the processing of 3 seconds
		//	PromotionUserbase(CurrentPromotion);
		//}
	}
}
