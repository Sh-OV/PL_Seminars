// Задача № 11. Напишите программу, которая выводит случайное трёхзначноечисло
// и удаляет вторую цифру этого числа.
Console.Clear();
int rand = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число = {rand}");
int Dev(int random)
{
    int digit1 = random / 100;
    int digit3 = random % 100 % 10;
    int answer = digit1 * 10 + digit3;
    
    return answer;
}
Console.WriteLine($"После удаления второй цифры из случайного числа {rand} получается {Dev(rand)}");