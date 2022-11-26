// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
size = CheckNumber(size);
int[] array = new int[size];
Console.Write($"Введите диапазон значений элементов массива.\nМинимальное значение: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное значение: ");
int maximum = Convert.ToInt32(Console.ReadLine());
array = CreateArrayRndInt(size, minimum, maximum);
PrintArray(array);
int sumElement = SumElement(array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях:  {sumElement}");

int SumElement(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            sum += arr[i];
    }
    return sum;
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
int[] CreateArrayRndInt(int size, int min, int max)
{
    if (min > max)
    {
        int temp = default;
        temp = max;
        max = min;
        min = temp;
    }
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