// Задан двумерный массив. Нужно узнать сколько встречается раз значение элемента в массиве. Составить частотный словарь.
int[,] matrix1 = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix1);
Console.WriteLine();
(int row2, int column2) = MinElement(matrix1);
Console.WriteLine($"{row2}, {column2}");
int[,] matrix2 = SkippingRowColumn(matrix1, row2, column2);
PrintMatrix(matrix2);

int[,] SkippingRowColumn(int[,] matrix, int row, int column)
{
    int[,] matrix1 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        if (i == row)
            m++;
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (j == column)
                n++;
            matrix1[i, j] = matrix[m, n];
            n++;
        }
        m++; n = 0;
    }
    return matrix1;
}
(int row, int colimn) MinElement(int[,] matrix)
{
    int row1 = 0, column1 = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                row1 = i;
                column1 = j;
            }
    }
    return (row1, column1);
}
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],4} ");
        Console.WriteLine();
    }
}
