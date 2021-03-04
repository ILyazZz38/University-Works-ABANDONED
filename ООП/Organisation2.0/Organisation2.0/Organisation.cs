using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SotrudForm;

namespace Organisation2._0
{
    class Organisation
    {
        private static Departments firstDep;
        private string OrganisationName;
        static int count;

        public Organisation(string aName)
        {
            OrganisationName = aName;
        }

        public Departments getFirstDep() { return firstDep; }

        public static void addWorker(string first, string name, string fath)
        {
            Worker worker = new Worker();
            worker.addWorker(first, name, fath);
            firstDep = new Departments(firstDep, worker);
            count++;
        }

        public static Departments findWorker(string fio)
        {
            Departments trueDep = firstDep;
            while(trueDep != null)
            {
                Worker worker = trueDep.getWorker();
                if (worker != null)
                {
                    if (worker.FirstName1 + " " + worker.Name1 + " " + worker.FatherName1 == fio)
                    {
                        return trueDep;
                    } else
                    {
                        trueDep = trueDep.getNextDep();
                    }
                }
            }
            return null;
        }

        public static string GetWorkersMed()
        {
            string result = "Средняя ЗП сотрудников за год равна: ";
            double res = 0;
            Departments dep = firstDep;
            while(dep != null)
            {
                Worker worker = dep.getWorker();
                res = res + Convert.ToInt32(worker.plusCash());
                dep = dep.getNextDep();
            }
            res = res / count;
            result = result + Convert.ToString(res);
            return result;
        }

        public static string GetInfo()
        {
            string infoAll = "ИНФО о всех сотрудниках\n\n";
            Departments dep = firstDep;
            while(dep != null)
            {
                Worker worker = dep.getWorker();
                infoAll = infoAll + worker.INFO() + "\n\n";
                dep = dep.getNextDep();
            }
            return infoAll;
        }
    }
}
