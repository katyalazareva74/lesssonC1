//Задача 08. Принмаем на вход число. Нужно показать все четные числа от 1 до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (N < 2)
    Console.Write("Некорректная попытка ввода числа");

while (count <= N)
{
    Console.Write(count + " ");
    count += 2;
}