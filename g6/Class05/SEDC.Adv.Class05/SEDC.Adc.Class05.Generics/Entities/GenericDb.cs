using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adc.Class05.Generics.Entities
{
    public class GenericDb<T>
        where T : BaseEntity
    {
        private List<T> Db;

        public GenericDb()
        {
            Db = new List<T>();
        }
        public void PrintAll()
        {
            foreach (T item in Db)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public List<T> GetAll()
        {
            return Db;
        }

        public void Insert(T item)
        {
            Db.Add(item);
            Console.WriteLine($"Item was added in the {item.GetType().Name} Db");
        }

        public T GetById(int id)
        {
            return Db.FirstOrDefault(item => item.Id == id);
        }

        public T GetByIndex(int index)
        {
            return Db[index];
        }

        public void RemoveById(int id)
        {
            T item = Db.FirstOrDefault(item => item.Id == id);
            if(item == null)
            {
                Console.WriteLine($"Item was not found in the {item.GetType().Name} Db");
                return;
            }
            Db.Remove(item);
            Console.WriteLine($"Item was removed from the {item.GetType().Name} Db");
        }
    }
}
