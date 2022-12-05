//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 456 -> 5 782 -> 8 918 -> 1

using static System.Console;
Clear ();

//Функция считывания из консоли к int
int GetIntFromConsole (string message)
{
    WriteLine(message);
    return int.Parse(ReadLine());
}

// Функция, позволяющая узнать вторую цифру числа
int GetSecondNumber (int A)
{
    int secondNumber = A % 100 / 10;
    return secondNumber;
}

int A = GetIntFromConsole("Введите трехзначное число: ");
Write("Вторая цифра числа: " + GetSecondNumber(A));
