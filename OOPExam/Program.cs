using System.Diagnostics;

namespace OOPExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject obj = new Subject(1, "OOP");
            obj.CreateExam();
            Console.Clear();

            Console.Write("Do You Want To Start The Exam  (y | n): ");

            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Console.Clear();
                Stopwatch SW = new Stopwatch();
                SW.Start();
                obj.Exam.ShowExam();
                Console.WriteLine($"The Elapsed Time Is : {SW.Elapsed}");

                if( ((int)SW.Elapsed.TotalMinutes) > obj.Exam.ExamTime)
                    Console.WriteLine($"Your Time is Over, The Exam Time Is {obj.Exam.ExamTime} Minuets");
            }
        }
    }

}