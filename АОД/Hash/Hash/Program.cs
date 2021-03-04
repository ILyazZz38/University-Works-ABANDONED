using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Program
    {
        static int[] hash = new int[10];
        static int count = 0;

        public static void addHash(int element)
        {
            //int square = 1
            int enter = 0, key;
            key = element % hash.Length;
            while (enter != 1)
            {
                if (hash[key] == 0)
                {
                    hash[key] = element;
                    count++;
                    Console.WriteLine("Элемент успешно занесен. его ключ - {0}", key);
                    enter = 1;
                }
                else if (hash[key] != 0 & key == hash.Length)
                {
                    //key = Convert.ToInt32(Math.Pow(square, 2));
                    //square++;
                    key = 0;
                } else if (hash[key] != 0) key++;
            }
        }

        public static void delHash(int element)
        {
            int find = searchHash(element);
            if (find != 0)
            {
                Console.WriteLine("Элемент {0} найден.\nКлюч элемента = {1}.\nПроизводим удаление", element, find);
                hash[find] = 0;
                Console.WriteLine("Элемент удален");
            } else Console.WriteLine("Элемент {0} не найден.\nУдаление невозможно", element);
        }

        public static int searchHash(int element)
        {
            int find = 0, key = element % hash.Length, firstKey = key, circle = 0, result = 0;
            while (find != 1)
            {
                if (hash[key] == element)
                {
                    result = key;
                    find = 1;
                }
                else
                {
                    if (key != firstKey) key++;
                    else if (key == firstKey & circle == 0)
                    {
                        circle = 1;
                        key++;
                    }
                    else if (key == firstKey & circle == 1)
                    {
                        result = 0;
                        find = 1;
                    }
                }
            }
            return result;
        }
        public static string searchHash2(int element)
        {
            string result = "";
            int find = searchHash(element);
            if (find != 0)
            {
                result = "Элемент " + element + " найден.\nКлюч элемента = " + find;
            } else
            {
                result = "Элемент " + element + " не найден.";
            }
            return result;
        }

        public static int isClear()
        {
            int result = 0;
            for (int i = 0; i <= hash.Length-1; i++)
            {
                if (hash[i] != 0)
                {
                    result = 1;
                    break;
                }
            }
            return result;
        }

        public static void reHash()
        {
            double coef = count / hash.Length;
            if (coef >= 0.7)
            {
                Console.WriteLine("Коэфицент заполненности >= 0,7.\nНачинаем процедуру рехешироания.");
                int[] reHash = hash;
                Array.Clear(hash, 0, hash.Length);
                Array.Resize(ref hash, hash.Length + 5);
                for (int i = 0; i <= reHash.Length - 1; i++)
                {
                    if (reHash[i] != 0)
                    {
                        addHash(reHash[i]);
                    }
                }
                //reHash = null;
                Array.Clear(reHash, 0, reHash.Length);
                Console.WriteLine("Рехеширование успешно завершено. Можно продолжать работу.\n\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Хещь сепощьки!");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...\n\n");
            Console.ReadKey();

            for (int i = 0; i <= hash.Length - 1; i++)
            {
                hash[i] = 0;
            }

            int menu, Exit = 0, doReHash; ;
            while(Exit != 1)
            {
                doReHash = isClear();
                if (doReHash != 0) reHash();
                Console.WriteLine("МЕНЮ\n");
                Console.WriteLine("1.Добавить элемент");
                Console.WriteLine("2.Удалить элемент");
                Console.WriteLine("3.Поиск элемента");
                Console.WriteLine("4.Выход");
                Console.Write("\nВвод: ");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Write("\nВведите элемент:");
                        addHash(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 2:
                        Console.Write("\nВведите элемент:");
                        delHash(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write("\nВведите элемент:");
                        searchHash2(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 4:
                        Exit = 1;
                        break;
                }

                if (Exit == 0)
                {
                    Console.Write("Нажмите на любую клавишу для продолжения...");
                } else
                {
                    Console.Write("Нажмите на любую клавишу для подверждения выхода...");
                }
            Console.ReadKey();
            Console.Clear();
            }            
        }
    }
}
