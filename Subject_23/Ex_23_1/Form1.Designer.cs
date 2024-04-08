namespace Ex_23_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1=new ListBox();
            button1=new Button();
            label1=new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=20;
            listBox1.Items.AddRange(new object[] { "В корзине лежат 4 яблока. Как разделить их между 4 детьми так, чтобы каждый из них получил по 1 яблоку, и 1 яблоко осталось бы в корзине.", "Занимает 3 место по численности (около 300 млн ч) среди христианских направлений после католицизма (1,25 млрд) и протестантизма (800 млн).", "9 (девять) это натуральное число, расположенное между числами 8 и 10." });
            listBox1.Location=new Point(12, 21);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(1045, 124);
            listBox1.TabIndex=0;
            // 
            // button1
            // 
            button1.Location=new Point(412, 166);
            button1.Name="button1";
            button1.Size=new Size(94, 29);
            button1.TabIndex=1;
            button1.Text="Пуск";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(525, 175);
            label1.Name="label1";
            label1.Size=new Size(50, 20);
            label1.TabIndex=2;
            label1.Text="label1";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1069, 231);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Label label1;
    }
}