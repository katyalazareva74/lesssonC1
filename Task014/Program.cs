// Вводится число. Нужно узнать число кратно 7 и 23 или нет
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multiplicity2 (number)? "Да" : "Нет");

bool Multiplicity2 (int num){
    return num % 7 == 0 && num % 23 == 0;
}
