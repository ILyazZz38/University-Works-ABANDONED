using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> genericStr = new GenericClass<string>(5);
            GenericClass<int> genericInt = new GenericClass<int>(5);
            int menu = 0;
            while (menu != 6)
            {
                Console.WriteLine("1 add String");
                Console.WriteLine("2 add int");
                Console.WriteLine("3 del str");
                Console.WriteLine("4 del int");
                Console.WriteLine("5 get all");
                Console.WriteLine("6 exit");
                Console.Write("insert: ");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Write("string: ");
                        genericStr.Push(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("int: ");
                        genericInt.Push(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        genericStr.Del();
                        break;
                    case 4:
                        genericInt.Del();
                        break;
                    case 5:
                        genericStr.Pop();
                        genericInt.Pop();
                        break;
                }
            }
        }
    }
}
