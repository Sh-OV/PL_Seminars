// Задача № 30. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

Console.Write("Введите количество элементов в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Решение № 1:");
int[] arr = new int[length];
Console.Write("[");
for (int i = 0; i < length-1; i++)
{
    arr[i] = new Random().Next(0, 2);
    Console.Write($"{arr[i]}, ");
}
arr[length-1] = new Random().Next(0, 2);
    Console.WriteLine($"{arr[length-1]}]");

Console.WriteLine();
Console.WriteLine("Решение № 2:");


int[] Arr(int size)
{
    int [] array = new int[size];
    var rnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(0, 2); 
}
return array;
}
int[] result = Arr(length);

void PrintArr (int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[{res[i]}, ");
        else if (i > 0 && i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.Write($"{res[i]}]");
    }
}
PrintArr(result);