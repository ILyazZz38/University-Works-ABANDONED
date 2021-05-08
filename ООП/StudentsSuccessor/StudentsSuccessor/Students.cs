using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSuccessor
{
    class StudentsArray
    {
        private static int count = 0;
        private static Students[] students = new Students[10];
        public static void needResize()
        {
            if (count == students.Length)
                Array.Resize(ref students, students.Length + 5);
        }
        public static void addStudent(Students student)
        {
            for (int i = 0; i < students.Length;)
            {
                if (students[i] == null)
                {
                    students[i] = student;
                    break;
                }
                else
                    i++;
            }
        }
        public static string getStudent(string StudFIO)
        {
            string result = "";
            for (int i = 0; i < students.Length;)
            {
                if (students[i].fio == StudFIO)
                {
                    result =  students[i].getInfo();
                    break;
                }
                else
                    i++;
            }
            return result;
        }
        public static string getAllStudent()
        {
            string result = "";
            for (int i = 0; i < students.Length;)
            {
                if (students[i] != null)
                {
                    result = result + students[i].getInfo() + "\n\n";
                    i++;
                }
                else
                    i++;
            }
            return result;
        }
    }
    class Students
    {
        protected string FIO;
        protected byte year;

        public string fio { get => FIO; }

        public Students (string fio, byte addYear)
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
