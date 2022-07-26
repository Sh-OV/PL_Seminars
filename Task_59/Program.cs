// Задача № 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
//              строку и столбец на пересечении которых расположен наименьший элемент.

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

int[,] TwoMatrix(int row, int col) // метод создания двумерного массива на убывание
{
    int[,] matrix = new int[row, col];
    int maxnumb = row * col;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = maxnumb;
            maxnumb--;
        }
    }
    return matrix;
}
int[,] twoMatrix = TwoMatrix(5, 7);

void PrintTwoMatrix(int[,] matrix)      // метод вывода двумерного массива на печать
{
    string digit = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0 && matrix[i, j] < 10) digit = $"      {matrix[i, j]}";
            else if ((matrix[i, j] >= 10 && matrix[i, j] < 100) ||
                    (matrix[i, j] > -10 && matrix[i, j] < 0)) digit = $"     {matrix[i, j]}";
            else if ((matrix[i, j] >= 100 && matrix[i, j] < 1000) ||
                    (matrix[i, j] > -100 && matrix[i, j] <= -10)) digit = $"    {matrix[i, j]}";
            else if ((matrix[i, j] >= 1000 && matrix[i, j] < 10000) ||
                    (matrix[i, j] > -1000 && matrix[i, j] <= -100)) digit = $"   {matrix[i, j]}";
            else if ((matrix[i, j] >= 10000 && matrix[i, j] < 1000000) ||
                    (matrix[i, j] > -10000 && matrix[i, j] < -1000)) digit = $"  {matrix[i, j]}";
            else if ((matrix[i, j] >= 100000 && matrix[i, j] < 10000000) ||
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

int[] FindingMinElement(int[,] matrix) // метод поиска наменьшего элемнента двумерного массива
{
    int minElement = matrix[0, 0];
    int m = 0;
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                m = i;
                k = j;
            }
        }
    }
    Console.WriteLine($"minElement = matrix[{m},{k}] = {minElement}");
    Console.WriteLine();
    return new int[] { m, k };
}
int[] arrayMinElement = FindingMinElement(randMatrix);

int[,] NewTwoMatrix(int[,] matrix, int[] array) // метод изменения двумерного массива с удалением строки и столбца
{
    int[,] matrixNew = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (m < matrixNew.GetLength(0))
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (k < matrixNew.GetLength(1))
                {
                    matrixNew[m, k] = matrix[i, j];
                    if (j != array[1]) k++;
                }
            }
            if (i != array[0]) m++;
            k = 0;
        }
    }
    return matrixNew;
}
int[,] randMatrixNew = NewTwoMatrix(randMatrix, arrayMinElement);
PrintTwoMatrix(randMatrixNew);
Console.WriteLine();


