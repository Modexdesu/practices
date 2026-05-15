namespace forma.Forms
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelName = new Label();
            textBoxForName = new TextBox();
            labelEmail = new Label();
            textBoxForEmail = new TextBox();
            labelPhoneNumber = new Label();
            textBoxForPhoneNumber = new TextBox();
            labelUserName = new Label();
            textBoxForUserName = new TextBox();
            labelPassword = new Label();
            textBoxForPassword = new TextBox();
            buttonRegister = new Button();
            buttonLoginHere = new Button();
            SuspendLayout();

            // labelTitle
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.Location = new Point(150, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(100, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Sign Up";

            // labelName
            labelName.AutoSize = true;
            labelName.Location = new Point(50, 80);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";

            // textBoxForName
            textBoxForName.Location = new Point(50, 100);
            textBoxForName.Name = "textBoxForName";
            textBoxForName.Size = new Size(300, 23);
            textBoxForName.TabIndex = 2;

            // labelEmail
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(50, 140);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Email:";

            // textBoxForEmail
            textBoxForEmail.Location = new Point(50, 160);
            textBoxForEmail.Name = "textBoxForEmail";
            textBoxForEmail.Size = new Size(300, 23);
            textBoxForEmail.TabIndex = 4;

            // labelPhoneNumber
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(50, 200);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(84, 15);
            labelPhoneNumber.TabIndex = 5;
            labelPhoneNumber.Text = "Phone Number:";

            // textBoxForPhoneNumber
            textBoxForPhoneNumber.Location = new Point(50, 220);
            textBoxForPhoneNumber.Name = "textBoxForPhoneNumber";
            textBoxForPhoneNumber.Size = new Size(300, 23);
            textBoxForPhoneNumber.TabIndex = 6;

            // labelUserName
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(50, 260);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(60, 15);
            labelUserName.TabIndex = 7;
            labelUserName.Text = "Username:";

            // textBoxForUserName
            textBoxForUserName.Location = new Point(50, 280);
            textBoxForUserName.Name = "textBoxForUserName";
            textBoxForUserName.Size = new Size(300, 23);
            textBoxForUserName.TabIndex = 8;

            // labelPassword
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(50, 320);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password:";

            // textBoxForPassword
            textBoxForPassword.Location = new Point(50, 340);
            textBoxForPassword.Name = "textBoxForPassword";
            textBoxForPassword.PasswordChar = '*';
            textBoxForPassword.Size = new Size(300, 23);
            textBoxForPassword.TabIndex = 10;

            // buttonRegister
            buttonRegister.Location = new Point(50, 400);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(140, 40);
            buttonRegister.TabIndex = 11;
            buttonRegister.Text = "Register Now";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;

            // buttonLoginHere
            buttonLoginHere.Location = new Point(210, 400);
            buttonLoginHere.Name = "buttonLoginHere";
            buttonLoginHere.Size = new Size(140, 40);
            buttonLoginHere.TabIndex = 12;
            buttonLoginHere.Text = "Login Here";
            buttonLoginHere.UseVisualStyleBackColor = true;
            buttonLoginHere.Click += buttonLoginHere_Click;

            // SignUpForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 500);
            Controls.Add(labelTitle);
            Controls.Add(labelName);
            Controls.Add(textBoxForName);
            Controls.Add(labelEmail);
            Controls.Add(textBoxForEmail);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxForPhoneNumber);
            Controls.Add(labelUserName);
            Controls.Add(textBoxForUserName);
            Controls.Add(labelPassword);
            Controls.Add(textBoxForPassword);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLoginHere);
            Name = "SignUpForm";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelTitle;
        private Label labelName;
        private TextBox textBoxForName;
        private Label labelEmail;
        private TextBox textBoxForEmail;
        private Label labelPhoneNumber;
        private TextBox textBoxForPhoneNumber;
        private Label labelUserName;
        private TextBox textBoxForUserName;
        private Label labelPassword;
        private TextBox textBoxForPassword;
        private Button buttonRegister;
        private Button buttonLoginHere;
    }
}