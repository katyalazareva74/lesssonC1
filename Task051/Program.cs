
//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. 


int[,] array2D = CreateMatrixRndInt(3, 4, -50, 50);
PrintMatrix(array2D);
//int sum1 = SummaMatrix(array2D);
int sum1 = SummaMatrix1(array2D);
Console.WriteLine(sum1);

int SummaMatrix1(int[,] matrix)
{
    int sum = 0, n = matrix.GetLength(0);
    if (matrix.GetLength(0) > matrix.GetLength(1))
        n = matrix.GetLength(1);
    for (int i = 0; i < n; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}
int SummaMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (i == j)
                sum = sum + matrix[i, j];
    }
    return sum;
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
