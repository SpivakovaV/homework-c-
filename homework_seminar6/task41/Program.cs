// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

int[] getArray(int length)
{
    int[] array=new int[length];
    for (int i=0; i<length; i++)
    {
        Write($"Введите {i+1} число: ");
        array[i] = int.Parse(ReadLine());
    }
    return array;
}

void HowManyPozitiveInteger(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Write($"Количество введённых чисел больше 0: {count}");
}

WriteLine("Сколько чисел мы будем анализировать?");
int length=int.Parse(ReadLine());

int[]array=getArray(length);
HowManyPozitiveInteger(array);