/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2      */
Console.Clear();
Console.Write("Для создания массива введите количество элементов массива: ");
int digit = Convert.ToInt32(Console.ReadLine());

int [] Array(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
int[] arr = Array(digit);

int EvanNumArr(int [] array)
{
    int[] arr = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
int evanNum = EvanNumArr(arr);

void PrintArr (int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[");
        if (i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.Write($"{res[i]}]");
    }
}
PrintArr(arr);
Console.WriteLine($" --> {evanNum}");
