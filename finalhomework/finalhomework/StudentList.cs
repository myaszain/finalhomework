using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalhomework
{
    class StudentList
    {
        public Node First { get; set; }
        public Node Last { get; set; }

        public void AddStudentInOrder(StudentManage new_student)
        {
            //creating a node for the new student
            Node node = new Node(new_student);

            //checking if the linkedlist empty or if the new student should be at the first
            if (First == null || First.Data.TotalMark > new_student.TotalMark)
            {
                //adding the new node at the first
                node.Next = First;
                First = node;

                //if it is the only node :
                if (Last == null)
                {
                    Last = node;
                }

                return;
            }

            //checking if the new student should be after the last node
            if (new_student?.TotalMark > Last?.Data?.TotalMark)
            {
                Last.Next = node;
                Last = node;
                return;
            }

            Node temp = First;
            Node previous = null;

            //finding the right position for the new student
            while (temp != null && temp.Data.TotalMark < new_student.TotalMark)
            {
                previous = temp;
                temp = temp.Next;
            }

            //adding the node at the right position
            node.Next = temp;
            previous.Next = node;

            //if the new nodde at the last , refresh Last
            if (node.Next == null)
            {
                Last = node;
            }
        }

        public void Print()
        {
            for (Node i = First; i != null; i = i.Next)
            {
                i.Data.PrintStudentInfo();
            }
        }
    }
}