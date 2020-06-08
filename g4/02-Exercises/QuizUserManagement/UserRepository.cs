using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizUserManagement
{
    public class UserRepository
    {
        private readonly List<User> users = new List<User>();

        public User? Login(string username, string password)
        {
            var candidateUser = users.SingleOrDefault(user => user.UserName == username);
            if (candidateUser == null)
            {
                return null;
            }
            if (candidateUser.Password == password)
            {
                return candidateUser;
            }
            else
            {
                return null;
            }
        }
 
        public UserRepository()
        {
            users.Add(new Student { FirstName = "Aleksandar", LastName = "Jangelovski", UserName = "alex", Password = "alex" });
            users.Add(new Student { FirstName = "Petre", LastName = "Arsovski", UserName = "petre", Password = "petre" });
            users.Add(new Student { FirstName = "Blagoja", LastName = "Grozdanovski", UserName = "bazejbt", Password = "bazejbt" });
            users.Add(new Student { FirstName = "Deni", LastName = "Stojanovski", UserName = "deni", Password = "deni" });
            users.Add(new Student { FirstName = "Katerina", LastName = "Atanasoska", UserName = "kate", Password = "kate" });

            users.Add(new Teacher { FirstName = "Wekoslav", LastName = "Stefanovski", UserName = "swekster", Password = "swekster" });
            users.Add(new Teacher { FirstName = "Kristina", LastName = "Spasevska", UserName = "kiki", Password = "kiki" });
        }

        public IEnumerable<Student> GetStudents()
        {
            return users.OfType<Student>();
        }

        public void ClearStudentScore(Student student)
        {
            if (student.FinishedQuiz)
            {
                return;
            }
            student.Score = 0;
        }

        public void IncreaseScore(Student student)
        {
            if (student.FinishedQuiz)
            {
                return;
            }
            student.Score += 1;
        }

        public void FinishQuiz(Student student)
        {
            student.FinishedQuiz = true;
        }
    }
}
