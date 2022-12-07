//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 6 -> да 7 -> да 1 -> нет

using static System.Console;
Clear();

bool HolidayChek(int day) { return day>5 ? true : false; }
int day;
do
{
    Write("Введите порядковый номер дня недели: ");
    day = Convert.ToInt32(ReadLine());
} while (day > 7||day<1);

if (HolidayChek(day)) Write("Ура! Этот день выходной.");
else Write("Этот день не является выходным.");
