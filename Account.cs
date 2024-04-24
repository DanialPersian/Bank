using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
	public class Account
	{
		public int ID { get; private set; }
		public string Name { get; private set; }
		public int Balance { get; private set; }

		private static int nextID = 0;

		public Account(string name, int balance = 0)
		{
			if(name == null || name == String.Empty)
			{
				throw new Exception("null or empty name");
			}

			Balance = balance;
			ID = nextID;
			nextID++;
		}

		public virtual bool WithdrawFunds(int pAmount)
		{
			if(pAmount < 0)
			{
				return false;
			}

			if(Balance < pAmount)
			{
				return false;
			}

			Balance -= pAmount;

			return true;
		}

		public bool DepositFunds(int pAmount)
		{
			if(pAmount < 0)
			{
				return false;
			}

			Balance += pAmount;

			return true;
		}

		public override string ToString()
		{
			return $"{ID} - {Name} : {Balance}";
		}
	}
}
