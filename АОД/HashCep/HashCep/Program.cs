using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCep
{
    
    class Program
    {
        const int m = 10;
        public static string[][] hash = new string[m][];

        static void HashResizePlus(int key)
        {
            Array.Resize<string>(ref hash[key],  hash[key].Length + 1);
        }
        static void HashResizeMin(int key)
        {
            Array.Resize<string>(ref hash[key], hash[key].Length - 1);
        }

        static void addHash(string word)
        {
            int key = 0;
            foreach (int i in word)
                key = key + i;
            key = key % m;
            if (hash[key][0] == "")
            {
                hash[key][0] = word;
                Console.WriteLine("Элемент добавлен. Ключ {0}. Место в цепочке 1", key);
            } else
            {
                HashResizePlus(key);
                hash[key][hash[key].Length - 1] = word;
                Console.WriteLine("Элемент добавлен. Ключ {0}. Место в цепочке {1}", key, hash[key].Length);
            }
        }

        static void delHash(string word)
        {
            int key = 0;
            foreach (int i in word)
                key = key + i;
            key = key % m;
            if (hash[key][0] == "")
                Console.WriteLine("Ключ пуст. Данного слова нет.");
            else
            {
                byte find = 0;
                for (int i = 0; i < hash[key].Length; i++)
                    if (hash[key][i] == word)
                    {
                        find = 1;
                        Console.WriteLine("Слово найдено. Ключ слова - {0}. Место слова в цепочке {1}.", key, i + 1);
                        hash[key][i] = "";
                        int cNext = i + 1, cThis = i;
                        while(cThis != hash[key].Length - 1)
                        {
                            hash[key][cThis] = hash[key][cNext];
                            cThis++;
                            cNext++;
                        }
                        if (hash[i].Length != 1)
                            HashResizeMin(key);
                        Console.WriteLine("Слово удалено");
                        break;
                    }
                if (find == 0)
                    Console.WriteLine("Слово в ключе" + key + " не найдено");
            }
        }

        static void findHash(string word)
        {
            int key = 0;
            foreach (int i in word)
                key = key + i;
            key = key % m;
            if (hash[key][0] == "")
                Console.WriteLine("Ключ пуст. Данного слова нет.");
            else
            {
                byte find = 0;
                for (int i = 0; i < hash[key].Length; i++)
                    if (hash[key][i] == word)
                    {
                        find = 1;
                        Console.WriteLine("Слово найдено. Ключ слова {0}. Место в цепочке {1}.", key, i + 1);
                        break;
                    }
                if (find == 0)
                    Console.WriteLine("Слово в ключе" + key + "не найдено");
            }
        }

        static string printHash()
        {
            string result = "Вывод цепочек\n";
            for (int i = 0; i < m; i++)
            {
                if (hash[i].Length == 1 & hash[i][0] == "")
                {
                    result = result + i + ". **ПУСТО**\n";
                } else
                {
                    result = result + i + ". ";
                    foreach(string item in hash[i])
                    result = result + item + " - ";
                    result = result + "|\n";
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < m; i++)
            {
                hash[i] = new string[1];
                hash[i][0] = "";
            }

            Console.WriteLine("Хещь сепощьки! Выполнил Айгозин Ильяс. ПИ-922");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...\n\n");
            Console.ReadKey();
            Console.Clear();

            int menu = 0;

            while (menu != 5)
            {
                Console.WriteLine("Меню\n");
                Console.WriteLine("1. Добавить элемент в хеш.");
                Console.WriteLine("2. Найти элемент в хеше");
                Console.WriteLine("3. Удалить элемент из хеша");
                Console.WriteLine("4. Вывести хеш");
                Console.WriteLine("5. Выход");

                Console.Write("\nВвод: ");
                menu = int.Parse(Console.ReadLine());
                Console.Clear();

                switch(menu)
                {
                    case 1:
                        Console.WriteLine("Введите элемент: ");
                        addHash(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Введите элемент: ");
                        findHash(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Введите элемент: ");
                        delHash(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine(printHash());
                        break;
                }

                if (menu != 5)
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
