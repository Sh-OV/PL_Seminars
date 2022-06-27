// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.Write("Введите любое целое число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 
 int ThirdDigit(int num)
 {
    int i = 1;
    int digit = num;

    while (num / 10 > 0)
    {
        num /= 10;
        i++;
    }
    int count = i;
    i = count-3;
    if(i > 0)
    {
        count = 1;
       while (i > 0)
        {
            count *= 10;
            i--;
        }
    i = count;
     num = digit / i % 10;
    }
    else num = -1;
    return num;
 }
 string result = ThirdDigit(number) > 0 ? 
        $"Третья цифра заданного числа равна {ThirdDigit(number)}" : 
        "Третьей цифры НЕТ";
 Console.WriteLine(result);
