// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3
Console.Write("Сколько чисел будет вводиться: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
//I ВАРИАНТ (ВВОД В СТОЛБИК)
array = EnteringNumbers(number);
//II ВАРИАНТ (ВВОД ОДНОЙ СТРОКОЙ)
array = EnteringNumbersStr(number);
int numPositiv = NumberPositiv(array);
PrintArray(array);
Console.WriteLine($"--> {numPositiv}");

int[] EnteringNumbersStr(int n)
{
    string text = String.Empty;
    Console.WriteLine("Введите числа через пробел в одну строку: ");
    text = Console.ReadLine()!;
    string[] arrStr = text!.Split(' ');
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = Convert.ToInt32(arrStr[i]);
    }
    return arr;
}
int[] EnteringNumbers(int n)
{
    int[] arr = new int[n];
    Console.WriteLine("Введите числа: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{i + 1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
int NumberPositiv(int[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) n++;
    }
    return n;
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
    Console.Write("} ");
}