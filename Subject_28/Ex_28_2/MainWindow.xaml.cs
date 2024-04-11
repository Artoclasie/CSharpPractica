using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex_28_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Ellipse el = new Ellipse();
            el.Width = 100;
            el.Height = 100;
            el.VerticalAlignment = VerticalAlignment.Top;
            el.Fill = Brushes.Green;
            el.Stroke = Brushes.Red;
            el.StrokeThickness = 3;
            grid1.Children.Add(el);

            Ellipse el1 = new Ellipse();
            el1.Width = 100;
            el1.Height = 100;
            el1.VerticalAlignment = VerticalAlignment.Center;
            el1.Fill = Brushes.White;
            el1.Stroke = Brushes.Black;
            el1.StrokeThickness = 3;
            grid1.Children.Add(el1);

            Polygon myTriangle = new Polygon();

            PointCollection points = new PointCollection();
            points.Add(new Point(50, 150));
            points.Add(new Point(150, 50));
            points.Add(new Point(250, 150));
            myTriangle.Points = points;

            myTriangle.Fill = Brushes.Red;

            grid1.Children.Add(myTriangle);

            Polygon myTriangle2 = new Polygon();

            PointCollection points2 = new PointCollection(); 
            points2.Add(new Point(300, 400));
            points2.Add(new Point(400, 300));
            points2.Add(new Point(500, 400));
            myTriangle2.Points = points2;

            myTriangle2.Fill = Brushes.White;
            myTriangle2.Stroke = Brushes.Black;

            grid1.Children.Add(myTriangle2);

            Path sector = new Path();
            sector.Fill = Brushes.Green;

            PathGeometry pathGeometry = new PathGeometry();
            PathFigure pathFigure = new PathFigure();
            pathFigure.StartPoint = new Point(300, 300);

            ArcSegment arcSegment = new ArcSegment(new Point(100, 190), new Size(100, 100), 45, false, SweepDirection.Clockwise, true);
            pathFigure.Segments.Add(arcSegment);

            pathGeometry.Figures.Add(pathFigure);
            sector.Data = pathGeometry;

            grid1.Children.Add(sector);

            this.Content = grid1;
        }
    }
}

 

