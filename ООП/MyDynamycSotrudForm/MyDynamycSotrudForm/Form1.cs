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

namespace MyDynamycSotrudForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Вывод месяцев в combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
            {
                comboBox2.Items.Insert(i - 1, Convert.ToString(i));
            }
        }

        //Счетчик заполненности массива
        int full = 0;
        //Добавление сотрудника
        private void Button1_Click(object sender, EventArgs e)
        {
                Worker newWorker = new Worker();
                newWorker.addWorker(textBox1.Text, textBox2.Text, textBox3.Text);
                for (int i = 0; i < 12; i++)
                    newWorker.CashMounth[i] = 0;

                Departament.addSotrud(newWorker ,full);
                comboBox1.Items.Add(newWorker.FirstName1 + " " + newWorker.Name1 + " " + newWorker.FatherName1);
                comboBox3.Items.Add(newWorker.FirstName1 + " " + newWorker.Name1 + " " + newWorker.FatherName1);
                full++;

                MessageBox.Show("Сотрудник добавлен.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Departament.departament.Length;)
            {
                
                if (comboBox3.GetItemText(comboBox3.SelectedItem) == Departament.departament[i].FirstName1 + " " + Departament.departament[i].Name1 + " " + Departament.departament[i].FatherName1)
                {
                    if (Departament.departament[i].CashMounth[Convert.ToInt32(comboBox2.GetItemText(comboBox2.SelectedItem))] == 0)
                    {
                        Departament.departament[i].Cash(Convert.ToInt32(comboBox2.GetItemText(comboBox2.SelectedItem)), Convert.ToInt32(textBox4.Text));
                        MessageBox.Show("Зарплата за " + comboBox2.GetItemText(comboBox2.SelectedItem) + " месяц добавлена.");
                        break;
                    } else
                    {
                        MessageBox.Show("Зарплата за этот месяц уже добавлена.\nПопробуйте изменить её в соответсвующем меню");
                        break;
                    }
                } else
                {
                    i++;
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Departament.departament.Length;)
            {
                if (comboBox3.GetItemText(comboBox3.SelectedItem) == Departament.departament[i].FirstName1 + " " + Departament.departament[i].Name1 + " " + Departament.departament[i].FatherName1)
                {
                    MessageBox.Show("Зарплата за " + comboBox2.GetItemText(comboBox2.SelectedItem) + " месяц: " + Departament.departament[i].requestCash(Convert.ToInt32(comboBox2.GetItemText(comboBox2.SelectedItem))));
                    break;
                } else
                {
                    i++;
                }
            }
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Departament.departament.Length;)
            {
                if (comboBox3.GetItemText(comboBox3.SelectedItem) == Departament.departament[i].FirstName1 + " " + Departament.departament[i].Name1 + " " + Departament.departament[i].FatherName1)
                {
                    if (Departament.departament[i].CashMounth[Convert.ToInt32(comboBox2.GetItemText(comboBox2.SelectedItem))] != 0)
                    {
                        Departament.departament[i].Cash(Convert.ToInt32(comboBox2.GetItemText(comboBox2.SelectedItem)), Convert.ToInt32(textBox4.Text));
                        MessageBox.Show("Зарплата за " + comboBox2.GetItemText(comboBox2.SelectedItem) + " изменена.");
                        break;
                    } else
                    {
                        MessageBox.Show("Невозможно изменить зарплату! Зарплата за данный месяц не была введена.\nВведите её в соответсвующем меню.");
                        break;
                    }
                } else
                {
                    i++;
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Departament.departament.Length;)
            {
                if (comboBox3.GetItemText(comboBox3.SelectedItem) == Departament.departament[i].FirstName1 + " " + Departament.departament[i].Name1 + " " + Departament.departament[i].FatherName1)
                {
                    MessageBox.Show("Зарплата сотрудника за год: " + Departament.departament[i].plusCash());
                    break;
                } else
                {
                    i++;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Departament.departament.Length;)
            {
                if (comboBox1.GetItemText(comboBox1.SelectedItem) == Departament.departament[i].FirstName1 + " " + Departament.departament[i].Name1 + " " + Departament.departament[i].FatherName1)
                {
                    MessageBox.Show(Departament.departament[i].INFO());
                    break;
                } else
                {
                    i++;
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
           textBox5.Text = Departament.getNum(comboBox1.GetItemText(comboBox1.SelectedItem));
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Средняя зарплата сотрудников за год: " + Convert.ToString(Departament.getSredCash(full)));
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Departament.INFOall(full);
        }
    }
}
