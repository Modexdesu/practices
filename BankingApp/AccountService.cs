using models;
using data;

namespace services
{
    // aq tviton aqauntis servisebi
    // Implements the IService interface with Account type
    public class AccountService : IService<Account>
    {
        // Add a new account to the system
        public void Add(Account account)
        {
            Database.Accounts.Add(account);
        }

        // Get all accounts from the system
        public List<Account> GetAll()
        {
            return Database.Accounts;
        }

        // Find a specific account by its ID
        public Account GetById(Guid id)
        {
            return Database.Accounts.FirstOrDefault(a => a.Id == id);
        }

        // Update an existing account (like changing balance or currency info)
        public void Update(Account account)
        {
            var existingAccount = GetById(account.Id);
            if (existingAccount != null)
            {
                existingAccount.Balance = account.Balance;
                existingAccount.Currency = account.Currency;
            }
        }

        // Remove an account from the system
        public void Delete(Account account)
        {
            Database.Accounts.Remove(account);
        }

        // Generate a unique account number in format: 0000000001GEL
        public string GenerateAccountNumber(string currency)
        {
            // Get the next number and increment counter
            int number = Database.AccountNumberCounter++;
            
            // Format as 10 digits with leading zeros, then add currency
            return number.ToString("D10") + currency;
        }

        // Get all accounts for a specific client
        public List<Account> GetAccountsByClientId(Guid clientId)
        {
            return Database.Accounts
                .Where(a => a.ClientId == clientId)
                .ToList();
        }
    }
}