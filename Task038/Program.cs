// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
size = CheckNumber(size);
double[] array = new double[size];
Console.Write($"Введите диапазон значений элементов массива.\nМинимальное значение: ");
double minimum = Convert.ToDouble(Console.ReadLine());
Console.Write("Максимальное значение: ");
double maximum = Convert.ToDouble(Console.ReadLine());
array = CreateArrayRndDouble(size, minimum, maximum);
PrintArray(array);
double difference = DifferenceMinMax(array);
Console.WriteLine($"Разница между минимальным значением элментов массива и \nмаксимальным значением элементов массива {difference}");

double DifferenceMinMax(double[] arr)
{
    double diff = 0, max = arr[0], min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        else
        {
            if (arr[i] < min)
                min = arr[i];
        }
    }
    diff = max - min;
    diff = Math.Round(diff, 2, MidpointRounding.ToZero);
    return diff;
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
double[] CreateArrayRndDouble(int size, double min, double max)
{
    if (min > max)
    {
        double temp = default;
        temp = max;
        max = min;
        min = temp;
    }
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(arr[i], 1, MidpointRounding.ToZero);
    }
    return arr;
}
void PrintArray(double[] arr)
{
    Console.Write("{ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine("}");
}