// Вводится число А. Нужно узнать сумму числе от 1 до А.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int sumDigit = SumDigits(number);
    //Console.WriteLine($"{number} --> {SumDigits(number)}");
    Console.WriteLine($"{number} --> {sumDigit}");
}
else
    Console.WriteLine("Введно некорректное число");

int SumDigits(int num)
{
    int sum = default; // неопределенное значение
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
