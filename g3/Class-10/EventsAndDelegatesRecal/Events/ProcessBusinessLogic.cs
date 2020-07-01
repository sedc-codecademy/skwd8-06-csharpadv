using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void Notify(); // this = > 'string message as parameter' will expect to work with events/methods that have string parameter in the signature
    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted;
        public void StartProcess()
        {
            Console.WriteLine("Starting process!");
            //something to code here / hard logic
            OnProcessCompleted(); //"process completed" as string argument will be for delegate with 1 string parameter
        }
        protected virtual void OnProcessCompleted() //this => 'string message' as parameter will fail because the signature will not be compatible with delegate signature
        {
            if (ProcessCompleted != null)
            {
                ProcessCompleted(); // this = > 'message as argument' will fail
            }
        }
    }
}
