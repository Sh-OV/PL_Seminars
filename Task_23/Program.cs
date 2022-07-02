// Задача № 23. Напишите программу, которая принимает на вход число N 
// и выдает таблицу кубов чисел от 1 до N
Console.Write("Введите любое натуральное число до 100: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
 Console.Write($"Таблица кубов чисел от 1 до {number}:    ");
while (count < number)
{
    Console.Write($"{Math.Pow(count,3)}, ");
    count++;
}
Console.WriteLine(Math.Pow(number,3));