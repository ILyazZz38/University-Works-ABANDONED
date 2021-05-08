using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure
{
    public partial class Form1 : Form
    {
        public static Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            button1.Click += Button1_Click;
        }

        public static circle Circle = new circle(100, 100, 50);
        public static ellipse Ellipse = new ellipse(100, 100, 50, 50);
        public static square Square = new square(100, 100, 50);
        public static rect Rect = new rect(100, 100, 50, 50);

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Квадрат");
            comboBox1.Items.Add("Круг");
            comboBox1.Items.Add("Прямоугольник");
            comboBox1.Items.Add("Элипс");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Квадрат")
            {
                Square.MoveTo(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            }
            else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Круг")
            {
                Circle.MoveTo(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Элипс")
            {
                Ellipse.MoveTo(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Прямоугольник")
            {
                Rect.MoveTo(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            }
            pictureBox1.Image = bmp;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Квадрат")
            {
                square.setxy(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                square.seta(Convert.ToInt32(textBox2.Text));
                Square.Show();
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Круг")
            {
                circle.setxy(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                circle.setrad(Convert.ToInt32(textBox3.Text));
                Circle.Show();
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Элипс")
            {
                ellipse.setxy(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                ellipse.setrad(Convert.ToInt32(textBox3.Text));
                ellipse.setrad2(Convert.ToInt32(textBox4.Text));
                Ellipse.Show();
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Прямоугольник")
            {
                rect.setxy(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                rect.seta(Convert.ToInt32(textBox2.Text));
                rect.SetB(Convert.ToInt32(textBox1.Text));
                Rect.Show();
            }
            pictureBox1.Image = bmp;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
