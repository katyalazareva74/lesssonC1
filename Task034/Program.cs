// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
size = CheckNumber(size);
int[] array = new int[size];
array = CreateArrayRndInt(size, 100, 999);
PrintArray(array);
int number = EvenNumbers(array);
Console.WriteLine($"--> {number}");

int EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    return count;
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
    Console.Write("}");
}
int CheckNumber(int num)
{
    while (num < 1)
    {
        Console.WriteLine("Некорректный ввод числа!");
        Console.Write("Введите размер массива: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}