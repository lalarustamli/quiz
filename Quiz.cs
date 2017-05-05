namespace IntellectualQuiz
{
    public class Quiz
    {
        public int number;
        public string question;
        public string[] answers;
        public string correct;
        public Quiz(int number, string question, string answers, string correct)
        {
            this.number = number;
            this.question = question;
            this.answers = answers.Split(',');
            this.correct = correct;

        }
    }

}
