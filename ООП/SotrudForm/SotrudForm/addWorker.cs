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
    public partial class addWorker : Form
    {
        public addWorker()
        {
            InitializeComponent();
        }

        private void AddWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form Form1 = Application.OpenForms[0];
            Form1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Transit.worker.addWorker(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("ФИО сотрудника внесено/изменено");
        }
    }
}
