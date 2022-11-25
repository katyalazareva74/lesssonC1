// Задагн массив из 123 элементов. Нужно узнать сколько двузначных элементов в массиве.
int[] array = CreateArrayRndInt(10, -10, 200);
PrintArray(array);
int number = FindNumber(array);
Console.WriteLine(number);
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
int FindNumber(int[] arr)
{int j=0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] > 10 & arr[i]<99)
        j++;
     
    }
    return j; 
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
