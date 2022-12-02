// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите размер массива.\nКоличество строк и столбцов:  ");
(int rows1, int columns1) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
(rows1, columns1) = CheckNumber(rows1, columns1);
Console.Write($"Введите диапазон значений элементов массива.\nМинимальное значение и максимальное: ");
(double minimum, double maximum) = (Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
double[,] array2D = CreateMatrixRndDouble(rows1, columns1, minimum, maximum);
PrintMatrix(array2D);

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
double[,] CreateMatrixRndDouble(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(matrix[i, j], 1, MidpointRounding.ToZero);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],5} ");
        Console.Write(" |\n");
    }
    Console.WriteLine();
}
