// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3
Console.Write("Сколько чисел будет вводиться: ");
int number = Convert.ToInt32(Console.ReadLine());
number = CheckNumber(number);
int[] array = new int[number];
//I ВАРИАНТ (ВВОД В СТОЛБИК)
//array = EnteringNumbers(number);
//II ВАРИАНТ (ВВОД ОДНОЙ СТРОКОЙ)
array = EnteringNumbersStr(number);
int numPositiv = NumberPositiv(array);
PrintArray(array);
Console.WriteLine($"--> {numPositiv}");

string[] Entering(int n)
{
    string text = String.Empty;
    Console.WriteLine("Введите числа через пробел в одну строку: ");
    text = Console.ReadLine()!;
    string[] arrStr1 = text!.Split(' ');
    while (arrStr1.Length < n)
    {
        Console.WriteLine("Введите числа через пробел в одну строку: ");
        text = String.Empty;
        text = Console.ReadLine()!;
        arrStr1 = text!.Split(' ');
    }
    return arrStr1;
}
int[] EnteringNumbersStr(int size)
{
    int[] arr = new int[size];
    string[] arrStr = Entering(size);
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(arrStr[i]);
    }
    return arr;
}
int[] EnteringNumbers(int size)
{
    int[] arr = new int[size];
    Console.WriteLine("Введите числа: ");
    for (int i = 0; i < size; i++)
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
int CheckNumber(int num)
{
    while (num < 1)
    {
        Console.WriteLine("Некорректный ввод числа!");
        Console.Write("Сколько чисел будет вводиться: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}