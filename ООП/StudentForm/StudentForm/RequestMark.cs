using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class RequestMark : Form
    {
        public RequestMark()
        {
            InitializeComponent();
        }

        private void RequestMark_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ISU = Application.OpenForms[0];
            ISU.Show();
        }

        private void RequestMark_Load(object sender, EventArgs e)
        {
            if (Transit.student1.FatherName1 != null)
            {
                comboBox1.Items.Insert(0, Transit.student1.FirstName1 + " " + Transit.student1.Name1 + " " + Transit.student1.FatherName1);
            }
            if (Transit.student2.FatherName1 != null)
            {
                comboBox1.Items.Insert(1, Transit.student2.FirstName1 + " " + Transit.student2.Name1 + " " + Transit.student2.FatherName1);
            }
            if (Transit.student3.FatherName1 != null)
            {
                comboBox1.Items.Insert(2, Transit.student3.FirstName1 + " " + Transit.student3.Name1 + " " + Transit.student3.FatherName1);
            }


            comboBox2.Items.Insert(0, "Программирование");
            comboBox2.Items.Insert(1, "Математика");
            comboBox2.Items.Insert(2, "Физ.Культура");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == Transit.student1.FirstName1 + " " + Transit.student1.Name1 + " " + Transit.student1.FatherName1)
            {
                if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Программирование")
                {
                    int menu = 1;
                    MessageBox.Show("Оценка за предмет: " + Convert.ToString(Transit.student1.requestMark(menu)));
                    
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Математика")
                {
                    int menu = 2;
                    MessageBox.Show("Оценка за предмет: " + Convert.ToString(Transit.student1.requestMark(menu)));
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Физ.Культура")
                {
                    int menu = 3;
                    MessageBox.Show("Оценка за предмет: " + Convert.ToString(Transit.student1.requestMark(menu)));
                }
            }
            else if (comboBox1.GetItemText(comboBox1.SelectedItem) == Transit.student2.FirstName1 + " " + Transit.student2.Name1 + " " + Transit.student2.FatherName1)
            {
                if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Программирование")
                {
                    int menu = 1;
                    MessageBox.Show("Оценка за предмет: " + Convert.ToString(Transit.student2.requestMark(menu)));
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Математика")
                {
                    int menu = 2;
                    MessageBox.Show("Оценка за предмет: " + Convert.ToString(Transit.student2.requestMark(menu)));
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Физ.Культура")
                {
                    int menu = 3;
                    MessageBox.Show("Оценка за предмет: " + Convert.ToString(Transit.student2.requestMark(menu)));
                }
            }
            else if (comboBox1.GetItemText(comboBox1.SelectedItem) == Transit.student3.FirstName1 + " " + Transit.student3.Name1 + " " + Transit.student3.FatherName1)
            {
                if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Программирование")
                {
                    int menu = 1;
                    MessageBox.Show("Оценка за предмет: " + Convert.ToString(Transit.student3.requestMark(menu)));
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Математика")
                {
                    int menu = 2;
                    MessageBox.Show("Оценка за предмет: " + Convert.ToString(Transit.student3.requestMark(menu)));
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Физ.Культура")
                {
                    int menu = 3;
                    MessageBox.Show("Оценка за предмет: " + Convert.ToString(Transit.student3.requestMark(menu)));
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
