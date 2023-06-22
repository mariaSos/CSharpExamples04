// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Заполнение массива
int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int index = 0; index < size; index++)
    {
        array[index] = rand.Next(min, max);
    }
    return array;
}

//Печать массива
void PrintArray(int[] array, string separator)
{
    System.Console.WriteLine("[" + string.Join(separator, array) + "]");
}

//Ввод чисел
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}
////////////////////////////////////////////////
int[] size = ReadInt("Укажите размер массива: ");
int[] rang = ReadInt("Укажите макс. и мин. значения массива через пробел: ");

int[] array = FillArray(size[0], rang[0], rang[1]);
PrintArray(array, ",");