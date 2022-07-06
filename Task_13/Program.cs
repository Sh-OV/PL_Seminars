// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Решение №1: ");
Console.Write("Введите любое целое число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите номер цифры в числе, которую хотите узнать: ");
 int numdig = Convert.ToInt32(Console.ReadLine());
 
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
 string result = answer > -1 ? 
        $"В заданном числе {numdig} цифра равна {answer}" : 
        $"В заданном числе {numdig} цифры НЕТ";
 Console.WriteLine(result);

 Console.WriteLine();
 Console.WriteLine("Решение №2: ");

 int Digit(int num, int dig)
 {
  if (num < Math.Pow(10,(numdig-1))) num = -1; 
 else  
 { 
    while (num >= Math.Pow(10,(numdig)))
    {
        num /= 10;
    }
    num %= 10;
 }
    return num;
 }
 answer = Digit(number, numdig);
 result = answer > -1 ? 
        $"В заданном числе {number} {numdig}-я цифра равна {answer}" : 
        $"В заданном числе {number} {numdig}-ей(ой) цифры НЕТ";
 Console.WriteLine(result);
 
