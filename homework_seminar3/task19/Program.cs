//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using static System.Console;
Clear();

Write("Введите число: ");
string number = ReadLine();
int count = 0;
for (int i = 0; i < number.Length; i++)
{
    if (number[i] == number[number.Length - i - 1]) count++;
}
if (count == number.Length) WriteLine("Это число является полиндромом.");
else WriteLine("Введённое число полиндромом не является.");