// Вводится трёхзначное число. Нужно показать вторую цифру этого числа. 

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра --> {SecondDigit(number)}");

int SecondDigit(int num)
{
    int secondDigit = num / 10;
    return secondDigit % 10;
}
