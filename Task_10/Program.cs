/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.*/
 Console.Write("Введите трехзначное число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 if(number < 100 || number >= 1000) 
 {
    Console.Write("Вы ввели неверное число. Пожалуйста введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
 }
 Console.WriteLine($"Вторая цифра числа {number} будет равна {number / 10 % 10}");