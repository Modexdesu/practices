namespace models
{
    public class Payment
    {
        // Unique identifier for the payment/transaction
        public Guid Id { get; }
        
        // The account that is sending the money
        public Guid FromAccountId { get; set; }
        
        // The account that is receiving the money
        public Guid ToAccountId { get; set; }
        
        // How much money was transferred
        public decimal Amount { get; set; }
        
        // The currency of the transaction
        public string Currency { get; set; }
        
        // Description of why the money was sent
        public string Purpose { get; set; }
        
        // When the transaction happened
        public DateTime CreatedOn { get; }

        // Constructor - 
        public Payment(Guid fromAccountId, Guid toAccountId, decimal amount, string currency, string purpose)
        {
            Id = Guid.NewGuid();
            FromAccountId = fromAccountId;
            ToAccountId = toAccountId;
            Amount = amount;
            Currency = currency;
            Purpose = purpose;
            CreatedOn = DateTime.UtcNow;
        }
        namespace models
    {
        public class Payment
        {

     
            public string Proof { get; set; }

            // Constructor 
            public Payment(Guid fromAccountId, Guid toAccountId, decimal amount, string currency, string purpose)
            {
                Id = Guid.NewGuid();
                FromAccountId = fromAccountId;
                ToAccountId = toAccountId;
                Amount = amount;
                Currency = currency;
                Purpose = purpose;
                CreatedOn = DateTime.UtcNow;
                Proof = string.Empty; // Will be set by PaymentService
            }
        }
    }
}
}