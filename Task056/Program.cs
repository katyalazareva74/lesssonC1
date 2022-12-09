// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
    int[] array = MinSumRow(matrix1);
    int minSum = SortArray(array);
    Console.Write($"В {minSum} строке --> ");
    PrintRow(matrix1, minSum);
    Console.WriteLine($"наименьшая сумма элементов равна {array[minSum - 1]}");
}

void PrintRow(int[,] matrix, int row)
{
    Console.Write("{ ");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        if (i < matrix.GetLength(1) - 1)
            Console.Write($"{matrix[row - 1, i]}, ");
        else Console.Write($"{matrix[row - 1, i]} ");
    }
    Console.WriteLine("}");
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
int SortArray(int[] arr)
{
    int num = 0, min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            num = i;
        }
    }
    return num + 1;
}
int[] MinSumRow(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    int m = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        arr[m] = matrix[i, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            arr[m] += matrix[i, j];
        }
        m++;
    }
    return arr;
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