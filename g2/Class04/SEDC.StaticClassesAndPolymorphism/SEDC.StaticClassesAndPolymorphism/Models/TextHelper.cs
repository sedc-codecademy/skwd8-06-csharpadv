using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.StaticClassesAndPolymorphism.Models
{
    //Static helpler class that we can use to help us out with some tasks involving text
    public static class TextHelper
    {
        public static void GenerateStatusMessage(OrderStatus status)
        {
            string result = String.Empty;

            switch (status)
            {
                case OrderStatus.Processing:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    result = "[Processing] The order is being processed.";
                    break;
                case OrderStatus.Fullfiled:
                    Console.ForegroundColor = ConsoleColor.Green;
                    result = "[Fullfiled] The order is successfully delivered.";
                    break;
                case OrderStatus.DeliveryInProgress:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    result = "[In progress] The delivery is in progress...";
                    break;
                case OrderStatus.CouldNotDeliver:
                    Console.ForegroundColor = ConsoleColor.Red;
                    result = "[Not delivered] There was a problem with the delivery, because of COVID-19.";
                    break;
                default: 
                    break;
            }

            Console.WriteLine(result);
            Console.ResetColor();
        }

        public static string CapitalFirstLetter(string word)
        {
            if(word.Length == 0)
            {
                return "Empty string. Try again.";
            }
            else if(word.Length == 1)
            {
                return char.ToUpper(word[0]).ToString();
            }
            else
            {
                return String.Format("{0}{1}", char.ToUpper(word[0]), word.Substring(1));
            }
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
