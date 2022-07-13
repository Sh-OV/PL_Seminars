// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 Console.WriteLine("Задайте координаты двух прямых b1, k1, b2 и k2: ");
Console.Write("Координата b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

// Дана система уравнений:
// y = k1 * x + b1;                 => y = k1*(y-b2)/k2 + b1    =>   y - k1*y/k2 = b1 - k1*b2/k2 // умножим все на k2 =>
// y = k2 * x + b2 => x = (y - b2)/k2
// 
// y = (k2*b1-k1*b2)/(k2 - k1)
// x = (y-b2)/k2

double[] InterStraightLines(double a, double c, double b, double d)
{
    double y = 0;
    double x = 0;
    y = (d*a-c*b)/(d-c);
    x = (y-b)/d;
    return new[] {Math.Round(x, 2), Math.Round(y, 2)};
}
double[] inter =  InterStraightLines (b1, k1, b2, k2);

 Console.WriteLine($"Точка пересечений двух прямых: ({inter[0]}; {inter[1]})");
