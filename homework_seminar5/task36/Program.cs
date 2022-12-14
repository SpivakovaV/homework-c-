// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}

int oddSum(int[] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (j % 2 == 0) sum += array[j];
    }
    return sum;
}

Write("Массив из скольки элементов вы хотите получить? ");
int n =int.Parse(ReadLine());

int[] array = new int[n];

FillArray(array);

Write($"[{String.Join(", ", array)}]-> {oddSum(array)}");
