using System;

namespace InternetStore
{
	/// <summary>
	/// Description of Payment.
	/// </summary>
	public class Payment
	{
	    public enum PayFrom
		{
			ByMoney = 1,
			ByCard = 2,
		}
		
	    protected PayFrom Pay;
		protected Customer CustomerDate;
		
		public Payment(PayFrom PayFrom, Customer CustomerDate)
		{
			this.Pay = PayFrom;
			this.CustomerDate = CustomerDate;
		}
	}
}
