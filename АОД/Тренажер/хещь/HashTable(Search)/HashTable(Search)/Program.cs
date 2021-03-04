using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Search_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа Хещь Сепощьки\nВыполнил студент: Айгозин Ильяс");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...\n");
            Console.ReadKey();
            int menu, x = 0;
            while (x != 1)
            {
                Console.WriteLine("1.");
                Console.WriteLine("2.");
                Console.WriteLine("3.");
                Console.WriteLine("4. Выход");
                Console.Write("\nВаше значение: ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        x = 1;
                        break;
                }
                if (x == 0)
                {
                    Console.WriteLine("Нажмите на любую клавишу для продолжения...");
                } else
                {
                    Console.WriteLine("Завершение работы.\nНажмите любую клавишу для поддверждения...");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
