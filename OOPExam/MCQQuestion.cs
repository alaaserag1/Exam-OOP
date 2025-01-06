using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    class MCQQuestion : Questions
    {

        #region Constructor
        public MCQQuestion(string _Body, int _Mark, int _RightAnswer, Answer[] _Answers) : base("Choice one answer", _Body, _Mark, _RightAnswer, _Answers)
        {
        }
        #endregion

        #region Methods
        public static MCQQuestion CreateMcqQuestion(int Index)
        {
            string Body;
            int Mark;
            int RightAns;
            int AnsId;
            string AnsText;
            Answer[] Answers = new Answer[3];

            Console.WriteLine("Choose One Answer Question");
            Console.WriteLine("Please Enter The Body Question: ");
            Body = Console.ReadLine();

            do
            {
                Console.WriteLine("Please Enter The Mark of Question: ");
            } while (!int.TryParse(Console.ReadLine(), out Mark) || !(Mark >= 0));

            Console.WriteLine("Enter The Choices Of Question");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter The Choice Number {i + 1}: ");
                AnsText = Console.ReadLine();
                AnsId = i + 1;
                Answers[i] = new Answer(AnsId, AnsText);
            }

            do
            {
                Console.WriteLine("Please Enter The Right Answer of Question (1, 2 Or 3) ");
            } while (!int.TryParse(Console.ReadLine(), out RightAns) || !(RightAns >= 1 && RightAns <= 3));

            return new MCQQuestion(Body, Mark, RightAns, Answers);
        }

        #endregion
    }
}