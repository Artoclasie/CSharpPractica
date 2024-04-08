namespace Ex_23_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = listBox1.Text;
            string digits = "";

            foreach (char c in inputString)
            {
                if (Char.IsDigit(c))
                {
                    digits += c +" ";
                }
            }

            label1.Text =  "Öטפנû ג סענמךו: " + digits.Trim();
        }
    }
}