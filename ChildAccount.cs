using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
	public class ChildAccount : Account
	{
		public ChildAccount(string name, int balance = 0) : base(name, balance)
		{
		}

		public override bool WithdrawFunds(int pAmount)
		{
			if(pAmount > 10)
			{
				return false;
			}
			return base.WithdrawFunds(pAmount);
		}
	}
}
