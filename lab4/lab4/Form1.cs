using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public int area1, area2;
        public Form1()
        {
            int area1 = Convert.ToInt32(label12);
            int area2 = Convert.ToInt32(label13);
            InitializeComponent();
        }
        public void function()
        {
            int area3 = area1 * area2;
            label11.Text = Convert.ToString(area3);
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            var g = pictureBox1.CreateGraphics();
            Func<string, Point> convert = (s) => new Point(int.Parse(s.Split(',')[0]),
           int.Parse(s.Split(',')[1]));
            var point1 = convert(textBox1.Text);
            var point2 = convert(textBox2.Text);
            var point3 = convert(textBox3.Text);
            var point4 = convert(textBox1.Text);
            var point5 = convert(textBox2.Text);
            var point6 = convert(textBox3.Text);
            var point7 = convert(textBox1.Text);
            var point8 = convert(textBox2.Text);
            g.DrawLines(new Pen(Color.Black, 1), new[] { point1, point2, point3, point1 });
            double area = 0;
            area1 = Convert.ToInt32(Math.Sqrt(Math.Pow(Math.Abs(point2.X - point1.X), 2)
           + Math.Pow(Math.Abs(point2.Y - point1.Y), 2) *
           Math.Sqrt(Math.Pow(Math.Abs(point3.X - point2.X), 2) +
           Math.Pow(Math.Abs(point3.Y - point2.Y), 2) *
           Math.Sqrt(Math.Pow(Math.Abs(point4.X - point3.X), 2) +
           Math.Pow(Math.Abs(point4.Y - point3.Y), 2) *
           Math.Sqrt(Math.Pow(Math.Abs(point5.X - point4.X), 2) +
           Math.Pow(Math.Abs(point5.Y - point4.Y), 2) *
           Math.Sqrt(Math.Pow(Math.Abs(point6.X - point5.X), 2) +
           Math.Pow(Math.Abs(point6.Y - point5.Y), 2) *
           Math.Sqrt(Math.Pow(Math.Abs(point7.X - point6.X), 2) +
           Math.Pow(Math.Abs(point7.Y - point6.Y), 2) *
           Math.Sqrt(Math.Pow(Math.Abs(point8.X - point1.X), 2) +
           Math.Pow(Math.Abs(point8.Y - point1.Y), 2)))))))));
            label12.Text = Convert.ToString(area1);
        }
        public void Button2_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox9.Text);
            var g = pictureBox1.CreateGraphics();
            g.FillEllipse(Brushes.Black, new Rectangle(a, a, 100, 100));
            Invalidate();
            double area = 0;
            area2 = Convert.ToInt32(Math.PI * Math.Pow((a), 2) * 10);
            label13.Text = Convert.ToString(area2);
        }
        private void Label3_Click(object sender, EventArgs e)
        {
        }
        private void Label6_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            function();
        }
    }
}

