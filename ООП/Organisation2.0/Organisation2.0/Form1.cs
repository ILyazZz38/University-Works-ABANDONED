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

namespace Organisation2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
            {
                comboBox5.Items.Insert(i - 1, Convert.ToString(i));
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Organisation.addWorker(textBox1.Text, textBox2.Text, textBox3.Text);
            comboBox4.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            comboBox6.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            MessageBox.Show("Сотрудник добавлен");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Departments dep = Organisation.findWorker(comboBox4.GetItemText(comboBox4.SelectedItem));
            Worker worker = dep.getWorker();
            worker.Cash(Convert.ToInt32(comboBox5.GetItemText(comboBox5.SelectedItem)), Convert.ToInt32(textBox7.Text));
            MessageBox.Show("Зарплата за указанный месяц добавлена");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Departments dep = Organisation.findWorker(comboBox4.GetItemText(comboBox4.SelectedItem));
            Worker worker = dep.getWorker();
            MessageBox.Show("Зарплата сотрудника за год равна: " + worker.plusCash());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Departments dep = Organisation.findWorker(comboBox4.GetItemText(comboBox4.SelectedItem));
            Worker worker = dep.getWorker();
            MessageBox.Show("Зарплата сотрудника за данный месяц равна: " + worker.requestCash(Convert.ToInt32(comboBox5.GetItemText(comboBox5.SelectedItem))));
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Средняя зарплата сотрудников за данный год: " + Organisation.GetWorkersMed());
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Organisation.GetInfo();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Departments dep = Organisation.findWorker(comboBox4.GetItemText(comboBox4.SelectedItem));
            Worker worker = dep.getWorker();
            richTextBox1.Text = worker.INFO();
        }
    }
}
