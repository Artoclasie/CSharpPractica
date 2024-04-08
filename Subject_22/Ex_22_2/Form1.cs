namespace Ex_22_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ��������� �������� ������ �� TextBox
            double x = Convert.ToDouble(textBox2.Text);
            double y = Convert.ToDouble(textBox1.Text);

            // ���� �������� ������ � ���� ����������� 
            textBox3.Text += "��� X = " + textBox2.Text + Environment.NewLine;
            textBox3.Text += "��� Y = " + textBox1.Text + Environment.NewLine;

            // ���������� ���������
            double d;
            if (x > y)
                d = Math.Pow(Math.Pow(x, 2)-y, 3) + Math.Atan(Math.Pow(x, 2));
            else if (x < y)
                d = Math.Pow(y-Math.Pow(x, 2), 3) + Math.Atan(Math.Pow(x, 2));
            else
                d = y * Math.Pow(y + Math.Pow(x, 2), 3) + 0.5;

            // ����� ����������
            textBox3.Text += "d = " + d.ToString() + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}