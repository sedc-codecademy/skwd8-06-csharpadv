using Newtonsoft.Json;
using SEDC.TryBeingFit.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Db
{
    public class FileSystemDb<T> : IDb<T> where T : BaseEntity
    {
        private string _dbFolder;
        private string _dbPath;
        private int IdCount;

        public FileSystemDb()
        {
            _dbFolder = @"..\..\..\Db";
            _dbPath = $@"{_dbFolder}\{typeof(T).Name}s.json";
            IdCount = 1;
            if (!Directory.Exists(_dbFolder))
            {
                Directory.CreateDirectory(_dbFolder);
            }
            if (!File.Exists(_dbPath))
            {
                File.Create(_dbPath).Close();
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
                List<T> entities = GetAll();
                T entity = entities.SingleOrDefault(x => x.Id == id);
                return entity;
            }
        }

        public int Insert(T entity)
        {
            List<T> data = new List<T>();
            using (StreamReader sr = new StreamReader(_dbPath))
            {
                data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
            if (data == null) 
                data = new List<T>();
            entity.Id = IdCount;
            data.Add(entity);
            WriteData(_dbPath, data);
            IdCount++;
            return entity.Id;
        }

        public void RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        private void WriteData(string path, List<T> updatedData)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(JsonConvert.SerializeObject(updatedData));
            }
        }
    }
}
