using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Quiz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[3]
            {
                "1- What is the capital of Italy ? ",
                "2- What is the Red plant ?",
                "3- What is the Big animal ? "
             };
            string[] answers = new string[3]
            {
                "Rome",
                "Mars",
                "Whale"
             };

            int CorrectAnswer = 0;

            Console.WriteLine("** Welcome to Quiz Game **");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Please answer the following question : ");
            Console.WriteLine("---------------------------------------");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(questions[i]);
                string userAnswer = Console.ReadLine();

                try
                {
                    bool result = AnswerCorrect(userAnswer, answers[i]);

                    if (result == true)
                    {
                        Console.WriteLine("Correct answer");
                        CorrectAnswer++;
                        Console.WriteLine("---------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Sorry incorrect answer");
                        Console.WriteLine($" The correct answer  is {answers[i]}");
                        Console.WriteLine("---------------------------------------");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.WriteLine($"Your score is :{CorrectAnswer} ");
                Console.WriteLine("Quiz complete ,thank you for playing");
        }
      
        private static bool AnswerCorrect(string correctanswer,string userinput)
           {
            if (string.IsNullOrEmpty(userinput))
            {
                throw new Exception("answer can be empty ");
            }
            if (userinput == correctanswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}