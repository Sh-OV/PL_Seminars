// Задача № 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное
Console.Write("Введите номер системы, в которую хотите преобразовать число (двоичная - 2, десятичная - 10 и т.п.): ");
int system = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, которе хотите преобразовать: ");
int number = Convert.ToInt32(Console.ReadLine());

string TranslationNum(int sys, int num)
{
    string digit = String.Empty;
    while (num / sys > 0)
    {
        int dig = num % sys;
        num /= sys;
        digit = dig + digit;
        Console.WriteLine($"num = {num}");
        Console.WriteLine($"digit = {digit}");
    }
    digit = num + digit;
    return digit;
}
string result = TranslationNum(system, number);
Console.WriteLine($"После преобразования десятичного числа {number} в {system}-ичную получается: {result}");