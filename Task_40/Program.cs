// Задача № 40. Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длинны
//(Теоремма о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон)
Console.Clear();
int[] UserArr()
{
    int[] array = new int[3];
    Console.WriteLine($"Введите три натуральных числа: ");
    Console.Write("Первое число: ");
    array[0] = Convert.ToInt32( Console.ReadLine());
    Console.Write("Второе число: ");
    array[1] = Convert.ToInt32( Console.ReadLine());
    Console.Write("Третье число: ");
    array[2] = Convert.ToInt32( Console.ReadLine());
    return array;
}
int[] userarr = UserArr();

bool TriangleYesOrNo(int[] array)
{
    bool res = false;
    if (array[0] < array[1] + array[2] &&
        array[1] < array[0] + array[2] &&
        array[2] < array[1] + array[0]) res = true;
        else res = false;
        return res;
}
bool triangle = TriangleYesOrNo(userarr);
string result = triangle ?  $"Со сторонами {userarr[0]}, {userarr[1]} и {userarr[2]} треугольник МОЖЕТ существовать!" :
                            $"Со сторонами {userarr[0]}, {userarr[1]} и {userarr[2]} треугольник существовать НЕ МОЖЕТ!";

Console.WriteLine(result); 