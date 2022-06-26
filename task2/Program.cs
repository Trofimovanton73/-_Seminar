// Находим квадрат введенного числа

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int squareOfNumbers = numberB * numberB;
if (squareOfNumbers == numberA)
{
    Console.WriteLine($"Число {numberB} является квадратом числа {numberA}");
}
else
{
    Console.WriteLine($"Число {numberB} не является квадратом числа {numberA}");
}