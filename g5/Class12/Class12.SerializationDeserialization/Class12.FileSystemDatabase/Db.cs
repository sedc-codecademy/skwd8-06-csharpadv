using Class12.FileSystemDatabase.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Class12.FileSystemDatabase
{
    public class Db<T> where T : BaseEntity
    {
        private string _dbDirectory;
        private string _dbFile;
        private int IdTracker = 0;

        public Db()
        {
            _dbDirectory = $@"..\..\..\Db";
            _dbFile = $@"{_dbDirectory}\{typeof(T).Name}s.json";
            if(!Directory.Exists(_dbDirectory))
            {
                Directory.CreateDirectory(_dbDirectory);
            }
            if(!File.Exists(_dbFile))
            {
                File.Create(_dbFile).Close();
            }

            List<T> data = Read();
            if(data == null)
            {
                Write(new List<T>());
            }
            else if(data.Count > 0)
            {
                IdTracker = data[data.Count - 1].Id;
            }
        }

        #region Reading/Writing

        private List<T> Read()
        {
            try
            {
                using(StreamReader sr = new StreamReader(_dbFile))
                {
                    string data = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<T>>(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private bool Write(List<T> entities)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(_dbFile))
                {
                    string data = JsonConvert.SerializeObject(entities);
                    sw.Write(data);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        #endregion

        #region DataManipulation
        public List<T> GetAll()
        {
            return Read();
        }

        public int Insert(T entity)
        {
            List<T> data = Read();
            IdTracker++;
            entity.Id = IdTracker;
            data.Add(entity);
            Write(data);
            return entity.Id;
        }

        public T GetById(int id)
        {
            List<T> data = Read();
            return data.SingleOrDefault(x => x.Id == id);

        }

        public void ClearDb()
        {
            Write(new List<T>());
        }

        #endregion
    }
}
