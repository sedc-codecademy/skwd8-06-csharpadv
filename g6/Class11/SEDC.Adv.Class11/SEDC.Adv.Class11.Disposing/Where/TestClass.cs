using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class11.Disposing.Where
{
    public class ActivitiesService
    {
        private Db<Reading> _redingDb;
        private Db<Working> _workingDb;

        public ActivitiesService()
        {
            _redingDb = new Db<Reading>();
            _workingDb = new Db<Working>();
        }

        public void Sometihng()
        {
            var book = _redingDb.FindById(1);
            book.ReadPeages = 1001;

            var work = _workingDb.FindById(1);
            work.IsWorking = true;
        }
    }
}
