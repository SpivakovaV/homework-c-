// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();

WriteLine($"Введите значение: ");
int n = int.Parse(ReadLine());


string PrintNumber(int n)
{
    if (n == 1) return n.ToString();
    return (n + " " + PrintNumber(n-1));
}

WriteLine($"Натуральные числа в промежутке от {n} до 1: ");
Write(PrintNumber(n));