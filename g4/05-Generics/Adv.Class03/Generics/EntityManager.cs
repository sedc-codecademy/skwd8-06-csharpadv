using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Generics
{
    public class EntityManager<T> where T:IBasicEntity
    {
        private List<T> entities = new List<T>();

        public T GetEntityByID(int id)
        {
            return entities.SingleOrDefault(item => item.ID == id);
        }

        public int SaveEntity(T entity)
        {
            entities.Add(entity);
            return entity.ID;
        }

        public bool DeleteEntity(T entity)
        {
            return entities.Remove(entity);
        }

        public IEnumerable<T> GetAllEntities()
        {
            return entities.AsReadOnly();
        }
    }
}
