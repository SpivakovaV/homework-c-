//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

using static System.Console;
Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}

int FindEvenNumber(int[] array)
{
    int j = 0;
    foreach (int i in array)
        if (i % 2 == 0) j++;
    return j;
}

Write("Массив из скольки элементов вы хотите получить? ");
int n =int.Parse(ReadLine());

int[] array = new int[n];

FillArray(array);

Write($"[{String.Join(",", array)}]-> {FindEvenNumber(array)}");

