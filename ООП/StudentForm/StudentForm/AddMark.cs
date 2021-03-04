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
    public partial class AddMark : Form
    {
        public AddMark()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddMark_Load(object sender, EventArgs e)
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


            comboBox2.Items.Insert(0,"Программирование");
            comboBox2.Items.Insert(1,"Математика");
            comboBox2.Items.Insert(2,"Физ.Культура");


            comboBox3.Items.Insert(0, "1");
            comboBox3.Items.Insert(1, "2");
            comboBox3.Items.Insert(2, "3");
            comboBox3.Items.Insert(3, "4");
            comboBox3.Items.Insert(4, "5");
        }

        private void AddMark_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ISU = Application.OpenForms[0];
            ISU.Show();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public static double k1 = 0, k2 = 0,k3 = 0;
        
        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == Transit.student1.FirstName1 + " " + Transit.student1.Name1 + " " + Transit.student1.FatherName1)
            {
                if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Программирование" & Transit.student1.MarkProgram == 0)
                {
                    int menu = 1;
                    Transit.student1.addMark(menu, Convert.ToDouble(comboBox3.SelectedItem));
                    k1++;
                    MessageBox.Show("Оценка внесена");
                } else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Программирование" & Transit.student1.MarkProgram != 0)
                {
                    MessageBox.Show("Оценка по данному предмету уже стоит!\nПопробуйте изменить её в соответсвующем меню");
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Математика" & Transit.student1.MarkMath == 0)
                {
                    int menu = 2;
                    Transit.student1.addMark(menu, Convert.ToDouble(comboBox3.SelectedItem));
                    k1++;
                    MessageBox.Show("Оценка внесена");
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Математика" & Transit.student1.MarkMath != 0)
                {
                    MessageBox.Show("Оценка по данному предмету уже стоит!\nПопробуйте изменить её в соответсвующем меню");
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Физ.Культура" & Transit.student1.MarkSport == 0)
                {
                    int menu = 3;
                    Transit.student1.addMark(menu, Convert.ToDouble(comboBox3.SelectedItem));
                    k1++;
                    MessageBox.Show("Оценка внесена");
                } else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Физ.Культура" & Transit.student1.MarkSport != 0)
                {
                    MessageBox.Show("Оценка по данному предмету уже стоит!\nПопробуйте изменить её в соответсвующем меню");
                }
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == Transit.student2.FirstName1 + " " + Transit.student2.Name1 + " " + Transit.student2.FatherName1)
            {
                if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Программирование" & Transit.student2.MarkProgram == 0)
                {
                    int menu = 1;
                    Transit.student2.addMark(menu, Convert.ToDouble(comboBox3.SelectedItem));
                    k2++;
                    MessageBox.Show("Оценка внесена");
                } else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Программирование" & Transit.student2.MarkProgram != 0)
                {
                    MessageBox.Show("Оценка по данному предмету уже стоит!\nПопробуйте изменить её в соответсвующем меню");
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Математика" & Transit.student2.MarkMath == 0)
                {
                    int menu = 2;
                    Transit.student2.addMark(menu, Convert.ToDouble(comboBox3.SelectedItem));
                    k2++;
                    MessageBox.Show("Оценка внесена");
                } else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Математика" & Transit.student2.MarkMath != 0)
                {
                    MessageBox.Show("Оценка по данному предмету уже стоит!\nПопробуйте изменить её в соответсвующем меню");
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Физ.Культура" & Transit.student2.MarkSport == 0)
                {
                    int menu = 3;
                    Transit.student2.addMark(menu, Convert.ToDouble(comboBox3.SelectedItem));
                    k2++;
                    MessageBox.Show("Оценка внесена");
                } else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Физ.Культура" & Transit.student2.MarkSport != 0)
                {
                    MessageBox.Show("Оценка по данному предмету уже стоит!\nПопробуйте изменить её в соответсвующем меню");
                }
                
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == Transit.student3.FirstName1 + " " + Transit.student3.Name1 + " " + Transit.student3.FatherName1)
            {
                if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Программирование" & Transit.student3.MarkProgram == 0)
                {
                    int menu = 1;
                    Transit.student3.addMark(menu, Convert.ToDouble(comboBox3.SelectedItem));
                    k3++;
                    MessageBox.Show("Оценка внесена");
                } else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Программирование" & Transit.student3.MarkProgram != 0)
                {
                    MessageBox.Show("Оценка по данному предмету уже стоит!\nПопробуйте изменить её в соответсвующем меню");
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Математика" & Transit.student3.MarkMath == 0)
                {
                    int menu = 2;
                    Transit.student3.addMark(menu, Convert.ToDouble(comboBox3.SelectedItem));
                    k3++;
                    MessageBox.Show("Оценка внесена");
                } else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Математика" & Transit.student3.MarkMath != 0)
                {
                    MessageBox.Show("Оценка по данному предмету уже стоит!\nПопробуйте изменить её в соответсвующем меню");
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Физ.Культура" & Transit.student3.MarkSport == 0)
                {
                    int menu = 3;
                    Transit.student3.addMark(menu, Convert.ToDouble(comboBox3.SelectedItem));
                    k3++;
                    MessageBox.Show("Оценка внесена");
                } else if (comboBox2.GetItemText(comboBox2.SelectedItem) == "Физ.Культура" & Transit.student3.MarkSport != 0)
                {
                    MessageBox.Show("Оценка по данному предмету уже стоит!\nПопробуйте изменить её в соответсвующем меню");
                }
            }
         }
    }
}

