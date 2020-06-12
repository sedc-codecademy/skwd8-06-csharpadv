using System;

namespace SEDC.BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Boxing

            // Boxing an integer in to a more universal type, object
            // All value types derive from object
            // That is why we can box any value type in to object

            int number1 = 100;
            Console.WriteLine(number1.GetType());

            //Behind the scene in the memory. In the process of boxing.
            Int32 objTest = new Int32();
            objTest = 200;

            object obj1 = number1;
            Console.WriteLine(obj1.GetType());
            #endregion

            #region Unboxing
            // Unboxing an object back in to integer
            // Since an object variable can hold any value we can try and unbox it to a specific type

            try
            {
                object obj2 = 5000;
                Console.WriteLine(objTest);

                int number2 = (int)obj2;

                string string1 = (string)obj2;
                Console.WriteLine(number2);
                Console.WriteLine(string1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0} | Exception: {1}", ex.Message, ex);
            }
            #endregion

            // Note: Casting changes the type, but does not change the object value
            // It is different than converting since converting tries to change the value to match another type
            // Casting just changes the type if the value is eligable to exist in that type as well
            // A good example is unboxing since object and int can both hold the number 9000
            // There is no need to change the number since it can exist in both of the types

            Console.ReadLine();
        }
    }
}
