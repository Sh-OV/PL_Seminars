// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.Clear();
int[] UserArray()
{
    // Можно так:
    Console.Write("Введите размер массива, который Вы будете вводить: ");
    int len = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите указанное Вами количество любых чисел: ");
    int[] arrNum = new int[len];
    int num = 0;
    // Можно так:
    // Console.WriteLine("Введите несколько чисел (не более 100) любого значения, ");
    // Console.WriteLine("после, чтобы завершить ввод чисел, напишите четыре единицы (1111): ");
    // int[] arrNum = new int[100];
    // int num = Convert.ToInt32(Console.ReadLine());
    // int i = 0;
    // while (num != 1111)
    // {
    //     arrNum[i] = num;
    //     num = Convert.ToInt32(Console.ReadLine());   
    //     i++;   
    // }
    for (int i = 0; i < len; i++)
    {
         num = Convert.ToInt32(Console.ReadLine());
         arrNum[i] = num;
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

string EndWord(int digit)
{
    string end = String.Empty;
    
    if (digit % 10 == 1 && digit / 10 <= 10) end = "положительное значение";
    else if ((digit % 10 == 2 || digit % 10 == 3 || digit % 10 == 4) && digit / 10 <= 10) end = "положительных значения";
    else if ((digit / 10 >= 10 && digit / 10 <= 20) || digit % 10 == 0 || 
              digit % 10 == 5 || digit % 10 == 6 || digit % 10 == 7 ||
              digit % 10 == 8 || digit % 10 == 9) end = "положительных значений";

    return end;  
}
string res = EndWord(num);

Console.WriteLine("В созданном Вами одномерном массиве:");
PrintArr(userArr);
Console.WriteLine($"имеется  {num}  {res}");