using QuizQuestions;

using QuizUserManagement;

using System;

namespace QuizMe
{
    class Program
    {
        const int MaxRetries = 3;
        static readonly UserRepository UserRepo = new UserRepository();

        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    var user = LoginUser();

                    Console.Clear();
                    Console.WriteLine($"Welcome {user.FullName}");

                    if (user is Teacher teacher)
                    {
                        ListStudents();
                    }
                    else if (user is Student student)
                    {
                        if (student.FinishedQuiz)
                        {
                            ShowScore(student);
                        }
                        else
                        {
                            RunQuiz(student);
                        }
                    }
                    else
                    {
                        // panic
                        throw new QuizException($"Invalid user type {user.GetType()}");
                    }
                }
            }
            catch (QuizException qex)
            {
                Console.WriteLine(qex.Message);
                Console.WriteLine("Terminating application");
                return;
            }

        }

        private static void ListStudents()
        {
            Console.Clear();
            Console.WriteLine("Listing students");
            var students = UserRepo.GetStudents();
            var oldColor = Console.ForegroundColor;
            foreach (var student in students)
            {
                if (student.FinishedQuiz)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{student.FullName}: {student.Score}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{student.FullName}: --");
                }
            }
            Console.ForegroundColor = oldColor;
            Console.ReadKey();
        }

        private static void ShowScore(Student student)
        {
            Console.WriteLine($"You have already finished the quiz with {student.Score} points");
            Console.WriteLine($"Press enter to exit");
            Console.ReadKey();
        }

        private static void RunQuiz(Student student)
        {
            Console.Clear();
            Console.WriteLine("Running quiz");
            UserRepo.ClearStudentScore(student);
            var questionRepo = new QuestionRepository();
            var questions = questionRepo.GetQuestions();
            foreach (var question in questions)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(question.Text);
                    Console.WriteLine();

                    for (int index = 0; index < question.Answers.Count; index++)
                    {
                        Console.WriteLine($"{index + 1}: {question.Answers[index]}");
                    }

                    Console.WriteLine();
                    var response = Console.ReadLine();
                    if (!int.TryParse(response, out int result))
                    {
                        Console.WriteLine($"Please enter a valid number 1-{question.Answers.Count}");
                        Console.ReadKey();
                        continue;
                    }
                    if (result > question.Answers.Count)
                    {
                        Console.WriteLine($"Please enter a valid number 1-{question.Answers.Count}");
                        Console.ReadKey();
                        continue;
                    }
                    if (result <= 0)
                    {
                        Console.WriteLine($"Please enter a valid number 1-{question.Answers.Count}");
                        Console.ReadKey();
                        continue;
                    }
                    var answer = question.Answers[result - 1];
                    if (questionRepo.CheckQuestion(question, answer))
                    {
                        UserRepo.IncreaseScore(student);
                    }
                    break;
                }
            }
            UserRepo.FinishQuiz(student);

            Console.Clear();
            Console.WriteLine($"You have finished the quiz with {student.Score} points");
            Console.WriteLine($"Press enter to exit");

            Console.ReadKey();
        }

        private static User LoginUser()
        {
            var retries = 0;

            Console.Clear();
            while (retries < MaxRetries)
            {
                Console.WriteLine("Enter username: ");
                var username = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                var password = Console.ReadLine();

                var user = UserRepo.Login(username, password);

                if (user != null)
                {
                    return user;
                }

                retries += 1;
                if (retries != MaxRetries)
                {
                    Console.WriteLine("Incorrect user/password combination. Please try again");
                }
            }

            throw new QuizException("Unable to login. Maximum retry limit exceeded");
        }
    }
}
