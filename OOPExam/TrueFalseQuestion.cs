using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using OOPExam;

namespace OOPExam
{
    class TrueFalseQuestion : Questions
    {


        #region Constructors

        public TrueFalseQuestion(string _Body, int _Mark, int _RightAnswer, Answer[] _Answers) : base("True | False Question", _Body, _Mark, _RightAnswer, _Answers)
        {
        }

        #endregion

        #region Methods
        public static TrueFalseQuestion CreateTrueFalseQuestion(int index)
        {
            string Body;
            int Mark;
            int RightAns;
            Answer[] Answers = new Answer[] { new Answer(1, "True"), new Answer(2, "False") };

            Console.WriteLine("True | False Question");
            Console.WriteLine("Please Enter The Body Question: ");
            Body = Console.ReadLine();
            do
            {
                Console.WriteLine("Please Enter The Mark of Question: ");
            } while (!int.TryParse(Console.ReadLine(), out Mark) || !(Mark >= 0));
            do
            {
                Console.WriteLine("Please Enter The Right Answer of Question (1 For True, 2 For False) ");
            } while (!int.TryParse(Console.ReadLine(), out RightAns) || !(RightAns >= 1 && RightAns <= 2));

            return new TrueFalseQuestion(Body, Mark, RightAns, Answers);
        }


        #endregion 
    }
}