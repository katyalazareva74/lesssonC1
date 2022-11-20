// Вводтся число N. Нужно вывести в виде таблицы кубы чисел от 1 до N.
Console.Write("Введите  число ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 0)
    Console.WriteLine("Некорректный ввод числа");
else
    Cube(num1);

void Cube(int num)
{
    int count = 1;
    if (num < 0)
    {
        count = num;
        num = -1;
    }
    while (count <= num)
    {
        Console.WriteLine($"{count} --> {count * count * count}");
        count++;
    }
}