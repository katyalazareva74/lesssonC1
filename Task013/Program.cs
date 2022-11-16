// Вводится число. Нужно вывести 3 цифру этого числа или сообщить, что третьей цифры нет.

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (ThreeDigit(number) < 100)
    Console.WriteLine($"{number} --> Нет третьей цифры");
else
    Console.WriteLine($"{number} --> {ThirdDigit(ThreeDigit(number))}");

int ThreeDigit(int num)
{
    if (num < 0)
        num = -num;
    while (num >= 1000)
    {
        num = num / 10;
    }
    return num;
}

int ThirdDigit(int num)
{
    return num % 10;
}