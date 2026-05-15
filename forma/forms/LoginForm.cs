namespace forma.Forms
{
    using forma.Services;

    public partial class LoginForm : Form
    {
        private UserService userService;

        public LoginForm(UserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxForUserName.Text.Trim();
            string password = textBoxForPassword.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userService.AuthenticateUser(userName, password))
            {
                MessageBox.Show($"Welcome, {userName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                OpenMainForm(userName);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegisterNow_Click(object sender, EventArgs e)
        {
            OpenSignUpForm();
        }

        private void ClearFields()
        {
            textBoxForUserName.Clear();
            textBoxForPassword.Clear();
        }

        private void OpenSignUpForm()
        {
            SignUpForm signUpForm = new SignUpForm(userService);
            signUpForm.Show();
            this.Hide();
        }

        private void OpenMainForm(string userName)
        {
            MainForm mainForm = new MainForm(userService, userName);
            mainForm.Show();
            this.Hide();
        }
    }
}