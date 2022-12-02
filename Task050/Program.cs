// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите размер массива.\nКоличество строк и столбцов:  ");
(int rows1, int columns1) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
(rows1, columns1) = CheckNumber(rows1, columns1);
Console.Write($"Введите диапазон значений элементов массива.\nМинимальное значение и максимальное: ");
(double minimum, double maximum) = (Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
double[,] array2D = CreateMatrixRndDouble(rows1, columns1, minimum, maximum);
Console.Write("Введите  позицию элемента в массиве.\nСтрока и столбец:  ");
(int x1, int y1) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
PrintMatrix(array2D);
Console.Write($"[{x1}, {y1}] --> ");
if (CheckElement(x1, y1, rows1, columns1))
{
    double findElement = FindElement(x1, y1, array2D);
    Console.WriteLine(findElement);
}
else
    Console.WriteLine("Элемент массиву не принадлежит!");

bool CheckElement(int x, int y, int rows, int columns)
{
    return ((x >= 0 && x < rows)
    && (y >= 0 && y < columns));
}
double FindElement(int x, int y, double[,] matrix)
{
    int i = 0, j = 0;
    while (i != x)
    {
        i++;
    }
    while (j != y)
    {
        j++;
    }
    return matrix[i, j];
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