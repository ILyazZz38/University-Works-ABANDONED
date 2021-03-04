using System;
using Students;
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
    public partial class ISU : Form
    {
      public Student student1 = new Student();
        public ISU()
        {
            InitializeComponent();
        }

   //     public  void AddStudent(string fam, string name, string fath)
   //     {
 //           student1.FirstName = fam;
   //         student1.Name = name;
      //      student1.FatherName = fath;
    //    }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form addStudent = new AddStud();
            addStudent.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form addMark = new AddMark();
            addMark.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form changeMark = new ChangMark();
            changeMark.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form requestMark = new RequestMark();
            requestMark.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form averageMark = new AverageMark();
            averageMark.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form info = new Info();
            info.Show();
            this.Hide();
        }

        private void ISU_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
