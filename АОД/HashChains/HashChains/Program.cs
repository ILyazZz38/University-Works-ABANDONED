using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashChains
{
    class Program
    {
        const int m = 10;
        static List<string>[] hash = new List<string>[m];
        static List<string> hashList = new List<string>();

        
        public static void addHash(string text)
        {
            int key = 0;
            foreach (int i in text) key = key + i;
            key = key % m;
            if (hash[key] == null)
            {
                hash[key] = hashList;
                hash[key].Add(text); 
                Console.WriteLine("Слово успешно занесено. Ключ слова - {0}", key);
            }
            else if (hash[key] != null)
            {
                Console.WriteLine("Ключ слова - {0}. Место занято другим словом.\nИщем свободную ячейку.", key);
                hash[key].Add(text);
                Console.WriteLine("Слово успешно занесено. Ключ слова - {0}.", key);
            }
        }

        public static string searchHash(string text)
        {

            int key = 0;
            string result = "";
            foreach (int i in text) key = key + i;
            key = key % m;
            if (hash[key] == null)
            {
                result = "Слово " + text + " не найдено.";
            }
            else if (hash[key] != null)
            {
                int find = -1;
                find = hash[key].BinarySearch(text);
                if (find == -1) result = "Слово " + text + " не найдено.";
                else result = "Слово " + text + " найдено. Ключ слова - " + key;
            }
            return result;
        }

        public static string printHash()
        {
            string result = "";
            for (int i = 0; i < m; i++)
            {
                if (hash[i] != null)
                {
                    foreach (string item in hash[i])
                    result = result + i + ". " + item + " ";
                    result = result + i + ".\n";
                } else
                {
                    result = result + "\n";
                }
            }
            result = result + "\nВывод завершен";
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Хещь сепощьки!");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...\n\n");
            Console.ReadKey();



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
