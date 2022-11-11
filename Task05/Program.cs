//Задача 05. Вводится число N. Нужно вывести все целые числа в интервале [-N, N].

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count;

if (N < 0)
{
    count = N;
    N = -N;
}
else
    count = -N;

while (count <= N)
{
    Console.Write(count + " ");
    count++;
}
