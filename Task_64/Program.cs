/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
              в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"       */

Console.Clear();
Console.Write("Введите натуральное число: ");
int naturalNumber = Convert.ToInt32(Console.ReadLine());

while (naturalNumber < 1)
{
    Console.WriteLine("Вы ввели НЕ НАТУРАЛЬНОЕ число ");
    Console.Write("Введите натуральное число (целое число начиная с 1): ");
    naturalNumber = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();

string SequenceViaRecursion(int min, int max)
{
    if (max >= min)
    {
        if (max == min) return $"{max}";
        return $"{max}, " + SequenceViaRecursion(min, max - 1);
    }
    else return String.Empty;
}
string result = SequenceViaRecursion(1, naturalNumber);
Console.WriteLine($"N = {naturalNumber} -> ({result})");
Console.WriteLine();
