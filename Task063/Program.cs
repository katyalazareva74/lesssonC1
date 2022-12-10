// Вывести все числа от 1 до N.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}

