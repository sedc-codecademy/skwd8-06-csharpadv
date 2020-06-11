using System;
using System.Collections.Generic;
using System.Text;

namespace Static.Entities
{
    // Static helper class that we can use to help us out with some tasks involving text
    // We can call these methods without creating an instance of the class
    public class TextHelper
    {
        // These values will be the same values from everywhere, no matter from where do we change them
        public static int CapitalLettersUses = 0;
        public static int MessagesGenerated = 0;
        public static string CapitalFirstLetter (string word)
        {
            if (word.Length == 0)
            {
                return "Empty string";
            }
            else if (word.Length == 1)
            {
                CapitalLettersUses++;
                return char.ToUpper(word[0]).ToString();
            }
            else
            {
                CapitalLettersUses++;
                return char.ToUpper(word[0]) + word.Substring(1);
            }
        }
        public static void GenerateStatusMesage(OrderStatus status)
        {
            string result = "";
            switch (status)
            {
                case OrderStatus.Proccessing:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    result = "[Proccessing] The order is being proccessed";
                    break;
                case OrderStatus.Delivered:
                    Console.ForegroundColor = ConsoleColor.Green;
                    result = "[Proccessing] The order is successfully delivered";
                    break;
                case OrderStatus.DeliveryInProgress:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    result = "[Proccessing] The order is in the delivery stage";
                    break;
                case OrderStatus.CouldNotDeliver:
                    Console.ForegroundColor = ConsoleColor.Red;
                    result = "[Proccessing] The order could nt be delivered";
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
            Console.ResetColor();
            MessagesGenerated++;
        }
        public static int ValidateNumberInput(string input)
        {
            int choice = 0;
            bool isMenuChoiceValid = int.TryParse(input, out choice);
            if (!isMenuChoiceValid)
            {
                Console.WriteLine("Wrong input...");
                return -1;
            }
            return choice;
        }
    }
}
