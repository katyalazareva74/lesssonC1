// Вводится трёхзначное число. Нужно показать вторую цифру этого числа. 

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
    number = -number;
if (CheckUp(number))
    Console.WriteLine("Некорректный ввод числа");
else
    Console.WriteLine($"Вторая цифра --> {SecondDigit(number)}");

int SecondDigit(int num)
{
    int secondDigit = num / 10;
    return secondDigit % 10;
}

bool CheckUp(int num)
{
    return num < 100 || num > 1000;
}