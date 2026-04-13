namespace models
{
    public class Client
    {
        public Guid ID { get; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string PersonalNumber { get; set; }
        public DateTime CreationDate { get; }

        public List<Account> Accounts { get; private set; } = new();

        public Client(string name, string lastName, int phoneNumber, string personalNumber)
        {
            ID = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            PersonalNumber = personalNumber;
            CreationDate = DateTime.UtcNow;
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
    }
}
