// Задача № 22. Напишите программу, которая принимает на вход число (N) и выдает
// таблицу квадратов чисел от 1 до N.
Console.Write("Введите любое натуральное число до 100: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count < number)
{
    Console.Write($"{Math.Pow(count,2)}, ");
    count++;
}
Console.WriteLine(Math.Pow(number,2));