// Задача № 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
Console.Write("Введите координату x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance (int cx1, int cy1, int cx2, int cy2)
{
    int x = cx1 - cx2;
    int y = cy1 - cy2;
    double dist = Math.Pow((x*x + y*y),0.5); // double dist = Math.Sqrt(x*x + y*y);
    return Math.Round(dist,2);
}
double result =  Distance (x1, y1, x2, y2);
Console.Write($"Расстояние между точкой А ({x1},{y1}) и точкой Б ({x2},{y2}) составляет {result}");