namespace models
{
    public class Account
    {
        // Unique identifier
        public Guid Id { get; }
        
        // The client 
        public Guid ClientId { get; }
        
        // Account number in format: 0000000001GEL 
        public string AccountNumber { get; }
        
        // The currency 
        public string Currency { get; set; }
        
        // How much money 
        public decimal Balance { get; set; }
        
        // account was created
        public DateTime CreatedOn { get; }

        // Constructor 
        public Account(Guid clientId, string accountNumber, string currency, decimal initialBalance = 0)
        {
            Id = Guid.NewGuid();
            ClientId = clientId;
            AccountNumber = accountNumber;
            Currency = currency;
            Balance = initialBalance;
            CreatedOn = DateTime.UtcNow;
        }
    }
}