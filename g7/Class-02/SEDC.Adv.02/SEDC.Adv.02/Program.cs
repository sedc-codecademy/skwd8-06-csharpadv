using SEDC.Adv._02.Entities;
using System;

namespace SEDC.Adv._02
{
	class Program
	{
		static void Main(string[] args)
		{
            #region Examples
            // We can't create an instance of a static class
            // This does not mean that an instance does not exist from this class
            // Static class actually has an instance but it is created automatically when the app starts
            // That is why you can't create a new instance from it. There is already an instance 
            // And since there can only be one instance of a static class, there is no reason for a developer to create a new one
            // TextHelper txt = new TextHelper(); // This gives an error
            // Static class is the same for EVERYBODY EVERYWHERE
            // Normal class is sepparate for each context ( between {} brackets )
            Console.WriteLine("NOT THE APP");
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            string capitalLetterInput = TextHelper.CapitalFirstLetter(input);
            User bob = new User(1, "bob22", "Bob Street");
            // You can't call methods on normal classes without an instance, like we can with the static classes
            // User.PrintInfo(); // this gives an error
            // We can now use PrintInfo because we have an instance
            bob.PrintInfo();
            Console.WriteLine($"Your string: {capitalLetterInput}");
            Console.WriteLine($"The capital letter method was used {TextHelper.CapitalLetterUses} times!");
            Console.ReadLine();
            Console.Clear();
            #endregion

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the ordering menu!");
                Console.WriteLine("Choose a User:");
                OrdersTempDB.ListUsers();
                
            }
        }
    }
}
