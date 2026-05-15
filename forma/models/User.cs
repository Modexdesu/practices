namespace forma.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string name, string email, string phoneNumber, string userName, string password)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            UserName = userName;
            Password = password;
        }
    }
}