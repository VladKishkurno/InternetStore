using System;

namespace InternetStore
{
	/// <summary>
	/// Description of Customer.
	/// </summary>
	public class Customer
	{
		public string Name;
		public string Adress;
		public string PhoneNumber;
		
		public Customer( string Name, string Adress, string PhoneNumber)
		{
			this.Name = Name; 
			this.Adress = Adress;
			this.PhoneNumber = PhoneNumber;
		}
	}
}
