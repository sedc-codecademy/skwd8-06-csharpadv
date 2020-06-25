using SEDC.Adv.TryBeingFit.Domain.Db;
using SEDC.Adv.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.Services
{
    public class TrainingService<T> : ITrainingService<T> where T : Training
    {
        private IDb<T> _db;
        public TrainingService()
        {
            _db = new LocalDb<T>();
        }
        public void AddTraining(T training)
        {
            _db.Insert(training);
        }

        public T GetSingleTraining(int id)
        {
            return _db.GetById(id);
        }

        public List<T> GetTrainings()
        {
            return _db.GetAll();
        }
    }
}
