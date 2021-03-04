using System;

namespace Double_linked
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, x;

            DoubleLinkedList list = new DoubleLinkedList();

            list.CreateList();

            while (true)
            {
                Console.WriteLine("1.Отобразить список");
                Console.WriteLine("2.Вставить в пустой список");
                Console.WriteLine("3.Вставить в начало списка");
                Console.WriteLine("4.Вставить в конец списка");
                Console.WriteLine("5.Вставить после указанного");
                Console.WriteLine("6.Вставить перед указанным");
                Console.WriteLine("7.Удалить первый");
                Console.WriteLine("8.Удалить последний");
                Console.WriteLine("9.Удалить выбранный ");
                Console.WriteLine("10.Перевернуть список");
                Console.WriteLine("11.Выход");
                Console.Write("Выбор: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 11)
                    break;

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        Console.Write("Введите элемент для вставки: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInEmptyList(data);
                        break;
                    case 3:
                        Console.Write("Введите элемент для вставки: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break;
                    case 4:
                        Console.Write("Введите элемент для вставки: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 5:
                        Console.Write("Введите элемент для вставки:  ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите элемент, после которого нужно вставить ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;
                    case 6:
                        Console.Write("Введите элемент для вставки:  ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите элемент, перед которым нужно вставить ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 7:
                        list.DeleteFirstNode();
                        break;
                    case 8:
                        list.DeleteLastNode();
                        break;
                    case 9:
                        Console.Write("Введите удаляемый элемент ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 10:
                        list.ReverseList();
                        break;
                    default:
                        Console.WriteLine("Неправильный выбор");
                        break;

                }
                Console.WriteLine();
            }
            Console.WriteLine("Выход ");
        }
    }
    }


