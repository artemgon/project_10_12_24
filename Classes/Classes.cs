
namespace project_10_12_24.Classes
{
    public class Matrix
    {
        private double[,] _matrix;
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public double[,] MatrixData
        {
            get => _matrix;
            private set => _matrix = value;
        }
        public Matrix()
        {
            _matrix = new double[0, 0];
            Rows = 0;
            Columns = 0;
        }
        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new ArgumentException("Rows and columns must be positive integers.");
            }
            Rows = rows;
            Columns = columns;
            _matrix = new double[rows, columns];
        }
        public double this[int row, int column]
        {
            get
            {
                if (row < 0 || row >= Rows || column < 0 || column >= Columns)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
                return _matrix[row, column];
            }
            set
            {
                if (row < 0 || row >= Rows || column < 0 || column >= Columns)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
                _matrix[row, column] = value;
            }
        }
        public double MinimalElement()
        {
            double min = _matrix[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (_matrix[i, j] < min)
                    {
                        min = _matrix[i, j];
                    }
                }
            }
            return min;
        }
        public double MaximalElement()
        {
            double max = _matrix[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (_matrix[i, j] > max)
                    {
                        max = _matrix[i, j];
                    }
                }
            }
            return max;
        }
        public void PrintMatrix()
        {
            Console.WriteLine();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(_matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new(matrix1.Rows, matrix2.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix2.Columns; j++)
                {
                    for (int k = 0; k < matrix1.Columns; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix matrix1, double number)
        {
            Matrix result = new(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] * number;
                }
            }
            return result;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Matrix matrix)
            {
                if (Rows != matrix.Rows || Columns != matrix.Columns)
                {
                    return false;
                }
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (_matrix[i, j] != matrix._matrix[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
