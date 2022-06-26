// Задача №7
// Напишите программу, которая принимает на вход 
//  ёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number % 10;
Console.WriteLine($"Последнее число: {number2}");