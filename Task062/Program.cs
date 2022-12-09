// Напишите программу, которая заполнит спирально массив.

Console.WriteLine("Введите размер массива\nКоличество строк: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int column1 = Convert.ToInt32(Console.ReadLine());
if (CheckMatrix(row1, column1))
    Console.WriteLine("Матриц с заданными параметрами не существует!");
else
{
    int[,] matrix1 = CreateSpiralMatrix(row1, column1);
    PrintMatrix(matrix1);
}

bool CheckMatrix(int rows, int columns)
{
    return rows < 1 || columns < 1;
}
int[,] CreateSpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int i = 0, j = 0, k = 0, n = 1, l = 0;
    matrix[0, 0] = 1;
    if (rows > columns)
    {
        if (columns % 2 == 0)
            l = columns + 1;
        else l = columns;
    }
    else l = rows;

    for (k = 0; k < matrix.GetLength(1) - n; k++)
    {
        j++;
        matrix[i, j] = matrix[i, j - 1] + 1;
    }
    for (k = 0; k < matrix.GetLength(0) - n; k++)
    {
        i++;
        matrix[i, j] = matrix[i - 1, j] + 1;
    }
    for (k = 0; k < matrix.GetLength(1) - n; k++)
    {
        j--;
        matrix[i, j] = matrix[i, j + 1] + 1;
    }
    for (n = 2; n < l; n++)
    {
        for (k = 0; k < matrix.GetLength(0) - n; k++)
        {
            i--;
            matrix[i, j] = matrix[i + 1, j] + 1;
        }
        for (k = 0; k < matrix.GetLength(1) - n; k++)
        {
            j++;
            matrix[i, j] = matrix[i, j - 1] + 1;
        }
        if (matrix.GetLength(1) - n == 0)
            n = matrix.GetLength(0) - 1;
        for (k = 0; k < matrix.GetLength(0) - n - 1; k++)
        {
            i++;
            matrix[i, j] = matrix[i - 1, j] + 1;
        }
        if (matrix.GetLength(0) - n - 1 == 0)
            n = matrix.GetLength(1) - 1;
        for (k = 0; k < matrix.GetLength(1) - n - 1; k++)
        {
            j--;
            matrix[i, j] = matrix[i, j + 1] + 1;
        }
        n++;
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],4} ");
        Console.WriteLine("|");
    }
}