namespace winquiz
{
    partial class Form1
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
            textBoxName = new TextBox();
            labelQuestionsCount = new Label();
            numericUpDownQuestionsCount = new NumericUpDown();
            buttonStart = new Button();
            labelQuestion = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            labelProgress = new Label();
            buttonNextQuestion = new Button();
            buttonFinishQuiz = new Button();
            labelResults = new Label();
            buttonPlayAgain = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuestionsCount).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitle.Location = new Point(200, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(269, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Quiz Application";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(50, 120);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(150, 115);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(300, 29);
            textBoxName.TabIndex = 2;
            // 
            // labelQuestionsCount
            // 
            labelQuestionsCount.AutoSize = true;
            labelQuestionsCount.Font = new Font("Segoe UI", 12F);
            labelQuestionsCount.Location = new Point(30, 176);
            labelQuestionsCount.Name = "labelQuestionsCount";
            labelQuestionsCount.Size = new Size(163, 21);
            labelQuestionsCount.TabIndex = 3;
            labelQuestionsCount.Text = "Number of Questions:";
            // 
            // numericUpDownQuestionsCount
            // 
            numericUpDownQuestionsCount.Location = new Point(200, 165);
            numericUpDownQuestionsCount.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownQuestionsCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuestionsCount.Name = "numericUpDownQuestionsCount";
            numericUpDownQuestionsCount.Size = new Size(100, 23);
            numericUpDownQuestionsCount.TabIndex = 4;
            numericUpDownQuestionsCount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Green;
            buttonStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(200, 230);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(150, 40);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start Quiz";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += ButtonStart_Click;
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelQuestion.Location = new Point(30, 30);
            labelQuestion.MaximumSize = new Size(700, 0);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(0, 25);
            labelQuestion.TabIndex = 6;
            labelQuestion.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11F);
            radioButton1.Location = new Point(50, 120);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 7;
            radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 11F);
            radioButton2.Location = new Point(50, 160);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 8;
            radioButton2.Visible = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 11F);
            radioButton3.Location = new Point(50, 200);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 9;
            radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 11F);
            radioButton4.Location = new Point(50, 240);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(14, 13);
            radioButton4.TabIndex = 10;
            radioButton4.Visible = false;
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Font = new Font("Segoe UI", 10F);
            labelProgress.Location = new Point(30, 300);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(0, 19);
            labelProgress.TabIndex = 11;
            labelProgress.Visible = false;
            // 
            // buttonNextQuestion
            // 
            buttonNextQuestion.BackColor = Color.Blue;
            buttonNextQuestion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonNextQuestion.ForeColor = Color.White;
            buttonNextQuestion.Location = new Point(300, 320);
            buttonNextQuestion.Name = "buttonNextQuestion";
            buttonNextQuestion.Size = new Size(150, 35);
            buttonNextQuestion.TabIndex = 12;
            buttonNextQuestion.Text = "Next";
            buttonNextQuestion.UseVisualStyleBackColor = false;
            buttonNextQuestion.Visible = false;
            buttonNextQuestion.Click += ButtonNextQuestion_Click;
            // 
            // buttonFinishQuiz
            // 
            buttonFinishQuiz.BackColor = Color.Red;
            buttonFinishQuiz.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonFinishQuiz.ForeColor = Color.White;
            buttonFinishQuiz.Location = new Point(470, 320);
            buttonFinishQuiz.Name = "buttonFinishQuiz";
            buttonFinishQuiz.Size = new Size(150, 35);
            buttonFinishQuiz.TabIndex = 13;
            buttonFinishQuiz.Text = "Finish";
            buttonFinishQuiz.UseVisualStyleBackColor = false;
            buttonFinishQuiz.Visible = false;
            buttonFinishQuiz.Click += ButtonFinishQuiz_Click;
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelResults.Location = new Point(200, 150);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(0, 37);
            labelResults.TabIndex = 14;
            labelResults.TextAlign = ContentAlignment.TopCenter;
            labelResults.Visible = false;
            // 
            // buttonPlayAgain
            // 
            buttonPlayAgain.BackColor = Color.Green;
            buttonPlayAgain.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonPlayAgain.ForeColor = Color.White;
            buttonPlayAgain.Location = new Point(235, 361);
            buttonPlayAgain.Name = "buttonPlayAgain";
            buttonPlayAgain.Size = new Size(300, 40);
            buttonPlayAgain.TabIndex = 15;
            buttonPlayAgain.Text = "Play Again";
            buttonPlayAgain.UseVisualStyleBackColor = false;
            buttonPlayAgain.Visible = false;
            buttonPlayAgain.Click += ButtonPlayAgain_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTitle);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelQuestionsCount);
            Controls.Add(numericUpDownQuestionsCount);
            Controls.Add(buttonStart);
            Controls.Add(labelQuestion);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton4);
            Controls.Add(labelProgress);
            Controls.Add(buttonNextQuestion);
            Controls.Add(buttonFinishQuiz);
            Controls.Add(labelResults);
            Controls.Add(buttonPlayAgain);
            Name = "Form1";
            Text = "Quiz Application";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuestionsCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code
        #endregion

        private Label labelTitle;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelQuestionsCount;
        private NumericUpDown numericUpDownQuestionsCount;
        private Button buttonStart;
        private Label labelQuestion;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label labelProgress;
        private Button buttonNextQuestion;
        private Button buttonFinishQuiz;
        private Label labelResults;
        private Button buttonPlayAgain;
    }
}

