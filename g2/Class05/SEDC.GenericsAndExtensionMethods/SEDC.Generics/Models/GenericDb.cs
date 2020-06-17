using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Generics.Models
{
    public class GenericDb<T> where T : BaseEntity
    {
        private List<T> Db;

        public GenericDb()
        {
            Db = new List<T>();
        }

        public void PrintAll()
        {
            foreach (var item in Db)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public void Insert(T item)
        {
            Db.Add(item);
            Console.WriteLine($"Item was added in the {item.GetType().Name} Db!");
        }

        public T GetByIndex(int index)
        {
            return Db[index];
        }

        public T GetById(int id)
        {
            return Db.SingleOrDefault(x => x.Id == id);
        }

        public void RemoveById(int id)
        {
            T item = Db.SingleOrDefault(x => x.Id == id);
            if(item == null)
            {
                Console.WriteLine($"Item was not found in {item.GetType().Name} Db!");
                return;
            }
            Db.Remove(item);
            Console.WriteLine($"Item was successfully removed from {item.GetType().Name} Db!");
        }

    }
}
