//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


using static System.Console;
Clear();

Write("Введите число: ");
int n = Convert.ToInt32(ReadLine());
Write($"Таблица кубов целых чисел от 1 до {n}: ");
for (int i = 1; i <= n; i++)
{
    Write($"{i * i * i} ");
}