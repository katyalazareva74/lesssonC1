// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
//построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array3D = CreateArray3DRndInt(3, 3, 3);
PrintArray3D(array3D);

int[,,] CreateArray3DRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int n = 10, m = 68;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = 3 * n / 2 + 6 * m / 5;
                n++;
                if (n > 18)
                    n = 10;
                m = m - 6;
                if (m < 10)
                    m = 68;
            }
        }
    }
    return matrix;
}
void PrintArray3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}{(i, j, k),8}  ");
            }
        }
        Console.WriteLine("|");
    }
}