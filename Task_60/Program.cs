/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Clear();
Console.Write("Введите количество листов трехмерного массива (желательно не более 5): ");
int oneLevelArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк трехмерного массива (желательно не более 4): ");
int twoLevelArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов трехмерного массива (желательно не более 4): ");
int threeLevelArray = Convert.ToInt32(Console.ReadLine());


while (oneLevelArray * twoLevelArray * threeLevelArray > 99)      // проверка
{
    Console.Write("Вы ввели слишком большое количество листов, строк и столбцов! ");
    Console.Write("Введите количество листов трехмерного массива (желательно не более 5): ");
    oneLevelArray = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк трехмерного массива (желательно не более 4): ");
    twoLevelArray = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов трехмерного массива (желательно не более 4): ");
    threeLevelArray = Convert.ToInt32(Console.ReadLine());
} 

int minElements = 10;
int maxElements = 99;
Console.WriteLine();

int[, ,] RandThreeMatrix(int list, int row, int col, int min, int max) // метод создания трехмерного массива рандомно
{
    int[, ,] matrix = new int[list, row, col];
    int lengtharr = list * row * col;
    int[] arr = new int[lengtharr];
    int count = 0;
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(2); k++)
           {
             matrix[i, j, k] = rnd.Next(min, max + 1);
             if (matrix[i, j, k] != matrix[0, 0, 0])
             {
                while (! RepeatCheck(arr, matrix[i, j, k]))
                {
                    matrix[i, j, k] = rnd.Next(min, max + 1);
                }
                }
             arr[count] = matrix[i, j, k];
             count++;
           }
        }
    }
    return matrix;
}
int[, ,] randMatrix = RandThreeMatrix(oneLevelArray, twoLevelArray, threeLevelArray, minElements, maxElements);

void PrintThreeMatrix(int[, ,] matrix)      // метод вывода двумерного массива на печать
{
    string digit = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(2); k++)
           {
            if ((matrix[i, j, k] >= 10 && matrix[i, j, k] < 100)) digit = $"  {matrix[i, j, k]}({i},{j},{k})";
             else if ((matrix[i, j, k] > -100 && matrix[i, j, k] <= -10)) digit = $"{matrix[i, j, k]}({i},{j},{k})";
 
             if (k == 0) Console.Write("[");
             if (k < matrix.GetLength(2) - 1) Console.Write($"{digit} ");
             if (k == matrix.GetLength(2) - 1) Console.Write($"{digit} ]");
           }
           Console.WriteLine();
        }
        Console.WriteLine();
    }
}
PrintThreeMatrix(randMatrix);
Console.WriteLine();

bool RepeatCheck(int[] array, int element)      // метод проверки повторения числа 
{    
    bool res = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (element == array[i]) res = false;
    }
    return res;
}

