/* Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]8*/
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int digit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int neg = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int pos = Convert.ToInt32(Console.ReadLine());

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

int[] ReplacArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = - arr[i];
    }
    return arr;
}
void PrintArr (int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[{res[i]}, ");
        else if (i > 0 && i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.Write($"{res[i]}]");
    }
}
int[] resArray =  Array(digit, neg, pos);
Console.WriteLine($"Созданный массив генератором случайных чисел: ");
PrintArr (resArray);
int[] replacArray = ReplacArray(resArray);
Console.WriteLine();
Console.WriteLine($"Измененный массив: ");
PrintArr (replacArray);

