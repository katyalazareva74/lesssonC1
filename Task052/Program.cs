//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите размер массива.\nКоличество строк и столбцов:  ");
(int rows1, int columns1) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
(rows1, columns1) = CheckNumber(rows1, columns1);
Console.WriteLine($"Введите диапазон значений элементов массива.\nМинимальное значение и максимальное: ");
(int minimum, int maximum) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
int[,] array2D = CreateMatrixRndInt(rows1, columns1, minimum, maximum);
PrintMatrix(array2D);
double[] array = Average(array2D);
Console.Write("Среднее арифметическое элементов в каждом сотолбце:  ");
PrintArray(array);

double[] Average(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arr[j] += matrix[i, j];
        }
        arr[j] = arr[j] / matrix.GetLength(0);
        arr[j] = Math.Round(arr[j], 1, MidpointRounding.ToZero);
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
        Console.Write(" |\n");
    }
    Console.WriteLine();
}
(int rows, int columns) CheckNumber(int rows, int columns)
{
    while (rows < 1)
    {
        Console.WriteLine("Некорректный ввод числа!");
        Console.Write("Количество строк в массиве:  ");
        rows = Convert.ToInt32(Console.ReadLine());
    }
    while (columns < 1)
    {
        Console.WriteLine("Некорректный ввод числа!");
        Console.Write("Количество столбцов в массиве:  ");
        columns = Convert.ToInt32(Console.ReadLine());
    }
    return (rows, columns);
}
void PrintArray(double[] arr)
{
    Console.Write("{ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.Write("} ");
}