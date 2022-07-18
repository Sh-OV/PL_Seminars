// Задача № 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.Write("Введите количество рядов двумерного массива: ");
int oneLevelArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int twoLevelArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxElements = Convert.ToInt32(Console.ReadLine());

int[,] RandTwoMatrix (int row, int col, int min, int max)
{
    int[,] matrix  = new int [row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] randMatrix = RandTwoMatrix (oneLevelArray, twoLevelArray, minElements, maxElements);

double[] ColumnArithmeticMeanMatrix (int[,] matrix, int row, int col)
{
    double[] colarr  = new double [col];
    //int sum = 0;
         for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < colarr.Length; k++)
             {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                        if (j == k) colarr[k] += matrix[i,j];
                }
             }
        }
        for (int i = 0; i < colarr.Length; i++)
        {
                colarr[i] = Math.Round(colarr[i] / row, 1);
        }
    return colarr;
}

double[] arithmeticMeanCol = ColumnArithmeticMeanMatrix (randMatrix, oneLevelArray, twoLevelArray);

void PrintTwoMatrix(int[,] matrix)
{
    string digit = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if(matrix[i,j] >= 0 && matrix[i,j] < 10) digit = $"      {matrix[i,j]}";
        else if((matrix[i,j] > 10 && matrix[i,j] < 100) || 
                (matrix[i,j] > -10 && matrix[i,j] < 0)) digit = $"     {matrix[i,j]}";
        else if((matrix[i,j] > 100 && matrix[i,j] < 1000) ||
                (matrix[i,j] > -100 && matrix[i,j] <= -10)) digit = $"    {matrix[i,j]}";
        else if((matrix[i,j] > 1000 && matrix[i,j] < 10000) ||
                (matrix[i,j] > -1000 && matrix[i,j] <= -100)) digit = $"   {matrix[i,j]}";
        else if((matrix[i,j] > 10000 && matrix[i,j] < 1000000) || 
                (matrix[i,j] > -10000 && matrix[i,j] < -1000 )) digit = $"  {matrix[i,j]}";
        else if((matrix[i,j] > 100000 && matrix[i,j] < 10000000) || 
                (matrix[i,j] > -100000 && matrix[i,j] < -10000 )) digit = $" {matrix[i,j]}";
 
        if (j == 0) Console.Write("        { ");
        if (j < matrix.GetLength(1)-1)  Console.Write($"{digit} | ");
        if (j == matrix.GetLength(1)-1) Console.Write($"{digit} }}");
        }
        Console.WriteLine();
    }
}

void PrintArrayColumn (double[] array)
{
    string digit = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i] >= 0 && array[i] < 10) digit = $"    {array[i]}";
    else if((array[i] > 10 && array[i] < 100) || 
            (array[i] > -10 && array[i] < 0)) digit = $"   {array[i]}";
    else if((array[i] > 100 && array[i] < 1000) ||
            (array[i] > -100 && array[i] <= -10)) digit = $"  {array[i]}";
    else if((array[i] > 1000 && array[i] < 10000) ||
            (array[i] > -1000 && array[i] <= -100)) digit = $" {array[i]}";
    else if((array[i] > 10000 && array[i] < 1000000) || 
            (array[i] > -10000 && array[i] < -1000 )) digit = $"{array[i]}";
 
    if (i == 0) Console.Write("СУММА:  { ");
    if (i < array.Length-1)  Console.Write($"{digit} | ");
    if (i == array.Length-1) Console.Write($"{digit} }}");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("                                                 ДВУМЕРНЫЙ МАССИВ:");
PrintTwoMatrix(randMatrix);
Console.WriteLine();
PrintArrayColumn(arithmeticMeanCol);
Console.WriteLine();


