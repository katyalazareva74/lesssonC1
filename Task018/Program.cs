// Вводятся номер четверти. Нужно определить диапазон точек в этой четверти. X!=0, Y!=0.
Console.WriteLine("Введите номер четверти ");
string quarter = Console.ReadLine();

string Quarter(string num)
{
    if (num == "1")
        return "x > 0 && y > 0";
    if (num == "2")
        return "x < 0 && y > 0";
    if (num == "3")
        return "x < 0 && y < 0";
    if (num == "4")
        return "x > 0 && y < 0";
    return "Ввели некорректное число";
}

Console.WriteLine(Quarter(quarter));