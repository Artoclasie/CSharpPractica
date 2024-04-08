namespace Ex_22_2
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
            label1=new Label();
            label2=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            button1=new Button();
            button2=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(50, 37);
            label1.Name="label1";
            label1.Size=new Size(155, 20);
            label1.TabIndex=0;
            label1.Text="Введите значение X: ";
            label1.Click+=label1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(50, 82);
            label2.Name="label2";
            label2.Size=new Size(150, 20);
            label2.TabIndex=1;
            label2.Text="Введите значение Y:";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(211, 34);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(125, 27);
            textBox1.TabIndex=2;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(211, 75);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(125, 27);
            textBox2.TabIndex=3;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(50, 130);
            textBox3.Multiline=true;
            textBox3.Name="textBox3";
            textBox3.Size=new Size(286, 161);
            textBox3.TabIndex=4;
            // 
            // button1
            // 
            button1.Location=new Point(242, 323);
            button1.Name="button1";
            button1.Size=new Size(94, 29);
            button1.TabIndex=5;
            button1.Text="Очистить";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(50, 323);
            button2.Name="button2";
            button2.Size=new Size(94, 29);
            button2.TabIndex=6;
            button2.Text="Пуск";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(383, 400);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}