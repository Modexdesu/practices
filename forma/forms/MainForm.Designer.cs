namespace forma.Forms
{
    partial class MainForm
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
            labelWelcome = new Label();
            labelUserInfo = new Label();
            buttonLogOut = new Button();
            SuspendLayout();

            // labelWelcome
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelWelcome.Location = new Point(80, 50);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(100, 32);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome!";

            // labelUserInfo
            labelUserInfo.AutoSize = true;
            labelUserInfo.Location = new Point(50, 120);
            labelUserInfo.Name = "labelUserInfo";
            labelUserInfo.Size = new Size(100, 15);
            labelUserInfo.TabIndex = 1;
            labelUserInfo.Text = "User Information";

            // buttonLogOut
            buttonLogOut.Location = new Point(140, 250);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(120, 40);
            buttonLogOut.TabIndex = 2;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;

            // MainForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 350);
            Controls.Add(labelWelcome);
            Controls.Add(labelUserInfo);
            Controls.Add(buttonLogOut);
            Name = "MainForm";
            Text = "Dashboard";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelWelcome;
        private Label labelUserInfo;
        private Button buttonLogOut;
    }
}