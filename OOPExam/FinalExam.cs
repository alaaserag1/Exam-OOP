using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class FinalExam : Exam
    {

        #region Constructor

        public FinalExam(int _ExamTime, int _QuestionNo) : base(_ExamTime, _QuestionNo)
        {
        }

        #endregion

        #region Methods

        public override void CreateExamQuestions()
        {
            for(int i = 0; i < QuestionNo; i++)
            {
                int QuestionType;
                Console.Clear();
                do
                {
                    Console.Write($"Choice type of question number({i + 1})  (1. For True or False || 2. For MCQ): ");
                } while (!int.TryParse(Console.ReadLine(), out QuestionType) || !(QuestionType == 1 || QuestionType == 2));

                if (QuestionType == 1)
                {
                    CreateTrueFalse(i);
                }
                else if (QuestionType == 2)
                {
                    CreateMCQ(i);
                }
            }
        }

        public void CreateTrueFalse(int Index)
        {           
            Questions[Index] = TrueFalseQuestion.CreateTrueFalseQuestion(Index);
        }

        public void CreateMCQ(int Index)
        {
            Questions[Index] = MCQQuestion.CreateMcqQuestion(Index);
        }


        public override void ShowExam()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("============================================");
            Console.WriteLine("================ Final Exam ================");
            Console.WriteLine("============================================");
            Console.WriteLine("============================================\n");

            for (int i = 0; i < QuestionNo; i++)
            {
                int UserAns;
                Console.WriteLine(Questions[i]);
                Console.WriteLine("--------------------------------");
                if (Questions[i] is TrueFalseQuestion)
                {
                    do
                    {
                        Console.Write("Answer:  ");
                    } while (!int.TryParse(Console.ReadLine(), out UserAns) || !(UserAns >= 1 && UserAns <= 2));
                }
                else
                {
                    do
                    {
                        Console.Write("Answer:  ");
                    } while (!int.TryParse(Console.ReadLine(), out UserAns) || !(UserAns >= 1 && UserAns <= 3));

                }
                Questions[i].UserAnswer = UserAns;
                Console.WriteLine("================================\n\n");
            }

            Console.Clear();
            ShowResult();
        }

        public override void ShowResult()
        {
            Console.WriteLine("Your Answers: ");
            for (int i = 0; i < QuestionNo; i++)
                Console.WriteLine($"Q{i+1})\t {Questions[i].Body}:  {AnswerShown(Questions[i], Questions[i].UserAnswer)}");

            Console.WriteLine($"Your Exam Grade Is {TotalUserMark} From {TotalMark} ");
        }
        
        public override string AnswerShown(Questions Question, int AnswerId)
        {
            if (Question.Answers[AnswerId-1].Id.CompareTo(Question.RightAnswer) == 0)
            {
                TotalUserMark += Question.Mark;
            } 
            return $"{Question.Answers[AnswerId - 1].AnswerText}";
        }


        #endregion
    }
}
