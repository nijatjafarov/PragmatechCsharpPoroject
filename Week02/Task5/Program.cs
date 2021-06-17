using System;

namespace Task5
{
    public struct Student
    {
        public int ExamResult;

        public Student(int examResult)
        {
            ExamResult = examResult;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int result = int.Parse(Console.ReadLine());

            Student student = new Student(result);

            if(student.ExamResult <=100 && student.ExamResult >= 0)
            {
                if (student.ExamResult > 89)
                {
                    Console.WriteLine("You get a point A");
                }
                else if (student.ExamResult > 79)
                {
                    Console.WriteLine("You get a point B");
                }
                else if (student.ExamResult > 69)
                {
                    Console.WriteLine("You get a point C");
                }
                else if (student.ExamResult > 59)
                {
                    Console.WriteLine("You get a point D");
                }
                else
                {
                    Console.WriteLine("\"Allah rehmet etsin\"-in ingiliscesi ne idi?");
                }
            }
            else
            {
                Console.WriteLine("You entered something wrong. Try again!");
            }
        }
    }
}
