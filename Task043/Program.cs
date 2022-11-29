// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
(double k1, double b1) = EnteringNumbers();
(double k2, double b2) = EnteringNumbers();
if (k1 == k2)
    Console.WriteLine("Прямые не пересекаются!");
else
{
    double x = FindX(k1, b1, k2, b2);
    double y = FindY(k1, b1, x);
    Console.WriteLine($"y = {k1}*x + {b1}; y = {k2}*x + {b2} --> ({x} , {y})");
}

(double, double) EnteringNumbers()
{
    Console.Write("Введите параметры прямой: \nk =  ");
    double k = Convert.ToDouble(Console.ReadLine());
    k = Math.Round(k, 1, MidpointRounding.ToZero);
    Console.Write("b =  ");
    double b = Convert.ToDouble(Console.ReadLine());
    b = Math.Round(b, 1, MidpointRounding.ToZero);
    return (k, b);
}
double FindX(double a1, double c1, double a2, double c2)
{
    double fx = (c2 - c1) / (a1 - a2);
    fx = Math.Round(fx, 1, MidpointRounding.ToZero);
    return fx;
}
double FindY(double a1, double c1, double x1)
{
    double fy = a1 * x1 + c1;
    fy = Math.Round(fy, 1, MidpointRounding.ToZero);
    return fy;
}