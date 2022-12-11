// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {number} --> \"");
NaturalNumbers(number);
Console.WriteLine("\" ");
void NaturalNumbers(int n)
{
    if (n != 1)
    {
        Console.Write($"{n}, ");
        NaturalNumbers(n - 1);
    }
    else Console.Write($"{1}");
}