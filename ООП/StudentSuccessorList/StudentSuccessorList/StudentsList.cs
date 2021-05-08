using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSuccessorList
{
    class StudentsList
    {
        private static Node start;
        public StudentsList()
        {
            start = null;
        }
        public static void add(Students students)
        {
            if (start == null)
            {
                Node node = new Node(students);
                start = node;
            }
            else
            {
                Node node = new Node(students);
                Node p = start;
                while (p.next != null)
                    p = p.next;
                p.next = node;
            }
        }
        public static string get(string studFIO)
        {
            string result = "";
            Node node = start;
            while (node != null)
            {
                if (node.info.fio == studFIO)
                {
                    result = node.info.getInfo();
                    break;
                }
                else
                    node = node.next;
            }
            return result;
        }
        public static string getAll()
        {
            string result = "";
            Node node = start;
            while (node != null)
            {
                result = result + node.info.getInfo() + "\n\n";
                node = node.next;
            }
            return result;
        }
    }
}
