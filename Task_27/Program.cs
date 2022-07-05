// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите любое целое число от -1 000 000 000 до 1 000 000 000: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum (int num)
{
    int sum = 0;
    while (0 < Math.Abs(num))
    {
        sum += num % 10;
        num = num / 10;
        
        Console.WriteLine($"num = {num};  sum = {sum}");
    }
    return sum;
}
int result = Sum (number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}");