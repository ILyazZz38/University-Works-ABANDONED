using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSuccessorList
{
    class Node
    {
        public Students info;
        public Node next;

        public Node(Students student)
        {
            info = student;
            next = null;
        }
    }
}