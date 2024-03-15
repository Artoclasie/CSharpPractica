using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex_3_3
{
    class Matrix
    {
        private double[,] _numbers;


        public int RowCount => _numbers.GetLength(0);
        public int ColumnCount => _numbers.GetLength(1);

        public double this[int i, int j]
        {
            get
            {
                if ((i<0 || i>_numbers.GetLength(0)) || (j<0 || j>_numbers.GetLength(1)))
                {

                    throw new IndexOutOfRangeException();
                }
                return _numbers[i, j];
            }
            set
            {
                if ((i<0 || i>_numbers.GetLength(0)) || (j<0 || j>_numbers.GetLength(1)))
                {

                    throw new IndexOutOfRangeException();
                }
                _numbers[i, j] = value;
            }
        }

        public Matrix(int row, int column)
        {
            _numbers=new double[row, column];
        }

        public static Matrix Generate(int row, int column)
        {
            Matrix matrix = new Matrix(row, column);
            Random number = new Random();
            for (int i = 0; i<matrix.RowCount; i++)
            {
                for (int j = 0; j<matrix.ColumnCount; j++)
                {
                    matrix[i, j] = number.NextDouble() * 100;
                }
            }
            return matrix;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _numbers.GetLength(0); i++)
            {
                string line = string.Empty;
                for (int j = 0; j<_numbers.GetLength(1); j++)
                {
                    line+=$"{_numbers[i, j]:N2} ";
                }
                sb.AppendLine(line);
            }
            return sb.ToString();
        }
        public void MatrixChange(int rowNumber)
        {
            for (int i = 0; i < _numbers.GetLength(0); i++)
            {
                if (i != rowNumber - 1)
                {
                    for (int j = 0; j < _numbers.GetLength(1); j++)
                    {
                        _numbers[i, j] -= _numbers[rowNumber - 1, j];
                    }
                }
            }
        }

    }
}
