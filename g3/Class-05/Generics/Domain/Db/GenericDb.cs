using Domain.Entities;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Db
{
    // NOTE: see the AnyList class for Generics explanation comments
    public class GenericDb<T> where T : IBaseEntity // by using the where keyword on a Generic type, we are doing a restriction of what types could be passing in, so the types/classes that we are going to pass in this class need to inherit from IBaseEntity directly or indirectly
    {
        // CRUD Operations: Create, Read, Update, Delete
        
        public GenericDb()
        {
            _db = new List<T>();
        }
        
        private List<T> _db; // This list represents a "real" database, It will be a List of some class that inherit from IBaseEntity

        public void Create(T item)
        {
            Console.WriteLine($"Item added to db");
            _db.Add(item);
        }

        public T Read(int id) // In this method we are using the T parameter to tell what type would return the Read method
        {
            // Also we can define a variable of type "T" since the _db is a List<T>, Find() will return T
            T item = _db.Find(item => item.Id == id);
            Console.WriteLine($"Item with id {item.Id} read from db");
            return item;
        }

        public T Delete(int id)
        {
            Console.WriteLine($"Item deleted from db");
            T item = _db.Find(item => item.Id == id);
            _db.Remove(item);
            return item;
        }
    }
}
