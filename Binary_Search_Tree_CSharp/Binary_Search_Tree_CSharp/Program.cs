using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree_CSharp
{
    //Стороны дерева
    public enum BinSide
    {
        Left,
        Right
    }

    //Дерево и работа с элементами дерева
    public class BinarySearchTree
    {
        public int? INFO { get; private set; } //Значение дерева
        public BinarySearchTree Left { get; set; } //Ссылка на левого наследна
        public BinarySearchTree Right { get; set; } //Ссылка на правого наследника
        public BinarySearchTree Parent { get; set; } //Ссылка на родителя
        public void Insert(int data) //Ввод значения в пустое дерево
        { 
            if (INFO == null || INFO == data)//Вставка значения в корень
            {
                INFO = data;
                return;
            }
            //B случае наличия корня...
            if (INFO > data) //Проверка на принадлежность левой части дерева
            {
                if (Left == null) Left = new BinarySearchTree();
                Insert(data, Left, this);
            }
            else //Проверка на принадлежность правой части дерева
            {
                if (Right == null) Right = new BinarySearchTree();
                Insert(data, Right, this);
            }
        }
        
        //Ввод значения с указанием места и родителя
        private void Insert(int data, BinarySearchTree node, BinarySearchTree parent)
        {

            if (node.INFO == null || node.INFO == data) //Ввод значения на его место
            {
                node.INFO = data;
                node.Parent = parent;
                return;
            }
            if (node.INFO > data) //Проверка на принадлежность левому потомку
            {
                if (node.Left == null)
                    node.Left = new BinarySearchTree();
                Insert(data, node.Left, node);
            }
            else //Проверка на принадлежность правому потомку
            {
                if (node.Right == null)
                    node.Right = new BinarySearchTree();
                Insert(data, node.Right, node);
            }
        }

        //Ввод для удаления
        private void Insert(BinarySearchTree data, BinarySearchTree node, BinarySearchTree parent)
        {
            if (node.INFO == null || node.INFO == data.INFO) //Ввод в новое место
            {
                node.INFO = data.INFO;
                node.Left = data.Left;
                node.Right = data.Right;
                node.Parent = parent;
                return;
            }
            if (node.INFO > data.INFO) //Поиск нового места слева
            {
                if (node.Left == null)
                    node.Left = new BinarySearchTree();
                Insert(data, node.Left, node);
            }
            else //Поиск нового места справа
            {
                if (node.Right == null)
                    node.Right = new BinarySearchTree();
                Insert(data, node.Right, node);
            }
        }

        //Проверка на родителя
        private BinSide? ForParent(BinarySearchTree node)
        {
            if (node.Parent == null)
                return null;
            if (node.Parent.Left == node)
                return BinSide.Left;
            if (node.Parent.Right == node)
                return BinSide.Right;
            return null;
        }

        //Удаление значения
        public void Remove(BinarySearchTree node)
        {
            if (node == null)
                return;
            var me = ForParent(node);
            //В случае терминальной вершины
            if (node.Left == null && node.Right == null)
            {
                if (me == BinSide.Left)
                    node.Parent.Left = null;
                else
                    node.Parent.Right = null;
                return;
            }
            //Вставка правого наследника на место удаляемого, в случае отсутсвия левого наследника
            if (node.Left == null)
            {
                if (me == BinSide.Left)
                    node.Parent.Left = node.Right;
                else
                    node.Parent.Right = node.Right;
                node.Right.Parent = node.Parent;
                return;
            }
            //Вставка левого наследника на место удаляемого, в случае отсутсвия правого наследника
            if (node.Right == null)
            {
                if (me == BinSide.Left)
                    node.Parent.Left = node.Left;
                else
                    node.Parent.Right = node.Left;
                node.Left.Parent = node.Parent;
                return;
            }

            //Если присутствуют оба дочерних узла
            if (me == BinSide.Left)
                node.Parent.Left = node.Right;
            if (me == BinSide.Right)
                node.Parent.Right = node.Right;
            if (me == null)
            {
                var bufLeft = node.Left;
                var bufRightLeft = node.Right.Left;
                var bufRightRight = node.Right.Right;
                node.INFO = node.Right.INFO;
                node.Right = bufRightRight;
                node.Left = bufRightLeft;
                Insert(bufLeft, node, node);
            }
            else
            {
                node.Right.Parent = node.Parent;
                Insert(node.Left, node.Right, node.Right);
            }
        }

        //Поиск удалямого значения
        public void Remove(int data)
        {
            var removeNode = Search(data);
            if (removeNode != null)
                Remove(removeNode);
        }

        //Поиск
        public BinarySearchTree Search(int data)
        {
            if (INFO == data)
                return this;
            if (INFO > data)
                return Search2(data, Left);
            return Search2(data, Right);
        }

        //Поиск
        public BinarySearchTree Search2(int data, BinarySearchTree node)
        {
            if (node == null)
                return null;
            if (node.INFO == data)
                return node;
            if (node.INFO > data)
                return Search2(data, node.Left);
            return Search2(data, node.Right);
        }
    }
    public class BinaryTreeExtensions //Работа с деревом
    {
        //Вывод прямым обходом
        public static void PreOrderPrint(BinarySearchTree node, string space)
        {
            space = space + "     ";
            if (node != null)
            {
                Console.WriteLine(space + node.INFO);
                if (node.Left != null)
                    PreOrderPrint(node.Left, space);
                if (node.Right != null)
                    PreOrderPrint(node.Right, space);
            }
        }

        //Вывод симетричным обходом
        public static void InOrderPrint(BinarySearchTree node, string space)
        {
            space = space + "     ";
            if (node != null)
            {
                if (node.Left != null)
                    PreOrderPrint(node.Left, space);
                Console.WriteLine(space + node.INFO);
                if (node.Right != null)
                    PreOrderPrint(node.Right, space);
            }
        }

        //Вывод обратным обходом
        public static void PostOrderPrint(BinarySearchTree node, string space)
        {
            space = space + "     ";
            if (node != null)
            {
                if (node.Left != null)
                    PreOrderPrint(node.Left, space);
                if (node.Right != null)
                    PreOrderPrint(node.Right, space);
                Console.WriteLine(space + node.INFO);
            }
        }

        //Поиск элемента с выводом
        public static void SearchPrint(BinarySearchTree node, int x)
        {
            if (node.INFO == x)
                Console.WriteLine("Элемент найден!");
            else if (node.INFO > x & node.Left != null)
                SearchPrint(node.Left, x);
            else if (node.INFO < x & node.Right != null)
                SearchPrint(node.Right, x);
            else
                Console.WriteLine("Элемент НЕ найден!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinarySearchTree();
            Console.WriteLine("Программа дерево поиска.");
            Console.WriteLine("Выполнил студент Айгозин Ильяс, группа ПИ-922");
            Console.WriteLine("Нажмите любую клавишу для продолжения...\n");
            Console.ReadKey();
            Console.Clear();
            int menu = 0;
            while (menu != 5)
            {
                Console.WriteLine("Меню программы");
                Console.WriteLine("1.Добавить значение в дерево");
                Console.WriteLine("2.Удалить значение из дерева");
                Console.WriteLine("3.Поиск значения в дереве");
                Console.WriteLine("4.Вывод дерева");
                Console.WriteLine("5.Выход");
                Console.Write("\nВвод:");
                menu = Convert.ToInt32(Console.ReadLine());
                string space = "";
                switch (menu)
                {
                    case 1:
                        Console.Write("\nЗначение для ввода:");
                        tree.Insert(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 2:
                        Console.Write("\nЗначение для удаления:");
                        tree.Remove(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 3:
                        Console.WriteLine("\nЭлемент для поиска:");
                        BinaryTreeExtensions.SearchPrint(tree, Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("\n1. Вывод с прямым обходом");
                        Console.WriteLine("2. Вывод с симметричным обходом");
                        Console.WriteLine("3. Вывод с обратным обходом");
                        Console.Write("\nВвод:");
                        int printMenu = int.Parse(Console.ReadLine());
                        if (printMenu == 1)
                        {
                            Console.WriteLine("\nПрямой обход:");
                            BinaryTreeExtensions.PreOrderPrint(tree, space);
                        }
                        else if (printMenu == 2)
                        {
                            Console.WriteLine("\nСимметричный обход:");
                            BinaryTreeExtensions.InOrderPrint(tree, space);
                        }
                        else if (printMenu == 3)
                        {
                            Console.WriteLine("\nОбратный обход:");
                            BinaryTreeExtensions.PostOrderPrint(tree, space);
                        }
                        break;
                }
                if (menu != 5)
                {
                    Console.WriteLine("\n\nДля продолжения нажмите Enter...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\n\nДля ВЫХОДА нажмите ENTER...");
                    Console.ReadKey();
                }
            }
        }
    }
}
