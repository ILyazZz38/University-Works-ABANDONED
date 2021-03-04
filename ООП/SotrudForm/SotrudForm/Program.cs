using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SotrudForm
{
    public class Transit
    {
        public static Worker worker = new Worker();
        static void FOR()
        {
            for (int i = 1; i < 13; i++)
            {
                worker.CashMounth[i] = 0;
            }
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
