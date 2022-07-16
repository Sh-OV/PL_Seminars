// Задача № 47. Задайте двумерный массив размером m*n,
// заполненный случайными вещественными числами.

Console.Clear();
Console.Write("Введите количество рядов двумерного массива: ");
int oneLevelArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int twoLevelArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество чисел после запятой ");
int digitsDoubl = Convert.ToInt32(Console.ReadLine());

double[,] RandTwoMatrix (int row, int col, int min, int max, int digits)
{
    double[,] matrix  = new double [row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(rnd.NextDouble() + rnd.Next(min, max + 1), digits);
        }
    }
    return matrix;
}
double[,] randMatrix = RandTwoMatrix (oneLevelArray, twoLevelArray, minElements, maxElements, digitsDoubl);

void PrintTwoMatrixDoubl(double[,] matrix)
{
    string digit = String.Empty;
    //string matrixBit  = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if      (matrix[i,j] >= 0 && matrix[i,j] < 10) digit = $"{matrix[i,j]}      ";
            else if((matrix[i,j] > 10 && matrix[i,j] < 100) || 
                    (matrix[i,j] > -10 && matrix[i,j] < 0)) digit = $"{matrix[i,j]}     ";
            else if((matrix[i,j] > 100 && matrix[i,j] < 1000) ||
                    (matrix[i,j] > -100 && matrix[i,j] <= -10)) digit = $"{matrix[i,j]}    ";
            else if((matrix[i,j] > 1000 && matrix[i,j] < 10000) ||
                    (matrix[i,j] > -1000 && matrix[i,j] <= -100)) digit = $"{matrix[i,j]}   ";
            else if((matrix[i,j] > 10000 && matrix[i,j] < 1000000) || 
                    (matrix[i,j] > -10000 && matrix[i,j] < -1000 )) digit = $"{matrix[i,j]}  ";
            else if((matrix[i,j] > 100000 && matrix[i,j] < 10000000) || 
                    (matrix[i,j] > -100000 && matrix[i,j] < -10000 )) digit = $"{matrix[i,j]} ";
        

            if (j == 0) Console.Write("{ ");
            if (j < matrix.GetLength(1)-1)  Console.Write($"{digit} | ");
            if (j == matrix.GetLength(1)-1) Console.Write($"{digit} }}");

        
        }
        Console.WriteLine();
    }
}

PrintTwoMatrixDoubl(randMatrix);