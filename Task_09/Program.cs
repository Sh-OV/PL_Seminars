// Напишите программу, которая выводит случайное число из отрезка [10,99] 
// и показывает наибольшую цифру числа
Console.Clear();
Console.WriteLine("Решение № 1");
void BigNum (int random)
{
    int number1 = random / 10;
    int number2 = random % 10;
    if (number1 >= number2) Console.WriteLine($"Наибольшая цифра случайного числа {random}: {number1}");
    else Console.WriteLine($"Наибольшая цифра случайного числа {random}: {number2}");
}
int rand = new Random().Next(10, 100);
BigNum(rand);
Console.WriteLine();
Console.WriteLine("Решение № 2");

int MaxDigit(int randNum)
{
    int num1 = randNum / 10;
    int num2 = randNum % 10;
    int Max = num1 > num2 ? num1 : num2;
    return Max;
}
Console.WriteLine($"Наибольшая цифра случайного числа {rand}: {MaxDigit(rand)}");