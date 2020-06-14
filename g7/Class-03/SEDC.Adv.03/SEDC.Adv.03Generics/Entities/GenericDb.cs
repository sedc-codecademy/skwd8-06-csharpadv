using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv._03Generics.Entities
{
	// We need to have a class that simulates a DB
	// We need two classes that have a list of orders and list of products
	// And get all, insert, detele functions inside of both of them
	// If we had 10 entities we would need 10 times this logic

	// This Generic class is not a good practice to be used as generic methods alone
	// Because we want all methods and the list to work together for a particular type
	// For this generic class to have a certain scope for the placeholder type we must give that scope as a parent to some inheritance tree
	// Order and Product inherit from BaseEntity and they can be passed as T
	// Other classes that do not have BaseEntity in their inheritance tree as parent, can't be passed as T
	// Even if we have SpecialOrder class that inherits from Order, that can also be passed here since it has BaseEntity as paretnt SOMEWHERE in the inheritance tree
	// THIS SAME SYNTAX CAN BE USED ON GENERIC METHODS AS WELL
	public class GenericDb<T> where T : BaseEntity // T must be BaseEntity or some other child of BaseEntity along the inheritance tree
	{
		private List<T> _db;
		public GenericDb()
		{
			_db = new List<T>();
		}
		public void PrintAll()
		{
			// 1. We create a new instance of GenericDb<Produt> 
			// 2. All T in that object are changed to Product
			// 2.1. Ex: List<Produt> _db;
			// 2.2. Ex: Product item in _db
			// 3. The PrintAll() is called on this instance
			// 4. It goes to the implementation of PrintAll()
			// 5. When it gets to foreach Product item in _db it starts a loop
			// 6. In the loop we say item.GetInfo()
			// 6.1. What we are really doing is item( that is Product ).GetInfo()
			// 6.2. Since the item is Product, GetInfo() is called from the Product class

			// The same steps apply for Order or for any item that inherits from BaseEntity

			foreach (T item in _db)
			{
				// We can now use Id and GetInfo
				// When we didn't have "where T : BaseEntity", those were not accessible
				// We can access them because now we made sure that T has AT LEAST the properties or methods from BaseEntity
				// We can't call properties from Product or Order because the minimum that this Type guarantees are only Id and GetInfo()
				Console.WriteLine(item.GetInfo());
			}
		}
		public void Insert(T item)
		{
			_db.Add(item);
			Console.WriteLine($"Item was added in the {item.GetType().Name} Db!");
		}
		public T GetById(int id)
		{
			#region Singe, SingeOrDefault, First, FirstOrDefault
			// Single() -> Will try and return ONE item that it found a match for
			// Note: If there are no items that match, it will break
			// Note: If it has more matches it will brake
			// SingleOrDefault() -> Will try and return ONE item that it found a match for
			// Note: If there are no items that match, it will return null
			// Note: If it has more matches it will brake
			// First() -> Will try and return the first item it finds that has a match
			// Note: If there are no items that match, it will break
			// Note: It does not break if it finds multiple items, it just returns the first one
			// FirstOrDefault() -> Will try and return the first item it finds that has a match
			// Note: If there are no items that match, it wil return null
			// Note: It does not break if it finds multiple items, it just returns the first one
			#endregion
			return _db.SingleOrDefault(x => x.Id == id);
		}
		public void DeleteById(int id)
		{
			T item = _db.SingleOrDefault(x => x.Id == id);
			if(item == null)
			{
				Console.WriteLine("Item was not found!");
				return;
			}
			_db.Remove(item);
			Console.WriteLine("The item was deleted!");
		}
	}
}
