//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 645 -> 5 78 -> третьей цифры нет 32679 -> 6

using static System.Console;
Clear ();

int WhowMatchDigitsInNumber(int digit)//Функция для подсчёта количества цифр в числе
{
    int counter = 0;
    while (digit != 0)
    {
        digit /= 10;
        counter++;
    }
    return counter;
}

Write("Введите число: ");
int digit = Convert.ToInt32(ReadLine());
int number = 3;


if (WhowMatchDigitsInNumber(digit) <= -number || WhowMatchDigitsInNumber(digit) >= number)
{
    for (int i = 0; i < WhowMatchDigitsInNumber(digit); i++)
    {
        digit = (int)(digit / Math.Pow(10, (WhowMatchDigitsInNumber(digit) - number)));
        digit %= 10;
    }
    WriteLine($"3-ая цифра числа  {digit}");
}
else WriteLine($"Ваше число {digit} не содержить 3-ей цифры");