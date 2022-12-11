// Вывести числа в промежутке от N до M.
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number1, number2);

void NaturalNumbers(int num1, int num2)
{
    if (num1 != num2)
    {
        if (num1 < num2)
        {
            NaturalNumbers(num1, num2 - 1);
            Console.Write($"{num2} ");
        }
        else
        {
            Console.Write($"{num1} ");
            NaturalNumbers(num1 - 1, num2);
        }
    }
    else
    {
        Console.Write($"{num1} ");
        return;
    }
}

