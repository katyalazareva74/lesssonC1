//  Вводятся два числа. Нужно узнать является ли одно число квадратом другого.
Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Square(number1, number2) ? "Да" : "Нет");

bool Square(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}