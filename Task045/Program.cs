// Сделать копию заданного массива поэлементно.
int[] array = CreateArrayRndInt(7, 10, 50);
PrintArray(array);
CopyArray(array);
PrintArray(array);
int[] CopyArray(int[] arr)
{
    int[] arrCopy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrCopy[i] = arr[i];
    }
    return arrCopy;
}
void PrintArray(int[] arr)
{
    Console.Write("{ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine("}");
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