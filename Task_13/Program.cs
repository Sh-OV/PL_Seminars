// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите любое целое число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int numdig = 3;      // номер цифры
 
 int NumDigits(int num)
 {
    int i = 1;
     while (num / 10 > 0)
    {
        num /= 10;
        i++;
    }
    return i;
 }

 int NDigit(int count, int digit, int num)
 {
    int i = count - digit;
    int dig = 0;
    if(i >= 0)
    {
        count = 1;
       while (i > 0)
        {
            count *= 10;
            i--;
        }
       dig = num / count % 10;
    }
    else dig = -1;
    return dig;
 }
 int answer = NDigit(NumDigits(number), numdig, number);
 string result = answer > 0 ? 
        $"В заданном числе {numdig} цифра равна {answer}" : 
        $"В заданном числе {numdig} цифры НЕТ";
 Console.WriteLine(result);