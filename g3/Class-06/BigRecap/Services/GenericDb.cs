using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class GenericDb<T> where T : BaseEntity
    {
        public GenericDb()
        {
            _data = new List<T>();
        }

        private IList<T> _data { get; set; } // This is a simulation of a DB

        public void AddItem(T item)
        {
            _data.Add(item);
        }

        public List<T> GetItems()
        {
            //return (List<T>)_data;
            return _data.ToList();
        }
    }
}
