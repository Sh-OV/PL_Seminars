// Задача № 57. Составьте частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.
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

void SelectionSort (int[] array)    // метод сортировки одномерного массива от меньшего к большему
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;  

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int[] TransformationMatrixIntoArraySort (int[,] matrix)            // метод сортировки массива от меньшего к большему
{
    int[] sortarray = new int[matrix.GetLength(0)*matrix.GetLength(1)];
    int count = 0;
    int minelem = sortarray[0];
    int maxelem = sortarray[0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sortarray[count] = matrix[i,j];
            count++;
        }
    }
    SelectionSort (sortarray);
    return sortarray;
}
int[] transfMatrixIntoArraySort = TransformationMatrixIntoArraySort (randMatrix);

void PrintArr (int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[{res[i]}, ");
        else if (i > 0 && i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.WriteLine($"{res[i]}]");
    }
}
PrintArr(transfMatrixIntoArraySort);
Console.WriteLine();
//-------------------------------------------------------------------------------
string EndWord(int digit)
{
    string end = String.Empty;
    
    if ((digit % 100 == 2 || digit % 100 == 3 || digit % 100 == 4) || (digit > 1 && digit < 5)) end = "раза";
    else if ((digit % 100 >= 10 && digit % 100 <= 20)|| (digit >= 10 && digit <= 20) || digit % 10 == 0 || 
     digit % 10 != 1) end = "раз";
    else if (digit % 10 == 1 || digit == 1 ||  digit % 100 == 1) end = "раз"; 
 
    return end;  
}

void FrequencyDictionaryElementsArray (int[] array) // метод Частотный словарь повторения элементов
{
    int count = 0;
    int number = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else
        {
            Console.WriteLine($"{number} встречается {count} {EndWord(count)}");
            number = array[i];
            count = 0;
        }
    }
}

FrequencyDictionaryElementsArray (transfMatrixIntoArraySort);
Console.WriteLine();

