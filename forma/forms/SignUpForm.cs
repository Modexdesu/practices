namespace forma.Forms
{
    using forma.Services;

    public partial class SignUpForm : Form
    {
        private UserService userService;

        public SignUpForm(UserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxForName.Text.Trim();
            string email = textBoxForEmail.Text.Trim();
            string phoneNumber = textBoxForPhoneNumber.Text.Trim();
            string userName = textBoxForUserName.Text.Trim();
            string password = textBoxForPassword.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(userName) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userService.RegisterUser(name, email, phoneNumber, userName, password))
            {
                MessageBox.Show("Registration successful! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                OpenLoginForm();
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose another.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoginHere_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void ClearFields()
        {
            textBoxForName.Clear();
            textBoxForEmail.Clear();
            textBoxForPhoneNumber.Clear();
            textBoxForUserName.Clear();
            textBoxForPassword.Clear();
        }

        private void OpenLoginForm()
        {
            LoginForm loginForm = new LoginForm(userService);
            loginForm.Show();
            this.Hide();
        }
    }
}