namespace winquiz
{
    public class QuestionLoader
    {
        public static List<Question> LoadQuestions(string filePath)
        {
            List<Question> questions = new List<Question>();

            if (!File.Exists(filePath))
            {
                return questions;  
            }

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();

              
                if (string.IsNullOrEmpty(line) || line.StartsWith("#"))
                    continue;

               

                string[] parts = line.Split('|');

                if (parts.Length >= 6)  
                {
                    Question q = new Question
                    {
                        Text = parts[0].Trim(),
                        Answers = new string[]
                        {
                            parts[1].Trim(),
                            parts[2].Trim(),
                            parts[3].Trim(),
                            parts[4].Trim()
                        },
                        CorrectAnswerIndex = int.Parse(parts[5].Trim()),
                        Points = parts.Length > 6 ? int.Parse(parts[6].Trim()) : 1
                    };

                    questions.Add(q);
                }
            }

            return questions;
        }
    }
}
