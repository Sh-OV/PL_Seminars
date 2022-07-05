// Задача № 30. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
int[] arr = {0,0,0,0,0,0,0,0};
int length = 7;
for (int i = 0; i < length; i++)
{
    arr[i] = new Random().Next(0, 2);
    Console.Write($"{arr[i]}, ");
}
arr[length] = new Random().Next(0, 2);
    Console.WriteLine($"{arr[length]}");
