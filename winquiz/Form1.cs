namespace winquiz
{
    public partial class Form1 : Form
    {
        private List<Question> allQuestions;
        private List<Question> currentQuiz;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private string playerName = "";

        public Form1()
        {
            InitializeComponent();
            allQuestions = new List<Question>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load questions from file - look in current directory and bin folder
            string questionFilePath = "questions.txt";

            // If not found in current directory, try the bin folder
            if (!File.Exists(questionFilePath))
            {
                questionFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "questions.txt");
            }

            allQuestions = QuestionLoader.LoadQuestions(questionFilePath);

            if (allQuestions.Count == 0)
            {
                MessageBox.Show("Could not load questions. Make sure questions.txt exists in:\n" + 
                    Path.GetDirectoryName(Path.GetFullPath(questionFilePath)));
            }
        }

        // START QUIZ BUTTON
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            if (allQuestions.Count == 0)
            {
                MessageBox.Show("No questions available.");
                return;
            }

            playerName = textBoxName.Text;
            int questionCount = (int)numericUpDownQuestionsCount.Value;

            // Make sure we don't ask for more questions than available
            if (questionCount > allQuestions.Count)
            {
                questionCount = allQuestions.Count;
            }

            // Randomly select questions
            Random random = new Random();
            currentQuiz = new List<Question>();
            List<int> usedIndices = new List<int>();

            for (int i = 0; i < questionCount; i++)
            {
                int randomIndex;
                do
                {
                    randomIndex = random.Next(allQuestions.Count);
                } while (usedIndices.Contains(randomIndex));

                usedIndices.Add(randomIndex);
                currentQuiz.Add(allQuestions[randomIndex]);
            }

            // Hide start screen
            HideStartScreen();

            // Show quiz screen
            ShowQuizScreen();

            // Load first question
            currentQuestionIndex = 0;
            score = 0;
            LoadQuestion();
        }

        // NEXT QUESTION BUTTON
        private void ButtonNextQuestion_Click(object sender, EventArgs e)
        {
            int selectedAnswer = GetSelectedAnswer();

            if (selectedAnswer == -1)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            // Check if answer is correct
            if (selectedAnswer == currentQuiz[currentQuestionIndex].CorrectAnswerIndex)
            {
                score += currentQuiz[currentQuestionIndex].Points;
            }

            currentQuestionIndex++;

            if (currentQuestionIndex >= currentQuiz.Count)
            {
                ShowResults();
            }
            else
            {
                LoadQuestion();
            }
        }

        // FINISH QUIZ BUTTON
        private void ButtonFinishQuiz_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to finish the quiz?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ShowResults();
            }
        }

        // PLAY AGAIN BUTTON
        private void ButtonPlayAgain_Click(object sender, EventArgs e)
        {
            ShowStartScreen();
        }

        // Helper: Load and display current question
        private void LoadQuestion()
        {
            Question q = currentQuiz[currentQuestionIndex];

            // Show question text
            labelQuestion.Text = $"Q{currentQuestionIndex + 1}: {q.Text}";
            labelQuestion.Visible = true;

            // Show answer options
            radioButton1.Text = q.Answers[0];
            radioButton1.Checked = false;
            radioButton1.Visible = true;

            radioButton2.Text = q.Answers[1];
            radioButton2.Checked = false;
            radioButton2.Visible = true;

            radioButton3.Text = q.Answers[2];
            radioButton3.Checked = false;
            radioButton3.Visible = true;

            radioButton4.Text = q.Answers[3];
            radioButton4.Checked = false;
            radioButton4.Visible = true;

            // Show progress
            labelProgress.Text = $"Question {currentQuestionIndex + 1} of {currentQuiz.Count}";
            labelProgress.Visible = true;

            // Show buttons
            buttonNextQuestion.Visible = true;
            buttonFinishQuiz.Visible = true;
        }

        // Helper: Get selected answer index
        private int GetSelectedAnswer()
        {
            if (radioButton1.Checked) return 0;
            if (radioButton2.Checked) return 1;
            if (radioButton3.Checked) return 2;
            if (radioButton4.Checked) return 3;
            return -1;
        }

        // Helper: Show results screen
        private void ShowResults()
        {
            HideQuizScreen();

            int totalPoints = 0;
            foreach (Question q in currentQuiz)
            {
                totalPoints += q.Points;
            }

            labelResults.Text = $"Quiz Finished!\n\n{playerName}, your score:\n{score}/{totalPoints}";
            labelResults.Visible = true;
            buttonPlayAgain.Visible = true;
        }

        // Helper: Hide start screen
        private void HideStartScreen()
        {
            labelTitle.Visible = false;
            labelName.Visible = false;
            textBoxName.Visible = false;
            labelQuestionsCount.Visible = false;
            numericUpDownQuestionsCount.Visible = false;
            buttonStart.Visible = false;
        }

        // Helper: Show start screen
        private void ShowStartScreen()
        {
            labelTitle.Visible = true;
            labelName.Visible = true;
            textBoxName.Visible = true;
            textBoxName.Text = "";
            labelQuestionsCount.Visible = true;
            numericUpDownQuestionsCount.Visible = true;
            numericUpDownQuestionsCount.Value = 5;
            buttonStart.Visible = true;

            HideQuizScreen();
            HideResults();
        }

        // Helper: Show quiz screen
        private void ShowQuizScreen()
        {
            labelQuestion.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            labelProgress.Visible = true;
            buttonNextQuestion.Visible = true;
            buttonFinishQuiz.Visible = true;
        }

        // Helper: Hide quiz screen
        private void HideQuizScreen()
        {
            labelQuestion.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            labelProgress.Visible = false;
            buttonNextQuestion.Visible = false;
            buttonFinishQuiz.Visible = false;
        }

        // Helper: Hide results screen
        private void HideResults()
        {
            labelResults.Visible = false;
            buttonPlayAgain.Visible = false;
        }
    }
}
