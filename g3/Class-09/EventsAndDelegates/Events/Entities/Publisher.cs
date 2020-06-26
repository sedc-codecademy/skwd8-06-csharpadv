using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events.Entities
{
    public class Publisher
    {
        public delegate void DataProccessingDelegate(string message);
        public event DataProccessingDelegate DataProccessingHandler;
        public void ProccessData(string message) //business logic
        {
            Console.WriteLine("Proccessing data...");
            Thread.Sleep(3000);
            WhenDataIsProccesed(message);
        }
        // It notifies all subscribers for the message that is processed from the ProcessData method
        protected void WhenDataIsProccesed(string message)
        {
            if (DataProccessingHandler != null)
            {
                DataProccessingHandler(message);
            }
        }
    }
}
