using Domain;
using Domain.Config;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Services
{
    public class FileService
    {
        private const string APPSETTINGS_PATH = "../../../appsettings.json";

        private AppSettings _appSettings;
        private string _basePath;

        public FileService()
        {
            AppSettings appSettings = GetAppSettings();

            _appSettings = appSettings;
            _basePath = appSettings.DataPath;
        }

        public List<T> GetAllEntities<T>()
            where T : class, IBaseEntity
        {
            string filePath = GetFilePath<T>();
            ValidateFile(filePath);

            FileStream file = File.OpenRead(filePath);
            using StreamReader reader = new StreamReader(file);

            return JsonConvert.DeserializeObject<List<T>>(reader.ReadToEnd());
        }

        public T GetEntity<T>(Guid id) 
            where T : class, IBaseEntity
        {
            string filePath = GetFilePath<T>();
            ValidateFile(filePath);

            FileStream file = File.OpenRead(filePath);
            using StreamReader reader = new StreamReader(file);
            List<T> fileContent = JsonConvert.DeserializeObject<List<T>>(reader.ReadToEnd());

            return fileContent.Single(entity => entity.Id == id);
        }

        public void AddEntity<T>(T entity)
            where T : class, IBaseEntity
        {
            string filePath = GetFilePath<T>();
            ValidateFile(filePath);

            List<T> fileContent;
            using (StreamReader reader = new StreamReader(filePath))
            {
                fileContent = JsonConvert.DeserializeObject<List<T>>(reader.ReadToEnd());
                fileContent.Add(entity);
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(JsonConvert.SerializeObject(fileContent));
            }
        }

        public void UpdateEntity<T>(T entity)
            where T : class, IBaseEntity
        {
            string filePath = GetFilePath<T>();
            ValidateFile(filePath);

            List<T> fileContent;
            using (StreamReader reader = new StreamReader(filePath))
            {
                fileContent = JsonConvert.DeserializeObject<List<T>>(reader.ReadToEnd());
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                T fileEntity = fileContent.Single(x => x.Id == entity.Id);
                int fileEntityIndex = fileContent.IndexOf(fileEntity);
                fileContent.RemoveAt(fileEntityIndex);
                fileContent.Insert(fileEntityIndex, entity);

                writer.WriteLine(fileContent);
            }
        }

        public AppSettings GetAppSettings()
        {
            string appSettingsPath = APPSETTINGS_PATH;
            ValidateFile(appSettingsPath);

            FileStream appSettings = File.OpenRead(appSettingsPath);
            using StreamReader reader = new StreamReader(appSettings);

            return JsonConvert.DeserializeObject<AppSettings>(reader.ReadToEnd());
        }

        private string GetFilePath<T>()
            where T : class, IBaseEntity
        {
            return Path.Combine(_basePath, typeof(T).Name + "s.json");
        }

        private void ValidateFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File does not exist! Please create one", filePath);
        }
    }
}
