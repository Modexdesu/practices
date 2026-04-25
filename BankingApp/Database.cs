using models;

namespace data
{
    // databaza ra amdens mixvdebi kaci
    // All data is stored in static List collections
    public static class Database
    {
        // Storage for all clients
        public static List<Client> Clients { get; } = new();
        
        // Storage for all accounts
        public static List<Account> Accounts { get; } = new();
        
        // Storage for all payments/transactions
        public static List<Payment> Payments { get; } = new();
        
        // Counter to generate unique account numbers (starts at 1 and increments)
        public static int AccountNumberCounter { get; set; } = 1;
    }
}