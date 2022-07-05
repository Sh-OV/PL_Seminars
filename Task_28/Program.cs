// Задача № 28. Напишите программу, которая принимает на вход число N 
// и выдает произведение чисел от 1 до N.
Console.Clear();
Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multiplication (int num)
{
    int multiple = 1;

    for (int i = 1; i <= num; i++)
    {
        multiple *= i;
        if (i < num)  Console.Write($"{i} * ");
        else Console.Write($"{i} = ");
    }
    return multiple;
}
int result = Multiplication (number);
Console.WriteLine(result);
