// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Random x = new Random();
            array[i, j] = x.Next(10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

void EachColomnAverage(int[,] array)
{
    Write("Среднее арифмитическое в каждом столбце по порядку: ");
    int[,] revertArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < revertArray.GetLength(0); i++)
    {
        for (int j = 0; j < revertArray.GetLength(1); j++)
        {
            revertArray[i, j] = array[j, i];
        }
    }
    double[] counter = new double[revertArray.GetLength(0)];
    for (int i = 0; i < revertArray.GetLength(0); i++)
    {
        for (int j = 0; j < revertArray.GetLength(1); j++)
        {
            counter[i] += revertArray[i, j];
        }
        Write($"{Math.Round(counter[i] / revertArray.GetLength(1), 2)}    ");
    }
}

Write("Сколько строк будет в массиве: ");
int m=int.Parse(ReadLine());
Write("Сколько столбцов будет в массиве: ");
int n = int.Parse(ReadLine());

int[,]array=new int[m,n];

FillArray(array);
WriteLine();

PrintArray(array);
WriteLine();

EachColomnAverage(array);
WriteLine();