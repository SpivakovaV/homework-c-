//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void PrintArray(int[,] array) //Метод вывода массива
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

int SumRowElements(int[,] array, int i) //Метод определения суммы элементов в массиве
{
    int sumRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}

Write("Введите размерность прямоугольного массива: ");
int m=int.Parse(ReadLine());
int[,]array=new int[m,m];

FillArray(array);

WriteLine("Создан массив: ");
PrintArray(array);
WriteLine();

int minRow = 0;
int sumRow = SumRowElements(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = SumRowElements(array, i);
    if (sumRow > temp)
    {
        sumRow = temp;
        minRow = i;
    }
}

WriteLine($"Номер строки с наименьшей суммой элементов: {minRow + 1}");
WriteLine($"Сумма элементов строки: {sumRow}");
WriteLine();
