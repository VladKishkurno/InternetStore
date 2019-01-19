using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore
{
	/// <summary>
	/// Description of Store.
	/// </summary>
	public class Store
	{
		
		//protected List<Product> Products = new List<Product>();
		public Catalog Catal;
		
        public void Add(Catalog Catal)
        {
             this.Catal = Catal;
        }
        
        public void Buy(Item It, Customer CustomerDate)
        {
        	int PayFrom = 1;
        	int NumPos = 2;
        	Payment Pay = new Payment((Payment.PayFrom) PayFrom  ,CustomerDate);
        	Sale Sale = new Sale(It, Pay, NumPos);
        }
        
        public void Compare(Item It1, Item It2)
        {
        	if(It1 == It2) 
        	{
        		Console.WriteLine(It1.Price + " == " + It2.Price);
        	}
        	if(It1 > It2) Console.WriteLine(It1.Price + " > " + It2.Price);
        	if(It1 < It2) Console.WriteLine(It1.Price + " < " + It2.Price);
        	if(It1 != It2) Console.WriteLine(It1.Price + " != " + It2.Price);
        }
        
	}
}
