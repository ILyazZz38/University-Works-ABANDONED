using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashChains2
{
    class Program
    {
        const int m = 10;
        
        static hashList[] hashArray = new hashList[m];
        class hashList
        {
            public hashList prev;
            public string info;
            public hashList next;
            public hashList first, last;

            public hashList(string text)
            {
                info = text;
                prev = null;
                next = null;
                first = null;
                last = null;
            }
        }

        class Hash
        {
            public static int count = 0;
            private static hashList start;

            internal static hashList Start { get => start; set => start = value; }

            public static void addHash(string text)
            {
                int key = 0;
                foreach (int i in text) key = key + i;
                key = key % m;

                if (hashArray[key] == null)
                {
                    hashList temp = new hashList(text);
                    Start = temp;
                    hashList p = Start;
                    p.first = temp;
                    p.last = temp;
                    count++;
                    Console.WriteLine("Слово успешно занесено. Ключ слова - {0}", key);
                } else if (hashArray[key] != null)
                {
                    Console.WriteLine("Ключ слова - {0}. Место занято другим словом.\nИщем свободную ячейку.", key);
                    hashList temp = new hashList(text);
                    hashList p = Start;
                    p = p.last;
                    p.next = temp;
                    p.last = temp;
                    temp.prev = p;
                    count++;
                    Console.WriteLine("Слово успешно занесено. Ключ слова - {0}.", key);
                }
            }
            public static string searchHash(string text)
            {

                int key = 0;
                string result = "";
                foreach (int i in text) key = key + i;
                key = key % m;
                if (hashArray[key] == null)
                {
                    result = "Слово " + text + " не найдено.";
                }
                else if (hashArray[key] != null)
                {
                    int find = 0;
                    hashList p = Start;
                    while (p.next != null)
                    {
                        if (p.info == text) find = 1;
                        else p = p.next;
                    }
                    if (find == 0) result = "Слово " + text + " не найдено.";
                    else result = "Слово " + text + " найдено. Ключ слова - " + key;
                }
                return result;
            }
            public static void delHash(string text)
            {
                int key = 0;
                string result = "";
                foreach (int i in text) key = key + i;
                key = key % m;
                if (hashArray[key] == null)
                {
                    result = "Слово " + text + " не найдено.";
                } else
                {
                    int del = 0;
                    hashList p = Start;
                    
                    while (p.next != null)
                    {
                        if (p.info == text)
                        {
                            if (p == p.last) p.info = null;
                            else
                            {
                                p.prev.next = p.next;
                                p = null;
                            } 
                            del = 1;
                        }
                        else p = p.next;
                    }
                    if (del == 0) result = "Слово " + text + " не найдено.";
                    else result = "Слово " + text + " найдено. Слово удалено";
                }
            }
            public static string printHash()
            {
                hashList p = Start;
                string result = "Вывод хеша\n";
                for (int i = 0; i < m; i++)
                {
                    result = result + i + ":    ";
                    while(hashArray[i] != null)
                    {
                        result = result + hashArray[i].info + "    ";
                        hashArray[i] = hashArray[i].next;
                    }
                }
                result = result + "\nВывод завершен";
                return result;
            }
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
                        Hash.addHash((Console.ReadLine()));
                        break;

                    case 2:
                        Console.Write("\nВывод хеша:\n");
                        Console.WriteLine(Hash.printHash());
                        break;

                    case 3:
                        Console.Write("\nВведите элемент:");
                        Console.WriteLine(Hash.searchHash(Console.ReadLine()));
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
