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

namespace OrganisationMediator
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Departments manager = new Departments();
            manager.addManager(textBox5.Text, textBox6.Text, textBox4.Text);
            Organisation.insertManager(manager);
            comboBox1.Items.Add(manager.FirstName1 + " " + manager.Name1 + " " + manager.FatherName1);
            comboBox2.Items.Add(manager.FirstName1 + " " + manager.Name1 + " " + manager.FatherName1);
            comboBox3.Items.Add(manager.FirstName1 + " " + manager.Name1 + " " + manager.FatherName1);

            MessageBox.Show("Администратор добавлен.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            worker.addWorker(textBox1.Text, textBox2.Text, textBox3.Text);
            dep p;
            p = Organisation.Start;
            while (comboBox2.GetItemText(comboBox2.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }
            p.info.insertWorker(worker);

            MessageBox.Show("Сотрудник добавлен");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            dep p;
            p = Organisation.Start;
            while (comboBox3.GetItemText(comboBox3.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }

            comboBox4.Items.Clear();

            Departments manager = new Departments();
            manager = p.info;

            man x = manager.Start1;
            while (x != null)
            {
                comboBox4.Items.Add(x.info.FirstName1 + " " + x.info.Name1 + " " + x.info.FatherName1);
                x = x.next;
            }

            MessageBox.Show("Выбраны сотрудники данного администратора");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            dep p;
            p = Organisation.Start;
            while (comboBox1.GetItemText(comboBox1.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }

            Departments manager = new Departments();
            manager = p.info;

            comboBox6.Items.Clear();

            man x = manager.Start1;
            while (x != null)
            {
                comboBox6.Items.Add(x.info.FirstName1 + " " + x.info.Name1 + " " + x.info.FatherName1);
                x = x.next;
            }

            MessageBox.Show("Выбраны сотрудники данного администратора");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dep p;
            p = Organisation.Start;
            while (comboBox3.GetItemText(comboBox3.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }

            Departments manager = new Departments();
            manager = p.info;

            man x = manager.Start1;
            while (comboBox4.GetItemText(comboBox4.SelectedItem) != x.info.FirstName1 + " " + x.info.Name1 + " " + x.info.FatherName1)
            {
                x = x.next;
            }
            x.info.Cash(Convert.ToInt32(comboBox5.GetItemText(comboBox5.SelectedItem)), Convert.ToInt32(textBox7.Text));
            MessageBox.Show("Зарплата за данный месяц добавлена/изменена");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            dep p;
            p = Organisation.Start;
            while (comboBox3.GetItemText(comboBox3.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }

            Departments manager = new Departments();
            manager = p.info;

            man x = manager.Start1;
            while (comboBox4.GetItemText(comboBox4.SelectedItem) != x.info.FirstName1 + " " + x.info.Name1 + " " + x.info.FatherName1)
            {
                x = x.next;
            }
            MessageBox.Show("Зарплата сотрудника за данный месяц равна: " + x.info.requestCash(Convert.ToInt32(comboBox5.GetItemText(comboBox5.SelectedItem))));
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            dep p;
            p = Organisation.Start;
            while (comboBox3.GetItemText(comboBox3.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }

            Departments manager = new Departments();
            manager = p.info;

            man x = manager.Start1;
            while (comboBox4.GetItemText(comboBox4.SelectedItem) != x.info.FirstName1 + " " + x.info.Name1 + " " + x.info.FatherName1)
            {
                x = x.next;
            }
            MessageBox.Show("Зарплата сотрудника за год равна: " + x.info.plusCash());
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            dep p;
            p = Organisation.Start;
            while (comboBox3.GetItemText(comboBox3.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }

            MessageBox.Show(p.info.GetManMed());
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            dep p;
            p = Organisation.Start;
            while (comboBox1.GetItemText(comboBox1.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }

            Departments manager = new Departments();
            manager = p.info;
            richTextBox1.Text = p.info.GetManINFO();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dep p;
            p = Organisation.Start;
            while (comboBox1.GetItemText(comboBox1.SelectedItem) != p.info.FirstName1 + " " + p.info.Name1 + " " + p.info.FatherName1)
            {
                p = p.next;
            }

            Departments manager = new Departments();
            manager = p.info;

            man x = manager.Start1;
            while (comboBox6.GetItemText(comboBox6.SelectedItem) != x.info.FirstName1 + " " + x.info.Name1 + " " + x.info.FatherName1)
            {
                x = x.next;
            }
            richTextBox1.Text = x.info.INFO();
        }
    }
}
