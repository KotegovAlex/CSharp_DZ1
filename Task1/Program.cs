// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число b: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a >= b) 
{
    Console.WriteLine($"Максимальное значение {a}");
}
else
{
    Console.WriteLine($"Максимальное значение {b}");
}
