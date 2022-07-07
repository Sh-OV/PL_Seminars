/* Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива. Вывод данных.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.*/
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

int[] GetSumNegPosElem(int[] arr)
{
    int sumneg = 0;
    int sumpos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumpos += arr[i];
        else sumneg += arr[i];
    }
    return new[] {sumneg, sumpos};
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
PrintArr (resArray);
int[] sumNegPosElem = GetSumNegPosElem(resArray);

void PrintGetSumNegPosElem (int[] array)
{
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных чисел массива {array[1]}");
    Console.WriteLine($"Сумма отрицательных чисел массива {array[0]}");
}
PrintGetSumNegPosElem(sumNegPosElem);

 