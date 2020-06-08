using System;
using System.Collections.Generic;
using System.Text;

namespace QuizUserManagement
{
    public class Student: User
    {
        public bool FinishedQuiz { get; internal set; }
        public int? Score { get; internal set; }

        internal Student()
        {

        }
    }
}
