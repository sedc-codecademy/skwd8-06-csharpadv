﻿using SEDC.Exercise.TryBeingFit.Domain.Core.Entities;
using SEDC.Exercise.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Db
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
            if (item != null)
                db.Remove(item);
        }

        public void Update(T entity)
        {
            T item = db.SingleOrDefault(x => x.Id == entity.Id);
            item = entity;
        }

        public List<T> GetAll()
        {
            return db;
        }
    }
}
