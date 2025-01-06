using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class Answer
    {
        #region Attributes & Properties

        public int Id;
        public string AnswerText;

        #endregion

        #region Constructor
        public Answer(int _Id, string _Text)
        {
            Id = _Id;
            AnswerText = _Text;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{Id}. {AnswerText}";
        }


        #endregion

    }
}
