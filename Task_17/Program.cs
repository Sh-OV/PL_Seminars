﻿// Задача № 17. Напишите программу, которая принимает на вход две точки (X; Y), причем X != 0 и Y != 0,
// и выдает номер четверти плоскости в которой находится эта точка (нумерация плоскостей против часовой
// стрелки, с 1-4, начиная с положительной плоскости для X и Y)
Console.WriteLine("Решение № 1");
Console.Write("Введите координату по оси Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());


string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Точка находится в первой четверти плоскости";
    if (xc < 0 && yc > 0) return "Точка находится во второй четверти плоскости";
    if (xc < 0 && yc < 0) return "Точка находится в третьей четверти плоскости";
    if (xc > 0 && yc < 0) return "Точка находится в четвертой четверти плоскости";
    else return "Введены некорректные координаты";
}

string result = Quarter(x, y);
Console.Write(result);

// Console.WriteLine("Решение № 2");
// Console.Write("Введите координату по оси Х: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// switch (x1)
// {
//     case x1 > 0 :
//     switch (y1)
//     {
//         case y1 > 0 : "Точка находится в первой четверти плоскости"; break;
//         case y1 < 0 : "Точка находится в четвертой четверти плоскости"; break;
//     }
//     case x1 < 0 :
//     switch (y1)
//     {
//         case y1 > 0 : "Точка находится во второй четверти плоскости"; break;
//         case y1 < 0 : "Точка находится в третьей четверти плоскости"; break;
//     }
//     default: "Введены некорректные координаты"; break;
// }

