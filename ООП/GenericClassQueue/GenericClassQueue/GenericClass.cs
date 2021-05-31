using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassQueue
{
    class GenericClass <T>
    {
        private T[] ts;
        private int last = 0, first = 0;
        public GenericClass (int size)
        {
            ts = new T[size];
        }
        public void Push (T newItem)
        {
            ts[last] = newItem;
            last++;
        }
        public void Pop()
        {
            for (int qp = first; qp <= last; qp++)
                Console.WriteLine(ts[qp]);
        }
        public void Del()
        {
            int qp = first;
            while (qp != last)
            {
                ts[qp] = ts[qp + 1];
                qp++;
            }
            last--;
        }
    }
}
