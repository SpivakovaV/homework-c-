//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


using static System.Console;
Clear();

int sum(int digit)
{
    int result = 0;
    while (digit != 0)
    {
        result += digit%10;
        digit /= 10;
    }
    return result;
}

Write("Введите число: ");
WriteLine($"Сумма цифр в числе: {sum(int.Parse(ReadLine()))}");

