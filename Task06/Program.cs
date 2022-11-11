//Задача 06. Принмаем на вход число. Нужно определить является число четным или нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

 if ((num % 2) == 0)
    Console.Write("Число четное");   
else 
    Console.WriteLine("Число нечетное");    