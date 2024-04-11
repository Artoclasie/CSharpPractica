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
using OxyPlot;
using OxyPlot.Series;

namespace Ex_25_3
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonRun.Click += ButtonRun_Click;
            buttonClose.Click += ButtonClose_Click;
        }

        private void ButtonRun_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(textBoxXmin.Text, out double xMin);
            double.TryParse(textBoxXmax.Text, out double xMax);

            if (double.TryParse(textBoxStep.Text, out double step))
            {
                PlotModel plotModel = new PlotModel();
                LineSeries series = new LineSeries();

                for (double x = xMin; x <= xMax; x += step)
                {
                    double y = Math.Tan(x);
                    series.Points.Add(new DataPoint(x, y));
                }

                plotModel.Series.Add(series);
                plotView.Model = plotModel;
            }
            else
            {
                MessageBox.Show("Введите корректное значение шага h.");
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
