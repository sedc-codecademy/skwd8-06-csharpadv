using System;
using System.Collections.Generic;
using System.Text;

namespace QuizQuestions
{
    public class QuestionRepository
    {
        public bool CheckQuestion(Question question, string answer)
        {
            return question.CorrectAnswer == answer;
        }

        public List<Question> GetQuestions()
        {
            return new List<Question>
            {
                new Question
                {
                    Text = "Who wrote Mozard's Third Symphony?",
                    Answers = new List<string>
                    {
                        "Ludwig van Beethoven",
                        "Wolfgang Amadeus Mozart",
                        "Carl Friedrich Abel",
                        "Johann Sebastian Bach"
                    },
                    CorrectAnswer = "Carl Friedrich Abel"
                },
                new Question
                {
                    Text = "What animals are the Canary Islands named for?",
                    Answers = new List<string>
                    {
                        "Dogs",
                        "Canaries",
                        "Giraffes",
                        "Lions"
                    },
                    CorrectAnswer = "Dogs"
                },
                new Question
                {
                    Text = "In which month did the October revolution happen?",
                    Answers = new List<string>
                    {
                        "January",
                        "October",
                        "November",
                        "September"
                    },
                    CorrectAnswer = "November"
                },
                new Question
                {
                    Text = "What was King George VI's first name?",
                    Answers = new List<string>
                    {
                        "George",
                        "James",
                        "Henry",
                        "Albert"
                    },
                    CorrectAnswer = "Albert"
                },
                new Question
                {
                    Text = "Which country makes Panama hats?",
                    Answers = new List<string>
                    {
                        "Panama",
                        "Guatemala",
                        "Equador",
                        "Brazil"
                    },
                    CorrectAnswer = "Equador"
                }
            };
        }
    }
}
