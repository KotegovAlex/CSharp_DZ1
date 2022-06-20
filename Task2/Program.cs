// Задача 2: Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// for (int i = 0; i < arrNumbers.Length; i++)
//        Console.Write(arrNumbers[i] + " ");

Console.WriteLine("Введите через пробел 3 числа: ");
double[] arrNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

double max = arrNumbers[0];
int count = 0;
if (arrNumbers.Length > 3) 
{
    Console.WriteLine("Превышен лимит чисел для сравнения!!! Введите 3 числа");
}
else 
{
while (count < arrNumbers.Length)
{
    if (arrNumbers[count] > max) 
    {
        max = arrNumbers[count];
    }
    count++;
}
Console.Write($"Максимальное число: {max}");
}