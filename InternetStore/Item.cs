using System;

namespace InternetStore
{
	/// <summary>
	/// Description of Item.
	/// </summary>
	public class Item : Product
	{
		
		public int Price;
		
		
		public Item( int Price, string Name, string Photo, string Description)
		{
			this.Price = Price;
			
			base.Name = Name;
			base.Photo = Photo;
			base.Description = Description;			
		}
		
		public static bool operator < (Item Item1, Item Item2)
        {
        	return Item1.Price < Item2.Price;
        }
        
        public static bool operator > (Item Item1, Item Item2)
        {
        	return Item1.Price > Item2.Price;
        }
                
        public static bool operator == (Item Item1, Item Item2)
        {
        	return Item1.Price == Item2.Price;
        }
        
        public static bool operator != (Item Item1, Item Item2)
        {
        	return Item1.Price != Item2.Price;
        }
		
	}
}
