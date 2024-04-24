namespace BankLibrary
{
	public class Bank
	{
		private List<Account> accounts = new List<Account>();

		public Account? GetAccountByID(int id)
		{
			foreach(Account account in accounts)
			{
				if(account.ID == id)
				{
					return account;
				}
			}
			return null;
		}

		public List<Account> GetAccountsByName(string name)
		{
			List<Account> results = new List<Account>();
			
			foreach(Account account in accounts)
			{
				if(account.Name == name)
				{
					results.Add(account);
				}
			}
			return accounts;
		}

		public bool AddNewAccount(Account newAccount)
		{
			foreach(Account account in accounts)
			{
				if(account.ID == newAccount.ID) { return false; }
			}

			accounts.Add(newAccount);
			return true;
		}

		public int GetTotalMoney()
		{
			int totalMoney = 0;
			foreach (Account account in accounts)
			{
				totalMoney += account.Balance;
			}
			return totalMoney;
		}
	}
}
