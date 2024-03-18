using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace Ex_9_2
{
    internal class Matrix : IComparable
    {
        private int[,] _numbers;

        public int RowCount => _numbers.GetLength(0);
        public int ColumnCount => _numbers.GetLength(1);

        public int this[int i, int j]
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
            _numbers=new int[row, column];
        }

        public static Matrix Generate(int row, int column)
        {
            Matrix matrix = new Matrix(row, column);
            Random number = new Random();
            for (int i = 0; i<matrix.RowCount; i++)
            {
                for (int j = 0; j<matrix.ColumnCount; j++)
                {
                    matrix[i, j] = number.Next(0, 10);
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
                    line+=$"{_numbers[i, j]} ";
                }
                sb.AppendLine(line);
            }
            return sb.ToString();
        }
        public Matrix Submatrix(int rowSubMatrix, int columnSubMatrix, int rowToIndexSubMatrex, int columnToIndexSubMatrix)
        {
            if (rowToIndexSubMatrex+rowSubMatrix>RowCount || columnSubMatrix+columnToIndexSubMatrix>ColumnCount)
            {
                throw new IndexOutOfRangeException("Arguments Out of range");
            }

            Matrix matrix = new Matrix(rowSubMatrix, columnSubMatrix);

            for (int i = rowToIndexSubMatrex; i < rowToIndexSubMatrex+rowSubMatrix; i++)
            {
                for (int j = columnToIndexSubMatrix; j <columnToIndexSubMatrix+ columnSubMatrix; j++)
                {
                    matrix[i-rowToIndexSubMatrex, j-columnToIndexSubMatrix]= _numbers[i, j];
                }
            }

            return matrix;

        }
        public void Change(int rowToChange, int columnToChange)
        {
            var minRow = Min(RowCount, rowToChange);
            var minColumn = Min(ColumnCount, columnToChange);
            int[,] temp = new int[rowToChange, columnToChange];
            for (int i = 0; i<minRow; i++)
            {
                for (int j = 0; j<minColumn; j++)
                {
                    temp[i, j]=_numbers[i, j];
                }
            }
            _numbers=temp;

        }

        public void Element(int rowIToIndex, int columnJToIndex)
        {

            if (rowIToIndex>RowCount ||  columnJToIndex>ColumnCount)
            {
                throw new IndexOutOfRangeException("Arguments Out of range");
            }
            int element = 0;
            for (int i = 0; i <_numbers.Length; i++)
            {
                for (int j = 0; j< _numbers.Length; j++)
                {
                    if (i==rowIToIndex && j==columnJToIndex)
                    {
                        element=_numbers[i, j];
                    }
                }
            }
            WriteLine(element);
        }

        int IComparable.CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
