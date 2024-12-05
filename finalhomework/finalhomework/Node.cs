using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalhomework
{
    class Node
    {
        public StudentManage Data { get; set; }

        public Node Next { get; set; }

        public Node() { }

        public Node(StudentManage data)
        {
            this.Data = data;
        }
    }
}
