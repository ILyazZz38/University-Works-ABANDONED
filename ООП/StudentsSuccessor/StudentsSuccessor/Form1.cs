using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsSuccessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                comboBox1.Items.Insert(i, i + 1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StudentsArray.needResize();
            if (radioButton1.Checked)
            {
                PaidStudent paidStudent = new PaidStudent(textBox1.Text, Convert.ToByte(comboBox1.GetItemText(comboBox1.SelectedItem)), int.Parse(textBox2.Text));
                StudentsArray.addStudent(paidStudent);
                comboBox2.Items.Add(textBox1.Text);
            }
            else if (radioButton2.Checked)
            {
                StateStudent stateStudent = new StateStudent(textBox1.Text, Convert.ToByte(comboBox1.GetItemText(comboBox1.SelectedItem)), int.Parse(textBox2.Text));
                StudentsArray.addStudent(stateStudent);
                comboBox2.Items.Add(textBox1.Text);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = StudentsArray.getStudent(comboBox2.GetItemText(comboBox2.SelectedItem));
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = StudentsArray.getAllStudent();
        }
    }
}
