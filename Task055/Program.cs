// В двумерном массиве заменить строки на столбцы, в случае невозможности это сделать, написать об этом пользователю.
int[,] matrix1 = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix1);
Console.WriteLine();
if (CheckRowsColumns(matrix1))
{
    ReplaceRowsColumns(matrix1);
    Console.WriteLine();
    PrintMatrix(matrix1);
}
else
    Console.WriteLine("Невозможно сделать замену!");

bool CheckRowsColumns(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}
void ReplaceRowsColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
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
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],4} ");
        Console.WriteLine();
    }
}