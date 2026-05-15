namespace forma.Forms
{
    partial class LoginForm
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
            labelUserName = new Label();
            textBoxForUserName = new TextBox();
            labelPassword = new Label();
            textBoxForPassword = new TextBox();
            buttonLogin = new Button();
            buttonRegisterNow = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(150, 50);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(96, 34);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Login";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(50, 120);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(63, 15);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "Username:";
            // 
            // textBoxForUserName
            // 
            textBoxForUserName.BackColor = SystemColors.InactiveCaption;
            textBoxForUserName.Location = new Point(50, 140);
            textBoxForUserName.Name = "textBoxForUserName";
            textBoxForUserName.Size = new Size(300, 23);
            textBoxForUserName.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(50, 180);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // textBoxForPassword
            // 
            textBoxForPassword.BackColor = SystemColors.InactiveCaption;
            textBoxForPassword.Location = new Point(50, 200);
            textBoxForPassword.Name = "textBoxForPassword";
            textBoxForPassword.PasswordChar = '*';
            textBoxForPassword.Size = new Size(300, 23);
            textBoxForPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.HotTrack;
            buttonLogin.Location = new Point(50, 260);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(140, 40);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRegisterNow
            // 
            buttonRegisterNow.BackColor = SystemColors.MenuBar;
            buttonRegisterNow.Location = new Point(210, 260);
            buttonRegisterNow.Name = "buttonRegisterNow";
            buttonRegisterNow.Size = new Size(140, 40);
            buttonRegisterNow.TabIndex = 6;
            buttonRegisterNow.Text = "Register Now";
            buttonRegisterNow.UseVisualStyleBackColor = false;
            buttonRegisterNow.Click += buttonRegisterNow_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(400, 350);
            Controls.Add(labelTitle);
            Controls.Add(labelUserName);
            Controls.Add(textBoxForUserName);
            Controls.Add(labelPassword);
            Controls.Add(textBoxForPassword);
            Controls.Add(buttonLogin);
            Controls.Add(buttonRegisterNow);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelTitle;
        private Label labelUserName;
        private TextBox textBoxForUserName;
        private Label labelPassword;
        private TextBox textBoxForPassword;
        private Button buttonLogin;
        private Button buttonRegisterNow;
    }
}