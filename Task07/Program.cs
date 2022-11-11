//Задача 07. Вводится трехзначное число N. Нужно вывести последнюю его цифру.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
    num = -num;

int last = num % 10;

Console.WriteLine($"Последняя цифра будет {last}");