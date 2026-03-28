namespace models
{
    internal class Client
    {
        private string Name { get; set; }
        private string LastName { get; set; }

        private int phoneNumber { get; set; }
        private string PersonalNumber { get; set; }

        private Guid    ID { get; set; }

        private DateTime CreationDate { get; set; }

        private List<account> accounts { get; set; } = new List<account>();

        private class account
        {
            private int AccountNumber { get; set; }
            private string AccountType { get; set; }
            private string AccountName { get; set; }
            private decimal Balance { get; set; }
            private DateTime CreationDate { get; set; }

          //  public int Transfer();


            private class payments
            {
                private decimal Amount { get; set; }
                private string Currency { get; set; }
                private DateTime PaymentDate { get; set; }
                private string Description { get; set; }
            }
        }




    }
}
