using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    class ArrayUni
    {
        private static int count = 0;
        private static People[] peoples = new People[10];
        public static void needResize()
        {
            if (count == peoples.Length)
                Array.Resize(ref peoples, peoples.Length + 5);
        }
        public static void addPeople(People people)
        {
            for (int i = 0; i < peoples.Length;)
            {
                if (peoples[i] == null)
                {
                    peoples[i] = people;
                    break;
                }
                else
                    i++;
            }
        }
        public static string getPeople(string FIO)
        {
            string result = "";
            for (int i = 0; i < peoples.Length;)
            {
                if (peoples[i].GetFIO() == FIO)
                {
                    result = peoples[i].GetInfo();
                    break;
                }
                else
                    i++;
            }
            return result;
        }
        public static string getAllPeoples()
        {
            string result = "";
            for (int i = 0; i < peoples.Length;)
            {
                if (peoples[i] != null)
                {
                    result = result + peoples[i].GetInfo() + "\n\n";
                    i++;
                }
                else
                    i++;
            }
            return result;
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
