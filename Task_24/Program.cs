// Задача № 24. Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.
Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}
int result = Sum(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равна {result}");