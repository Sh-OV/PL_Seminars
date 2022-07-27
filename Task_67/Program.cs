/* Задача № 67. Напишите программу, которая будет принимать на вход число и 
                возвращать сумму его цифр.
                453 -> 12
                45 -> 9         */
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

int SumDigitsViaRecursion(int number)
{
   if (number > 0)
   {
        return number % 10 + SumDigitsViaRecursion(number / 10);
   }
   else return 0;
}
int result = SumDigitsViaRecursion(naturalNumber);
Console.WriteLine($"{naturalNumber} -> ({result})");
Console.WriteLine();
