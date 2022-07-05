/*  Задача 29: Напишите программу, которая задаёт массив из 8 элементов,
 заполненный псевдослучайными числами и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */
//Console.Write("Введите количество элементов в массиве (по усл. задачи это 8): "); // Можно так - будет универсальной
//int length = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
int length = 8;

int[] ArrRnd(int size)
{
    int [] array = new int[size];
    var rnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(-100, 100); 
}
return array;
}
int[] result = ArrRnd(length);

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

