using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    // When inheriting from a generic intefrace we can do one of 2 things:
    // 1. Make the class that inherits from the generic interface generic as well
    // 2. Add a type to replace the T in the interface so that the class will work with that type only

    // Opt 1
    // T from the LocalDb must match with the T from IDb ( the interface )
    // That is why we need to write where T : BaseEntity on this side as well
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {
        public int IdCount { get; set; }
        private List<T> db;
        public LocalDb()
        {
            // We create an empty list that will be used as a locla DB while our app is running
            db = new List<T>();
            // This is sthe starting point for the ids in our locla DB
            IdCount = 1;
        }
        public List<T> GetAll()
        {
            return db;
        }

        public T GetById(int id)
        {
            return db.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(T entity)
        {
            entity.Id = IdCount;
            db.Add(entity);
            IdCount++;
            return entity.Id;
        }

        public void RemoveById(int id)
        {
            T item = db.SingleOrDefault(x => x.Id == id);
            if(item != null) db.Remove(item);
        }

        public void Update(T entity)
        {
            T item = db.SingleOrDefault(x => x.Id == entity.Id);
            item = entity;
        }
    }

    // Opt 2
    //public class LocalDb : IDb<User>
    //{
    //    public List<User> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public User GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int Insert(User entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void RemoveById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(User entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
