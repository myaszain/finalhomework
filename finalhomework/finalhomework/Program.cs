using System;

namespace finalhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList student = new StudentList();

            Console.WriteLine("Enter the number of the students : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                StudentManage student1 = new StudentManage();
                Console.WriteLine("___________________");
                student.AddStudentInOrder(student1);
            }

            student.Print();
           
        }
    }
}