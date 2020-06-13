using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._03Generics.Entities
{
	// We have a non generic types for the DB classes
	public class NotGenericOrdersDb
	{
		private List<Order> _orders;
		public NotGenericOrdersDb()
		{
			_orders = new List<Order>();
		}
		public void PrintAll()
		{
			//... some code
		}
		public void Insert(Order order)
		{
			//... some code
		}
		public Order GetById(int id)
		{
			return new Order(); // some code
		}
		public void DeleteById(int id)
		{
			//... some code
		}
	}
	public class NotGenericProdutsDb
	{
		private List<Product> _produts;
		public NotGenericProdutsDb()
		{
			_produts = new List<Product>();
		}
		public void PrintAll()
		{
			//... some code
		}
		public void Insert(Product order)
		{
			//... some code
		}
		public Product GetById(int id)
		{
			return new Product(); // some code
		}
		public void DeleteById(int id)
		{
			//... some code
		}
	}
}
