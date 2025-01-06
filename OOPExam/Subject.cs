using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class Subject
    {
        #region Attributes and Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }
        #endregion

        #region Constructor
        public Subject(int _Id, string _Name)
        {
            Id = _Id;
            Name = _Name;
        }

        #endregion

        #region Methods
        public void CreateExam()
        {
            int ExamType, ExamTime, QuestionNo;
            do
            {
                Console.Write("Please enter the type of exam you want to create  (1. Practical   2. Final): ");
            } while (!int.TryParse(Console.ReadLine(), out ExamType) || !(ExamType == 1 || ExamType == 2));
            do
            {
                Console.Write("Please Enter The Time Of Exam In Minutes: ");
            } while (!int.TryParse(Console.ReadLine(), out ExamTime) || !(ExamTime > 0));
            do
            {
                Console.Write("Please enter the number of questions you want to create: ");
            } while (!int.TryParse(Console.ReadLine(), out QuestionNo) || !(QuestionNo > 0));

            Console.Clear();

            if (ExamType == 1)
                Exam = new PracticalExam(ExamTime, QuestionNo);


            else
                Exam = new FinalExam(ExamTime, QuestionNo);

            Exam.CreateExamQuestions();
        }
        #endregion


    }
}
