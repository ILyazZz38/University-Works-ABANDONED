using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        public class Graph
        {
            int V;
            int Gr = 1;
            public int[,] Matrix;

            public Graph(int V)
            {
                this.V = V;
                Matrix = new int[V, V];
                for (int i = 1; i < V; i++)
                {
                    Matrix[i, 0] = i;
                }
                for (int i = 1; i < V; i++)
                {
                    Matrix[0, i] = i;
                }
            }
            public void addConnection(int src, int dest)
            {
                Matrix[src, dest] = 1;
                Matrix[dest, src] = 1;
            }
            public void addGraph()
            {
                Gr++;
            }
            public void removeGraph()
            {
                for (int i = 1; i < Gr; i++)
                {
                    Matrix[i, Gr-1] = 0;
                }
                for (int i = 1; i < Gr; i++)
                {
                    Matrix[Gr-1, i] = 0;
                }
                Gr--;
            }
            public void removeConnection(int src, int dest)
            {
                Matrix[src, dest] = 0;
                Matrix[dest, src] = 0;
            }
            public void printGraph()
            {
                for (int i = 0; i < Gr; i++)
                {
                    for (int j = 0; j < Gr; j++)
                        Console.Write(String.Format("{0,3}", Matrix[i, j]));
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа графы.");
            Console.WriteLine("Выполнил студент: Айгозин Ильяс ПИ-922.");
            Console.Write("Нажмите любую клавишу для продолжения...\n\n");
            Console.ReadKey();

            Graph G = new Graph(5);
            int menu = 0;
            while (menu != 6)
            {
                Console.WriteLine("Меню");
                Console.WriteLine("1.Добавить граф");
                Console.WriteLine("2.Удалить граф");
                Console.WriteLine("3.Добавить связь");
                Console.WriteLine("4.Удалить связь");
                Console.WriteLine("5.Вывод графа");
                Console.WriteLine("6.Выход");
                Console.Write("\nВаш выбор:");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        G.addGraph();
                        break;

                    case 2:
                        G.removeGraph();
                        break;

                    case 3:
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        G.addConnection(x, y);
                        break;

                    case 4:
                        int z = Convert.ToInt32(Console.ReadLine());
                        int j = Convert.ToInt32(Console.ReadLine());
                        G.removeConnection(z, j);
                        break;

                    case 5:
                        G.printGraph();
                        break;
                    
                    
                }
                Console.Write("\n\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
