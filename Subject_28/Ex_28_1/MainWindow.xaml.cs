using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Ex_28_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid mainGrid = new Grid(); 
            Content = mainGrid; 

            chessBoardCanvas = new Canvas();
            chessBoardCanvas.Width = 400;
            chessBoardCanvas.Height = 400;

            mainGrid.Children.Add(chessBoardCanvas); 

            DrawChessBoard(); 
        }
       
        private void DrawChessBoard()
        {
            int boardSize = 8;
            int cellSize = 50;

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    Rectangle cell = new Rectangle();
                    cell.Width = cellSize;
                    cell.Height = cellSize;

                    if ((row + col) % 2 == 0)
                    {
                        cell.Fill = Brushes.White;
                    }
                    else
                    {
                        cell.Fill = Brushes.Black;
                    }

                    Canvas.SetLeft(cell, col * cellSize);
                    Canvas.SetTop(cell, row * cellSize);

                    chessBoardCanvas.Children.Add(cell);
                }
            }
        }
    }
}
