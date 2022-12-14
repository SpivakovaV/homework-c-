//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

using static System.Console;
Clear();

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}

double MinMaxDiff (double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return diff = max - min;
}

Write("Массив из скольки элементов вы хотите получить? ");
int n = int.Parse(ReadLine());

double[] array = new double[n];

FillArray(array);
MinMaxDiff(array);

WriteLine($"[{String.Join(", ", array)}]-> {MinMaxDiff(array)}");




