// Задаче № 19. Напишите программу, которая принимает на вход пятизначное число и проверяет
// является ли оно палиндромом
// Console.WriteLine("Решение №1 по ТЗ задачи: ");
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

    while (number < 10000 || number > 99999)
    {
        Console.Write("Вы ввели некорректное число, введите пятизначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    } 

string Palindrome(int num)
{
    string answer;
    int n5 = num % 10;
    int n4 = num % 100 / 10;
    int n3 = num % 1000 / 100;
    int n2 = num / 1000 % 10;
    int n1 = num / 10000;
    
    if (n1 == n5 && n2 == n4) { answer = $"Число {num} являеется полиндромом";}
    else { answer = $"Число {num} не являеется полиндромом, это обычное число";}
    return answer;
}

    string result = Palindrome(number);
    Console.WriteLine(result);
