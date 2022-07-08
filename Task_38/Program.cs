// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
Console.WriteLine("Для создания одномерного массива");
Console.Write("Введите количество элементов массива: ");
int digit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int neg = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int pos = Convert.ToInt32(Console.ReadLine());

double [] Array(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() + rnd.Next(min, max+1), 2);
    }
    return array;
}
double[] arr = Array(digit, neg, pos);

void PrintArrDouble (double[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[");
        if (i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.WriteLine($"{res[i]}]");
    }
}
PrintArrDouble(arr);

double[] DiffNumMinMax (double[] array)
{
    double diff = 0.0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    diff = max - min;
    return new[] {min, max, diff};
}
double[] diffNumMinMax = DiffNumMinMax (arr);
Console.WriteLine($"Разница между максимальным ({diffNumMinMax[1]}) и минимальным ({diffNumMinMax[0]}) элементами массива составляет: {diffNumMinMax[2]}");