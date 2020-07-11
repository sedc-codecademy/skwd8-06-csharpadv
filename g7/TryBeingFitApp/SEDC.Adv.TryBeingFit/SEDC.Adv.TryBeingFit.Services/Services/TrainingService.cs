using SEDC.Adv.TryBeingFit.Domain;
using SEDC.Adv.TryBeingFit.Domain.Db;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services
{
    public class TrainingService<T> : ITrainingService<T> where T : Training
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
