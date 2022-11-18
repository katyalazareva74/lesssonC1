// Вводятся номер четверти. Нужно определить диапазон точек в этой четверти. X!=0, Y!=0.
Console.WriteLine("Введите координаты точки ");

int num = Convert.ToInt32(Console.ReadLine());

string Quarter(int num1)
{
    if (num == 1)
        return "x > 0 && y > 0";
    if (num == 2)
        return "x < 0 && y > 0";
    if (num == 3)
        return "x < 0 && y < 0";
    if (num == 4)
        return "x > 0 && y < 0";
    return "Ввели некорректное число";
}

Console.WriteLine(Quarter(num));