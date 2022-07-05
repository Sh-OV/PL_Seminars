/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.WriteLine("Введите два числа А и Б (где А - число, Б - степень числа А): ");
Console.Write("число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Степень Б: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= b; i++)
{
    result *= a;
}
Console.WriteLine($"Число {a} в степени {b} равно {result}");