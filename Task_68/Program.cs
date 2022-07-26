/* Задача 68:   Напишите программу вычисления функции Аккермана с помощью рекурсии. 
                Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29     */
Console.Clear();
Console.WriteLine("Для вычисления функции Аккермана введите два неотрицательных числа m и n ");
Console.Write("Введите неотрицательное число m (от 0 до 3): ");
int firstNonNegativeNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n (от 0 до 10): ");
int secondNonNegativeNumber = Convert.ToInt32(Console.ReadLine());

while (firstNonNegativeNumber < 0 || firstNonNegativeNumber > 3)    // проверка
{
    Console.WriteLine("Вы ввели неверные данные. Число m НЕ должно быть отрицательным и НЕ должно быть больше 3!");
    Console.Write("Введите неотрицательное число m (от 0 до 3): ");
    firstNonNegativeNumber = Convert.ToInt32(Console.ReadLine());
}

while (secondNonNegativeNumber < 0 || secondNonNegativeNumber > 11)    // проверка
{
    Console.WriteLine("Вы ввели неверные данные. Число m НЕ должно быть отрицательным и НЕ должно быть больше 10!");
    Console.Write("Введите неотрицательное число n (от 0 до 10): ");
    secondNonNegativeNumber = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();

ulong AckermanFunction(ulong m, ulong n)    // метод вычисления функции Аккермана
{
    ulong result = 0;
  if (m == 0) result = n+1;
  else
    if (m != 0 && n == 0)
      result =  AckermanFunction (m - 1, 1);
    else
      result =  AckermanFunction (m - 1, AckermanFunction (m, n - 1));
      return result;
}
ulong ackerman = AckermanFunction (Convert.ToUInt64(firstNonNegativeNumber), Convert.ToUInt64(secondNonNegativeNumber));
Console.WriteLine($"Ответ:  {ackerman}");
Console.WriteLine();

//       ВЫДАЕТ ОШИБКУ:
// ! [rejected]        main -> main (fetch first)

// Используйте эти команды для решения этой проблемы:

// git fetch origin master
// git merge origin master
// git add .
// git commit -m 'your commit message'
// git push origin master

/*       ВЫДАЕТ ОШИБКУ:
   ! [rejected]        main -> main (non-fast-forward)

   Используйте эти команды для решения этой проблемы :

  git pull
  потом уже можно делать
  git push
  */