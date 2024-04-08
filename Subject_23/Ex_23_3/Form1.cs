using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_23_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush treeBrush = Brushes.Green;
            Pen trunkPen = Pens.Brown;

            g.FillRectangle(trunkPen.Brush, 195, 200, 10, 50);

            Point top = new Point(200, 50);
            Point left = new Point(150, 200);
            Point right = new Point(250, 200);
            Point[] trianglePoints = { top, left, right };
            g.FillPolygon(treeBrush, trianglePoints);

            Point top2 = new Point(200, 100);
            Point left2 = new Point(175, 175);
            Point right2 = new Point(225, 175);
            Point[] trianglePoints2 = { top2, left2, right2 };
            g.FillPolygon(treeBrush, trianglePoints2);

            Point top3 = new Point(200, 150);
            Point left3 = new Point(200, 150);
            Point right3 = new Point(200, 150);
            Point[] trianglePoints3 = { top3, left3, right3 };
            g.FillPolygon(treeBrush, trianglePoints3);
        }
    }
}
