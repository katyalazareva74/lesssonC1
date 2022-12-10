// Найти сумму цифр в числе N.
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int sum = NaturalNumbers(number1);
Console.WriteLine(sum);

int NaturalNumbers(int num1)
{
    return num1 % 10 == 0 ? 0 : num1 % 10 + NaturalNumbers(num1 / 10);
}
