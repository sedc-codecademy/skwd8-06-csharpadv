using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv06.MarketSubscription
{
	public class User
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public ProductType FavoriteType { get; set; }

		public void ReadPromotion(ProductType product)
		{
			Console.WriteLine($"Ms/Ms: {Name}, The product {product} is on sale!");
			if (product == FavoriteType) Console.WriteLine("Cool! My Favorite!");
		}
	}
}
