// Напишите программу, которая на вход принимает число и выдает, является ли оно чётным
Console.Write("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num %2 == 0)
{
    Console.WriteLine($"Введенное число {num} является чётным!");
}
else Console.WriteLine($"Введенное число {num} НЕ является чётным!");