// Задан массив. Нужно перемножить пары элементов массива и создать новый массив. Пара элементов массива -
// первый и последний элементы, второй и предпоследний.
int[] array = CreateArrayRndInt(9, 0, 10);
PrintArray(array);
int[] collection = Number(array);
PrintArray(collection);

int[] Number(int[] arr)
{
    int size = default;
    if (arr.Length % 2 == 0)
        size = arr.Length / 2;
    else
        size = arr.Length / 2 + 1;
    int[] col = new int[size];
    for (int i = 0; i < size; i++)
    {
        col[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0)
        col[size - 1] = arr[size - 1];
    return col;
}
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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