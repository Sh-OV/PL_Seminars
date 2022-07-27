/* Задача № 69. Напишите программу, которая на вход принимает два числа А и В,
                и возводит число А в целую степень В с помощью рекурсии
                А = 3; В = 5 -> 243(3^5)        */
Console.Clear();
Console.WriteLine("Для возведения чмисла А в степень В");
Console.Write("Введите натуральное число А: ");
int firstNaturalNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число В: ");
int secondNaturalNumber = Convert.ToInt32(Console.ReadLine());

while (firstNaturalNumber < 1)    // проверка
{
    Console.Write("Вы ввели неверные данные. Число А должно быть натуральным (от 1 и более): ");
    firstNaturalNumber = Convert.ToInt32(Console.ReadLine());
}

while (secondNaturalNumber < 1)    // проверка
{
    Console.Write("Вы ввели неверные данные. Число В должно быть натуральным (от 1 и более): ");
    secondNaturalNumber = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();

int ExponentiationNumber(int a, int b)
{
   if (b > 0)
   {
        return (a * ExponentiationNumber(a, b-1));
   }
   else return 1;
}
int result = ExponentiationNumber(firstNaturalNumber, secondNaturalNumber);
Console.WriteLine($"A = {firstNaturalNumber}; B = {secondNaturalNumber} -> {result} ({firstNaturalNumber}^{secondNaturalNumber})");
Console.WriteLine();

