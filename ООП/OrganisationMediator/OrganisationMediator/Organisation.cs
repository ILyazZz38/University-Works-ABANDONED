using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganisationMediator
{
    class dep
    {
        public dep prev;
        public Departments info = new Departments();
        public dep next;


        public dep(Departments manager)
        {
            info = manager;
            prev = null;
            next = null;
        }
    }
class Organisation
    {
            public static int count = 0;
            private static dep start;

            internal static dep Start { get => start; set => start = value; }

            public static void insertManager(Departments manager)
            {
                if (count == 0)
                {
                    dep temp = new dep(manager);
                    Start = temp;
                    count++;
                }
                else
                {
                    dep temp = new dep(manager);
                    dep p = Start;
                    while (p.next != null)
                        p = p.next;
                    p.next = temp;
                    temp.prev = p;
                    count++;
                }
            }
        }
    }