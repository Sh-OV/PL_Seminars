// Задача № 39. Напишите программу, которая перевернет одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.
Console.Clear();
Console.WriteLine("Для создания одномерного массива");
Console.Write("Введите количество элементов массива: ");
int digit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int neg = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int pos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Решение №1: ");
Console.WriteLine();

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
PrintArr(arr);
int[] ReversArray(int[] array)
{
    int length = array.Length;
    int len = length / 2;
    for (int i = 0; i < len; i++)
    {
        int help = array[i];
        array[i] = array[length-1-i];
        array[length-1-i] = help;
    }
    return array;
}
int[] revarr = ReversArray(arr);

void PrintArr (int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[");
        if (i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.WriteLine($"{res[i]}]");
    }
}
PrintArr(revarr);

Console.WriteLine();
Console.WriteLine("Решение №2 (с созданием нового массива для реверса): ");
Console.WriteLine();


int[] RevArray(int[] array)
{
    int length = array.Length;
    int[] revarray = new int[length];
    for (int i = 0; i < length / 2; i++)
    {
        revarray[i] = array[length-1-i];
        revarray[length-1-i] = array[i];
    }
    if(length % 2 != 0) revarray[length / 2] = array[length / 2];
 //   Console.WriteLine($"array[len] = {array[len]}, array[len + 1] = {array[len + 1]}");
    return revarray;
}
int[] reversarr = RevArray(arr);

PrintArr(arr);
PrintArr(reversarr);

Console.WriteLine();
Console.WriteLine("Решение №3 (решение с преподавателем): ");
Console.WriteLine();

void Revers (int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;

        index1 ++;
        index2 --;
    }
}
PrintArr(arr);
Revers(arr);
PrintArr(arr);