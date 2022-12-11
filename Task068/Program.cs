//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int functionAkkerman = FunctionAkkerman(number1, number2);
Console.WriteLine(functionAkkerman);

int FunctionAkkerman(int m, int n)
{
    if (n == 0 && m != 0)
    {
        n = n + 1;
        m = m - 1;
    }
    int a = 1;
    if (m == 3)
        a = Exponentiation(2, m + n - 1);
    if (m == 4)
    {
        int a1 = 2, b = 1;
        for (int i = 1; i < n + 3; i++)
        {
            if (i == n + 3 - 1)
                b = a1;
            a1 = Exponentiation(2, a1);
        }
        a = a1 - b;
    }
    if (m == 1 || m == 2)
        a = Exponentiation(2, m - 1);
    return m == 0 ? 1 + n : a + FunctionAkkerman(m, n - 1);
}
int Exponentiation(int num, int degree)
{
    return degree == 0 ? 1 : num * Exponentiation(num, degree - 1);
}