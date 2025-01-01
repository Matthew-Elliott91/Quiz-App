﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Small_Quiz_App
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
          
            this._questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz");
            int questionNumber = 1; // Displays the question number we are on

            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct Answer");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect Answer. The correct answer was {question.Answers[question.CorrectAnswerIndex]}");
                }
            }

            DisplayResults(); 
        }

        private void DisplayResults()
        {
            

            double percentage = ((double)_score / _questions.Length) * 100;
            Console.WriteLine($"Quiz is over, Your Results: Your score is {_score} out of {_questions.Length}. That is {percentage}%");
            if (percentage > 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Well done, Great score");
            } else if (percentage >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good Effort");
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("You need to learn more Geography");
            }
            Console.ResetColor();




        }

        public void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(question.QuestionText);
            
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("  ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }

           
              
        }


        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;

            // If input wasnt a number do the while loop, else the out choice happens
            while (!int.TryParse(input, out choice) || choice <1 || choice >4)
            {
                Console.WriteLine("Invalid Choice, Please enter a number between 1 and 4;");
                input = Console.ReadLine();
            }

            return choice -1;
        }

    }
}


            