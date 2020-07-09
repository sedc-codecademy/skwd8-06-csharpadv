using Newtonsoft.Json;
using SEDC.Exercise.TryBeingFit.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Db
{
    public class FileSystemDb<T> where T : BaseEntity
    {
        private string _dbFolder;
        private string _dbPath;
        private string _idPath;

        public FileSystemDb()
        {
            _dbFolder = @"..\..\..\Db";
            _dbPath = $@"{_dbFolder}\{typeof(T).Name}s.json";
            _idPath = $@"{_dbFolder}\id.txt";
            if(!Directory.Exists(_dbFolder))
            {
                Directory.CreateDirectory(_dbFolder);
            }
            if(!File.Exists(_dbPath))
            {
                File.Create(_dbPath).Close();
            }
            if(!File.Exists(_idPath))
            {
                File.Create(_idPath).Close();
            }
        }

        public List<T> GetAll()
        {
            using (StreamReader sr = new StreamReader(_dbPath))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
        }

        public T GetById(int id)
        {
            using (StreamReader sr = new StreamReader(_dbPath))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd()).SingleOrDefault(x => x.Id == id);
            }
        }

        private int GenerateId()
        {
            int id = 1;
            using(StreamReader sr = new StreamReader(_idPath))
            {
                string currentId = sr.ReadLine();
                if (currentId != null)
                    id = int.Parse(currentId);
            }
            using (StreamWriter sw = new StreamWriter(_idPath))
            {
                sw.WriteLine(id + 1);
            }

            return id;
        }



    }
}
