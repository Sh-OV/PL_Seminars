// Задача № 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] RandTwoMatrix(int row, int col, int min, int max)
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

void PrintTwoMatrix(int[,] matrix)
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

int[,] ReplacingRowsWithColumnsMatrix(int[,] matrix)
{

    int length0 = matrix.GetLength(0);
    int length1 = matrix.GetLength(1);
    int[,] matrixNew = new int[length1, length0];
    if (length0 >= length1)
    {
        for (int i = 0; i < length0; i++)
        {
            int k = 0;
            for (int j = 0; j < length0; j++)
            {
                if (k >= length1) k = 0;
                matrixNew[k, i] = matrix[i, k];
                k++;
            }
        }
    }
    else
    {
        int k = 0;
        for (int i = 0; i < length1; i++)
        {
            if (k >= length0) k = 0;
            for (int j = 0; j < length1; j++)
            {
                matrixNew[j, k] = matrix[k, j];
               
            }
            k++;
        }
    }
    return matrixNew;
}


int[,] replacMatrix = ReplacingRowsWithColumnsMatrix(randMatrix);

PrintTwoMatrix(replacMatrix);
Console.WriteLine();
