using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSuccessorList
{
    class Students
    {
        protected string FIO;
        protected byte year;

        public string fio { get => FIO; }

        public Students(string fio, byte addYear)
        {
            FIO = fio;
            year = addYear;
        }
        public virtual string getInfo()
        {
            return "Студент " + year + " курса.\n" + FIO;
        }
    }

    class StateStudent : Students
    {
        private static int scholarship;
        public StateStudent(string sFIO, byte sYear, int money) : base(sFIO, sYear)
        {
            StateStudent stateStudent = this;
            stateStudent.FIO = sFIO;
            stateStudent.year = sYear;
            scholarship = money;
        }

        public override string getInfo()
        {
            return base.getInfo() + "\nСтипендия студенда: " + scholarship;
        }
    }

    class PaidStudent : Students
    {
        private static int payment;
        public PaidStudent(string sFIO, byte sYear, int money) : base(sFIO, sYear)
        {
            PaidStudent stateStudent = this;
            stateStudent.FIO = sFIO;
            stateStudent.year = sYear;
            payment = money;
        }
        public override string getInfo()
        {
            return base.getInfo() + "\nОплата студента: " + payment;
        }
    }
}