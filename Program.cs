using project_10_12_24.Classes;

namespace project_10_12_24
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                Matrix matrix = new(3, 3);
                matrix[0, 0] = 1;
                matrix[0, 1] = 2;
                matrix[0, 2] = 3;
                matrix[1, 0] = 4;
                matrix[1, 1] = 5;
                matrix[1, 2] = 6;
                matrix[2, 0] = 7;
                matrix[2, 1] = 8;
                matrix[2, 2] = 9;
                Console.WriteLine(matrix.MinimalElement());
                Matrix matrix1 = new(3, 3);
                matrix1[0, 0] = 9;
                matrix1[0, 1] = 8;
                matrix1[0, 2] = 7;
                matrix1[1, 0] = 6;
                matrix1[1, 1] = 5;
                matrix1[1, 2] = 4;
                matrix1[2, 0] = 3;
                matrix1[2, 1] = 2;
                matrix1[2, 2] = 1;
                Console.WriteLine(matrix1.MinimalElement());
                Matrix matrix2 = matrix + matrix1;
                matrix2.PrintMatrix();
                Matrix matrix3 = matrix - matrix1;
                matrix3.PrintMatrix();
                Matrix matrix4 = matrix * matrix1;
                matrix4.PrintMatrix();
                double num = 3;
                Matrix matrix5 = matrix * num;
                matrix5.PrintMatrix();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
