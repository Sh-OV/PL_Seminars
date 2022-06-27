// Напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго?
Console.Clear();
Console.Write("Введите первое целое число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int second_num = Convert.ToInt32(Console.ReadLine());
if(second_num * second_num == first_num)
{
    Console.WriteLine($"Число {first_num} является квадратом чила {second_num}");
}
else Console.WriteLine($"Число {first_num} НЕ ЯВЛЯЕТСЯ квадратом чила {second_num}");
