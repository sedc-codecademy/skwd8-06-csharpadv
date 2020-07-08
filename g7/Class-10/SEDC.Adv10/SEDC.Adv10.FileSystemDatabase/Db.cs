using Newtonsoft.Json;
using SEDC.Adv10.FileSystemDatabase.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SEDC.Adv10.FileSystemDatabase
{
	// We make it generic so we can use it for both Student and Subject and maybe for future entities as well ( Must inherit from BaseEntity )
	// If we don't make it generic we have to create two classes, one for Student and one for Subject or create one large class with 2 meathods for each action ( 1 method for Student and 1 method for Subject )
	// This Database will work with json files
	// In every json file we will keep a list of items of a particular type
	// Every time we write we must convert to json and every time we read we must convert to C# 
	public class Db<T> where T : BaseEntity
	{
		// Set up the configuration strings
		private string _dbDirectory;
		private string _dbFile;
		private string _idPath;

		public Db()
		{
			// We create the directory ( folder ) where the json files will be stored
			_dbDirectory = $@"..\..\..\Db";
			// Then we create the path to the json file where we will store the entities
			// The file name is created by taking the type with the method typeof()
			// Then typeof() returns a TYPE object and we get the Name property of the TYPE object which returns the name of the type it self which in our example would be Student or Subject
			_dbFile = $@"{_dbDirectory}\{typeof(T).Name}s.json"; // Example: For Student it will be \Students.json
			_idPath = $@"{_dbDirectory}\id.txt";
			// We need to check if these files and folders exist and if not create them
			if (!Directory.Exists(_dbDirectory))
			{
				Directory.CreateDirectory(_dbDirectory);
			}
			if (!File.Exists(_dbFile))
			{
				File.Create(_dbFile).Close();
			}
			if (!File.Exists(_idPath))
			{
				File.Create(_idPath).Close();
			}
			List<T> data = Read();
			if(data == null)
			{
				Write(new List<T>());
			}
			
		}

		#region Reading/Writing
		// We read from the file ( a json string ), we convert the string in to a list of items and return that list back
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

		// We get the items that we need to write, we convert them in to json string and we save the json string in to the file
		private bool Write(List<T> entities)
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(_dbFile))
				{
					// If we add a parameter true it will append to the previous data in the file
					// If we don't add true as a parameter, it will rewrite the file every time
					string data = JsonConvert.SerializeObject(entities);
					sw.Write(data);
					return true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
		// With this method we generate a new id for a new item
		// The id number that is next to be used is saved in a file
		// When we need a new id, we get that number from the file
		// Then we write the number + 1 to the file back for the next item
		// This method is for making unique ids 
		public int GenerateNewId()
		{
			int id = 1;
			using(StreamReader sr = new StreamReader(_idPath))
			{
				bool isInt = int.TryParse(sr.ReadLine(), out id);
			}
			using(StreamWriter sw = new StreamWriter(_idPath))
			{
				sw.Write(id + 1);
			}
			return id;
		}
		#endregion

		#region Data Manipulation
		public List<T> GetAll()
		{
			return Read();
		}
		public T GetById(int id)
		{
			List<T> data = Read();
			return data.SingleOrDefault(x => x.Id == id);
		}
		public int Insert(T entity)
		{
			// We get the current version of the data
			List<T> data = Read();
			entity.Id = GenerateNewId();
			// We change the current version of the data
			data.Add(entity);
			// We rewrite the file with the new version of the data
			bool isSuccessfull = Write(data);
			if (!isSuccessfull) throw new Exception("The writing was not successfull. Please trya gain!");

			// If we don't do this, we will have duplicate version of our files on the system

			return entity.Id;
		}
		public void ClearDb()
		{
			Write(new List<T>());
		}
		#endregion
	}
}
