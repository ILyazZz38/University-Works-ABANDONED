using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SotrudForm;

namespace Organisation2._0
{
    class Departments
    {
        private Departments nextDep;
        private Worker worker;
        public Departments(Departments aNextDep, Worker aWorker)
        {
            nextDep = aNextDep;
            worker = aWorker;
        }

        public Worker getWorker() { return worker; }
        internal Departments getNextDep() { return nextDep; }

    }
}
