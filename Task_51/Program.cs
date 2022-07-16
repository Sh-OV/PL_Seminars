// Задача № 51. Задайте двумерный массив. Найдите сумму
//элементов, находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.)
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

int SumDiagonalMatrix(int[,] matrix)
{
    int sumDiagonal = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sumDiagonal += matrix[i,j];
            }
        }
    }
    return sumDiagonal;
}
int sum = SumDiagonalMatrix(randMatrix);

void PrintTwoMatrix(int[,] matrix)
{
    string digit = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if      (matrix[i,j] >= 0 && matrix[i,j] < 10) digit = $"      {matrix[i,j]}";
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
 
        if (j == 0) Console.Write("[");
        if (j < matrix.GetLength(1)-1)  Console.Write($"{digit} ");
        if (j == matrix.GetLength(1)-1) Console.Write($"{digit} ]");
        }
        Console.WriteLine();
    }
}

PrintTwoMatrix(randMatrix);
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали, заданного двумерного массива, равна {sum}");
Console.WriteLine();