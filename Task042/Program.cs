// Перевести число из десятичной системы в двоичную.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Binary(number)];
array = Binary1(number);
PrintArray(array);
//string binary = Binary3(number);
//Console.WriteLine(binary);

//string Binary3(int num)
//{
  //  string bin = String.Empty;
    //while (num > 0)
    //{
      //  bin = num % 2 + bin;
        //num = num / 2;
    //}
    //return bin;
//}
int Binary(int num)
{
    int digit = 0;
    while (num != 0)
    {
        num = num / 2;
        digit++;
    }
    return digit;
}
int[] Binary1(int num)
{
    int[] arr = new int[Binary(num)];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[arr.Length - 1 - i] = num % 2;
        num = num / 2;
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("{ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine("}");
}