// Напишите программу, котоорая на вход получает число N, а на выходе показывает все четные числа от 1 до N
Console.Clear();
Console.Write("Введите любое натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= num)
{
    Console.Write($"{count} ");
    count += 2;
}