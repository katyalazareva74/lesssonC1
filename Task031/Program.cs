// Задан массив из 12 элементов, значения массива задаются из интервала (-9, 9). Нужно найти сумму всех отрицательных
// и положительных элементов массива. Вывести массив.
int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int sumNeg = GetSumNegativeElem(array);
int sumPos = GetSumPositiveElem(array);
Console.WriteLine($"Сумма положительных чисел = {sumPos}");
Console.WriteLine($"Сумма отрицательных чисел = {sumNeg}");

int GetSumNegativeElem(int[] arr)
{
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            sumNegative += arr[i];
    }
    return sumNegative;
}
int GetSumPositiveElem(int[] arr)
{
    int sumPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sumPositive += arr[i];
    }
    return sumPositive;
}
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size]; // массив сейчас заполнен 0
    Random rnd = new Random(); // создаем класс Random, new  выделяет память под объект
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