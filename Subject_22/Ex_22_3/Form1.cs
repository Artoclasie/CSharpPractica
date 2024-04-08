namespace Ex_22_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "5,3";
            textBox2.Text = "10,3";
            textBox3.Text = "1,25";
            textBox4.Text = "1,35";
            textBox5.Text = "-6,25";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание начальных данных
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);

            // Цикл для табулирования функции
            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = Math.Pow(a * x, 3) +Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
                textBox6.Text += "x=" + Convert.ToString(x) +"; y=" + Convert.ToString(y) + Environment.NewLine;

                x = x + dx;
            }
        }
    }
}