//Вводятся координаты двух точек. Нужно найти расстояние между ними. A (3,6,8); B (2,1,-7), -> 15.84 A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите число координат точки ");
int n1 = Convert.ToInt32(Console.ReadLine());
if (n1 > 1)
{
    Console.WriteLine("Введите координаты первой точки ");
    int[] firstPoint = PointCoord(n1);
    Console.WriteLine("Введите координаты второй точки ");
    int[] secondPoint = PointCoord(n1);
    Console.WriteLine($"Расстояние между точками -> {Distance(firstPoint, secondPoint, n1)}");
}
else
    Console.WriteLine("Некорректное число");

int[] PointCoord(int n)
{
    int[] array = new int[n];
    int index = 0, count = 1;
    while (index < n)
    {
        Console.Write($"K{count} = ");
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++; count++;
    }
    return array;
}
double Distance(int[] point1, int[] point2, int n)
{
    int index = 0, sum = 0;
    while (index < n)
    {
        sum = sum + (point1[index] - point2[index]) * (point1[index] - point2[index]);
        index++;
    }
    double distance = Math.Sqrt(sum);
    double result = Math.Round(distance, 2, MidpointRounding.ToZero);
    return result;
}