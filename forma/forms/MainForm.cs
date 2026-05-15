namespace forma.Forms
{
    using forma.Services;

    public partial class MainForm : Form
    {
        private UserService userService;
        private string currentUserName;

        public MainForm(UserService userService, string userName)
        {
            InitializeComponent();
            this.userService = userService;
            this.currentUserName = userName;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var user = userService.GetUser(currentUserName);
            if (user != null)
            {
                labelWelcome.Text = $"Welcome, {user.Name}!";
                labelUserInfo.Text = $"Username: {user.UserName}\nEmail: {user.Email}\nPhone: {user.PhoneNumber}";
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(userService);
            signUpForm.Show();
            this.Hide();
        }
    }
}