namespace forma.Services
{
    using forma.Models;

    public class UserService
    {
        private List<User> users;

        public UserService()
        {
            users = new List<User>();
        }

        public bool RegisterUser(string name, string email, string phoneNumber, string userName, string password)
        {
            // Check if user already exists
            if (users.Any(u => u.UserName == userName))
            {
                return false;
            }

            User newUser = new User(name, email, phoneNumber, userName, password);
            users.Add(newUser);
            return true;
        }

        public bool AuthenticateUser(string userName, string password)
        {
            return users.Any(u => u.UserName == userName && u.Password == password);
        }

        public User GetUser(string userName)
        {
            return users.FirstOrDefault(u => u.UserName == userName);
        }
    }
}