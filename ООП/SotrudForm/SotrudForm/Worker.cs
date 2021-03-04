using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotrudForm
{
    public class Worker
    {
        private string FirstName = "";
        private string Name = "";
        private string FatherName = "";

        private int[] cashMounth = new int[12];



        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string FatherName1 { get => FatherName; set => FatherName = value; }
        public int[] CashMounth { get => cashMounth; set => cashMounth = value; }

        public void addWorker(string First, string Name, string Father)
        {
            FirstName1 = First;
            Name1 = Name;
            FatherName1 = Father;
        }

        public void Cash(int mounth, int Cash)
        {
            cashMounth[mounth] = Cash;
        }

        public string requestCash(int mounth)
        {
            return Convert.ToString(cashMounth[mounth]);
        }

        public string plusCash()
        {
            int result = 0;
            for (int i = 0; i < 12; i++)
            {
                result = result + CashMounth[i];
            }
            return Convert.ToString(result);
        }

        public string INFO()
        {
            string info1 = "ИНФО\nФИО:" + FirstName1 + " " + Name1 + " " + FatherName1;
            for (int i = 1; i <12; i++)
            {
                info1 = info1 + "\n\nЗарплата за " + Convert.ToString(i) + " Месяц: " + Convert.ToString(cashMounth[i]);
            }
            info1 = info1 + "\n\nЗарплата за год: " + plusCash();
            return info1;
        }

    }
}
