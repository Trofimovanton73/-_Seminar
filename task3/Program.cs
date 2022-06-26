// Задача
//Напишите программу, которая будет выдавать название 
//дня недели по заданному номеру.

Console.WriteLine("Введите номер дня: ");
int dayweek = Convert.ToInt32(Console.ReadLine());
if (dayweek == 1)
{
    Console.WriteLine("Понедельник");
}
if (dayweek == 2)
{
    Console.WriteLine("Вторник");
}
if (dayweek == 3)
{
    Console.WriteLine("Среда");
}
if (dayweek == 4)
{
    Console.WriteLine("Четвеог");
}
if (dayweek == 5)
{
    Console.WriteLine("Пятница");
}
if (dayweek == 6)
{
    Console.WriteLine("Суббота");
}
if (dayweek == 7)
{
    Console.WriteLine("Воскресенье");
}
