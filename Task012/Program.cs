// Вводятся два числа. Нужно узнать кратно ли первое число второму. Если нет, то вывести остаток от деления.
Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Multiplicity(number1, number2) ? "Да" : $"Нет, остаток от деления --> {number1 % number2}");

Console.WriteLine(Multiplicity1(number1, number2) == 0 ? "Да" : $"Нет, остаток от деления --> {Multiplicity1(number1, number2)}");

// bool Multiplicity(int num1, int num2)
//{
  //  return num1 % num2 == 0;
//}

int Multiplicity1(int num1, int num2)
{
    return num1 % num2;
}