using SEDC.Adv.TryBeingFit.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services
{
    public interface ITrainingService<T> where T : Training
    {
        List<T> GetTrainings();
        T GetSingleTraining(int id);
        void AddTraining(T training);
    }
}
