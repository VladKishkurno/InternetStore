using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InternetStore
{
	class Program
	{
		public static Catalog GetListProducts()
		{
			var ListProducts = new List<Item> ();
			var Catalog = new Catalog();
			
			for(int i = 0; i < 10; i++)
			{
				if(i == 5)
				ListProducts.Add( new Item (1,  "0" , "0", "0") );
				else ListProducts.Add( new Item (i,  "0" , "0", "0") );
			}
			
			Catalog.Add(ListProducts);
			
			return Catalog;
		}
		
		public static void Main(string[] args)
		{
			var Store = new Store();
			var Customer = new Customer("Name", "Adress", "afacacs");
			Store.Add(GetListProducts());
			
			Store.Buy(Store.Catal.Get(5), Customer);
			
			Store.Compare(Store.Catal.Get(1), Store.Catal.Get(5));
			Store.Compare(Store.Catal.Get(8), Store.Catal.Get(4));
			
			Console.ReadKey();
		}
	}
}