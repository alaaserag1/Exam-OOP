using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class Questions
    {
        #region Attributes & Properties

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public int RightAnswer { get; set; }
        public int UserAnswer { get; set; }
        public Answer[] Answers { get; set; }  


        #endregion

        #region Constructors

        public Questions(string _Header,string _Body, int _Mark, int _RightAnswer, Answer[] _Answers)
        {
            Header = _Header;
            Body = _Body;
            Mark = _Mark;
            RightAnswer = _RightAnswer;
            Answers = _Answers;
            Exam.TotalMark += Mark;
        }

        #endregion

        #region Methods 
        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendLine($"{Body}\t Mark({Mark})");

            for (int i = 0; i < Answers.Length; i++)
            {
                SB.Append($"{Answers[i]}\t\t");
            }

            return SB.ToString();
        }
        
        #endregion


    }
}
