using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SotrudForm;

namespace Organization
{
    public partial class Form1 : Form
    {
        //public Worker transit = new Worker();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Worker newWorker = new Worker();
            newWorker.addWorker(textBox1.Text, textBox2.Text, textBox3.Text);
            for (int i = 0; i < 12; i++)
                newWorker.CashMounth[i] = 0;
            DepartamentList.insertWorker(newWorker);
            comboBox1.Items.Add(newWorker.FirstName1 + " " + newWorker.Name1 + " " + newWorker.FatherName1);
            comboBox3.Items.Add(newWorker.FirstName1 + " " + newWorker.Name1 + " " + newWorker.FatherName1);
            MessageBox.Show("Сотрудник добавлен.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
            {
                comboBox2.Items.Insert(i - 1, Convert.ToString(i));
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dep p;
            p = DepartamentList.Start;
            while (comboBox1.GetItemText(comboBox1.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }
            p.info.Cash(Convert.ToInt32(comboBox2.GetItemText(comboBox2.SelectedItem)), Convert.ToInt32(textBox4.Text));
            MessageBox.Show("ЗП сотрудника за указанный месяц добавлена/изменена");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dep p;
            p = DepartamentList.Start;
            while (comboBox1.GetItemText(comboBox1.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }
            MessageBox.Show("ЗП сотрудника за указанный месяц: " + p.info.requestCash(Convert.ToInt32(comboBox2.GetItemText(comboBox2.SelectedItem))));
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dep p;
            p = DepartamentList.Start;
            while (comboBox1.GetItemText(comboBox1.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }
            MessageBox.Show("ЗП сотрудника за год: " + p.info.plusCash());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            dep p;
            p = DepartamentList.Start;
            while (comboBox3.GetItemText(comboBox3.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }
            MessageBox.Show(p.info.INFO());
            string FIO = comboBox3.GetItemText(comboBox3.SelectedItem);
            textBox5.Text = Convert.ToString(DepartamentList.GetNum(FIO));
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = DepartamentList.GetDepINFO();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DepartamentList.GetDepMed());
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int find = DepartamentList.FindDep(textBox6.Text);
            if (find == 1) MessageBox.Show("Данный сотрудник работает в организации");
            else MessageBox.Show("Данный сотрудник не работает в организации");
        }
    }
}
