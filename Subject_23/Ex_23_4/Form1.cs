namespace Ex_23_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string controlType = textBoxControlType.Text.ToUpper();
            int x = Convert.ToInt32(textBoxX.Text);
            int y = Convert.ToInt32(textBoxY.Text);

            Control newControl = null;

            switch (controlType)
            {
                case "К":
                    newControl = new Button();
                    newControl.BackColor = Color.LightBlue;
                    newControl.Size = new Size(100, 50);
                    break;
                case "П":
                    newControl = new TextBox();
                    newControl.BackColor = Color.LightGreen;
                    newControl.Size = new Size(150, 30);
                    break;
                case "М":
                    newControl = new Label();
                    newControl.BackColor = Color.LightPink;
                    newControl.Size = new Size(120, 40);
                    break;
                default:
                    MessageBox.Show("Некорректный тип элемента управления.");
                    return;
            }

            newControl.Location = new Point(x, y);
            this.Controls.Add(newControl);

            newControl.MouseEnter += (s, ev) =>
            {
                this.Controls.Remove(newControl);
            };
        }
    }
}