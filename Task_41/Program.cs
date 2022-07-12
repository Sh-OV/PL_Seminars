// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.Clear();
int[] UserArray()
{
    // Можно так:
    // Console.Write("Введите размер массива, который Вы будете вводить: ");
    // int lenght = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Введите указанное Вами количество любых чисел: ");
    // int[] arrNum = new int[lenght];
    // через цикл for

    // Можно так:
    Console.WriteLine("Введите несколько чисел (не более 100) любого значения, ");
    Console.WriteLine("чтобы завершить ввод чисел напишите четыре единицы (1111): ");
    int[] arrNum = new int[100];
    int num = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    while (num != 1111)
    {
        arrNum[i] = num;
        num = Convert.ToInt32(Console.ReadLine());   
        i++;   
    }
    return arrNum;
}
int[] userArr = UserArray();

int CountPosArr(int[] array)
{
    int len = array.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] > 0) count ++;
    }
    return count;
}
int num = CountPosArr(userArr);

void PrintArr (int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"[");
        if (i < res.Length-1) Console.Write($"{res[i]}, ");
        else Console.WriteLine($"{res[i]}]");
    }
}
Console.WriteLine("В созданном Вами одномерном массиве:");
PrintArr(userArr);
Console.WriteLine($"имеется  {num}   положительных значений");