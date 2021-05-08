using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayUni.needResize();
            if(checkBox1.Checked & checkBox2.Checked)
            {
                StaffStudent staffStudent = new StaffStudent();
                staffStudent.SetFIO(textBox1.Text);
                staffStudent.SetSalary(int.Parse(textBox2.Text));
                staffStudent.SetPay(int.Parse(textBox3.Text));
                ArrayUni.addPeople(staffStudent);
                comboBox1.Items.Add(textBox1.Text);
            }
            else if (checkBox2.Checked)
            {
                Staff staf = new Staff();
                staf.SetFIO(textBox1.Text);
                staf.SetSalary(int.Parse(textBox2.Text));
                ArrayUni.addPeople(staf);
                comboBox1.Items.Add(textBox1.Text);
            }
            else if (checkBox1.Checked)
            {
                Student student = new Student();
                student.SetFIO(textBox1.Text);
                student.SetPay(int.Parse(textBox3.Text));
                ArrayUni.addPeople(student);
                comboBox1.Items.Add(textBox1.Text);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ArrayUni.getPeople(comboBox1.GetItemText(comboBox1.SelectedItem));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ArrayUni.getAllPeoples();
        }
    }
}
