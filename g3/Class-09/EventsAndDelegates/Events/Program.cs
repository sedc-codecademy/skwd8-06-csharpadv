using Events.Entities;
using System;
using System.Threading;

namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Javascript - events
            //function doSomething(){//does something};

            //let but = document.getElementByID("btnClick");
            //but.addEventListener("click", doSomething(), false);

            //C# logic of raising events
            //create delegate
            //create event of the delegate type accepting methods with the delegate signature
            //for example: void delegate (string something) => event of this delegate type 
            //to assign methods that return nothing and accepts string as a parameter

            string fancyMessage = "This is a very fancy message";
            Publisher publisher = new Publisher();
            Subscriber1 subscriber1 = new Subscriber1();
            Subscriber2 subscriber2 = new Subscriber2();

            publisher.DataProccessingHandler += subscriber1.GetMessage1;
            publisher.DataProccessingHandler += subscriber2.GetMessage2;
            publisher.DataProccessingHandler += x => Console.WriteLine($"Special handling of message: {x}");

            publisher.ProccessData(fancyMessage);

            Console.WriteLine("--------------------------------");

            Thread.Sleep(2000);

            publisher.DataProccessingHandler -= subscriber2.GetMessage2;
            publisher.ProccessData(fancyMessage);

            Console.ReadKey();
        }
    }
}
