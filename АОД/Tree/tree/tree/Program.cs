using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public enum BinSide
    {
        Left,
        Right
    }
    public class BinaryTree
    {

        public long? Data { get; private set; }
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }
        public BinaryTree Parent { get; set; }

        public void Insert(long data)
        {
            if (Data == null || Data == data)
            {
                Data = data;
                return;
            }
            if (Data > data)
            {
                if (Left == null) Left = new BinaryTree();
                Insert(data, Left, this);
            }
            else
            {
                if (Right == null) Right = new BinaryTree();
                Insert(data, Right, this);
            }
        }

        private void Insert(long data, BinaryTree node, BinaryTree parent)
        {

            if (node.Data == null || node.Data == data)
            {
                node.Data = data;
                node.Parent = parent;
                return;
            }
            if (node.Data > data)
            {
                if (node.Left == null) node.Left = new BinaryTree();
                Insert(data, node.Left, node);
            }
            else
            {
                if (node.Right == null) node.Right = new BinaryTree();
                Insert(data, node.Right, node);
            }
        }
 
        private void Insert(BinaryTree data, BinaryTree node, BinaryTree parent)
        {

            if (node.Data == null || node.Data == data.Data)
            {
                node.Data = data.Data;
                node.Left = data.Left;
                node.Right = data.Right;
                node.Parent = parent;
                return;
            }
            if (node.Data > data.Data)
            {
                if (node.Left == null) node.Left = new BinaryTree();
                Insert(data, node.Left, node);
            }
            else
            {
                if (node.Right == null) node.Right = new BinaryTree();
                Insert(data, node.Right, node);
            }
        }

        private BinSide? ForParent(BinaryTree node)
        {
            if (node.Parent == null) return null;
            if (node.Parent.Left == node) return BinSide.Left;
            if (node.Parent.Right == node) return BinSide.Right;
            return null;
        }


        public void Remove(BinaryTree node)
        {
            if (node == null) return;
            var me = ForParent(node);
            //Если у узла нет дочерних элементов, его можно смело удалять
            if (node.Left == null && node.Right == null)
            {
                if (me == BinSide.Left)
                {
                    node.Parent.Left = null;
                }
                else
                {
                    node.Parent.Right = null;
                }
                return;
            }
            //Если нет левого дочернего, то правый дочерний становится на место удаляемого
            if (node.Left == null)
            {
                if (me == BinSide.Left)
                {
                    node.Parent.Left = node.Right;
                }
                else
                {
                    node.Parent.Right = node.Right;
                }

                node.Right.Parent = node.Parent;
                return;
            }
            //Если нет правого дочернего, то левый дочерний становится на место удаляемого
            if (node.Right == null)
            {
                if (me == BinSide.Left)
                {
                    node.Parent.Left = node.Left;
                }
                else
                {
                    node.Parent.Right = node.Left;
                }

                node.Left.Parent = node.Parent;
                return;
            }

            //Если присутствуют оба дочерних узла
            //то правый ставим на место удаляемого
            //а левый вставляем в правый

            if (me == BinSide.Left)
            {
                node.Parent.Left = node.Right;
            }
            if (me == BinSide.Right)
            {
                node.Parent.Right = node.Right;
            }
            if (me == null)
            {
                var bufLeft = node.Left;
                var bufRightLeft = node.Right.Left;
                var bufRightRight = node.Right.Right;
                node.Data = node.Right.Data;
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
        public void Remove(long data)
        {
            var removeNode = Search(data);
            if (removeNode != null)
            {
                Remove(removeNode);
            }
        }

        public BinaryTree Search(long data)
        {
            if (Data == data) return this;
            if (Data > data)
            {
                return Search2(data, Left);
            }
            return Search2(data, Right);
        }

        public BinaryTree Search2(long data, BinaryTree node)
        {
            if (node == null) return null;

            if (node.Data == data) return node;
            if (node.Data > data)
            {
                return Search2(data, node.Left);
            }
            return Search2(data, node.Right);
        }
    }

    public class BinaryTreeExtensions
    {
        public static void PreOrderPrint(BinaryTree node, string space)
        {
            space = space + "     ";
            if (node != null)
            {
                Console.WriteLine(space + node.Data);
                if (node.Left != null) PreOrderPrint(node.Left, space);
                if (node.Right != null) PreOrderPrint(node.Right, space);
            }
        }

        public static void InOrderPrint(BinaryTree node, string space)
        {
            space = space + "     ";
            if (node != null)
            {
                if (node.Left != null) PreOrderPrint(node.Left, space);
                Console.WriteLine(space + node.Data);
                if (node.Right != null) PreOrderPrint(node.Right, space);
            }
        }

        public static void PostOrderPrint(BinaryTree node, string space)
        {
            space = space + "     ";
            if (node != null)
            {
                if (node.Left != null) PreOrderPrint(node.Left, space);
                if (node.Right != null) PreOrderPrint(node.Right, space);
                Console.WriteLine(space + node.Data);
            }
        }

        public static void SearchPrint(BinaryTree node, int x)
        {
            if (node.Data != x) Console.WriteLine("Элемент НЕ найден!");
            else if (node.Data > x) SearchPrint(node.Left, x);
            else if (node.Data < x)SearchPrint(node.Right, x);
            else if (node.Data == x) Console.WriteLine("Элемент найден!");
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree();

            int exit = 0;
            
                Console.WriteLine("Программа Б-Дерево");
            Console.WriteLine("Выполнил Айгозин Ильяс. ПИ-922");
            Console.WriteLine("Нажмите любую клавишу для продолжения...\n");
            Console.ReadKey();
            while (exit != 1) {
            Console.WriteLine("Меню программы");
            Console.WriteLine("1.Добавить значение в дерево");
            Console.WriteLine("2.Удалить значение");
            Console.WriteLine("3.Поиск значения");
            Console.WriteLine("4.Вывод с прямым обходом");
            Console.WriteLine("5.Вывод с симметричным обходом");
            Console.WriteLine("6.Вывод с обратным обходом");
            Console.WriteLine("7.Выход");
            Console.Write("\nВведите ваше значение: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            string space = "";

            switch (menu)
            {
                case 1:
                    Console.Write("\nКакое значение ввести: ");
                    tree.Insert(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 2:
                    Console.Write("\nКакое значение удалить: ");
                    tree.Remove(Convert.ToInt32(Console.ReadLine()));
                        break;

                case 3:
                    Console.WriteLine("\nКакой элемент нужно найти: ");
                        BinaryTreeExtensions.SearchPrint(tree, Convert.ToInt32(Console.ReadLine()));
                        break;
                case 4:

                    Console.WriteLine("\nПрямой обход:");
                    BinaryTreeExtensions.PreOrderPrint(tree, space);
                    break;

                case 5:
                    Console.WriteLine("\nСимметричный обход:");
                    BinaryTreeExtensions.InOrderPrint(tree, space);
                    break;

                case 6:
                    Console.WriteLine("\nОбратный обход:");
                    BinaryTreeExtensions.PostOrderPrint(tree, space);
                    break;

                case 7:
                    exit = 1;
                    break;
            }
                Console.WriteLine("\n\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
            Console.Clear();
            }
        }
    }
}
