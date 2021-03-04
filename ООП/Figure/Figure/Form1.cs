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
                square.move(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), square.geta(), square.geta());
            }
            else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Круг")
            {
                circle.move(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), circle.getrad(), circle.getrad());
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Элипс")
            {
                ellipse.move(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), ellipse.getrad(), ellipse.getrad2());
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Прямоугольник")
            {
                rect.move(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), rect.geta(), rect.GetB());
            }
            pictureBox1.Image = bmp;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Квадрат")
            {
                square.setxy(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                square.seta(Convert.ToInt32(textBox2.Text));
                square.paint(square.geta(), square.geta());
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Круг")
            {
                circle.setxy(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                circle.setrad(Convert.ToInt32(textBox3.Text));
                circle.paint(circle.getrad(), circle.getrad());
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Элипс")
            {
                ellipse.setxy(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                ellipse.setrad(Convert.ToInt32(textBox3.Text));
                ellipse.setrad2(Convert.ToInt32(textBox4.Text));
                ellipse.paint(ellipse.getrad(), ellipse.getrad2());
            } else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Прямоугольник")
            {
                rect.setxy(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                rect.seta(Convert.ToInt32(textBox2.Text));
                rect.SetB(Convert.ToInt32(textBox1.Text));
                rect.paint(rect.geta(), rect.GetB());
            }
            pictureBox1.Image = bmp;
        }
    }
}
