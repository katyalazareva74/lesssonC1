// Задан двумерный массив. Нужно узнать сколько встречается раз значение элемента в массиве. Составить частотный словарь.
int[,] matrix1 = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix1);
Console.WriteLine();
int[] array = ReplaceArray(matrix1);
Array.Sort(array);
Console.WriteLine();
PrintArray(array);
int[,] matrix2 = FrequencyNum(array, Size(array));
PrintMatrix(matrix2);

int Size(int[] arr)
{
    int size = 1, num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (num != arr[i])
        {
            num = arr[i];
            size++;
        }
    }
    Console.WriteLine(size);
    return size;
}
int[,] FrequencyNum(int[] arr, int row)
{
    int num = arr[0], count = 1, l = 0;
    int[,] matrix = new int[row, 2];
    for (int i = 1; i < arr.Length; i++)
    {
        if (num == arr[i])
            count++;
        else
        {
            matrix[l, 0] = arr[i - 1];
            matrix[l, 1] = count;
            l++;
            num = arr[i];
            count = 1;
        }
        if (l == row - 1)
        {
            matrix[l, 0] = num;
            matrix[l, 1] = count;
        }
    }
    return matrix;
}
int[] ReplaceArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[count++] = matrix[i, j];
        }
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("{ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("}");
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