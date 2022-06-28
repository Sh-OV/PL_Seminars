// Напишите программу, которая на вход принимает трехзначное число
// и на выходе показывает последнюю цифру этого числа
Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1000 || num < 100)
{
    Console.Write("Вы ввели неверное число, пожалуйста введите трехзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
int rem = num % 10;
Console.WriteLine($"Последняя цифра числа {num} будет {rem}");