// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();


Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

int functionAkkerman = Ack(m, n);

Write($"Функция Аккермана A({m},{n}) = {functionAkkerman}");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
