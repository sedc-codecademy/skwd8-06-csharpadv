using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TryBeingFit.Domain.Core.Entities;

namespace TryBeingFit.Domain.DB
{
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {
        public int IdCount { get; set; }
        private List<T> db;
        public LocalDb()
        {
            db = new List<T>();
            IdCount = 1;
        }
        //implementations of CRUD operations
        //Returns List of T entities that are present in the database
        public List<T> GetAll()
        {
            return db;
        }
        //Returns the Entity by mathing the id in the parameter with the quering of the field db using SingleOrDefault
        public T GetById(int id)
        {
            return db.SingleOrDefault(x => x.Id == id);
        }
        //Simply inserts the given entity as parameter in the db. Also increments Id counter to be ready with the next id number
        public int Insert(T entity)
        {
            entity.Id = IdCount;
            db.Add(entity);
            IdCount++;
            return entity.Id;
        }
        //Finds the given item/entity from the database using the parameter ID and then removes it from DB using Remove() method
        public void RemoveById(int id)
        {
            T item = db.SingleOrDefault(x => x.Id == id);
            if (item != null) db.Remove(item);
        }
        //Finds the item with the parameter ID and updates it by setting it to be the new entity
        public void Update(T entity)
        {
            T item = db.SingleOrDefault(x => x.Id == entity.Id);
            item = entity;
        }
    }
}
