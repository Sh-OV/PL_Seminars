// Задача № 49. Задайте двумерный массив. Найдите элементы,
// у которых оба индекса четные и замените их элементы на 
// их квадраты.

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
    int help = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            help = rnd.Next(min, max + 1);
            matrix[i,j] = help;
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i,j] = help * help; 
            }
        }
    }
    return matrix;
}
int[,] randMatrix = RandTwoMatrix (oneLevelArray, twoLevelArray, minElements, maxElements);

void PrintTwoMatrix(int[,] matrix)
{
    string digit = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if     (matrix[i,j] >= 0 && matrix[i,j] < 10) digit = $"      {matrix[i,j]}";
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
 
        if (j == 0) Console.Write("{ ");
        if (j < matrix.GetLength(1)-1)  Console.Write($"{digit} | ");
        if (j == matrix.GetLength(1)-1) Console.Write($"{digit} }}");
        }
        Console.WriteLine();
    }
}

PrintTwoMatrix(randMatrix);