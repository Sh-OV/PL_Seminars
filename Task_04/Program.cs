// Напишите программу, которая принимает на вход три числа 
// и выдает максимальное из трех чисел
Console.Clear();
Console.Write("Введите любое целое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно любое целое число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно любое целое число: ");
int num_3 = Convert.ToInt32(Console.ReadLine());
if (num_1 >= num_2 && num_1 >= num_3)
{
    Console.WriteLine($"Максимальное число из чисел {num_1}, {num_2}, {num_3} будет {num_1}");
}
else if (num_2 >= num_1 && num_2 >= num_3)
{
    Console.WriteLine($"Максимальное число из чисел {num_1}, {num_2}, {num_3} будет {num_2}");
}
else if (num_3 > num_1 && num_3 > num_2)
{
    Console.WriteLine($"Максимальное число из чисел {num_1}, {num_2}, {num_3} будет {num_3}");
}