// Напишите программу, котоорая на вход получает число N, а на выходе показывает все четные числа от 1 до N
Console.Clear();
Console.WriteLine("РЕШЕНИЕ № 1");
Console.Write("Введите любое натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= num)
{
    Console.Write($"{count} ");
    count += 2;
}
Console.WriteLine();

Console.WriteLine("РЕШЕНИЕ № 2");
Console.Write("Введите любое натуральное число: ");
num = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= num; i+=2)
{
    Console.Write($"{i} ");
}