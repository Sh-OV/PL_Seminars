/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18   */

Console.Clear();
Console.Write("Введите значение - количество столбцов первой матрицы и строк второй матрицы: ");
int totalnumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк первой матрицы: ");
int rowsfirstmatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы : ");
int columnsecondmatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxElements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] RandOneMatrix(int row, int col, int min, int max) // метод создания двумерного массива рандомно
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
int[,] randOneMatrix = RandOneMatrix(rowsfirstmatrix, totalnumb, minElements, maxElements);

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
int[,] randTwoMatrix = RandTwoMatrix(totalnumb, columnsecondmatrix, minElements, maxElements);

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

PrintTwoMatrix(randOneMatrix);
Console.WriteLine();

PrintTwoMatrix(randTwoMatrix);
Console.WriteLine();

int[,] MatrixMultiplication (int[,] onematrix, int[,] twomatrix)  // метод умножения матриц между собой
{
    int[,] multimatrix = new int[onematrix.GetLength(0), twomatrix.GetLength(1)];
    // int i = 0;
    // int length0 = 0; 
    // int length1 = 0;
    // int length2 = 0;
    // if (onematrix.GetLength(0) >= twomatrix.GetLength(0)) length0 = onematrix.GetLength(0);
    // else length0 = twomatrix.GetLength(0);
    // if (onematrix.GetLength(1) >= twomatrix.GetLength(1)) length1 = onematrix.GetLength(1);
    // else length1 = twomatrix.GetLength(1);
    // if (length1 >= length0) length2 = length1;
    // else length2 = length0;
    for (int i = 0; i < onematrix.GetLength(0); i++)
    {
            for (int j = 0; j < twomatrix.GetLength(1); j++)
            {
                for (int k = 0; k < twomatrix.GetLength(0); k++)
                {
                    multimatrix[i,j] += onematrix[i,k] * twomatrix[k,j];
                }
            }
    }

    return multimatrix;
}
int[,] matrixMultiplic = MatrixMultiplication (randOneMatrix, randTwoMatrix);

PrintTwoMatrix(matrixMultiplic);
Console.WriteLine();
