using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTextWithoutConflict
{
    class Program
    {
        static string[] hash = new string[10];

        public static void addHash(string text)
        {
            int key = 0;
            foreach (int i in text) key = key + i;
            key = key % hash.Length;
            if (hash[key] == "*")
            {
                hash[key] = text;
                Console.WriteLine("Слово успешно занесено. Ключ слова - {0}", key);
            }
            else if (hash[key] != "*")
            {
                Console.WriteLine("Ключ слова - {0}. Место занято словом - {1}.\nЗаменяем словом - {2}.", key, hash[key], text);
                hash[key] = text;
                Console.WriteLine("Слово успешно занесено. Ключ слова - {0}.", key);
            }
        }

        public static string searchHash(string text)
        {

            int key = 0;
            string result = "";
            foreach (int i in text) key = key + i;
            key = key % hash.Length;
            if (hash[key] == text)
            {
                result = "Слово " + text + " найдено.\nКлюч слова = " + key;
            }
            else
            {
                result = "Слово " + text + " не найдено.";
            }
            return result;
        }

        public static string printHash()
        {
            string result = "";
            for (int i = 0; i < hash.Length; i++)
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
