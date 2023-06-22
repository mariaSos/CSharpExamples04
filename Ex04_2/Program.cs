// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//Сумма цифр в числе
int Counter(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number /= 10;
    }
    return result;
}

//Ввод числа
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
//////////////////////////////////////////////////////////////////////////////
int number = ReadInt("Введите число: ");
System.Console.WriteLine($"Сумма цифр в числе {number} равна {Counter(number)}");

