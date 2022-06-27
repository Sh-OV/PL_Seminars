// Задача № 16. Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого

Console.Clear();
Console.Write("Введите первое целое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

bool Square (int num1, int num2)
{
    bool result;
    if (num1 * num1 == num2 || num2 * num2 == num1) result = true;
    else result = false;
    return (result);
}
string res = Square(firstNum, secondNum) == true ? "КРАТНЫ" : "НЕ КРАТНЫ";
Console.WriteLine($"Числа {firstNum} и {secondNum} {res} между собой");
