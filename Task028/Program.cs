// Вводится число А. Нужно узнать произведение чисел от 1 до А.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int prodDigit = ProdDigits(number);
    Console.WriteLine($"{number} --> {prodDigit}");
}
else
    Console.WriteLine("Введно некорректное число");

int ProdDigits(int num)
{
    int prod = 1; 
    for (int i = 1; i <= num; i++)
    {
        prod = prod * i;
    }
    return prod;
}