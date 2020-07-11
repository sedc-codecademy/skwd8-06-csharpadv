using SEDC.Adv.Class13.FileSystemDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class13.FileSystemDatabase
{
    public interface IDb<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void Delete(int id);
        void ClearDb();
    }
}
