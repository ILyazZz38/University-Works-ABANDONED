﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SotrudForm
{
    public partial class changeCash : Form
    {
        public changeCash()
        {
            InitializeComponent();
        }

        private void ChangeCash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form Form1 = Application.OpenForms[0];
            Form1.Show();
        }

        private void ChangeCash_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
            {
                comboBox1.Items.Insert(i - 1, Convert.ToString(i));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Transit.worker.CashMounth[Convert.ToInt32(comboBox1.GetItemText(comboBox1.SelectedItem))] != 0)
            {
                Transit.worker.Cash(Convert.ToInt32(comboBox1.GetItemText(comboBox1.SelectedItem)), Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Зарплата изменена");
            }
            else
            {
                MessageBox.Show("Зарплата за данный месяц не установлена.\nУстановите её в соответсвующем меню.");
            }
        }
    }
}
