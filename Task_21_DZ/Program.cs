// Задача № 21-ДЗ. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координату x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance (int cx1, int cy1, int cz1, int cx2, int cy2, int cz2)
{
    int x = cx2 - cx1;
    int y = cy2 - cy1;
    int z = cz2 - cz1;
    double dist = Math.Sqrt(x*x + y*y + z*z);
    return Math.Round(dist,2);
}
double result =  Distance (x1, y1, z1, x2, y2, z2);
Console.Write($"Расстояние между точкой А ({x1}, {y1}, {z1}) и точкой Б ({x2}, {y2}, {z2}) составляет {result}");