using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore
{
	/// <summary>
	/// Description of Catalog.
	/// </summary>
	public class Catalog
	{	
		
		protected List<Item> Items;
		
		 public void Add(List<Item> Items)
        {
             if (this.Items == null) this.Items = new List<Item>();
             this.Items.AddRange(Items);    
        }
		 
		 public Item Get(int i)
		 {
		 	return this.Items[i];
		 }
		 
	}
}
