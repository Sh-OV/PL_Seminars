/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int digit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int neg = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int pos = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое число в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

int [] Array(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

int[] arr = Array(digit, neg, pos);

bool Finder(int[] array, int request)
{
    foreach (int i in array)
    {
        if (i == request) return true;
    }
    return false;
}
string finder = Finder(arr, num) == true ? 
                $"Число {num} есть в сгенерированном массиве" : 
                $"Числа {num} нет в сгенерированном массиве";

void PrintArr (int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[{res[i]}, ");
        else if (i > 0 && i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.WriteLine($"{res[i]}]");
    }
}
Console.WriteLine();
PrintArr(arr);
Console.WriteLine(finder);


