// На входе случайное трехзначное число. Нужно удалить вторую цифру из этого числа.
int DeleteDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    return firstDigit * 10 + lastDigit;
}

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
Console.WriteLine($"Двухзначное число --> {DeleteDigit(number)}");