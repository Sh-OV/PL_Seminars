// Задача № 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
int oneLevelArray = 10;
int twoLevelArray = 10;
int minElements = -100;
int maxElements = 1000;

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

Console.WriteLine();
Console.WriteLine("Введите адрес элемента в двумерном массиве: ");
Console.Write("введите номер строки ");
int rowarr = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца ");
int colarr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int DesiredElementMatrix (int[,] matrix, int row, int col)
{
    int element = 101;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == row && j == col) element = matrix[i,j];
        }
    }
    return element;
}
int res = DesiredElementMatrix (randMatrix, rowarr, colarr);

string result = res == 101 ? $"В двумерном массиве НЕТ элемента по указанному Вами адресу {(rowarr, colarr)}" :
                $"По указанному Вами адресу {(rowarr, colarr)} находится элемент со значением: {res}";

Console.WriteLine(result);
Console.WriteLine();

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
 
        if (j == 0) Console.Write("{ ");
        if (j < matrix.GetLength(1)-1)  Console.Write($"{digit} | ");
        if (j == matrix.GetLength(1)-1) Console.Write($"{digit} }}");
        }
        Console.WriteLine();
    }
}

PrintTwoMatrix(randMatrix);
Console.WriteLine();

