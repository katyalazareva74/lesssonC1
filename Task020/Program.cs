// Вводятся координаты точки. Нужно определить какой четверти принадлежит точка. X!=0, Y!=0.
Console.WriteLine("Введите координаты первой точки ");
Console.Write("X1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки ");
Console.Write("X2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xc1, int yc1, int xc2, int yc2)
{
    double distance = Math.Sqrt((xc1 - xc2) * (xc1 - xc2) + (yc1 - yc2) * (yc1 - yc2));
    double result = Math.Round(distance, 2, MidpointRounding.ToZero);
    return result;
}
Console.WriteLine(Distance(x1, y1, x2, y2));
