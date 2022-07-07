// Задача № 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке[10, 99]
Console.Clear();

int [] Array()
{
    int[] array = new int[123];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 150);
    }
    return array;
}
int CountElemArr(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        count++;
    }
    return count;
}

int[] arrayRND = Array();
int countArr = CountElemArr(arrayRND);

void PrintArr (int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[{res[i]}, ");
        else if (i > 0 && i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.WriteLine($"{res[i]}]");
    }
}

PrintArr(arrayRND);
Console.WriteLine($"Количество элементов массива, значения которых лежат  в отрезке[10, 99]:  {countArr}");