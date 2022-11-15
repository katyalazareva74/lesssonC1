//  Принимаем на вход цифру, обозначающую день недели, и проверяем, является ли этот день выходным.

Console.Write("Введите цифру дня недели ");
int number = Convert.ToInt32(Console.ReadLine());

if (DayWeek(number) == true)
    Console.WriteLine("Нет такого дня недели!");
else
    Console.WriteLine(DayOff(number) ? "Это выходной!" : "Нет, не выходной");

bool DayWeek(int num)
{
    return num < 1 || num > 7;
}

bool DayOff(int num)
{
    return num == 6 || num == 7;
}