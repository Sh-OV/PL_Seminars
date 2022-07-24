/* Задача 56:   Задайте прямоугольный двумерный массив. Напишите программу, 
                 которая будет находить строку с наименьшей суммой элементов.
                 Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();
Console.Write("Введите количество рядов двумерного массива: ");
int oneLevelArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int twoLevelArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxElements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] RandTwoMatrix(int row, int col, int min, int max) // метод создания двумерного массива рандомно
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
int[,] randMatrix = RandTwoMatrix(oneLevelArray, twoLevelArray, minElements, maxElements);

void PrintTwoMatrix(int[,] matrix)      // метод вывода двумерного массива на печать
{
    string digit = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0 && matrix[i, j] < 10) digit = $"      {matrix[i, j]}";
            else if ((matrix[i, j] > 10 && matrix[i, j] < 100) ||
                    (matrix[i, j] > -10 && matrix[i, j] < 0)) digit = $"     {matrix[i, j]}";
            else if ((matrix[i, j] > 100 && matrix[i, j] < 1000) ||
                    (matrix[i, j] > -100 && matrix[i, j] <= -10)) digit = $"    {matrix[i, j]}";
            else if ((matrix[i, j] > 1000 && matrix[i, j] < 10000) ||
                    (matrix[i, j] > -1000 && matrix[i, j] <= -100)) digit = $"   {matrix[i, j]}";
            else if ((matrix[i, j] > 10000 && matrix[i, j] < 1000000) ||
                    (matrix[i, j] > -10000 && matrix[i, j] < -1000)) digit = $"  {matrix[i, j]}";
            else if ((matrix[i, j] > 100000 && matrix[i, j] < 10000000) ||
                    (matrix[i, j] > -100000 && matrix[i, j] < -10000)) digit = $" {matrix[i, j]}";

            if (j == 0) Console.Write("[");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{digit} ");
            if (j == matrix.GetLength(1) - 1) Console.Write($"{digit} ]");
        }
        Console.WriteLine();
    }
}
PrintTwoMatrix(randMatrix);
Console.WriteLine();

int[] RowsSumArray (int[,] matrix)
{
    int[] sumrows  = new int [matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < sumrows.Length; k++)
             {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                        if (i == k) sumrows[k] += matrix[i,j];
                }
             }
        }
    return sumrows;
}
int[] rowsumarr = RowsSumArray (randMatrix);

void PrintArr (int[] res)  // метод вывода одномерного массива на печать
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[{res[i]}, ");
        else if (i > 0 && i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.WriteLine($"{res[i]}]");
    }
}
PrintArr(rowsumarr);
Console.WriteLine();

int FindSmallSumRowArray(int[] array)
{
    int minelem = array[0];
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (minelem > array[i])
        {
            minelem = array[i];
            count = i+1;
        }   
    }
    return count;
}
int res = FindSmallSumRowArray(rowsumarr);

Console.WriteLine($"Наименьшая сумма элементов  - в {res} строке");

