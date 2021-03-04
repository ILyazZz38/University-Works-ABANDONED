using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SotrudForm;

namespace OrganisationMediator
{

    class man
    {
        public man prev;
        public Worker info = new Worker();
        public man next;
        
        public man(Worker worker)
        {
            info = worker;
            prev = null;
            next = null;
        }
    }
    class Departments
    {
        public static int count = 0;
        private static man start;
        private string FirstName;
        private string Name;
        private string FatherName;

        internal static man Start { get => start; set => start = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string FatherName1 { get => FatherName; set => FatherName = value; }

        public man Start1 = Start;
        public void addManager(string first, string name, string fath)
        {
            FirstName1 = first;
            Name1 = name;
            FatherName1 = fath;
        }

        public void insertWorker(Worker worker)
        {
            if (count == 0)
            {
                man temp = new man(worker);
                Start = temp;
                count++;
            }
            else
            {
                man temp = new man(worker);
                man p = Start;
                while (p.next != null)
                    p = p.next;
                p.next = temp;
                temp.prev = p;
                count++;
            }
        }

        //public static int GetNum(string FIO)
        //{
        //    man p;
        //    int k = 0;
        //    p = Start;
        //    while (p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1 == FIO)
        //    {
        //        p = p.next;
        //        k++;
        //    }
        //    return k;
        //}

        public string GetManINFO()
        {
            man p;
            p = Start;
            string str = "Администратор " + FirstName1 + " " + Name1 + " " + FatherName1 + "\nИНФО подчиненных\n\n";
            while (p != null)
            {
                str = str + "\n" + p.info.INFO();
                p = p.next;
            }
            return str;
        }

        public string GetManMed()
        {
            man p;
            p = Start;
            string str = "Средняя ЗП подчиненных администратора за год равна: ";
            double res = 0, x;
            x = count;
            while (p != null)
            {
                if (Convert.ToInt32(p.info.plusCash()) != 0)
                {
                    res = res + Convert.ToInt32(p.info.plusCash());
                    p = p.next;
                }
                else
                {
                    x--;
                    p = p.next;
                }
            }
            res = res / count;
            str = Convert.ToString(res);
            return str;
        }

        public static int FindMan(string FIO)
        {
            man p;
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
    }
}
