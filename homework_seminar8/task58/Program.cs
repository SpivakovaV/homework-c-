// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using static System.Console;
Clear();

void Print(int[,] a) //Метод выводит заданную матрицу в консоль.
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Write("{0} ", a[i, j]);
                }
                WriteLine();
            }
        }        
int[,] MatrixMultiplication(int[,] a, int[,] b) // Метод перемножения матриц.
        {
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            return r;
        }

WriteLine("Введите размерность первой матрицы: ");
            int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

WriteLine("Введите размерность второй матрицы: ");
            int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("B[{0},{1}] = ", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

WriteLine("Матрица A:");
Print(A);
WriteLine();

WriteLine("Матрица B:");
Print(B);
WriteLine();
            
if (A.GetLength(1) != B.GetLength(0)) Write("Матрицы нельзя перемножить!");
   else { 
         WriteLine("Результат перемножения матриц: ");
         int[,] C = MatrixMultiplication(A, B);
         Print(C);
         }

WriteLine();