//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using static System.Console;
Clear(); 

int ReadIntFromConsole()
{
    return int.Parse(ReadLine());
}

int degree(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}

Write("Введите 1-ое число: ");
int a=ReadIntFromConsole(); 
Write("Введите 2-ое число: ");
int b=ReadIntFromConsole();
WriteLine($"Если возвести {a} в степень {b} получится: {degree(a,b)}");

