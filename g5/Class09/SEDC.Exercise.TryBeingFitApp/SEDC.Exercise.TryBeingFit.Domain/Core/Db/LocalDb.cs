using SEDC.Exercise.TryBeingFit.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Db
{
    public class LocalDb<T> where T : BaseEntity
    {
        public int IdCount { get; set; }
        private List<T> db;

        public LocalDb()
        {
            db = new List<T>();
            IdCount = 1;
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
            
        }

        public void Update(T entity)
        {

        }

        public List<T> GetAll()
        {
            return db;
        }
    }
}
