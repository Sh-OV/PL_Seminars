// Напишите программу, которая будет выдавать название дня недели по заданному номеру
Console.Clear();
Console.WriteLine("РЕШЕНИЕ №1:");
Console.Write("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1) { Console.WriteLine("Понедельник");}
else if (num == 2) { Console.WriteLine("Вторник");}
else if (num == 3) { Console.WriteLine("Среда");}
else if (num == 4) { Console.WriteLine("Четверг");}
else if (num == 5) { Console.WriteLine("Пятница");}
else if (num == 6) { Console.WriteLine("Суббота");}
else if (num == 7) { Console.WriteLine("Воскресенье");}
else { Console.WriteLine("Вы ввели НЕВЕРНОЕ число");}

Console.WriteLine("РЕШЕНИЕ №2:");
Console.Write("Введите номер  дня недели (число от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1 : Console.WriteLine("Понедельник"); break;
    case 2 : Console.WriteLine("Вторник"); break;
    case 3 : Console.WriteLine("Среда"); break;
    case 4 : Console.WriteLine("Четверг"); break;
    case 5 : Console.WriteLine("Пятница"); break;
    case 6 : Console.WriteLine("Суббота"); break;
    case 7 : Console.WriteLine("Воскресенье"); break;
    default : Console.WriteLine("Вы ввели число вне заданного интервала!"); break;
}