/* Задача № 63. Задайте значение N. Напишите программу, которая выведет все
                натуральные числа в промежутке от 1 до N.
                N = 5 -> "1,2,3,4,5"
                N = 6 -> "1,2,3,4,5,6" и т.п. */

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
    if (min <= max)
    {
        if (min == max) return $"{min}";
        return $"{min}, " + SequenceViaRecursion(min + 1, max);
    }
    else return String.Empty;
}
string result = SequenceViaRecursion(1, naturalNumber);
Console.WriteLine($"N = {naturalNumber} -> ({result})");
Console.WriteLine();
