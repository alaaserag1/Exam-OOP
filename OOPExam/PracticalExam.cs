using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class PracticalExam : Exam
    {
        #region Constructors
        public PracticalExam(int _ExamTime, int _QuestionNo) : base(_ExamTime, _QuestionNo)
        {
        }


        #endregion

        #region Methods

        public override void CreateExamQuestions()
        {
            for (int i = 0; i < QuestionNo; i++)
            {
                Console.Clear();
                Questions[i] = MCQQuestion.CreateMcqQuestion(i);
            }
        }

        public override void ShowExam()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("==========================================");
            Console.WriteLine("============= Practical Exam =============");
            Console.WriteLine("==========================================");
            Console.WriteLine("==========================================\n");

            for (int i = 0; i < QuestionNo; i++)
            {
                int UserAns;
                Console.WriteLine(Questions[i]);
                Console.WriteLine("--------------------------------");

                do
                {
                    Console.Write("Answer:  ");
                } while (!int.TryParse(Console.ReadLine(), out UserAns) || !(UserAns >= 1 && UserAns <= 3));


                Questions[i].UserAnswer = UserAns;
                Console.WriteLine("================================\n\n");
            }

            Console.Clear();
            ShowResult();
        }

        public override void ShowResult()
        {
            for (int i = 0; i < QuestionNo; i++)
                Console.WriteLine($"Q{i + 1})\t {Questions[i].Body}:  {AnswerShown(Questions[i], Questions[i].RightAnswer)}");
        }

        public override string AnswerShown(Questions Question, int AnswerId)
        {
            return $"{Question.Answers[AnswerId - 1].AnswerText}";
        } 

        #endregion
    }
}
