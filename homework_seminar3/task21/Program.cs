//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();

Write("Введите координату 1-ой точки по оси Х: ");
int x1 = int.Parse(ReadLine());
Write("Введите координату 1-ой точки по оси Y: ");
int y1 = int.Parse(ReadLine());
Write("Введите координату 1-ой точки по оси Z: ");
int z1 = int.Parse(ReadLine());
Write("Введите координату 2-ой точки по оси Х: ");
int x2 = int.Parse(ReadLine());
Write("Введите координату 2-ой точки по оси Y: ");
int y2 = int.Parse(ReadLine());
Write("Введите координату 2-ой точки по оси Z: ");
int z2 = int.Parse(ReadLine());

double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
WriteLine($"Расстояние между этими точками в пространстве равно: {distance}");