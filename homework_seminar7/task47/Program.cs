// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using static System.Console;
Clear();

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Random x = new Random();
            array[i, j] = Convert.ToDouble(x.Next(-100, 100) / 10.0);

        }
    }
}
void PrintArray(double[,] array)
{
    WriteLine("Ваш массив готов: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
                for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

Write("Сколько строк должно быть в создаваемом массиве? ");
int m = int.Parse(ReadLine());

Write("Сколько столбцов должно быть в создаваемом массиве? ");
int n = int.Parse(ReadLine());
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);