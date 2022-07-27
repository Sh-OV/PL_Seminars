// Задача № 66. Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Для нахождения суммы введите два натуральных числа M и N (N должно быть больше M)");
Console.Write("Введите натуральное число M: ");
int firstNaturalNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int secondNaturalNumber = Convert.ToInt32(Console.ReadLine());

while (firstNaturalNumber < 1)    // проверка
{
    Console.Write("Вы ввели неверные данные. Число M должно быть натуральным (от 1 и более): ");
    firstNaturalNumber = Convert.ToInt32(Console.ReadLine());
}

while (secondNaturalNumber < 0 || secondNaturalNumber <= firstNaturalNumber)    // проверка
{
    Console.Write("Вы ввели неверные данные. Число N должно быть натуральным (от 1 и более) и больше M: ");
    secondNaturalNumber = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();

int SumNumbersViaRecursion(int min, int max)
{
    if (min <= max)
    {
        return min + SumNumbersViaRecursion(min + 1, max);
    }
    else return 0;
}
int result = SumNumbersViaRecursion(firstNaturalNumber, secondNaturalNumber);
Console.WriteLine($"M = {firstNaturalNumber}; N = {secondNaturalNumber}  -> ({result})");
Console.WriteLine();
