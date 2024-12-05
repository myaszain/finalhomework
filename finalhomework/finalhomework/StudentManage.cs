using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalhomework
{
    class StudentManage
    {
        public enum level
        {
            //declaring static values for the level of the student
            failed,
            good,
            very_good,
            excellent
        }

        //declaring student intoramtion paraeters

        public int ID { get; set; }
        public string Name { get; set; }
        public int FirstExamMark { get; set; }
        public level Level { get; set; }
        public int SecondExamMark { get; set; }
        public int TotalMark { get; set; }

        //setting primary value for the ID

        static int available_id = 1;

        public StudentManage()
        {
            //giving an ID for the student as an increment value

            ID = available_id;
            available_id++;
            Console.WriteLine("The student ID is : " + ID);

            //getteing student name

            Console.WriteLine("Enter student name : ");
            Name = Console.ReadLine();

            //getting the first exam mark

            Console.WriteLine("Enter first exam mark : ");
            FirstExamMark = int.Parse(Console.ReadLine());

            //getting the second exam mark

            Console.WriteLine("Enter second exam mark : ");
            SecondExamMark = int.Parse(Console.ReadLine());

            //getting the total mark
            TotalMark = (FirstExamMark + SecondExamMark) / 2;

            //getting the level of the student 

            if (TotalMark >= 0 && TotalMark <= 59)
                Level = level.failed;

            else if (TotalMark >= 60 && TotalMark <= 75)
                Level = level.good;

            else if (TotalMark >= 75 && TotalMark <= 85)
                Level = level.very_good;

            else
                Level = level.excellent;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Student Information : " +
             "\n ID :" + ID +
             "\n Name : " + Name +
             "\n Level : " + Level +
             "\n First Exam Mark : " + FirstExamMark +
             "\n Second Exam Mark : " + SecondExamMark +
             "\n Total Mark : " + TotalMark );
            Console.WriteLine("-----------------------------");
        }
    }
}

