namespace winquiz
{
    public class Question
    {
        public string Text { get; set; } = "";
        public string[] Answers { get; set; } = new string[] { };
        public int CorrectAnswerIndex { get; set; } = 0;  // Index of correct answer (0-3)
        public int Points { get; set; } = 1;
    }
}
