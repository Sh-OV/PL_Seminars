Console.Clear();
//int a = new Random().Next(-100, 101);
Console.Write("Введите любое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Чило, квадрат которого надо найти: " + a);
int kvadrat = a * a;
Console.WriteLine($"Квадрат числа {a} равен = {kvadrat}");