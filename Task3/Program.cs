// Задача 3: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число: ");
// double n = Convert.ToDouble(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0) 
{
    Console.WriteLine($"Число {n} является чётным");
}
else
{
    Console.WriteLine($"Число {n} не является чётным");
}