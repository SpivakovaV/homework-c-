// Напишите программу, которая заполнит спирально массив 4 на 4.

using static System.Console;
Clear();

void PrintArray(int[,] array) //Метод вывода массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Write($" {array[i, j]} ");

            else Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(ReadLine());
WriteLine();

int[,] A = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= A.GetLength(0) * A.GetLength(1))
{
    A[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < A.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= A.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > A.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintArray(A);