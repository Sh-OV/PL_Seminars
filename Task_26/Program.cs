// Задача № 26. Напишите программу, которая принимает  на вход число и выдает количекство цифр в числе.
Console.Write("Введите любое целое число до 1 000 000 000: ");
int number = Convert.ToInt32(Console.ReadLine());

int Quantity (int num)
{
    int count = 0;
    while (0 < num)
    {
        num /= 10;
        count++;
    }
    return count;
}
int result = Quantity (number);
Console.WriteLine($"Количество цифр в числе {number}: {result}");