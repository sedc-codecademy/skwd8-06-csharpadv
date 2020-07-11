using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Db
{
	public class FileSystemDb<T> : IDb<T> where T : BaseEntity
	{
		// Path to the folder where we keep the JSON database files
		private string _dbFolder;
		// Path to the JSON file where we would keep the data
		private string _dbPath;
		// Path to the file which keeps track of the IDs of our entities
		private string _idPath;

		public FileSystemDb()
		{
			// Within the project folder
			_dbFolder = @"..\..\..\Db";
			_dbPath = $@"{_dbFolder}\{typeof(T).Name}s.json";
			_idPath = $@"{_dbFolder}\id.txt";

			// We create the folders and files if they do not exist
			if (!Directory.Exists(_dbFolder))
			{
				Directory.CreateDirectory(_dbFolder);
			}
			if (!File.Exists(_dbPath))
			{
				File.Create(_dbPath).Close();
			}
			if (!File.Exists(_idPath))
			{
				File.Create(_idPath).Close();
			}
		}

		public List<T> GetAll()
		{
			using(StreamReader sr = new StreamReader(_dbPath))
			{
				string resultString = sr.ReadToEnd();
				return JsonConvert.DeserializeObject<List<T>>(resultString);
			}
		}

		public T GetById(int id)
		{
			using (StreamReader sr = new StreamReader(_dbPath))
			{
				// Opt. 1
				// string resultString = sr.ReadToEnd();
				// List<T> allData = JsonConvert.DeserializeObject<List<T>>(resultString);

				// Opt. 2
				List<T> allData = GetAll();
				return allData.SingleOrDefault(x => x.Id == id);
			}
		}

		// Insert gets the whole data from the json ( Ex: [bob, jill, greg] )
		// Then generates id for the new entity ( Ex: bill.Id = generate )
		// Then saves the new entity in to the data that we got from the json ( Ex: [bob, jill, greg, bill] )
		// Then it rewrites the whole json with the new data ( Ex: [bob, jill, greg, bill] )
		// If we didn't overwrite our file we would get a result like this ( Ex: [bob, jill, greg] [bob, jill, greg, bill] )
		public int Insert(T entity)
		{
			List<T> data = new List<T>();
			// We need to write in the method
			using (StreamReader sr = new StreamReader(_dbPath))
			{
				data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
			}
			// If the file is newly created and is empty we create a new list ( Deserialize can return null for an empty file )
			if (data == null) data = new List<T>();
			entity.Id = GenerateId(); // Generate a new id for that item
			data.Add(entity);
			WriteData(_dbPath, data);
			return entity.Id;
		}

		public void RemoveById(int id)
		{
			List<T> data = new List<T>();
			// We need to write in the method
			using (StreamReader sr = new StreamReader(_dbPath))
			{
				data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
			}

			T item = data.SingleOrDefault(x => x.Id == id);
			if(item != null)
			{
				data.Remove(item);
				WriteData(_dbPath, data);
			}
		}

		public void Update(T entity)
		{
			List<T> data = new List<T>();
			// We need to write in the method
			using (StreamReader sr = new StreamReader(_dbPath))
			{
				data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
			}
			T item = data.SingleOrDefault(x => x.Id == entity.Id);
			if (item != null)
			{
				data[data.IndexOf(item)] = entity;
				WriteData(_dbPath, data);
			}
		}

		// Method that writes in a file
		private void WriteData(string path, List<T> updatedData)
		{
			using (StreamWriter sw = new StreamWriter(path))
			{
				string jsonString = JsonConvert.SerializeObject(updatedData);
				sw.WriteLine(jsonString);
			}
		}
		// Method for generating unique ids by remembering the next unique id in a txt file
		private int GenerateId()
		{
			#region This method explained
			// CASE 1 ( The file is empty )
			// We start the application for the first time
			// A file for id tracking is created and is now empty
			// We try and insert a user
			// We call this method to generate an id
			// We check to see if there is an id in the id tracking file
			// There is no id, so we use id 1
			// We increment 1 + 1 and we write 2 in the file
			// The user is created with an id 1
			// CASE 2 ( The file has an id remembered )
			// We start the application for the second time
			// We create a user again
			// We call this method to generate an new id for that user
			// We don't want the id to be 1 again, same as the previous one
			// That is why we keep track of the next unique id in the file which right now is 2
			// We read from the file and we get the number 2 which we saved the first time we inserted a user
			// We get the number 2 and we give it to the new user as an id
			// Then we increment the number 2 + 1 and we get 3
			// We write 3 in the file now so the next entity can get an id 3 which is different
			// This continues forever
			#endregion
			int id = 1;
			using (StreamReader sr = new StreamReader(_idPath))
			{
				string currentId = sr.ReadLine();
				if (currentId != null) id = int.Parse(currentId);
			}
			using (StreamWriter sw = new StreamWriter(_idPath))
			{
				sw.WriteLine(id + 1);
			}
			return id;
		}
	}
}
