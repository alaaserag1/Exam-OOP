using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    abstract class Exam 
    {
        #region Attributes and properties

        public int ExamTime { get; set; }
        private protected static int QuestionNo { get; set; }

        private protected static int TotalUserMark = 0;

        internal protected static int TotalMark = 0;

        private protected Questions[] Questions;

        #endregion

        #region Constructor
        public Exam(int _ExamTime, int _QuestionNo)
        {
            ExamTime = _ExamTime;
            QuestionNo = _QuestionNo;
            Questions = new Questions[QuestionNo];
        }

        #endregion

        #region Methods

        public abstract void CreateExamQuestions();
        public abstract void ShowExam();
        public abstract void ShowResult();
        public abstract string AnswerShown(Questions Question, int AnswerId);

        #endregion
    }
}
