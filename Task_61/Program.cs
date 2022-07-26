// Задача № 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.
Console.Clear();
Console.Write("Для построения треугольника Паскаля введите количество строк треугольника: ");
int linesPaskal = Convert.ToInt32(Console.ReadLine());

// int x0 = 60, y0 = 1;
// Console.SetCursorPosition(x0, y0);
// Console.WriteLine("1");
// Console.SetCursorPosition(x0-1, y0+1);
// Console.WriteLine("1 1");
// Console.SetCursorPosition(x0-2, y0+2);
// Console.WriteLine("1 2 1");

void СonstructionTrianglePaskal(int row)
{
    int[] array = new int[row];
    int help1 = 0;
    int help2 = 0;
    int count = 0;
    int x = 60, y = 1;
    for (int i = 0; i < row; i++)
    {
        if (i != 0) { x --; y ++;}
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
            Console.Write($"{array[j]} ");
        }
        count++;
    }
}
СonstructionTrianglePaskal(linesPaskal);