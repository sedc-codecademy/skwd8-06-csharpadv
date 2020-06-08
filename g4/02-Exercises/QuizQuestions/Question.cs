using System;
using System.Collections.Generic;

namespace QuizQuestions
{
    public class Question
    {
        public string Text { get; set; }

        public List<string> Answers { get; set; }

        internal string CorrectAnswer { get; set; }
    }
}
