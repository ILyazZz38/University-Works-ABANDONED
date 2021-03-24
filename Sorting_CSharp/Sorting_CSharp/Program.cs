using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_CSharp
{
    class Program
    {
        static int[] BubbleSort(int[] arraySort)
        {
            Console.WriteLine("Сортировка методом обмена");
            Console.WriteLine("Начальный массив:");
            for (int i = 0; i < arraySort.Length; i++)
                Console.Write("{0} - ", arraySort[i]);
            Console.WriteLine("Начинаем сортировку методом обмена...");
            int clipboard;
            for (int i = 0; i <= arraySort.Length - 2; i++)
            {
                bool changedArray = false;
                for (int j = 0; j <= arraySort.Length - i - 2; j++)
                {
                    if (arraySort[j] > arraySort[j + 1])
                    {
                        clipboard = arraySort[j];
                        arraySort[j] = arraySort[j + 1];
                        arraySort[j + 1] = clipboard;
                        changedArray = true;
                    }
                }
                if (changedArray == false)
                    break;
            }
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < arraySort.Length; i++)
                Console.Write("{0} - ", arraySort[i]);
            return arraySort;
        }
        static int[] InsertionSort(int[] arraySort)
        {
            Console.WriteLine("Сортировка методом вставок");
            Console.WriteLine("Начальный массив:");
            for (int i = 0; i < arraySort.Length; i++)
                Console.Write("{0} - ", arraySort[i]);
            Console.WriteLine("Начинаем сортировку методом вставок...");
            int clipboard, x;
            for (int i = 1; i < arraySort.Length; i++)
            {
                clipboard = arraySort[i];
                x = i - 1;
                while (x >= 0 && arraySort[x] > clipboard)
                {
                    arraySort[x + 1] = arraySort[x];
                    x = x - 1;
                }
                arraySort[x + 1] = clipboard;
            }
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < arraySort.Length; i++)
                Console.Write("{0} - ", arraySort[i]);
            return arraySort;
        }
        static int[] selectSort(int[] arraySort)
        {
            Console.WriteLine("Сортировка методом выбора");
            Console.WriteLine("Начальный массив:");
            for (int i = 0; i < arraySort.Length; i++)
                Console.Write("{0} - ", arraySort[i]);
            Console.WriteLine("Начинаем сортировку методом выбора...");
            for (int i = 0; i < arraySort.Length - 1; i++)
            {
                int low = i;
                for (int j = i + 1; j < arraySort.Length; j++)
                {
                    if (arraySort[j] < arraySort[low])
                    {
                        low = j;
                    }
                }
                int clipboard = arraySort[low];
                arraySort[low] = arraySort[i];
                arraySort[i] = clipboard;
            }
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < arraySort.Length; i++)
                Console.Write("{0} - ", arraySort[i]);
            return arraySort;
        }
        static int quickSortWork(int[] arraySort, int left, int right)
        {
            int x = arraySort[right];
            int low = (left - 1);
            for (int j = left; j < right; j++)
            {
                if (arraySort[j] <= x)
                {
                    low++;
                    int clipboard = arraySort[low];
                    arraySort[low] = arraySort[j];
                    arraySort[j] = clipboard;
                }
            }
            int clipboard1 = arraySort[low + 1];
            arraySort[low + 1] = arraySort[right];
            arraySort[right] = clipboard1;
            return low + 1;
        }
        static int[] quickSort(int[] arraySort,int left,int right)
        {
            if (left < right)
            {
                int partitionIndex = quickSortWork(arraySort, left, right);
                quickSort(arraySort, left, partitionIndex - 1);
                quickSort(arraySort, partitionIndex + 1, right);
            }
            return arraySort;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа сортировки. Выполнил студент Айгозин Ильяс, группа ПИ-922");
            Console.WriteLine("Нажмите Enter для продолжения...");
            Console.ReadKey();
            Console.Clear();
            int menu = 0, switchMenu, fullArray = 0;
            int[] array = new int[0];
            while (menu != 5)
            {
                if (fullArray != 0)
                {
                    Console.WriteLine("Массив:");
                    for (int i = 0; i < array.Length; i++)
                        Console.Write("{0} - ", array[i]);
                    Console.Write("Старт программы");
                }
                else
                    Console.Write("Массив не введен");
                Console.WriteLine("\n\nМеню");
                Console.WriteLine("1. Создать массив");
                Console.WriteLine("2. Простейшие методы сортировки");
                Console.WriteLine("3. Быстрая сортировка");
                Console.WriteLine("4. Очистить массив");
                Console.WriteLine("5. Выход");
                Console.Write("Ввод:");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("\n1. Ввести массив вручную");
                        Console.WriteLine("2. Создать рандомный массив");
                        Console.Write("Ввод:");
                        switchMenu = int.Parse(Console.ReadLine());
                        if (switchMenu == 1)
                        {
                            Console.WriteLine("Введите размер массива");
                            int i = int.Parse(Console.ReadLine());
                            array = new int[i];
                            for (int y = 0; y < i; y++)
                            {
                                Console.Write("Введите {0} элемент массива:", y);
                                array[y] = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("Массив создан");
                            fullArray = 1;
                            Console.WriteLine("Массив:");
                            for (int y = 0; y < i; y++)
                                Console.Write("{0} - ", array[y]);
                        }
                        else if (switchMenu == 2)
                        {
                            Console.WriteLine("Введите размер массива");
                            int i = int.Parse(Console.ReadLine());
                            array = new int[i];
                            Random random = new Random();
                            for (int y = 0; y < i; y++)
                            {
                                array[y] = random.Next(0, 100);
                            }
                            Console.WriteLine("Массив создан");
                            fullArray = 1;
                            Console.WriteLine("Массив:");
                            for (int y = 0; y < i; y++)
                                Console.Write("{0} - ", array[y]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n1. Метод обмена (Bubble sort)");
                        Console.WriteLine("2. Метод вставок");
                        Console.WriteLine("3. Метод сортировки выбором");
                        switchMenu = int.Parse(Console.ReadLine());
                        if (switchMenu == 1)
                        {
                            array = BubbleSort(array);
                        }
                        else if (switchMenu ==2)
                        {
                            array = InsertionSort(array);
                        }
                        else if (switchMenu == 3)
                        {
                            array = selectSort(array);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Быстрая сортировка");
                        Console.WriteLine("Начальный массив:");
                        for (int i = 0; i < array.Length; i++)
                            Console.Write("{0} - ", array[i]);
                        Console.WriteLine("Начинаем быструю сортировку...");
                        array = quickSort(array, 0, array.Length - 1);
                        Console.WriteLine("Отсортированный массив:");
                        for (int i = 0; i < array.Length; i++)
                            Console.Write("{0} - ", array[i]);
                        break;
                    case 4:
                        array = new int[0];
                        Console.WriteLine("Массив очищен");
                        fullArray = 0;
                        break;
                }
                if (menu != 5)
                {
                    Console.WriteLine("Для продолжения нажмите Enter...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Для ВЫХОДА нажмите Enter...");
                    Console.ReadKey();
                }
            }
        }
    }
}
