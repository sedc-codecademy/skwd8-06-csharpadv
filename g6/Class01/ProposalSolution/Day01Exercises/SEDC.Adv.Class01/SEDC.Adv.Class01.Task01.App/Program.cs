using SEDC.Adv.Class01.Task01.Logic.Services;
using System;
using System.Collections.Generic;

namespace SEDC.Adv.Class01.Task01.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNames = new List<string>()
            {
                "Nulla",
                "Lorem",
                "eros",
                "dolor",
                "Vestibulum",
                "Hello"
            };

            var text = $"Lorem ipsum dolor sit amet, consectetur Hello dolor dolor  Lorem  Lorem  adipiscing elit. dolor Lorem Hello Vestibulum pharetra Lorem mattis libero, eget porttitor eros posuere eu. Quisque sit amet maximus eros. Donec id placerat massa, dignissim fermentum mi. Pellentesque habitant morbi tristique senectus  Hello et netus et malesuada fames ac turpis egestas. Vestibulum eleifend sem eu velit fermentum eleifend at sed justo. Cras fermentum elementum placerat. Morbi metus tortor, consectetur vehicula leo a, Hello lacinia eleifend quam. Vivamus quis quam Hello Hello quis justo dignissim pulvinar.Aliquam iaculis augue lorem, ac fermentum lorem gravida sit amet.Nulla consectetur lacus felis, at cursus elit mattis ut. Fusce sed congue dolor. Hello Nulla tempus  Hello laoreet velit. Hello";

            var searchService = new SearchService();
            var result = searchService.CountAppearancesInText(text, listOfNames);

            foreach (var item in result)
            {
                Console.WriteLine($"Name: {item.Key} is contained {item.Value}");
            }
            Console.WriteLine("-------------- SECOND WAY ----------------");
            var result2 = searchService.CountAppearancesInText2(text, listOfNames);

            foreach (var item in result2)
            {
                Console.WriteLine($"Name: {item.Name} is contained {item.Appearance}");
            }
            Console.WriteLine("-------------- THIRD WAY ----------------");
            searchService.CountAppearancesInText3(text, listOfNames);
            Console.ReadLine();
        }
    }
}
