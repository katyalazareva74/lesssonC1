// Вывести последовательность N чисел Фибоначчи.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = Fibonacci(number);
PrintArray(array);
int[] Fibonacci(int n)
{
    int[] arr = new int[n];
    arr[1] = 1;
    for (int i = 2; i < n; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
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