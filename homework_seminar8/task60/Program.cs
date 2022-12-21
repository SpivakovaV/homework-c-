// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

using static System.Console;
Console.Clear();

int[,,] GetArray(int length, int height, int width) // Метод заполнения трехмерного массива неповторяющимися цифрами
{
    int[,,] A = new int[length, height, width]; 

    for (int i = 0; i < A.GetLength(0); i++) 
    {
        for (int j = 0; j < A.GetLength(1); j++) 
        {
            for (int k = 0; k < A.GetLength(2);) 
            {
                int element = new Random().Next(10, 99); 
                if (Unique(A, element) is true) 
                continue;
                A[i,j,k] = element; 
                k ++; 
            }
        }
    }
    return A;
}

void PrintArray(int[,,] inArray) //Метод вывода массива построчно с указанием индекса
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2) ; k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i}, {j}, {k})\t "); 
            }
             WriteLine();
        }
       
    }
}

bool Unique(int[,,] array, int element) //Метод проверки на уникальность 
{
    bool x = false; 
    for (int length = 0; length < array.GetLength(0); length++) 
    {
        for (int height = 0; height < array.GetLength(1); height++)
        {
            for (int width = 0; width < array.GetLength(2); width++) 
            {
                if (array[length,height,width] == element) 
                x = true;               
            }
        }
    }
    return x; 
}

WriteLine("Введите размерность трёхмерного массива: ");
int[,,] firstarray = GetArray(Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));
WriteLine();

WriteLine("Массив построчно, с указанием индекса: ");
PrintArray(firstarray);
WriteLine();