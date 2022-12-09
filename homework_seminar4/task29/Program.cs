//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using static System.Console;
Clear();

void printArray(int Length)
{
    int[] arr = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        Write($"Введите {i+1} элемент массива ");
        arr[i] = int.Parse(ReadLine());
    }
    Write(" Требуемый массив:[");
    for (int i = 0; i < Length; i++)
    {
        Write(arr[i]);
        if (i < arr.Length - 1) Write(", ");
    }
    Write("]");
}


int size = 8;
printArray(size);


