// Вводится число. Нужно проверить является ли оно палиндромом. 14212 -> нет, 12821 -> да

Console.Write("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 10)
    Console.WriteLine("Некорректный ввод числа");
else
{
    Console.Write($"{num1} --> ");
    Palindrome(num1, Digit(num1));
}
void Palindrome(int num, int sign)
{
    int count = 0, degree1 = sign - 1, degree2 = 0;
    double frontDigit, backDigit;
    while (count < sign / 2)
    {
        frontDigit = Math.Round((num / Math.Pow(10, degree1) % 10), 0, MidpointRounding.ToZero);
        backDigit = Math.Round((num / Math.Pow(10, degree2) % 10), 0, MidpointRounding.ToZero);
        if (frontDigit == backDigit)
        {
            degree1--;
            degree2++;
            count++;
        }
        else
        {
            Console.WriteLine("Нет");
            break;
        }
    }
    if (count == sign / 2)
        Console.WriteLine("Палиндром ");
}
int Digit(int num)
{
    int count = 0, n = 1;
    while (count < 10)
    {
        num = num / 10;
        if (num != 0)
        {
            n++;
            count++;
        }
        else
            break;
    }
    return n;
}