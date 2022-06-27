// Задача № 14. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
Console.Clear();
Console.Write("Введите первое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int dev1 = 7;
int dev2 = 23;

bool Square (int num, int d1, int d2)
{
    bool result;
    if (num % d1 == 0 && num % dev2 == 0) result = true;
    else result = false;
    return (result);
}
string res = Square(number, dev1, dev2) == true ? "одновременно кратно" : "одновременно не кратно";
Console.WriteLine($"Число {number} {res} {dev1} и {dev2}");