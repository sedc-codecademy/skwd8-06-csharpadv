using SEDC.Adv.Class02.Database.Models;
using SEDC.Adv.Class02.Logic.Services;
using System;
using System.Collections.Generic;

namespace SEDC.Adv.Class02.App
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            QuizService quizService = new QuizService();
            User user = null;

            while (true)
            {
                Console.WriteLine("Login");
                user = userService.Login();

                if (!user.IsTeacher)
                {
                    quizService.TakeQuiz(user);
                    user = null;
                    continue;
                }

                if (user.IsTeacher)
                {
                    List<User> students = userService.GetStudents();
                    foreach (var student in students)
                    {
                        if (student.HasFinishedTest)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            if(student.CorrectAnswers >= 5)
                            {
                                Console.WriteLine($"{student.FullName} Excelent");
                            }
                            else if(student.CorrectAnswers > 3)
                            {
                                Console.WriteLine($"{student.FullName} very good");

                            }
                            else if (student.CorrectAnswers > 1)
                            {
                                Console.WriteLine($"{student.FullName} good");
                            }
                            else
                            {
                                Console.WriteLine($"{student.FullName} bad");
                            }
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{student.FullName} did not take test");
                            Console.ResetColor();
                        }
                    }
                    user = null;
                }

            }
        }
    }
}
