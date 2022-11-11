//Задача 00. Принмаем на вход число и умножаем его само на себя

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числаs {number} = {square}");