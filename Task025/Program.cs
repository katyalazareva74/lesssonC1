// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число степени, \nв которую возводится первое число: ");
int degree = Convert.ToInt32(Console.ReadLine());
degree = CheckNumber(degree);
int exponent = Exponentiation(number, degree);
Console.WriteLine($"{number}, {degree} --> {exponent}");

int Exponentiation(int num, int deg)
{
    int exp = 1;
    for (int i = 0; i < deg; i++)
    {
        exp = exp * num;
    }
    return num == 0 ? 0 : exp;
}
int CheckNumber(int num)
{
    while (num < 0)
    {
        Console.WriteLine("Некорректный ввод числа степени!");
        Console.Write("Введите натуральное число степени, \nв которую возводится первое число: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}