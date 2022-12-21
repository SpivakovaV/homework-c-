// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


using static System.Console;
Clear();

void FillArray(int[,]array) //Метод создания массива
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

void PrintArray(int[,] array) //Метод вывода массива в консоль
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

void ArrayRowsDescendingOrder(int[,] array) //Метод обработки двумерного массива на упорядочивание позиций в строке по убыванию.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Write("Сколько строк будет в массиве: ");
int m=int.Parse(ReadLine());
Write("Сколько столбцов будет в массиве: ");
int n = int.Parse(ReadLine());

int[,]array=new int[m,n];

FillArray(array);

WriteLine("Создан массив: ");
PrintArray(array);
WriteLine();

ArrayRowsDescendingOrder(array);

WriteLine("Массив упорядочен: ");
PrintArray(array);
WriteLine();