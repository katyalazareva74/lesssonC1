// Ввести число. Узнать количество цифр в числе
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = Digits(number);
Console.WriteLine($"{number} --> {digit}");

int Digits(int num)
{
    int n = 0;
    while (num != 0)
    {
        num = num / 10;
        n++;
    }
    return n == 0 ? 1 : n;
}
