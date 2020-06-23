using System;
using System.Collections.Generic;
using System.Text;
using TryBeingFit.Domain.Core.Entities;

namespace TryBeingFit.Domain.DB
{
     public interface IDb<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void RemoveById(int id);
        void Update(T entity);
    }
}
