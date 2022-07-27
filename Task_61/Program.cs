// Задача № 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.
Console.Clear();
Console.Write("Для построения треугольника Паскаля введите количество строк треугольника (не больше 15): ");
int linesPaskal = Convert.ToInt32(Console.ReadLine());

void СonstructionTrianglePaskal(int row)
{
    int[] array = new int[row];
    int help1 = 0;
    int help2 = 0;
    int count = 0;
    int x = 60, y = 1;
    for (int i = 0; i < row; i++)
    {
        if (i != 0) { x-= 4; y++; }
        Console.SetCursorPosition(x, y);
        for (int j = 0; j <= count; j++)
        {
            help1 = array[j];
            if (j > 0 && j < count)
            {
                array[j] = help2 + array[j];
            }
            else
            {
                array[j] = 1;
            }
            help2 = help1;
            Print(array[j]);
        }
        count++;
    }
}
СonstructionTrianglePaskal(linesPaskal);
Console.WriteLine();

void Print(int arg)
{
    string digit = String.Empty;
    if (arg >= 0 && arg < 10) digit = $"    {arg}   ";
    else if (arg >= 10 && arg < 100) digit = $"   {arg}   ";
    else if (arg >= 100 && arg < 1000) digit = $"  {arg}   ";
    else if (arg >= 1000 && arg < 10000) digit = $"  {arg}  ";
     else if (arg >= 10000 && arg < 100000) digit = $" {arg}  ";
     else if (arg >= 100000 && arg < 1000000) digit = $" {arg} ";
    Console.Write(digit);
}
