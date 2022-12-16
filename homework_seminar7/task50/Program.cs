// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

using static System.Console;
Clear();

void FillArray(double[,]array)
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

void PrintArray(double[,] array)
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

void FindElement(double[,] array,int digit)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == digit) WriteLine($"Число {digit} найдено в {i + 1} строке {j + 1} столбце.");
            else temp++;
        }
    }
    if (temp == array.Length) WriteLine("Заданного элемента в массиве нет.");
}

Write("Сколько строк будет в массиве: ");
int m=int.Parse(ReadLine());
Write("Сколько столбцов будет в массиве: ");
int n = int.Parse(ReadLine());

double[,]array=new double[m,n];

Write("Какой элемент массива мы ищем? ");
int digit=int.Parse(ReadLine());

FillArray(array);
WriteLine();

PrintArray(array);
WriteLine();

FindElement(array, digit);
WriteLine();
        