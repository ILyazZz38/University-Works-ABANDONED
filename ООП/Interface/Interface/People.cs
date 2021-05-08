using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IPerson
    {
        void SetFIO(string FIO);
        string GetFIO();
    }
    interface IStudent : IPerson
    {
        void SetPay(int pay);
        int GetPay();
    }
    interface IStaff : IPerson
    {
        void SetSalary(int salary);
        int GetSalary();
    }
    abstract class People : IPerson
    {
        private string FIO;
        public void SetFIO(string fio)
        {
            FIO = fio;
        }
        public string GetFIO()
        {
            return FIO;
        }
        public abstract string GetInfo();
    }
    class Student : People, IStudent
    {
        private int Pay;
        public void SetPay(int pay)
        {
            Pay = pay;
        }
        public int GetPay()
        {
            return Pay;
        }
        public override string GetInfo()
        {
            return "Студент: " + GetFIO() + "\nОплата: " + Pay;
        }
    }
    class Staff : People, IStaff
    {
        private int Salary;
        public void SetSalary(int salary)
        {
            Salary = salary;
        }
        public int GetSalary()
        {
            return Salary;
        }
        public override string GetInfo()
        {
            return "Сотрудник: " + GetFIO() + "\nЗарплата: " + Salary;
        }
    }
    class StaffStudent : People, IStaff, IStudent
    {
        private int Pay;
        private int Salary;
        public void SetPay(int pay)
        {
            Pay = pay;
        }
        public int GetPay()
        {
            return Pay;
        }
        public void SetSalary(int salary)
        {
            Salary = salary;
        }
        public int GetSalary()
        {
            return Salary;
        }
        public override string GetInfo()
        {
            return "Сотрудник - Студент: " + GetFIO() + "\nЗарплата: " + Salary + "\nОплата: " + Pay;
        }
    }
}
