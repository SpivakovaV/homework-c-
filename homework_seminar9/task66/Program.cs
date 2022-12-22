// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

void SummFromMtoN(int m, int n, int summ) //Метод подсчёта суммы натуральных чисел от M до N
{
  summ = summ + n;
  if (n <= m)
  {
    Write($"Сумма натуральных элементов между M и N: {summ} ");
    return;
  }
  SummFromMtoN(m, n-1, summ);
}

Write("Введите M: ");
int m=int.Parse(ReadLine());

Write("Введите N: ");
int n=int.Parse(ReadLine());

int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

SummFromMtoN(m, n, temp=0);



