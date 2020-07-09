using SEDC.Exercise.TryBeingFit.Domain;
using SEDC.Exercise.TryBeingFit.Domain.Core.Db;
using SEDC.Exercise.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Services.Services
{
    public class UserService<T> where T : User
    {
        private LocalDb<T> _db;
        public UserService()
        {
            _db = new LocalDb<T>();
        }

        public T GetById(int id)
        {
            return _db.GetById(id);
        }
        public T LogIn(string username, string password)
        {
            T user = _db.GetAll().SingleOrDefault(x => x.Username == username && x.Password == password);
            if (user == null)
            {
                //("[Error] Username or password did not match..", Color)
                Console.ReadLine();
                return null;
            }

            return user;

        }

        public T Register(T user)
        {
            if (ValidationHelper.ValidatePassword(user.Password) == null
                || ValidationHelper.ValidateUserName(user.Username) == null
                || ValidationHelper.ValidateString(user.LastName) == null
                || ValidationHelper.ValidateString(user.FirstName) == null)
            {
                MessageHelper.Color("[Error] Invalid info!", ConsoleColor.Red);
                Console.ReadLine();
                return null;
            }

            int id = _db.Insert(user);

            //return _db.GetById(id);
            return user;

        }

        public void ChangeInfo(int userId, string firstName, string lastName)
        {
            T user = _db.GetById(userId);
            if (ValidationHelper.ValidateString(firstName) == null || ValidationHelper.ValidateString(lastName) == null)
            {
                MessageHelper.Color("[Error] string were not valid. Please try again!", ConsoleColor.Red);
                Console.ReadLine();
                return;
            }
            user.FirstName = firstName;
            user.LastName = lastName;
            _db.Update(user);
            MessageHelper.Color("Data successfuly changed!", ConsoleColor.Green);
            Console.ReadLine();

        }



    }
}
