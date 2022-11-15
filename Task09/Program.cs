// Вывести случайное число и определить в нем наибольшую цифру.
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10, 99]--> {number}");

//int firstdigit = number / 10;
//int seconddigit = number % 10;

//if (firstdigit > seconddigit)
//    Console.WriteLine($"Наибольшая цифра числа  {firstdigit}");
//else
//    Console.WriteLine($"Наибольшая цифра числа  {seconddigit}");
// Создание функции    

int Maxdigit(int num)
{
    int firstdigit = num / 10;
    int seconddigit = num % 10;
    //if (firstdigit > seconddigit)
    //    return (firstdigit);
    //return (seconddigit);

   // int max  = firstdigit > seconddigit ? firstdigit : seconddigit; //  оператор
    // return (max);

    return firstdigit > seconddigit ? firstdigit : seconddigit;
}
int maxdigit = Maxdigit(number);
Console.WriteLine($"Наибольшая цифра числа  {maxdigit}");