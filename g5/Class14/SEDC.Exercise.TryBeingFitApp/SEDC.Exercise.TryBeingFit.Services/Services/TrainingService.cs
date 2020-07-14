using SEDC.Exercise.TryBeingFit.Domain.Core.Db;
using SEDC.Exercise.TryBeingFit.Domain.Core.Entities;
using SEDC.Exercise.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Services.Services
{
    public class TrainingService<T> where T : Training
    {
        private IDb<T> _db;

        public TrainingService()
        {
            _db = new FileSystemDb<T>();
        }

        public List<T> GetTrainings()
        {
            return _db.GetAll();
        }
        public T GetSingleTraining(int id)
        {
            T training = _db.GetById(id);
            return training;
        }

        public void AddTraining(T training)
        {
            _db.Insert(training);
        }
    }
}
