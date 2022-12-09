//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите размер матрицы\nКоличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
if (CheckMatrix(row, column))
    Console.WriteLine("Матрицы с заданными параметрами не существует!");
else
{
    Console.WriteLine("Введите диапазон значений элементов в матрице.\nМинимальное значение: ");
    int minimum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Максимальное значение: ");
    int maximum = Convert.ToInt32(Console.ReadLine());
    (minimum, maximum) = CheckNumber(minimum, maximum);
    int[,] matrix1 = CreateMatrixRndInt(row, column, minimum, maximum);
    PrintMatrix(matrix1);
    Console.WriteLine();
    Console.WriteLine("Элементы каждой строки матрицы упорядочены по убыванию ");
    SortElementRow(matrix1);
    PrintMatrix(matrix1);
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
void SortElementRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1) - 1; l++)
        {
            int min = matrix[i, 0];
            for (int j = 1; j < matrix.GetLength(1) - l; j++)
            {
                if (matrix[i, j] < min)
                    min = matrix[i, j];
                else
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = min;
                    matrix[i, j - 1] = temp;
                }
            }
        }
    }
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
