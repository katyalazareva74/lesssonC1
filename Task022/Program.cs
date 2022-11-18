// Вводтся число N. Нужно вывести в виде таблицы квадраты чисел от 1 до N.
Console.WriteLine("Введите  число ");
int num1 = Convert.ToInt32(Console.ReadLine());

void Squar(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} --> {count * count}");
        count++;
    }
}
Squar(num1);