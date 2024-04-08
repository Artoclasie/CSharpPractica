using System;
using System.Windows.Forms;

namespace Ex_22_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-15,246";
            textBox2.Text = "0,04646";
            textBox3.Text = "0,20001";
            textBox4.Text = "-182,036";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            double x = double.Parse(textBox1.Text);
            textBox5.Text += "X = " + x.ToString();

            double y = double.Parse(textBox2.Text);
            textBox5.Text += Environment.NewLine + "Y = " + y.ToString();

            double z = double.Parse(textBox3.Text);
            textBox5.Text += Environment.NewLine + "Z = " + z.ToString();

            double a = double.Parse(textBox4.Text);
            textBox5.Text += Environment.NewLine + "A = " + a.ToString();

            double f = Math.Pow(y, -Math.Sqrt(Math.Abs(x)));
            double s = x-(y/x);
            double t = Math.Pow(Math.Sin(Math.Atan(z)), 2);
            double u = Math.Log(f*s) + t;

            textBox5.Text += Environment.NewLine +  "Результат U = " + u.ToString();
        }
    }
}