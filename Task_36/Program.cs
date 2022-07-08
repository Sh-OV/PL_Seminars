/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0   */
Console.Clear();
Console.Write("Для создания массива введите количество элементов массива: ");
int digit = Convert.ToInt32(Console.ReadLine());

int [] Array(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
    return array;
}
int[] arr = Array(digit);

int OddElemArr(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}
int sumOddArr = OddElemArr(arr);

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
Console.WriteLine($" --> {sumOddArr}");