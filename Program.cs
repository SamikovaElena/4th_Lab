﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForLab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            #region Task#1.3
            Console.WriteLine("Task#1.3");
            int n = 4;
            int[, ] A = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = random.Next(50);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        s += A[i, j];
                    }
                }

            }
            Console.WriteLine("Сумма элементов диагонали: {0}", s);
            #endregion

            #region Task#1.6
            Console.WriteLine("Task#1.6");
            int n1 = 4, m1 = 7;
            int[,] AA = new int[n1, m1];
            int[] A_A = new int[n1];
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < m1; j++)
                    AA[i, j] = random.Next(-10, 10);
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    Console.Write(AA[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n1; i++)
            {
                int minAA = AA[i, 0], jAA = 0;
                for (int j = 0; j < m1; j++)
                {
                    if (AA[i, j] < minAA)
                    {
                        minAA = AA[i, j];
                        jAA = j;
                    }
                }
                A_A[i] = jAA;
            }
            for (int i = 0; i < A_A.Length; i++)
                Console.Write("{0} ", A_A[i]);
            Console.WriteLine();
            #endregion

            #region Task#1.12
            Console.WriteLine("Task#1.12");
            int n2 = 6, m2 = 7;
            int[,] A1 = new int[n2, m2];
            for (int i = 0; i < n2; i++)
                for (int j = 0; j < m2; j++)
                    A1[i, j] = random.Next(50);
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Console.Write(A1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int maxA1 = A1[0, 0], ik = 0, jk = 0;
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    if (maxA1 < A1[i, j])
                    {
                        maxA1 = A1[i, j];
                        ik = i;
                        jk = j;
                    }
                }
            }
            n2 -= 1; m2 -= 1;
            for (int i = ik; i < n2; i++)
                for (int j = jk; j < m2; j++)
                    A1[i, j] = A1[i + 1, j + 1];
            Console.WriteLine();
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Console.Write(A1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region Task#1.13
            Console.WriteLine("Task#1.13");
            int n3 = 5;
            int[,] A3 = new int[n3, n3];
            for (int i = 0; i < n3; i++)
                for (int j = 0; j < n3; j++)
                    A3[i, j] = random.Next(50);
            for (int i = 0; i < n3; i++)
            {
                for (int j = 0; j < n3; j++)
                {
                    Console.Write(A3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            int maxA3 = A3[0, 0], iA3 = 0, p = 0, k = 4;
            for (int i = 0; i < n3; i++)
            {
                for (int j = 0; j < n3; j++)
                {
                    if (A3[i, j] > maxA3 && i == j)
                    {
                        maxA3 = A3[i, j];
                        iA3 = i;
                    }
                }
            }
            for (int i = 0; i < n3; i++)
            {
                p = A3[i, k]; A3[i, k] = A3[i, iA3]; A3[i, iA3] = p;
            }
            for (int i = 0; i < n3; i++)
            {
                for (int j = 0; j < n3; j++)
                {
                    Console.Write(A3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region Task#1.17
            Console.WriteLine("Task#1.17");
            Console.WriteLine("Введите количество столбцов массива: ");
            int.TryParse(Console.ReadLine(), out int n4);
            Console.WriteLine("Введите количество строк массива:");
            int.TryParse(Console.ReadLine(), out int m4);
            int[,] B = new int[n4, n4];
            for (int i = 0; i < n4; i++)
                for (int j = 0; j < m4; j++)
                    B[i, j] = random.Next(50);
            for (int i = 0; i < n4; i++)
            {
                for (int j = 0; j < m4; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int pp = 0;
            Console.WriteLine("\n");
            for (int i = 0; i < n4; i++)
            {
                int minB = B[i, 0], jB = 0;
                for (int j = 0; j < m4; j++)
                {
                    if (minB > B[i, j])
                    {
                        minB = B[i, j];
                        jB = j;
                    }
                }
                while (jB > 0)
                {
                    pp = B[i, jB]; B[i, jB] = B[i, jB - 1]; B[i, jB - 1] = pp;
                    jB--;
                }
            }
            for (int i = 0; i < n4; i++)
            {
                for (int j = 0; j < m4; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region Task#1.29
            Console.WriteLine("Task#1.29");
            int n5 = 5, m5 = 7;
            int[,] F = new int[n5, m5];
            for (int i = 0; i < n5; i++)
                for (int j = 0; j < m5; j++)
                    F[i, j] = random.Next(-10, 10);
            for (int i = 0; i < n5; i++)
            {
                for (int j = 0; j < m5; j++)
                {
                    Console.Write(F[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            int iF = 0;
            for (int i = 0; i < n5; i++)
            {
                int minF = F[i, 0];
                for (int j = 0; j < m5; j++)
                {
                    if (j == 2 && Math.Abs(minF) > Math.Abs(F[i, j]))
                    {
                        minF = F[i, j];
                        iF++;
                    }
                }
            }
            m5 -= 1;
            if (iF < m5 - 1)
            {
                for (int i = iF + 1; i < n5; i++)
                {
                    for (int j = 0; j < m5; j++)
                    {
                        F[i, j] = F[i, j + 1];
                    }
                }
            }
            for (int i = 0; i < n5; i++)
            {
                for (int j = 0; j < m5; j++)
                {
                    Console.Write(F[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region Task#1.31
            Console.WriteLine("Task#1.31");
            int n6 = 5, m6 = 7;
            int[,] A6 = new int[5, 8];
            int[] B6 = new int[n6];
            for (int i = 0; i < n6; i++)
                for (int j = 0; j < m6; j++)
                    A6[i, j] = random.Next(50);
            for (int i = 0; i < n6; i++)
            {
                for (int j = 0; j < m6; j++)
                {
                    Console.Write(A6[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n6; i++)
                B6[i] = random.Next(5);
            Console.WriteLine();
            int minA6 = A6[0, 0], jA6 = 0;
            for (int i = 0; i < n6; i++)
            {
                for (int j = 0; j < m6 - 1; j++)
                {
                    if (i == 4 && minA6 > A6[i, j])
                    {
                        minA6 = A6[i, j];
                        jA6 = j;
                    }
                }
            }
            for (int i = 0; i < n6; i++)
                for (int j = m6 - 1; j >= jA6 + 1; j--)
                    A6[i, j + 1] = A6[i, j];
            for (int i = 0; i < n6; i++)
                A6[i, jA6 + 1] = B6[i];
            for (int i = 0; i < n6; i++)
            {
                for (int j = 0; j < m6 + 1; j++)
                {
                    Console.Write(A6[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region #Task2.7
            Console.WriteLine("Task#2.7");
            int n7 = 6;
            int[,] A7 = new int[n7, n7];
            for (int i = 0; i < n7; i++)
                for (int j = 0; j < n7; j++)
                    A7[i, j] = random.Next(50);
            for (int i = 0; i < n7; i++)
            {
                for (int j = 0; j < n7; j++)
                {
                    Console.Write(A7[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            int A7max = A7[0, 0], iA7 = 0;
            for (int i = 1; i < n7; i++)
            {
                if (A7[i, i] > A7max)
                {
                    A7max = A7[i, i];
                    iA7 = i;
                }
            }
            for (int i = 0; i < n7; i++)
            {
                for (int j = 0; j < n7; j++)
                {
                    if (iA7 > i && j > i)
                    {
                        A7[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < n7; i++)
            {
                for (int j = 0; j < n7; j++)
                {
                    Console.Write(A7[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region Task#2.8
            Console.WriteLine("Task#2.8");
            int n8 = 6;
            int[,] B8 = new int[n8, n8];
            int[] B_8 = new int[n8];
            for (int i = 0; i < n8; i++)
                for (int j = 0; j < n8; j++)
                    B8[i, j] = random.Next(50);
            for (int i = 0; i < n8; i++)
            {
                for (int j = 0; j < n8; j++)
                {
                    Console.Write(B8[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < n8; i++)
            {
                int maxA8 = 0, jB8 = 0;
                for (int j = 0; j < n8; j++)
                {
                    if (B8[i, j] > maxA8)
                    {
                        maxA8 = B8[i, j];
                        jB8 = j;
                    }
                }
                B_8[i] = jB8;
            }
            int p8 = 0;
            for (int i = 0; i < n8; i += 2)
            {
                p8 = B8[i, B_8[i]]; B8[i, B_8[i]] = B8[i + 1, B_8[i + 1]]; B8[i + 1, B_8[i + 1]] = p8;
            }
            for (int i = 0; i < n8; i++)
            {
                for (int j = 0; j < n8; j++)
                {
                    Console.Write(B8[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region Task#2.9
            Console.WriteLine("Task#2.9");
            int n9 = 6, m9 = 7;
            int[,] A9 = new int[n9, m9];
            int[,] A_9 = new int[n9, m9];
            for (int i = 0; i < n9; i++)
                for (int j = 0; j < m9; j++)
                    A9[i, j] = random.Next(50);

            for (int i = 0; i < n9; i++)
            {
                for (int j = 0; j < m9; j++)
                {
                    Console.Write(A9[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < n9; i++)
            {
                for (int j = 0; j < m9; j++)
                {
                    A_9[i, m9 - j - 1] = A9[i, j];
                }
            }
            for (int i = 0; i < n9; i++)
            {
                for (int j = 0; j < m9; j++)
                {
                    Console.Write(A_9[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region Task#3.1
            Console.WriteLine("Task#3.1");
            int[,] a3_1 = new int[7, 5];
            for (int i = 0; i < a3_1.GetLength(0); i++)
                for (int j = 0; j < a3_1.GetLength(1); j++)
                    a3_1[i, j] = random.Next(-10, 10);
            int[,] b3_1 = new int[7, 2];
            int[,] c3_1 = new int[7, 5];
            for (int i = 0; i < a3_1.GetLength(0); i++)
            {
                for (int j = 0; j < a3_1.GetLength(1); j++)
                {
                    Console.Write(a3_1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int k3_1 = 0;
            int q3_1 = 0;
            int m3_1;

            for (int i = 0; i < 7; i++)
            {
                int imin3_1 = i;
                int jmin3_1 = 0;
                int min3_1 = a3_1[i, 0];

                for (int j = 0; j < 5; j++)
                {
                    if (a3_1[i, j] < min3_1)
                    {
                        min3_1 = a3_1[i, j];
                        imin3_1 = i;
                        jmin3_1 = j;
                    }
                }
                b3_1[q3_1, k3_1] = imin3_1;
                b3_1[q3_1, k3_1 + 1] = min3_1;
                q3_1++;
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = i; j < 6; j++)
                {

                    if (b3_1[i, 1] < b3_1[j + 1, 1])
                    {
                        m3_1 = b3_1[i, 1];
                        b3_1[i, 1] = b3_1[j + 1, 1];
                        b3_1[j + 1, 1] = m3_1;
                        m3_1 = b3_1[i, 0];
                        b3_1[i, 0] = b3_1[j + 1, 0];
                        b3_1[j + 1, 0] = m3_1;
                    }
                }
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    c3_1[i, j] = a3_1[b3_1[i, 0], j];
                }
            }


            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(c3_1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region Task#3.2
            Console.WriteLine("Task#3.2");
            Console.WriteLine("Введите размер матрицы:");
            int.TryParse(Console.ReadLine(), out int g);
            int[,] Array = new int[g, g];
            for (int i = 0; i < g; i++)
                for (int j = 0; j < g; j++)
                    Array[i, j] = random.Next(50);
            for (int i = 0; i < g; i++)
            {
                for (int j = 0; j < g; j++)
                {
                    Console.Write(Array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < g; i++)
            {
                Array[i, 0] = 0;
                Array[0, i] = 0;
                Array[i, Array.GetLength(0) - 1] = 0;
                Array[Array.GetLength(1) - 1, i] = 0;
            }
            for (int i = 0; i < g; i++)
            {
                for (int j = 0; j < g; j++)
                {
                    Console.Write(Array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region Task#3.3
            Console.WriteLine("Task#3.3");
            Console.WriteLine("Введите размер матрицы");
            int.TryParse(Console.ReadLine(), out int len);
            int[,] MyArr = new int[len, len];
            int[] My_Arr = new int[2 * len - 1];
            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                    MyArr[i, j] = random.Next(50);
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                    Console.Write(MyArr[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            int k3_3 = 0;
            for (int i = len - 1; i > 0; i--)
            {
                int s3_3 = 0;
                for (int j = 0; j + i < len; j++)
                {
                    s3_3 += MyArr[i + j, j];
                }
                My_Arr[k3_3] = s3_3;
                k3_3++;
            }
            for (int i = len - 1; i >= 0; i--)
            {
                int s3_3 = 0;
                for (int j = 0; j + i < len; j++)
                {
                    s3_3 += MyArr[j, i + j];
                }
                My_Arr[k3_3] = s3_3;
                k3_3++;
            }
            for (int i = 0; i < My_Arr.Length; i++)
            {
                Console.Write(My_Arr[i] + "\t");
            }
            Console.WriteLine();
            #endregion

            #region Task#3.4
            Console.WriteLine("Task#3.4");
            Console.WriteLine("Введите размер матрицы:");
            int.TryParse(Console.ReadLine(), out int g1);
            int[,] Arr = new int[g1, g1];
            for (int i = 0; i < g1; i++)
                for (int j = 0; j < g1; j++)
                    Arr[i, j] = random.Next(50);
            for (int i = 0; i < g1; i++)
            {
                for (int j = 0; j < g1; j++)
                {
                    Console.Write(Arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = g1 / 2; i < g1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Arr[i, j] = 1;
                }
            }
            for (int i = 0; i < g1; i++)
            {
                for (int j = 0; j < g1; j++)
                {
                    Console.Write(Arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region Task#3.10
            Console.WriteLine("Task#3.10");
            Console.WriteLine("Введите размер матрицы:");
            int.TryParse(Console.ReadLine(), out int f);
            Console.WriteLine("Введите размер матрицы:");
            int.TryParse(Console.ReadLine(), out int f1);
            int[,] arr = new int[f, f1];
            for (int i = 0; i < f; i++)
                for (int j = 0; j < f1; j++)
                    arr[i, j] = random.Next(50);
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < f1; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            int p10;
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < f1 - 1; j++)
                {
                    for (int k3_10 = j; k3_10 < f1; k3_10++)
                    {
                        if (i % 2 == 0)
                        {
                            if (arr[i, j] < arr[i, k3_10])
                            {
                                p10 = arr[i, j]; arr[i, j] = arr[i, k3_10]; arr[i, k3_10] = p10;
                            }
                        }
                        else
                        {
                            if (arr[i, j] > arr[i, k3_10])
                            {
                                p10 = arr[i, j]; arr[i, j] = arr[i, k3_10]; arr[i, k] = p10;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < f1; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region Task#3.11
            Console.WriteLine("Task#3.11");
            Console.WriteLine("Введите размер массива");
            int.TryParse(Console.ReadLine(), out int n3_11);
            Console.WriteLine("Введите размер массива");
            int.TryParse(Console.ReadLine(), out int m3_11);
            int[,] A3_11 = new int[n3_11, m3_11];
            List<int> noll = new List<int>();

            for (int i = 0; i < n3_11; i++)
            {
                bool fg = false;
                for (int j = 0; j < m3_11; j++)
                {
                    A3_11[i, j] = random.Next(-50, 50);
                    if (A3_11[i, j] == 0)
                    {
                        fg = true;
                    }
                }
                if (fg == true)
                {
                    noll.Add(i);
                }
            }
            for (int i = 0; i < n3_11; i++)
            {
                for (int j = 0; j < m3_11; j++)
                {
                    Console.Write(A3_11[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int iA3_11 = 0;
            int len3_11 = noll.Count();
            for (int i = 0; i < n3_11; i++)
            {
                if (iA3_11 == len3_11)
                {
                    iA3_11 = 0;
                }
                else if (i == noll[iA3_11])
                {
                    iA3_11 += 1;
                    continue;
                }
                for (int j = 0; j < m3_11; j++)
                {
                    Console.Write(A3_11[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
