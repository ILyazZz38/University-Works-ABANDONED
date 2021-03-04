using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Students;

namespace StudentForm
{
    public partial class AddStud : Form
    {
        public AddStud()
        {
            InitializeComponent();
        }



        private void AddStud_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ISU = Application.OpenForms[0];
            ISU.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Transit.student1.FatherName1 == null)
            {
                int x, y;

                Transit.student1.addStud(textBox1.Text, textBox2.Text, textBox3.Text);

                x = Convert.ToInt32(textBox4.Text);
                x++;
                textBox4.Text = Convert.ToString(x);


                y = Convert.ToInt32(textBox5.Text);
                y--;
                textBox5.Text = Convert.ToString(y);

                MessageBox.Show("Студент добавлен!");
            } else if (Transit.student2.FatherName1 == null)
            {
                int x, y;
                Transit.student2.addStud(textBox1.Text, textBox2.Text, textBox3.Text);

                x = Convert.ToInt32(textBox4.Text);
                x++;
                textBox4.Text = Convert.ToString(x);

                y = Convert.ToInt32(textBox5.Text);
                y--;
                textBox5.Text = Convert.ToString(y);

                MessageBox.Show("Студент добавлен!");
            } else if (Transit.student3.FatherName1 == null)
            {
                int x, y;
                Transit.student3.addStud(textBox1.Text, textBox2.Text, textBox3.Text);

                x = Convert.ToInt32(textBox4.Text);
                x++;
                textBox4.Text = Convert.ToString(x);
                

                y = Convert.ToInt32(textBox5.Text);
                y--;
                textBox5.Text = Convert.ToString(y);

                MessageBox.Show("Студент добавлен!");
            } else
            {
                MessageBox.Show("Мест в группе больше нет!");
            }
            
        }
        private void AddStud_Load(object sender, EventArgs e)
        {

        }
    }
}
