using System;

namespace InternetStore
{
	/// <summary>
	/// Description of Sale.
	/// </summary>
	public class Sale
	{
		protected int NumOfTovar;
		
		protected Item Tovar;
		
		protected Payment Payment;
		
		public Sale(Item Item, Payment Payment, int NumPos)
		{
			this.Tovar = Item;
			this.Payment = Payment;
			this.NumOfTovar = NumPos;
		}
	}
}
