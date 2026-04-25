using models;
using data;

namespace services
{
    //  gadaxda-gadaricxvis serisebi


    // Implements the IService interface with Payment type
    public class PaymentService : IService<Payment>
    {
        private AccountService accountService = new();

        // Add a new payment record to the system
        public void Add(Payment payment)
        {
            Database.Payments.Add(payment);
        }

        // Get all payments from the system
        public List<Payment> GetAll()
        {
            return Database.Payments;
        }

        // Find a specific payment by its ID
        public Payment GetById(Guid id)
        {
            return Database.Payments.FirstOrDefault(p => p.Id == id);
        }

        // Update an existing payment record
        public void Update(Payment payment)
        {
            var existingPayment = GetById(payment.Id);
            if (existingPayment != null)
            {
                existingPayment.Amount = payment.Amount;
                existingPayment.Purpose = payment.Purpose;
            }
        }

        // Remove a payment record from the system
        public void Delete(Payment payment)
        {
            Database.Payments.Remove(payment);
        }

        // Process a payment between two accounts
        // Returns true if successful, false if validation fails
        public bool ProcessPayment(Guid fromAccountId, Guid toAccountId, decimal amount, string purpose)
        {
            // Get the sending and receiving accounts
            var fromAccount = accountService.GetById(fromAccountId);
            var toAccount = accountService.GetById(toAccountId);

            // Check if both accounts exist
            if (fromAccount == null || toAccount == null)
            {
                Console.WriteLine("Error: One or both accounts don't exist.");
                return false;
            }

            // Check if both accounts use the same currency
            if (fromAccount.Currency != toAccount.Currency)
            {
                Console.WriteLine("Error: Accounts must have the same currency to transfer money.");
                return false;
            }

            // Check if the sending account has enough balance
            if (fromAccount.Balance < amount)
            {
                Console.WriteLine("Error: Insufficient funds. Cannot transfer.");
                return false;
            }

            // remove money
            fromAccount.Balance -= amount;
            
            // Add money
            toAccount.Balance += amount;

            // Create and store the payment record
            var payment = new Payment(fromAccountId, toAccountId, amount, fromAccount.Currency, purpose);
            Add(payment);

            Console.WriteLine($"Payment successful: {amount} {fromAccount.Currency} transferred.");
            return true;

            public bool ProcessPayment(Guid fromAccountId, Guid toAccountId, decimal amount, string purpose)
        {
            // ... existing validation code ...

            // Create the payment record
            var payment = new Payment(fromAccountId, toAccountId, amount, fromAccount.Currency, purpose);

            // Generate and save the proof to the payment
            payment.Proof = GenerateTransactionProof(payment);

            Add(payment);

            Console.WriteLine($"Payment successful: {amount} {fromAccount.Currency} transferred.");
            return true;
        }
        }

        // Get all transactions for a specific account (last n transactions)
        public List<Payment> GetAccountTransactionHistory(Guid accountId, int numberOfTransactions = 10)
        {
            return Database.Payments
                .Where(p => p.FromAccountId == accountId || p.ToAccountId == accountId)
                .OrderByDescending(p => p.CreatedOn)
                .Take(numberOfTransactions)
                .ToList();
        }
        // Generate a transaction proof sentence with actual account data
        public string GenerateTransactionProof(Payment payment)
        {
            var fromAccount = accountService.GetById(payment.FromAccountId);
            var toAccount = accountService.GetById(payment.ToAccountId);

            if (fromAccount == null || toAccount == null)
            {
                return "Error: - account not found.";
            }

            return $"{fromAccount.AccountNumber} transferred {payment.Amount} to {toAccount.AccountNumber} on {payment.CreatedOn} in the currency '{payment.Currency}'";
        }
    }
}