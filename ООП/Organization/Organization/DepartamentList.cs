using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SotrudForm;

namespace Organization
{
    class dep
    {
        public dep prev;
        public Worker info = new Worker();
        public dep next;
        

        public dep(Worker worker)
        {
            info = worker;
            prev = null;
            next = null;
        }
    }
    class DepartamentList
    {
        public static int count = 0;
        private static dep start;

        internal static dep Start { get => start; set => start = value; }

        public static void insertWorker(Worker worker)
        {
            if (count == 0)
            {
                dep temp = new dep(worker);
                Start = temp;
                count++;
            } else
            {
                dep temp = new dep(worker);
                dep p = Start;
                while (p.next != null)
                    p = p.next;
                p.next = temp;
                temp.prev = p;
                count++;
            }
        }

        //public void InsertInBeginning(Worker worker)
        //{
        //    dep temp = new dep(worker);
        //    temp.next = start;
        //    start.prev = temp;
        //    start = temp;
        //}

        //public void InsertInEmptyList(Worker worker)
        //{
        //    dep temp = new dep(worker);
        //    start = temp;
        //}

        //public void InsertAtEnd(Worker worker)
        //{
        //    dep temp = new dep(worker);
        //    dep p = start;
        //    while (p.next != null)
        //        p = p.next;
        //    p.next = temp;
        //    temp.prev = p;
        //}

        public static int GetNum(string FIO)
        {
            dep p;
            int k = 0;
            p = Start;
            while (p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1 == FIO)
            {
                p = p.next;
                k++;
            }
            return k;
        }

        public static string GetDepINFO()
        {
            dep p;
            p = Start;
            string str = "ИНФО отдела\n\n";
            while (p != null)
            {
                str = str + "\n" + p.info.INFO();
                p = p.next;
            }
            return str;
        }

        public static string GetDepMed()
        {
            dep p;
            p = Start;
            string str = "Средняя ЗП отдела за год равна: ";
            double res = 0, x;
            x = count;
            while (p != null)
            {
                if (Convert.ToInt32(p.info.plusCash()) != 0)
                {
                    res = res + Convert.ToInt32(p.info.plusCash());
                    p = p.next;
                } else
                {
                    x--;
                    p = p.next;
                }
            }
            res = res / count;
            str = Convert.ToString(res);
            return str;
        }

        public static int FindDep(string FIO)
        {
            dep p;
            int Find = 0;
            p = Start;
            while (p != null)
            {
                if (p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1 != FIO) p = p.next;
                else
                {
                    Find = 1;
                    p = p.next;
                }
            }
            return Find;
        }

        //public Worker search(string fio)
        //{
        //    dep p;
        //    p = start;
        //    while (fio != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
        //    {
        //        p = p.next;
        //    }
        //    return p.info;
        //}
    }
}
