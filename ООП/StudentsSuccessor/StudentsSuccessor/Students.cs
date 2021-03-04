using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSuccessor
{
    class Students
    {
        private static string FIO;
        private static byte year;

        public static void addStud(string fio, byte x)
        {
            FIO = fio;
            year = x;
        }

        public virtual string getInfo()
        {
            return "Студент " + year + " курса.\n" + FIO;
        }
    }

    class StateStudent : Students
    {
        private static int scholarship;

        public static void addScholarship(int cash)
        {
            scholarship = cash;
        }

        public override string getInfo()
        {
            return base.getInfo() + "\nСтипендия студенда: " + scholarship;
        }
    }

    class paidStudent : Students
    {
        private static int payment;

        public static void addPayment(int cash)
        {
            payment = cash;
        }

        public override string getInfo()
        {
            return base.getInfo() + "\nОплата студента: " + payment;
        }
    }
}
