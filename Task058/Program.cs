// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите размер первой матрицы\nКоличество строк: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер второй матрицы\nКоличество строк: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int column2 = Convert.ToInt32(Console.ReadLine());
if (CheckMatrix(row1, column1) || CheckMatrix(row2, column2))
    Console.WriteLine("Матриц с заданными параметрами не существует!");
else
{
    if (ConditionMultiplication(column1, row2))
        Console.WriteLine("Невозможно умножение матриц с заданными параметрами!");
    else
    {
        Console.WriteLine("Введите диапазон значений элементов в матрицах.\nМинимальное значение: ");
        int minimum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Максимальное значение: ");
        int maximum = Convert.ToInt32(Console.ReadLine());
        (minimum, maximum) = CheckNumber(minimum, maximum);
        int[,] matrix1 = CreateMatrixRndInt(row1, column1, minimum, maximum);
        PrintMatrix(matrix1);
        Console.WriteLine();
        int[,] matrix2 = CreateMatrixRndInt(row2, column2, minimum, maximum);
        PrintMatrix(matrix2);
        Console.WriteLine();
        int[,] matrix = MultiplicationMatrix(matrix1, matrix2);
        PrintMatrix(matrix);
    }
}

bool ConditionMultiplication(int columns1, int rows2)
{
    return columns1 != rows2;
}
bool CheckMatrix(int rows, int columns)
{
    return rows < 1 || columns < 1;
}
(int min, int max) CheckNumber(int min, int max)
{
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
    }
    return (min, max);
}
int[,] MultiplicationMatrix(int[,] arr2D1, int[,] arr2D2)
{
    int[,] arr2D = new int[arr2D1.GetLength(0), arr2D2.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            for (int k = 0; k < arr2D1.GetLength(1); k++)
                arr2D[i, j] += arr2D1[i, k] * arr2D2[k, j];
        }
    }
    return arr2D;
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
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],4} ");
        Console.WriteLine("|");
    }
}