using System;
using System.Collections.Generic;
using System.Text;

namespace Adv06.Subscription
{
    // This class is a subscriber class
    // It can subscribe to publishers and can get info every time the publisher decides to send some info to all subscribers
    // This subscriber class is representing a user that has the ability to subscribe for promotions
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ProductType FavoriteType { get; set; }

        // A method that can read a promotion and get excited if that is the favorite type of this person
        public void ReadPromotion(ProductType product)
        {
            Console.WriteLine($"Mr/Ms: {Name}, The product {product} is on sale");
            if (product == FavoriteType) Console.WriteLine("MY FAVORITE!");
        }
    }
}
