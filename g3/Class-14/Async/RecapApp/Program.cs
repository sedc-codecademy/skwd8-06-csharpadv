using System;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;

namespace RecapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User dejanUser = new User { Id = 1, Username = "dejan", Password = "trajanBabus" };
            User trajanUser = new User { Id = 2, Username = "trajan", Password = "dekiBabus" };
            User viktorijaUser = new User { Id = 3, Username = "viktorija", Password = "123456" };

            List<User> users = new List<User> { dejanUser, trajanUser, viktorijaUser };

            string usersJson = JsonConvert.SerializeObject(users);

            //Console.WriteLine(usersJson);

            List<User> usersDeserialized = JsonConvert.DeserializeObject<List<User>>(usersJson);

            foreach (User user in usersDeserialized)
            {
                Console.WriteLine(user.Username);
            }

            Console.ReadKey();
        }
    }
}
