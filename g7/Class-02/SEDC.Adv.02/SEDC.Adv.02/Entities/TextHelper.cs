using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._02.Entities
{
    // A static class that can be used by just the name of the class ( TextHelper ) 
    // We can't use this class to create a new instance from it -> new TextHelper()
    // WE MUST HAVE STATIC MEMBERS IN STATIC CLASS
    // WE CAN'T HAVE NON STATIC MEMBERS IN A STATIC CLASS
    public static class TextHelper
    {
        // This is a property that remembers how many times did we use the capital letter method
        // It also must be static
        // IF you call the method from multiple places, the counter will count from all of them
        // IF this was a normal class, the counter can only count for the current instance ( Between the { } where the instance of the class is )
        public static int CapitalLetterUses { get; set; }
        public static string CapitalFirstLetter(string word)
        {
            CapitalLetterUses++;
            // We check if the string is empty
            if (word.Length == 0) return "Empty string";
            // We check if it's only one character
            // If it is, get the first index from the word string ( the character ) and convert it to upper ( capital letter )
            // Because it's a charater and we need to return a string, we call the ToString() method
            if (word.Length == 1) return char.ToUpper(word[0]).ToString();
            else
            {
                // don -> d -> make it to upper -> D, take don -> substring without the first letter -> on -> combine D with on -> Don
                // first get the capital letter, then get the word without the first letter, then combine them
                return char.ToUpper(word[0]) + word.Substring(1);
            }
        }
    }
}
