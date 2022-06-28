// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите день недели числом от 1 до 7: ");
int numday = Convert.ToInt32(Console.ReadLine());
if (numday > 7 || numday < 1)
{
    Console.Write("Такого дня недели нет! Введите, пожалуйста, день недели числом от 1 до 7: ");
    numday = Convert.ToInt32(Console.ReadLine());
}
int i = 0;
string [] arrday = {"NULL","Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if (numday == 6 || numday == 7)
{
    Console.WriteLine($"Введенный день недели {numday} это {arrday[numday]}, сегодня ВЫХОДНОЙ!!!");
}
else Console.WriteLine($"Введенный день недели {numday} это {arrday[numday]}, обычный день...");