// Задача № 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
Console.Clear();
Console.WriteLine("Для создания одномерного массива");
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
int[] arr = Array(digit, neg, pos);

int[] MultiplePirsArr(int[] array1)
{
    int Length = array1.Length;
    int len = 0;
    if (array1.Length % 2 == 0) int len = array1.Length / 2;
    else len = array1.Length / 2 +1;
    int[] array2 = new int[len];
    for (int i = 0; i < len; i++)
    {
        array2[i] = array1[i] * array1[array1.Length - 1 - i];
    }
    if (array1.Length % 2 != 0) array2[len-1] = array1[len-1];
    return array2;
}

int[] arrNew = MultiplePirsArr(arr);

void PrintArr (int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[");
        if (i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.WriteLine($"{res[i]}]");
    }
}
PrintArr(arr);
PrintArr(arrNew);