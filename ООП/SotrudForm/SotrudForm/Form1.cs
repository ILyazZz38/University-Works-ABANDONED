using System;
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
    public partial class Form1 : Form
    {
         //Worker worker = new Worker();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form addWorker = new addWorker();
            addWorker.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Transit.worker.FirstName1 == "" & Transit.worker.Name1 == "" & Transit.worker.FatherName1 == ""){
                MessageBox.Show("Сначал введите ФИО сотрудника");
            } else
            {
                Form addCash = new Cash();
                addCash.Show();
                this.Hide();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Transit.worker.FirstName1 == "" & Transit.worker.Name1 == "" & Transit.worker.FatherName1 == "")
            {
                MessageBox.Show("Сначал введите ФИО сотрудника");
            }
            else
            {
                Form changeCash = new changeCash();
                changeCash.Show();
                this.Hide();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Transit.worker.FirstName1 == "" & Transit.worker.Name1 == "" & Transit.worker.FatherName1 == "")
            {
                MessageBox.Show("Сначал введите ФИО сотрудника");
            }
            else
            {
                Form requestCash = new requestCash();
                requestCash.Show();
                this.Hide();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (Transit.worker.FirstName1 == "" & Transit.worker.Name1 == "" & Transit.worker.FatherName1 == "")
            {
                MessageBox.Show("Сначал введите ФИО сотрудника");
            }
            else
            {
                MessageBox.Show("Зарплата сотрудника за год: " + Transit.worker.plusCash());
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (Transit.worker.FirstName1 == "" & Transit.worker.Name1 == "" & Transit.worker.FatherName1 == "")
            {
                MessageBox.Show("Сначал введите ФИО сотрудника");
            }
            else
            {
                string info;
                info = Transit.worker.INFO();
                MessageBox.Show(info);
            }
        }

        //private void TextBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
            
        //}

        //private void Form1_Shown(object sender, EventArgs e)
        //{

        //}

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            textBox1.Text = Transit.worker.FirstName1 + " " + Transit.worker.Name1 + " " + Transit.worker.FatherName1;
        }
    }
}
