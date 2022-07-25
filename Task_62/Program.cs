/* Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.Clear();
Console.Write("Введите коли ство рядов двумерного массива: ");
int oneLevelArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int twoLevelArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minElements = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] RandTwoMatrix(int row, int col, int min) // метод создания двумерного массива рандомно
{
    int[,] matrix = new int[row, col];
    int number = min;
    int max = row * col;
    int len0 = row;
    int len1 = col;
    int longside = 0;
    int end = min + max;
    int m = 0;
    int count = 0;
    int k = len1 - 1;
    if (len0 > len1) longside = len1;
    else longside = len0;
    while (longside > 0)
    {
        {
            for (int j = count; j < len1; j++)
            {
                matrix[m, j] = number++;
                k = j;
                if (number == end) return matrix;
                Console.WriteLine($"Первая  стрелка matrix[m, j] m = {m}, j = {j} == {matrix[m, j]}");
            }
            for (int i = count + 1; i < len0; i++)
            {
                matrix[i, k] = number++;
                m = i;
                if (number == end) return matrix;
                Console.WriteLine($"Вторая  стрелка  matrix[i, k] i = {i}, k = {k} == {matrix[i, k]}");
            }
            for (int j = len1 - 2; j >= count; j--)
            {
                matrix[m, j] = number++;
                k = j;
                if (number == end) return matrix;
                Console.WriteLine($"Третья  стрелка  matrix[m, j]   m = {m}, j = {j} == {matrix[m, j]}");
            }
            for (int i = len0 - 2; i > count; i--)
            {
                matrix[i, k] = number++;
                m = i;
                if (number == end) return matrix;
                Console.WriteLine($"Четвертая  стрелка matrix[i, k] i = {i}, k = {k} == {matrix[i, k]}");
            }
        }
        len0--;
        len1--;
        count++;
    }
    return matrix;
}
int[,] randMatrix = RandTwoMatrix(oneLevelArray, twoLevelArray, minElements);

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
