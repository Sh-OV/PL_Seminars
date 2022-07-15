// Задача № 46. Задайте двумерный массив размером m * n,
//              заполненный случайными целыми числами. m = 3, n = 4.
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

void PrintTwoMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        // Можно так:
        // if (i == 0 && j == 0) Console.Write($"[");
        // if (i == 0 && j < matrix.GetLength(1))  Console.Write($"{matrix[i, j]},  ");
        // if (i != 0 && i < matrix.GetLength(0)-1 && j < matrix.GetLength(1))  Console.Write($" {matrix[i, j]}, ");
        // if    (i == matrix.GetLength(0)-1 && j != matrix.GetLength(1)-1) Console.Write($" {matrix[i, j]}, ");
        // if (i == matrix.GetLength(0)-1 && j == matrix.GetLength(1)-1) Console.Write($" {matrix[i, j]}]");

        // Можно так:
        if (j == 0) Console.Write("{ ");
        if (i < matrix.GetLength(0) && j < matrix.GetLength(1)-1)  Console.Write($"{matrix[i, j]}, ");
        if (j == matrix.GetLength(1)-1) Console.Write($"{matrix[i, j]} }}");
        }
        Console.WriteLine();
    }
}

PrintTwoMatrix(randMatrix);