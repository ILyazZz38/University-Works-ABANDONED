using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTextFirstConflict
{
    class Program
    {
        const int m = 10;

        static string[] hash = new string[m];

        public static void addHash(string text)
        {
            int key = 0;
            foreach (int i in text) key = key + i;
            key = key % m;
            if (hash[key] == "*")
            {
                hash[key] = text;
                Console.WriteLine("Слово успешно занесено. Ключ слова - {0}", key);
            }
            else if (hash[key] != "*")
            {
                Console.WriteLine("Ключ слова - {0}. Место занято словом - {1}.\nИщем свободную ячейку.", key, hash[key]);
                int insert = 0, j = 0;
                for (int i = 1; i < m;)
                {
                    j = ((key + i) % m);
                    if (hash[j] == "*")
                    {
                        hash[j] = text;
                        insert = 1;
                        break;
                    } else
                    {
                        i++;
                    }
                }
                if (insert == 0) Console.WriteLine("Слово не занесено. Все ячейки заняты!");
                else Console.WriteLine("Слово успешно занесено. Ключ слова - {0}.", j);
            }
        }

        public static string searchHash(string text)
        {

            int key = 0;
            string result = "";
            foreach (int i in text) key = key + i;
            key = key % m;
            if (hash[key] == text)
            {
                result = "Слово " + text + " найдено.\nКлюч слова = " + key;
            }
            else if (hash[key] != text)
            {
                result = "Слово " + text + " не находится в своем ключе\n";
                result = result + "Начинаем поиск\n";
                int find = 0, j = 0;
                for (int i = 1; i < m;)
                {
                    j = ((key + i) % m);
                    if (hash[j] == text)
                    {
                        find = 1;
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (find == 0) result = result + "Слово не найдено.";
                else result = result + "Слово " + text + " найдено. Ключ слова " + j; ;
            }
            return result;
        }

        public static string printHash()
        {
            string result = "";
            for (int i = 0; i < m; i++)
            {
                result = result + hash[i] + " - ";
            }
            result = result + "Вывод завершен";
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Хещь сепощьки!");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...\n\n");
            Console.ReadKey();

            for (int i = 0; i < hash.Length; i++)
            {
                hash[i] = "*";
            }

            int menu, Exit = 0;
            while (Exit != 1)
            {
                Console.WriteLine("МЕНЮ\n");
                Console.WriteLine("1.Добавить элемент");
                Console.WriteLine("2.Вывести хеш");
                Console.WriteLine("3.Поиск элемента");
                Console.WriteLine("4.Выход");
                Console.Write("\nВвод: ");

                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Write("\nВведите элемент:");
                        addHash((Console.ReadLine()));
                        break;

                    case 2:
                        Console.Write("\nВывод хеша:\n");
                        Console.WriteLine(printHash());
                        break;

                    case 3:
                        Console.Write("\nВведите элемент:");
                        Console.WriteLine(searchHash(Console.ReadLine()));
                        break;

                    case 4:
                        Exit = 1;
                        break;
                }

                if (Exit == 0)
                {
                    Console.Write("Нажмите на любую клавишу для продолжения...");
                }
                else
                {
                    Console.Write("Нажмите на любую клавишу для подверждения выхода...");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
