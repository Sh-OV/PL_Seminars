// Напишите программу, которая на вход принимает два числа и выдает,
// какое число больше, а какое меньше
Console.Clear();
Console.Write("Введите любое натуральное число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно любое натуральное число: ");
int second_num = Convert.ToInt32(Console.ReadLine());
if (first_num >= second_num)
{
    Console.WriteLine($"Максимальное число из двух введенных чисел: max = {first_num}");
}
else
{
    Console.WriteLine($"Максимальное число из двух введенных чисел: max = {second_num}");
}