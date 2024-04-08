namespace Ex_22_3
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
            label3=new Label();
            label4=new Label();
            label5=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            textBox4=new TextBox();
            textBox5=new TextBox();
            textBox6=new TextBox();
            button1=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(56, 35);
            label1.Name="label1";
            label1.Size=new Size(36, 20);
            label1.TabIndex=0;
            label1.Text="X0=";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(56, 88);
            label2.Name="label2";
            label2.Size=new Size(35, 20);
            label2.TabIndex=1;
            label2.Text="Xk=";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(56, 137);
            label3.Name="label3";
            label3.Size=new Size(37, 20);
            label3.TabIndex=2;
            label3.Text="Dx=";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(253, 38);
            label4.Name="label4";
            label4.Size=new Size(29, 20);
            label4.TabIndex=3;
            label4.Text="A=";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(253, 88);
            label5.Name="label5";
            label5.Size=new Size(28, 20);
            label5.TabIndex=4;
            label5.Text="B=";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(112, 32);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(125, 27);
            textBox1.TabIndex=5;
            textBox1.Text="5,3";
            // 
            // textBox2
            // 
            textBox2.Location=new Point(112, 85);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(125, 27);
            textBox2.TabIndex=6;
            textBox2.Text="10,3";
            // 
            // textBox3
            // 
            textBox3.Location=new Point(112, 134);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(125, 27);
            textBox3.TabIndex=7;
            textBox3.Text="1,25";
            // 
            // textBox4
            // 
            textBox4.Location=new Point(309, 32);
            textBox4.Name="textBox4";
            textBox4.Size=new Size(125, 27);
            textBox4.TabIndex=8;
            textBox4.Text="1,35";
            // 
            // textBox5
            // 
            textBox5.Location=new Point(309, 85);
            textBox5.Name="textBox5";
            textBox5.Size=new Size(125, 27);
            textBox5.TabIndex=9;
            textBox5.Text="-6,25";
            // 
            // textBox6
            // 
            textBox6.Location=new Point(56, 186);
            textBox6.Multiline=true;
            textBox6.Name="textBox6";
            textBox6.ScrollBars=ScrollBars.Vertical;
            textBox6.Size=new Size(378, 269);
            textBox6.TabIndex=10;
            // 
            // button1
            // 
            button1.Location=new Point(188, 478);
            button1.Name="button1";
            button1.Size=new Size(94, 29);
            button1.TabIndex=11;
            button1.Text="Вычислить";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(491, 540);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
    }
}