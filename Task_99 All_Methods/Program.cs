// Все методы, которые создавала на курсе "Знакомство с языками программирования" //
//=================================================================================
//-----------------------------------------------------------------------------
// Запросы пользователю на вводы данных
//------------------------------------------------------------------------------
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

//----------------------------------------------------------------------------------
// Метод создание двумерного массива случайными числами
//----------------------------------------------------------------------------------
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

//----------------------------------------------------------------------------
// Mетод вывода двумерного массива на печать
//----------------------------------------------------------------------------
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

//----------------------------------------------------------------------------
// Mетод сортировки массива от меньшего к большему ??? не доделан
//----------------------------------------------------------------------------
int[,] SortingMatrix (int[,] matrix)            // метод сортировки массива от меньшего к большему
{
    int sortmax = matrix[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int sortmin = matrix[0, 0];
    int support = 0;
    int help = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-j; j++)
        {
           if   (matrix[i,j] > sortmax)
           {
            support = matrix[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
            matrix[matrix.GetLength(0)-1, matrix.GetLength(1)-1] = matrix[i,j];
            matrix[i,j] = support;
            sortmax = matrix[i,j];
           }
           else if   (matrix[i,j] < sortmin)
           {
            support = matrix[0,0];
            matrix[0,0] = matrix[i,j];            matrix[i,j] = support;
            sortmin = matrix[i,j];
           }
           if (help > matrix[i,j])
           {
                support = matrix[i,j];
                matrix[i,j] = help;
                help = support;
           }
        }
    }
    return matrix;
}
int[,] sortMatrix = SortingMatrix (randMatrix);
PrintTwoMatrix(sortMatrix);
Console.WriteLine();

//-------------------------------------------------------------------------------
// Метод поиска повторения элемента (вызывается из циклов)
//-------------------------------------------------------------------------------
int RepeatingElements(int[,] matrix, int row, int col) // метод поиска повторения элемента (вызывается из циклов)
{
    int replay = matrix[row, col];
    int count = 0;
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if   (matrix[i,j] == replay) count++;
        }
    }
    Console.WriteLine($"метод поиска повторения элемента {replay} => {count}"); 
    return count;
}

//-------------------------------------------------------------------------------
// Метод подсчета количества повторяющихся чисел в массиве ??? не доделан
//-------------------------------------------------------------------------------
int NumberDuplicateElements (int [,] matrix) // метод подсчета количества повторяющихся чисел в массиве 
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (RepeatingElements(matrix, i, j) > 1) count ++;
        }
    }
    Console.WriteLine($"метод подсчета количества повторяющихся чисел: {count} позиций"); 
    return count;
}
int countElem = NumberDuplicateElements (randMatrix);

//-------------------------------------------------------------------------------
// Метод создания одномерного массива случайными числами
//-------------------------------------------------------------------------------
int [] RandArray(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

int[] rndArray = Array(15, 1, 9);

//-------------------------------------------------------------------------------
// Метод сортировки одномерного массива от меньшего к большему ??? не доделан
//-------------------------------------------------------------------------------
int[] SortingArray (int[] arr)            // метод сортировки массива от меньшего к большему
{
    int sortmax = arr[arr.Length-1];
    int sortmin = arr[0];
    int support = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > sortmax)
        {
            sortmax = arr[i];
            support = arr[arr.Length-1];
            arr[arr.Length-1] = arr[i];
            arr[i] = support;
        }
        else if (arr[i] < sortmin)
        {
            sortmin = arr[i];
            support = arr[0];
            arr[0] = arr[i];
            arr[i] = support;
        }
    }
    return arr;
}
int[] sortarr =  SortingArray (rndArray);

//-------------------------------------------------------------------------------
// Метод вывода одномерного массива в консоль
//-------------------------------------------------------------------------------
void PrintArr (int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[{res[i]}, ");
        else if (i > 0 && i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.WriteLine($"{res[i]}]");
    }
}
PrintArr(rndArray);
Console.WriteLine();
PrintArr(sortarr);

//-------------------------------------------------------------------------------
//  Mетод создания массива повторяющихся чисел
//-------------------------------------------------------------------------------
int[] ArrayIdenticalElements (int [,] matrix, int countElem)  // метод создания массива повторяющихся чисел
{
    int[] array = new int[countElem];      
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (RepeatingElements(matrix, i, j) > 1) array[j] = matrix[i,j];
        }
    }
    PrintArr(array);
    SortingArray (array);
    PrintArr(array);
    return array;
}
int[] sortArray = ArrayIdenticalElements (randMatrix, countElem);

//-------------------------------------------------------------------------------
// Метод Частотный словарь повторения элементов
//-------------------------------------------------------------------------------
void FrequencyDictionaryElementsMatrix (int [,] matrix, int[] array) // метод Частотный словарь повторения элементов
{
    int count = 0;
    int support = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
           for (int k = 0; k < matrix.GetLength(1); k++)
           {
                if (i == support && array[i] == matrix[j,k])
                {
                  count = RepeatingElements(matrix, j, k);
                }
            }
             Console.WriteLine($"{array[i]} встречается {count} раз");
         }
        support++;
    }
}

FrequencyDictionaryElementsMatrix (randMatrix, sortArray);

//-------------------------------------------------------------------------------
// Метод создания правильного окончания количества например цафр или раз и т.п.
//-------------------------------------------------------------------------------
string EndWord(int digit)
{
    string end = String.Empty;
    
    if ((digit % 100 == 2 || digit % 100 == 3 || digit % 100 == 4) || (digit > 1 && digit < 5)) end = "положительных значения";
    else if ((digit % 100 >= 10 && digit % 100 <= 20)|| (digit >= 10 && digit <= 20) || digit % 10 == 0 || 
     digit % 10 != 1) end = "положительных значений";
    else if (digit % 10 == 1 || digit == 1 ||  digit % 100 == 1) end = "положительное значение"; 
 
    return end;  
}
string res = EndWord(num);

Console.WriteLine("В созданном Вами одномерном массиве:");
PrintArr(userArr);
Console.WriteLine($"имеется  {num}  {res}");

//-------------------------------------------------------------------------------
