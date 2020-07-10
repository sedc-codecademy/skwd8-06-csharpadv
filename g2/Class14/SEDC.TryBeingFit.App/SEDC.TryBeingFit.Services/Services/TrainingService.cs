using SEDC.TryBeingFit.Domain.Core.Models;
using SEDC.TryBeingFit.Domain.Db;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services
{
    public class TrainingService<T> : ITrainingService<T> where T : Training
    {
        private IDb<T> _db;

        public TrainingService()
        {
            //_db = new LocalDb<T>();
            _db = new FileSystemDb<T>();
        }

        public void AddTraining(T training)
        {
            _db.Insert(training);
        }

        public T GetSingleTraining(int id)
        {
            T training = _db.GetById(id);
            return training;
        }

        public List<T> GetTrainings()
        {
            return _db.GetAll();
        }
    }
}
