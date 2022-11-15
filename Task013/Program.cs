// Вводится число. Нужно вывести 3 цифру этого числа или сообщить, что третьей цифры нет.

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int threeDigit = ThreeDigit(number);

if (threeDigit == 0)
    Console.WriteLine($"{number} --> Нет третьей цифры");
else
    Console.WriteLine($"{number} --> {ThirdDigit(threeDigit)}");

int ThreeDigit(int num)
{
    if (num < 100)
        return 0;
    else
    {
        while (num >= 1000)
        {
            num = num / 10;
        }
        return num;
    }
}

int ThirdDigit(int num)
{
    return num % 10;
}
