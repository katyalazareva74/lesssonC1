// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigit = SumDigit(number);
Console.WriteLine($"{number} --> {sumDigit}");

int SumDigit(int num)
{
    int a = default, sum = 0;
    while (num != 0)
    {
        a = num % 10;
        num = num / 10;
        sum = sum + a;
    }
    return sum < 0 ? -sum : sum;
}