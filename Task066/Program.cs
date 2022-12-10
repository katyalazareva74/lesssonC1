// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
//Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (number1 > number2)
    sum = SumElement(number2, number1);
else
    sum = SumElement(number1, number2);
Console.WriteLine($"Сумма элементов в промежтке от {number1} до {number2} равна {sum}");

int SumElement(int num1, int num2)
{
    return num1 == num2 ? num2 : num2 + SumElement(num1, num2 - 1);
}