namespace Ex_23_4
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
            button1=new Button();
            label1=new Label();
            textBoxControlType=new TextBox();
            label2=new Label();
            textBoxX=new TextBox();
            textBoxY=new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location=new Point(134, 75);
            button1.Name="button1";
            button1.Size=new Size(94, 29);
            button1.TabIndex=0;
            button1.Text="СОЗДАТЬ";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(37, 40);
            label1.Name="label1";
            label1.Size=new Size(55, 20);
            label1.TabIndex=1;
            label1.Text="БУКВА";
            // 
            // textBoxControlType
            // 
            textBoxControlType.Location=new Point(37, 77);
            textBoxControlType.Name="textBoxControlType";
            textBoxControlType.Size=new Size(55, 27);
            textBoxControlType.TabIndex=2;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(261, 40);
            label2.Name="label2";
            label2.Size=new Size(165, 20);
            label2.TabIndex=3;
            label2.Text="Координаты элемента";
            // 
            // textBoxX
            // 
            textBoxX.Location=new Point(303, 76);
            textBoxX.Name="textBoxX";
            textBoxX.Size=new Size(71, 27);
            textBoxX.TabIndex=4;
            textBoxX.Text="230";
            // 
            // textBoxY
            // 
            textBoxY.Location=new Point(303, 121);
            textBoxY.Name="textBoxY";
            textBoxY.Size=new Size(71, 27);
            textBoxY.TabIndex=5;
            textBoxY.Text="180";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(438, 269);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(label2);
            Controls.Add(textBoxControlType);
            Controls.Add(label1);
            Controls.Add(button1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBoxControlType;
        private Label label2;
        private TextBox textBoxX;
        private TextBox textBoxY;
    }
}