// Задача 4: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int count = 2;

while (count < N + 1)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}
if (N == 0 || N == 1) Console.WriteLine($"Для числа N = {N} нет четных чисел в диапазоне от 1 до N");