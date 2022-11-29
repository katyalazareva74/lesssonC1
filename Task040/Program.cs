// Вводится три часла - это длины сторон треугольника. 
//Нужно узнать существует ли такой треугольник. Треукгольник существует, если каждая из сторон меньше суммы двух других сторон.
Console.WriteLine("Введите  три числа: ");
int a1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Traiangl(a1, b1, c1) ? "Да" : "Нет");

bool Traiangl(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}