// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает одно число (N), а на выходе 
// показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
for(int i= -numberN; i<=numberN; i++)
{
  Console.Write($"{i},"); 
}