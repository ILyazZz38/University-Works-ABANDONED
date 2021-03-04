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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ISU = Application.OpenForms[0];
            ISU.Show();
        }

        private void Info_Load(object sender, EventArgs e)
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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == Transit.student1.FirstName1 + " " + Transit.student1.Name1 + " " + Transit.student1.FatherName1)
            {
                richTextBox1.Clear();
                richTextBox1.Text = Transit.student1.infoStudent(AddMark.k1);
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == Transit.student2.FirstName1 + " " + Transit.student2.Name1 + " " + Transit.student2.FatherName1)
            {
                richTextBox1.Clear();
                richTextBox1.Text = Transit.student2.infoStudent(AddMark.k1);
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == Transit.student3.FirstName1 + " " + Transit.student3.Name1 + " " + Transit.student3.FatherName1)
            {
                richTextBox1.Clear();
                richTextBox1.Text = Transit.student3.infoStudent(AddMark.k1);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
