using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SotrudForm;

namespace DynamicSotrudForm
{
    class Department
    {
        private Worker[] Workers;
        private int WorkerCount;
        private int ArrSize;
        private string DepName;

        //public int WorkerCount1 { get => WorkerCount; set => WorkerCount = value; }
        //public int ArrSize1 { get => ArrSize; set => ArrSize = value; }
        //public string DepName1 { get => DepName; set => DepName = value; }

        public Department(string depName, int startSize)
        {
            DepName = depName;
            ArrSize = startSize;
            WorkerCount = 0;
            Worker[] worker = new Worker[startSize];
        }

        public int getWorkerCount()
        {
            return WorkerCount;
        }

        public string getDepName()
        {
            return DepName;
        }

        public void setDepName(string newDepName)
        {
            DepName = newDepName;
        }

        public Worker getWorker(int num)
        {
            if (num <= 0 | num > WorkerCount)
                return null;
            else return Workers[num];
        }

        public bool setWorker(int num, Worker newWorker)
        {
            if (num <= 0 | num > WorkerCount)
                return false;
            else
            {
                Workers[num] = newWorker;
                return true;
            }
        }

        public bool addWorker(string Fam, string Name, string Fath)
        {
            if (this.Workers != null)
            {
                Worker newWorker = new Worker();
                newWorker.addWorker(Fam, Name, Fath);
                if (WorkerCount < Workers.Length)
                {
                    Workers[WorkerCount] = newWorker;
                    WorkerCount++;
                } else
                {
                    Worker[] newWorkers = new Worker[this.Workers.Length];
                    for (int i = 0; i < this.Workers.Length; i++)
                    {
                        newWorkers = this.Workers[i];
                    }
                }
            }
        }
    }
}
