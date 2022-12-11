// Возведение числа А в степень B.
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = Exponentiation(number1, number2);
Console.WriteLine(sum);
int Exponentiation(int num, int degree)
{
    return degree == 0 ? 1 : num * Exponentiation(num, degree - 1);
}