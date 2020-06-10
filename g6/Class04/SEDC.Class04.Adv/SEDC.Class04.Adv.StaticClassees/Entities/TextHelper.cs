using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class04.Adv.StaticClassees.Entities
{
    public static class TextHelper
    {
        public static int MessageGenerated = 0;
        public static void GenerateStatusMessage(OrderStatus status)
        {
            string message = string.Empty;
            switch (status)
            {
                case OrderStatus.Processing:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    message = "[Processing] The order is being processed.";
                    break;
                case OrderStatus.Delivered:
                    Console.ForegroundColor = ConsoleColor.Green;
                    message = "[Delivered] The order is successfuly delivered.";
                    break;
                case OrderStatus.DeliveryInProgress:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    message = "[In Progress] The delivery is in progress....";
                    break;
                case OrderStatus.CouldNotDeliver:
                    Console.ForegroundColor = ConsoleColor.Red;
                    message = "[Not Delivered] There was a problem with the dilivery.";
                    break;
                default:
                    break;
            }
            Console.WriteLine(message);
            Console.ResetColor();
            MessageGenerated++;
        }

        public static string CapitalFirstLetter(string word)
        {
            if(word.Length == 0)
            {
                return "Empty string";
            }
            else if(word.Length == 1)
            {
                return char.ToUpper(word[0]).ToString();
            }
            else
            {
                return char.ToUpper(word[0]) + word.Substring(1);
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
