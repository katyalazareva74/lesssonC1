// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
size = CheckNumber(size);
Console.Write($"Введите диапазон значений элементов массива.\nМинимальное значение: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное значение: ");
int maximum = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array, minimum, maximum);
PrintArray(array);

void FillArray(int[] arr, int min, int max)
{
    if (min > max)
    {
        int temp = default;
        temp = max;
        max = min;
        min = temp;
    }
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("{ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
            Console.WriteLine($"{arr[i]} }}");
        else
            Console.Write($"{arr[i]}, ");
    }
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