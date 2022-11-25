// Задан массив. Присутствует ли в массиве заданное число.
int[] array = CreateArrayRndInt(10, -10, 10);
PrintArray(array);
Console.WriteLine(FindNumber(array, 4) ? "yes" : "no");
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
bool FindNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] == num)
        return true;
     
    }
    return false; 
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