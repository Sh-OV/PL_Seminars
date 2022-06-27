// Задача № 12. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа
// должна выводить остаток от деления
Console.Write("Введите любое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Multi (int number1, int number2)
{
    int rem = 0;
    if (number1 % number2 == 0) rem = 0;
    else rem = number1 % number2;
    return rem;
}
if  (Multi(num1, num2) > 0) Console.WriteLine($"Число {num1} делится на {num2} с остатком {Multi(num1, num2)}");
else Console.WriteLine($"Число {num1} делится на {num2} без остатка");
