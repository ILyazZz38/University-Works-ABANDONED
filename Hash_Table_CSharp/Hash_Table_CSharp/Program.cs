using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_CSharp
{
    class Program
    {
        static string[] hash = new string[10];//Фиксированный массив
        static double count = 0;

        //Добавление слова в таблицу
        public static void addHash(string text)
        {
            int key = 0;
            foreach (int i in text)
                key = key + i;
            key = key % hash.Length;
            if (hash[key] == "")//Добавление в пустое место
            {
                hash[key] = text;
                count++;
                Console.WriteLine("Слово успешно занесено. Ключ слова - {0}", key);
            }
            else if (hash[key] != "")//В случае конфликта
            {
                Console.WriteLine("Ключ слова - {0}. Место занято словом - {1}.\nИщем свободную ячейку.", key, hash[key]);
                int j = 0;
                for (int i = 1; i < hash.Length;)
                {
                    j = ((key + i) % hash.Length);
                    if (hash[j] == "")
                    {
                        hash[j] = text;
                        count++;
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                Console.WriteLine("Слово успешно занесено. Ключ слова - {0}.", j);
            }
        }

        //Поиск слова в таблице
        public static string searchHash(string text)
        {

            int key = 0;
            string result = "";
            foreach (int i in text)
                key = key + i;
            key = key % hash.Length;
            if (hash[key] == text) //Поиск слова в ключе
            {
                result = "Слово " + text + " найдено.\nКлюч слова = " + key;
            }
            else if (hash[key] != text) //Поиск слова вне ключа
            {
                result = "Слово " + text + " не находится в своем ключе\n";
                result = result + "Начинаем поиск\n";
                int find = 0, j = 0;
                for (int i = 1; i < hash.Length;)
                {
                    j = ((key + i) % hash.Length);
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
                if (find == 0)
                    result = result + "Слово не найдено.";
                else
                    result = result + "Слово " + text + " найдено. Ключ слова " + j; ;
            }
            return result;
        }

        //Вывод таблицы
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

        //Удаление слова из таблицы
        public static void delHash(string text)
        {
            int key = 0;
            foreach (int i in text)
                key = key + i;
            key = key % hash.Length;
            if (hash[key] == text) //Удаление слова из ключа
            {
                hash[key] = "";
                count--;
                Console.WriteLine("Слово удалено");
            }
            else if (hash[key] != text) //Удаление слова вне ключа
            {
                int find = 0, j = 0;
                for (int i = 1; i < hash.Length;)
                {
                    j = ((key + i) % hash.Length);
                    if (hash[j] == text)
                    {
                        hash[j] = "";
                        count--;
                        find = 1;
                        break;
                    }
                    else
                    {
                        i++;
                    }
                    if (find == 1)
                        Console.WriteLine("Слово удалено");
                    else
                        Console.WriteLine("Слово не найдено");
                }
            }
        }

        //Увеличение таблицы
        static void resizeHash()
        {
            double resize = 0;
            resize = count / hash.Length;
            if (resize >= 0.7) //Проверка коэфицента заполненности
            {
                Console.WriteLine("Размер массива - {0}, количество слов - {1}\nКоэфицент заполненности таблицы больше 0.7", hash.Length, count);
                Console.WriteLine("Увеличиваем таблицу");
                string[] hashCopy = new string[hash.Length];
                hashCopy = hash;
                Array.Resize(ref hash, hash.Length + 10);
                for (int i = 0; i < hash.Length; i++)
                {
                    hash[i] = "";
                }
                count = 0;
                Console.WriteLine("Размер таблицы успешно увеличен");
                Console.WriteLine("Идет процедура пересчета значений:\n");
                for (int i = 0; i < hashCopy.Length; i++)
                {
                    if (hashCopy[i] != "")
                    {
                        addHash(hashCopy[i]);
                    }
                }
                hashCopy = null;
                Console.WriteLine("\n\nЗначения пересчитаны");
                Console.WriteLine("Нажмите на ENTER для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Размер массива - {0}, количество слов - {1}", hash.Length, count);
                Console.WriteLine("Увеличение размера таблицы не требуется");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Хеш таблицы. Выполнил студент Айгозин Ильяс, группа ПИ-922");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...\n\n");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < hash.Length; i++)
            {
                hash[i] = "";
            }
            int menu = 0;
            while (menu != 5)
            {
                resizeHash();
                Console.WriteLine("МЕНЮ\n");
                Console.WriteLine("1. Добавить элемент");
                Console.WriteLine("2. Удалить элемент");
                Console.WriteLine("3. Поиск элемента");
                Console.WriteLine("4. Вывести таблицу");
                Console.WriteLine("5. Выход");
                Console.Write("\nВвод:");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Write("\nВведите элемент:");
                        addHash((Console.ReadLine()));
                        break;

                    case 2:
                        Console.Write("\nВведите элемент:");
                        delHash((Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write("\nВведите элемент:");
                        Console.WriteLine(searchHash(Console.ReadLine()));
                        break;

                    case 4:
                        Console.Write("\nВывод хеша:\n");
                        Console.WriteLine(printHash());
                        break;
                }
                if (menu != 5)
                {
                    Console.Write("Нажмите на ENTER для продолжения...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Write("Нажмите на ENTER для подверждения ВЫХОДА...");
                    Console.ReadKey();
                }
            }
        }
    }
}
