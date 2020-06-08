using System;
using System.Collections.Generic;
using System.Text;

namespace QuizUserManagement
{
    public class Student: User
    {
        public bool FinishedQuiz { get; set; }
        public int? Score { get; set; }

        internal Student()
        {

        }
    }
}
