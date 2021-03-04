using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SotrudForm;

namespace MyDynamycSotrudForm
{
    class Departament
    {
        public static Worker[] departament = new Worker[5];

        public static void DepPlus() //увеличитель массива
        {
            Array.Resize(ref departament, departament.Length + 5);
        }

        public static void addSotrud (Worker worker, int full)
        {
            if (full == departament.Length)
            {
                DepPlus();
                departament[full + 1] = worker;
            } else
            {
                for (int i = 0; i <= departament.Length;)
                {
                    if (departament[i] == null)
                    {
                        departament[full] = worker;
                        break;
                    } else
                    {
                        i++;
                    }
                }
            }
        }

        public static string getNum(string FIO)
        {
            string ret ="";
            for (int i = 0; i <= departament.Length;)
            {
                if (FIO == departament[i].FirstName1 + " " + departament[i].Name1 + " " + departament[i].FatherName1)
                {
                    ret = Convert.ToString(i);
                    break;
                } else
                {
                    i++;
                }
            }
            return ret;
        }

        public static double getSredCash(int full)
        {
            double TF, res = 0;
            byte RP = 0;
            for (int i = 0; i <= full-1; i++)
            {
                TF = Convert.ToInt32(departament[i].plusCash());
                    if (TF != 0)
                {
                    res = res + TF;
                    RP++;
                }
            }
            res = res / RP;
            return res;
        }

        public static string INFOall(int full)
        {
            string infoAll = "ИНФО о всех сотрудниках\n\n";
            for (int i = 0; i <= full - 1; i++)
            {
                infoAll = infoAll + departament[i].INFO() + "\n\n";
            }
            return infoAll;
        }
    }
}
