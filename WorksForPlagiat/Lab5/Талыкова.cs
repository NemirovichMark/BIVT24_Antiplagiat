using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(8, 5);

        //program.Task_1_2(new double[] { 1, 1.5, 1 }, new double[] { 1, 1.75, 1 });

        //program.Task_1_3a(10, 1, 9, 1.6, 4);
        //program.Task_1_3b(10, 1, 9, 1.6);

        //program.Task_2_2(new double[] { 1, 12, 3, 4, 5, -6, 7, 0, 9 },
        //                 new double[] { 1, 2, 13, 4, -5, 6, 7 });

        //program.Task_2_4(new int[,] {
        //                { 1,    2,   3,   4,   5 },
        //                { 6,    7,   8,   9,   10 },
        //                { 11,  12,  13,  14,   15 },
        //                { -1,  -2,  -3 , -4,   -5 },
        //                { 6,    7,   8,   9,   0 }}, 
        //                 new int[,] {
        //                { 1,    2,   3,   4,   5 },
        //                { 6,    7,   8,   9,   10 },
        //                { 11,  12,  13,  14,   15 },
        //                { -1,  -2,  -3 , -4,   -5 },
        //                { 6,    7,   8,   9,   0 }});

        //int[] A = { 1, 2, 13, 4, -5, 6, 7 };
        //program.Task_2_6(ref A, new int[] { 1, 8, -3, 5, 5, 1, 0, 4 });

        //program.Task_2_8(new int[] { 1, 12, 3, 4, 5, -6, 7, 0, 9 }, 
        //                 new int[] { 1, 12, 13, 0, 9, 1, 5, -6, 7, 12, 14 });

        //int[,] matrix5x5 = new int[,] {
        //    { 1, 2, 3, 4, 5 },
        //    { 6, 7, 8, 9, 10 },
        //    { 11, 12, 13, 14, 15 },
        //    { -1, -2, -3, -4, -5 },
        //    { 6, 7, 8, 9, 0 }};
        //program.Task_2_10(ref matrix5x5);

        //program.Task_2_12(new int[,] {
        //               { 1,   2,   3,   4,   5 },
        //               { 6,   7,   8,   9,  10 },
        //               { 1,  12,  13,  14,  15 },
        //               { 1,  -2,  -3,  -4,  -5 },
        //               { 6,   7,  8,    9,   0 }},
        //                new int[,] {
        //               { 2,   3,   4,   5,  -1 },
        //               { 7,   8,   9,  10,  -2 },
        //               { 2,  13,  14,  15,  -3 },
        //               { 2,  -3,  -4,  -5,  -1 },
        //               { 7,   8,   9,   0,  -2 }});

        //program.Task_2_14(new int[,] {
        //    { 1, 2, 3, 4 },
        //    { 5, 5, 4, 6 },
        //    { 5, -5, 5, -5 },
        //    { 6, 7, 8, 9 },
        //    { -6, -5, -8, 0 },
        //    { 11, 12, 13, 14 },
        //    { 6, 5, 8, 0 }}); 

        //program.Task_2_16(new int[] { 1, 8, -3, 5, 5, 1, 0, 4 }, 
        //                  new int[] { 1, -8, -3, 5, -5, 1, 0, -4, -1, 2 });

        //program.Task_2_18(new int[,] {
        //                { 1,   2,   3,   4,   5 },
        //                { 6,   7,   8,   9,  10 },
        //                { 1,  12,  13,  14,  15 },
        //                { 1,  -2,  -3,  -4,  -5 },
        //                { 6,   7,  8,    9,   0 }},
        //                new int[,] {
        //                { 1,  2,  3,  4,  5,  -1 },
        //                { 6,  7,  8,  9,  10, -2 },
        //                { 11, 12, 13, 14, 15, -3 },
        //                { -1, -2, -3, -4, -5, -1 },
        //                { 6,  7,  8,  9,  20, -2 },
        //                { 1,  3,  3,  1,  5,   5 }});

        //int[,] A = new int[,] {
        //    { 1, 2, 3, 4 },
        //    { 5, 5, 4, 6 },
        //    { 5, -5, 5, -5 },
        //    { 6, 7, 8, 9 },
        //    { -6, -5, -8, 0 },
        //    { 11, 12, 13, 14 },
        //    { 6, 5, 8, 0 }};
        //int[,] B = new int[,] {
        //    { 1, 2, 3, 4, 5 },
        //    { 6, 7, 8, 9, 10 },
        //    { 11, 12, 13, 14, 15 },
        //    { -1, -2, -3, -4, -5 },
        //    { 0, 1, 0, 2, 0 },
        //    { 6, 7, 8, 9, 0 }};
        //program.Task_2_20(ref A, ref B);

        //int[] rows, cols;
        //program.Task_2_22(new int[,] {
        //    { 1,  2,  3,  4,  5,  -1 },
        //    { 6,  7,  8,  9,  10, -2 },
        //    { 11, 12, 13, 14, 15, -3 },
        //    { -1, -2, -3, -4, -5, -1 },
        //    { 6,  7,  8,  9,  20, -2 },
        //    { 1,  3,  3,  1,  5,   5 }},
        //    out rows, out cols);

        //program.Task_2_24(new int[,] {
        //                { 1,  2,  3,  4,  5 },
        //                { 6,  7,  8,  9,  10 },
        //                { 11, 12, 13, 14, 15 },
        //                { -1, -2, -3, -4, -5 },
        //                { 6,  7,  8,  9,  0 }},
        //                new int[,] {
        //                { 1,  2,  3,  4,  5,  -1 },
        //                { 6,  7,  8,  9,  10, -2 },
        //                { 11, 12, 13, 14, 15, -3 },
        //                { -1, -2, -3, -4, -5, -1 },
        //                { 6,  7,  8,  9,  20, -2 },
        //                { 1,  3,  3,  1,  5,   5 }});

        //program.Task_2_26(new int[,] {
        //                { -1, 1,  2,  3,  4,  5 },
        //                { -1, 6,  7,  8,  9,  10 },
        //                { -1, 11, 12, 13, 14, 15 },
        //                { -1, -1, -2, -3, -4, -5 },
        //                { 6,  7,  8,  9,  20, -2 },
        //                { -1, 6,  7,  8,  9,  0 }},
        //                new int[,] {
        //                { 1,  2,  3,  4,  5,  -1 },
        //                { 6,  7,  8,  9,  10, -2 },
        //                { 11, 12, 13, 14, 15, -3 },
        //                { -1, -2, -3, -4, -5, -1 },
        //                { 6,  7,  8,  9,  20, -2 },
        //                { 1,  3,  3,  1,  5,   5 }});

        //int answerFirst = 0;
        //int answerSecond = 0;
        //program.Task_2_28a(new int[] { -3, 5, 5, 1, 0, 4 }, new int[] { 13, 10, 1, 0, -2, -4 },
        //                   ref answerFirst, ref answerSecond);
        //int[,] answerFirst = null;
        //int[,] answerSecond = null;
        //program.Task_2_28b(new int[] { -3, 5, 5, 1, 0, 4 }, new int[] { 13, 10, 1, 0, -2, -4 },
        //                   ref answerFirst, ref answerSecond);
        //int[] answerFirst = null;
        //int[] answerSecond = null;
        //program.Task_2_28c(new int[] { -3, 5, 5, 1, 0, 4 }, new int[] { 13, 10, 1, 0, -2, -4 },
        //                   ref answerFirst, ref answerSecond);

        //program.Task_3_2(new int[,] {
        //    { 1, 2, 3, 4, 5, -1 },
        //    { 6, 7, 8, 9, 10, -2 },
        //    { 11, 12, 13, 14, 15, -3 },
        //    { -1, -2, -3, -4, -5, -1 },
        //    { 6, 7, 8, 9, 0, -2 }});

        //program.Task_3_4(new int[,] {
        //    { 1,  2,  3,  4,  5,  -1 },
        //    { 6,  7,  8,  9,  10, -2 },
        //    { 11, 12, 13, 14, 15, -3 },
        //    { -1, -2, -3, -4, -5, -1 },
        //    { 6,  7,  8,  9,  20, -2 },
        //    { 1,  3,  3,  1,  5,   5 }}, true);

        //program.Task_3_6(new int[,] {
        //    { 1, 2, 3, 4, 5 },
        //    { 6, 7, 8, 9, 10 },
        //    { 11, 12, 13, 14, 15 },
        //    { -1, -2, -3, -4, -5 },
        //    { 6, 7, 8, 9, 0 }});

        //int[,] B = new int[,] {
        //    { 1, 2, 3, 4, 5 },
        //    { 6, 7, 8, 9, 10 },
        //    { -11, 12, 13, 14, -15 },
        //    { 6, 7, 8, 9, 0 }};
        //program.Task_3_7(ref B,
        //    new int[,] {
        //    { 1, 2, 3, 4, 5, -1 },
        //    { 6, 7, 8, 9, 10, -2 },
        //    { 11, 12, 13, 14, 15, -3 },
        //    { -1, -2, -3, -4, -5, -1 },
        //    { 6, 7, 8, 9, 0, -2 }});

        //int[,] matrix = new int[,] {
        //    { 1, 2, 3, 4, 5 },
        //    { 6, 7, 8, 9, 10 },
        //    { 11, 12, 13, 14, 15 },
        //    { -1, -2, -3, -4, -5 },
        //    { 6, 7, 8, 9, 0 }};
        //program.Task_3_10(ref matrix);

        //int[,] matrix = new int[,] {
        //    { 1, 2, 3, 4, 5 },
        //    { 6, 7, 8, 9, 10 },
        //    { 11, 12, 13, 14, 15 },
        //    { -1, -2, -3, -4, -5 },
        //    { 6, 7, 8, 9, 0 }};
        //program.Task_3_13(ref matrix);

        //int[] rows, cols;
        //program.Task_3_22(new int[,] {
        //    { 1,  2,  3,  4,  5,  -1 },
        //    { 6,  7,  8,  9,  10, -2 },
        //    { 11, 12, 13, 14, 15, -3 },
        //    { -1, -2, -3, -4, -5, -1 },
        //    { 6,  7,  8,  9,  20, -2 },
        //    { 1,  3,  3,  1,  5,   5 }},
        //    out rows, out cols);

        //program.Task_3_27(new int[,] {
        //                { 1, 2, 3, 4, 5 },
        //                { 6, 7, 8, 9, 10 },
        //                { 11, 12, 13, 14, 15 },
        //                { -1, -2, -3, -4, -5 },
        //                { 6, 7, 8, 9, 0 }},
        //                new int[,] {
        //                { 1,  2,  3,  4,  5,  -1 },
        //                { 6,  7,  8,  9,  10, -2 },
        //                { 11, 12, 13, 14, 15, -3 },
        //                { -1, -2, -3, -4, -5, -1 },
        //                { 6,  7,  8,  9,  20, -2 },
        //                { 1,  3,  3,  1,  5,   5 }});
        //program.Task_4(new double[,] {
        //    {5, 1, 2, 1},
        //    {1, 6, 2, 3},
        //    {2, 2, 7, 2},
        //    {1, 3, 2, 8}}, 0);

    }
    #region Level 1
    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here
        // create and use Combinations(n, k);
        // create and use Factorial(n);

        if (n < 0 || k < 0)
        {
            Console.WriteLine("Error");
            return 0;
        }

        answer = Combinations(n, k);

        static int Combinations(int n, int k)
        {
            int otvet = Factorial(n) / Factorial(k) / Factorial(n - k);
            return otvet;
        }
        static int Factorial(int f)
        {
            int a = 1;
            for (; f > 1; f--)
            {
                a *= f;
            }
            return a;
        }
        Console.WriteLine(answer + " combinations");

        // end

        return answer;
    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here
        // create and use GeronArea(a, b, c);

        if (first.Length != 3 || second.Length != 3)
        {
            Console.WriteLine("Error");
            return -1;
        }
        bool isExist = (first[0] + first[1] <= first[2]) || (first[0] + first[2] <= first[1]) || (first[1] + first[2] <= first[0]);
        if (isExist)
        {
            Console.WriteLine("Error");
            return -1;

        }
        isExist = (second[0] + second[1] <= second[2]) || (second[0] + second[2] <= second[1]) || (second[1] + second[2] <= second[0]);
        if (isExist)
        {
            Console.WriteLine("Error");
            return -1;
        }

        double Plosch1 = GeronArea(first[0], first[1], first[2]);
        double Plosch2 = GeronArea(second[0], second[1], second[2]);

        double GeronArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return result;
        }

        if (Plosch1 > Plosch2)
        {
            answer = 1;
            Console.WriteLine("First triangle > Second triangle");
        }
        else if (Plosch1 < Plosch2)
        {
            answer = 2;
            Console.WriteLine("First triangle < Second triangle");
        }
        else if (Plosch1 == Plosch2)
        {
            answer = 0;
            Console.WriteLine("First triangle = Second triangle");
        }

        // end
        // first = 1, second = 2, equal = 0, error = -1

        return answer;
    }

    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here
        // create and use GetDistance(v, a, t); t - hours

        double distance1 = GetDistance(v1, a1, time);
        double distance2 = GetDistance(v2, a2, time);

        double GetDistance(double v, double a, int t)
        {
            double distance = v * t + a * t * t / 2;
            return distance;
        }

        if (distance1 > distance2)
        {
            Console.WriteLine("First one");
            answer = 1;
        }
        else if (distance2 > distance1)
        {
            Console.WriteLine("First one");
            answer = 2;
        }
        else if (distance2 == distance1)
        {
            Console.WriteLine("Both drove the same");
        }

        // end
        // first = 1, second = 2, equal = 0

        return answer;
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 1;

        // code here
        // use GetDistance(v, a, t); t - hours

        if (v2 < v1 && a2 < a1) { return 0; }
        else if (v2 >= v1) { return 1; }

        double distance1 = 1;
        double distance2 = 0;

        double GetDistance(double v, double a, int t)
        {
            double distance = v * t + a * t * t / 2;
            return distance;
        }

        for (; distance1 > distance2; answer++)
        {
            distance1 = GetDistance(v1, a1, answer);
            distance2 = GetDistance(v2, a2, answer);
        }
        answer -= 1;
        Console.WriteLine("Через " + answer + " час(а/ов)");

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public void Task_2_1(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxIndex(matrix, out row, out column);

        // end
    }

    public void Task_2_2(double[] A, double[] B)
    {
        // code here
        // create and use FindMaxIndex(array);
        // only 1 array has to be changed!

        static int FindMaxIndex(double[] array)
        {
            int indexmax = 0;
            double elemax = -999;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (elemax <= array[i])
                {
                    elemax = array[i];
                    indexmax = i;
                }
            }
            return indexmax;
        }

        static void Replace(double[] ar, int mesto)
        {
            double sredArifm = 0, kolvo = 0;
            double elemax = ar[mesto];
            for (int i = mesto + 1; i < ar.Length; i++)
            {
                sredArifm += ar[i];
                kolvo++;
            }
            sredArifm /= kolvo;

            for (int i = mesto; i < ar.Length; i++)
            {
                if (ar[i] == elemax)
                {
                    ar[i] = sredArifm;
                }
            }
        }

        int mestoEleMaxA = FindMaxIndex(A);
        int mestoEleMaxB = FindMaxIndex(B);

        if (mestoEleMaxA < mestoEleMaxB)
        {
            Replace(A, mestoEleMaxA);
        }
        else if (mestoEleMaxA > mestoEleMaxB)
        {
            Replace(B, mestoEleMaxB);
        }

        Console.Write("A: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
        Console.Write("B: ");
        for (int i = 0; i < B.Length; i++)
        {
            Console.Write(B[i] + " ");
        }
        Console.WriteLine();

        // end
    }

    public void Task_2_3(ref int[,] B, ref int[,] C)
    {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix);

        // end
    }

    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here
        //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3

        if (A.GetLength(0) != 5 || A.GetLength(1) != 5) { return; }
        if (B.GetLength(0) != 5 || B.GetLength(1) != 5) { return; }

        static void FindDiagonalMaxIndex(int[,] matrix, out int indmax, out int jndmax)
        {
            int elemax = -999;
            indmax = -1;
            jndmax = -1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j && elemax < matrix[i, j])
                    {
                        elemax = matrix[i, j];
                        indmax = i;
                        jndmax = j;
                    }
                }
            }
        }

        int iMaxA, jMaxA, iMaxB, jMaxB;

        FindDiagonalMaxIndex(A, out iMaxA, out jMaxA);
        FindDiagonalMaxIndex(B, out iMaxB, out jMaxB);

        for (int j = 0, i = 0; i < 5; j++, i++)
        {
            int reserv = A[iMaxA, j];
            A[iMaxA, j] = B[i, jMaxB];
            B[i, jMaxB] = reserv;
        }

        Console.WriteLine("First: ");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Second: ");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // end
    }

    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxInColumn(matrix, columnIndex, out rowIndex);

        // end
    }

    public void Task_2_6(ref int[] A, int[] B)
    {
        // code here
        // create and use FindMax(matrix, out row, out column); like in Task_2_1
        // create and use DeleteElement(array, index);

        static void FindMax(int[] array, out int place)
        {
            place = -1;
            int elemax = -999;
            for (int i = 0; i < array.Length; i++)
            {
                if (elemax < array[i])
                {
                    elemax = array[i];
                    place = i;
                }
            }
        }
        static int[] DeleteElement(int[] array, int index)
        {
            int[] ar = new int[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    ar[j] = array[i];
                    j++;
                }
            }
            return ar;
        }

        int placeInA, placeInB;
        FindMax(A, out placeInA);
        FindMax(B, out placeInB);
        A = DeleteElement(A, placeInA);
        B = DeleteElement(B, placeInB);

        int[] a = new int[A.Length + B.Length];
        for (int i = 0; i < A.Length; i++)
        {
            a[i] = A[i];
        }
        for (int i = A.Length, j = 0; i < a.Length && j < B.Length; i++, j++)
        {
            a[i] = B[j];
        }
        A = a;

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();

        // end
    }

    public void Task_2_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);

        // end
    }

    public void Task_2_8(int[] A, int[] B)
    {
        // code here
        // create and use SortArrayPart(array, startIndex);

        static void FindMax(int[] array, out int place)
        {
            place = -1;
            int elemax = -999;
            for (int i = 0; i < array.Length; i++)
            {
                if (elemax < array[i])
                {
                    elemax = array[i];
                    place = i;
                }
            }
        }
        static void SortArrayPart(int[] array, int startIndex)
        {
            for (int i = (startIndex + 2); i < array.Length; i++)
            {
                int current = array[i], j = i - 1;
                while (j >= (startIndex + 1) && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
            }
        }

        int indmaxA, indmaxB;
        FindMax(A, out indmaxA);
        FindMax(B, out indmaxB);
        SortArrayPart(A, indmaxA);
        SortArrayPart(B, indmaxB);

        Console.Write("A: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
        Console.Write("B: ");
        for (int i = 0; i < B.Length; i++)
        {
            Console.Write(B[i] + " ");
        }
        Console.WriteLine();

        // end
    }

    public int[] Task_2_9(int[,] A, int[,] C)
    {
        int[] answer = default(int[]);

        // code here

        // create and use SumPositiveElementsInColumns(matrix);

        // end

        return answer;
    }

    public void Task_2_10(ref int[,] matrix)
    {
        // code here
        // create and use RemoveColumn(matrix, columnIndex);

        int strok = matrix.GetLength(0), stolb = matrix.GetLength(1);
        int elemax = -999, jndmax = 0, elemin = 999, jndmin = 0;

        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (i >= j && elemax < matrix[i, j])
                {
                    elemax = matrix[i, j];
                    jndmax = j;
                }
                if (i < j && elemin > matrix[i, j])
                {
                    elemin = matrix[i, j];
                    jndmin = j;
                }
            }
        }

        static int[,] RemoveColumn(int[,] matrix, int columnIndex)
        {
            int strok = matrix.GetLength(0), stolb = matrix.GetLength(1);
            int[,] newmatrix = new int[strok, stolb - 1];
            int jj = 0;
            for (int j = 0; j < stolb; j++, jj++)
            {
                for (int i = 0; i < strok; i++)
                {
                    if (j != columnIndex)
                    {
                        newmatrix[i, jj] = matrix[i, j];
                    }
                    else { jj--; break; }
                }
            }
            return newmatrix;
        }

        if (jndmax < jndmin)
        {
            matrix = RemoveColumn(matrix, jndmax);
            matrix = RemoveColumn(matrix, jndmin - 1);
        }
        else if (jndmax > jndmin)
        {
            matrix = RemoveColumn(matrix, jndmin);
            matrix = RemoveColumn(matrix, jndmax - 1);
        }
        else if (jndmax == jndmin)
        {
            matrix = RemoveColumn(matrix, jndmax);
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // end
    }

    public void Task_2_11(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); from Task_2_1

        // end
    }

    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here
        // create and use FindMaxColumnIndex(matrix);

        if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1)) 
        {
            Console.WriteLine("Error");
            return;
        }

        static int FindMaxColumnIndex(int[,] matrix)
        {
            int elemax = -999, jmax = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (elemax < matrix[i, j])
                    {
                        elemax = matrix[i, j];
                        jmax = j;
                    }
                }
            }            
            return jmax;
        }

        int jmaxA = FindMaxColumnIndex(A);
        int jmaxB = FindMaxColumnIndex(B);

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int reserv = A[i, jmaxA];
            A[i, jmaxA] = B[i, jmaxB];
            B[i, jmaxB] = reserv;
        }

        Console.WriteLine("First: ");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Second: ");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // end
    }

    public void Task_2_13(ref int[,] matrix)
    {
        // code here

        // create and use RemoveRow(matrix, rowIndex);

        // end
    }

    public void Task_2_14(int[,] matrix)
    {
        // code here
        // create and use SortRow(matrix, rowIndex);

        static void SortRow(int[,] matrix, int rowIndex)
        {
            int[] ar = new int[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                ar[j] = matrix[rowIndex, j];
            }
            for (int i = 1; i < ar.Length; i++)
            {
                int current = ar[i], j = i - 1;
                while (j >= 0 && ar[j] > current)
                {
                    ar[j + 1] = ar[j]; 
                    j--;
                }
                ar[j + 1] = current;
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[rowIndex, j] = ar[j];
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            SortRow(matrix, i);
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // end
    }

    public int Task_2_15(int[,] A, int[,] B, int[,] C)
    {
        int answer = 0;

        // code here

        // create and use GetAverageWithoutMinMax(matrix);

        // end

        // 1 - increasing   0 - no sequence   -1 - decreasing
        return answer;
    }

    public void Task_2_16(int[] A, int[] B)
    {
        // code here
        // create and use SortNegative(array);

        static void SortNegative(int[] array)
        {
            int kolvoNegative = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    kolvoNegative++;
            }
            if (kolvoNegative <= 1) { return; }
            int[] a = new int[kolvoNegative];
            for (int i = 0, k = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    a[k] = array[i];
                    k++;
                }
            }            
            for (int i = 1; i < a.Length; i++)
            {
                int current = a[i], j = i - 1;
                while (j >= 0 && a[j] < current)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = current;
            }
            for (int i = 0, k = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = a[k];
                    k++;
                }
            }            
        }

        SortNegative(A);
        SortNegative(B);

        Console.WriteLine("First: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Second: ");
        for (int i = 0; i < B.Length; i++)
        {
            Console.Write(B[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        // end
    }

    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here

        // create and use SortRowsByMaxElement(matrix);

        // end
    }

    public void Task_2_18(int[,] A, int[,] B)
    {
        // code here
        // create and use SortDiagonal(matrix);

        static void SortDiagonal(int[,] matrix)
        {
            int kolvoEleDiag = 0, strok = matrix.GetLength(0), stolb = matrix.GetLength(1);
            for (int i = 0; i < strok; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (i == j)
                        kolvoEleDiag++;
                }
            }
            if (kolvoEleDiag <= 1) { return; }
            int[] a = new int[kolvoEleDiag];
            for (int i = 0, k = 0; i < strok; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (i == j)
                    {
                        a[k] = matrix[i, j];
                        k++;
                    }
                }
            }
            for (int i = 1; i < a.Length; i++)
            {
                int current = a[i], j = i - 1;
                while (j >= 0 && a[j] > current)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = current;
            }
            for (int i = 0, k = 0; i < strok; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = a[k];
                        k++;
                    }
                }
            }
        }

        SortDiagonal(A);
        SortDiagonal(B);

        Console.WriteLine("First: ");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Second: ");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // end
    }

    public void Task_2_19(ref int[,] matrix)
    {
        // code here

        // use RemoveRow(matrix, rowIndex); from 2_13

        // end
    }

    public void Task_2_20(ref int[,] A, ref int[,] B)
    {
        // code here
        // use RemoveColumn(matrix, columnIndex); from 2_10

        static int[,] RemoveColumn(int[,] matrix, int columnIndex)
        {
            int strok = matrix.GetLength(0), stolb = matrix.GetLength(1);
            int[,] newmatrix = new int[strok, stolb - 1];
            int jj = 0;
            for (int j = 0; j < stolb; j++, jj++)
            {
                for (int i = 0; i < strok; i++)
                {
                    if (j != columnIndex)
                    {
                        newmatrix[i, jj] = matrix[i, j];
                    }
                    else { jj--; break; }
                }
            }
            return newmatrix;
        }

        for (int j = A.GetLength(1) - 1; j >= 0; j--)
        {
            string kolvo0 = "no";
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == 0)
                {
                    kolvo0 = "yes";
                    break;
                }
            }
            if (kolvo0 == "no")
            {
                A = RemoveColumn(A, j);
            }
        }
        for (int j = B.GetLength(1) - 1; j >= 0; j--)
        {
            string kolvo0 = "no";
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (B[i, j] == 0)
                {
                    kolvo0 = "yes";
                    break;
                }
            }
            if (kolvo0 == "no")
            {
                B = RemoveColumn(B, j);
            }

        }

        Console.WriteLine("First: ");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Second: ");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }

        // end
    }

    public void Task_2_21(int[,] A, int[,] B, out int[] answerA, out int[] answerB)
    {
        answerA = null;
        answerB = null;

        // code here

        // create and use CreateArrayFromMins(matrix);

        // end
    }

    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;

        // code here
        // create and use CountNegativeInRow(matrix, rowIndex);
        // create and use FindMaxNegativePerColumn(matrix);

        static int CountNegativeInRow(int[,] matrix, int rowIndex)
        {
            int kolvoOtriz = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[rowIndex, j] < 0)
                {
                    kolvoOtriz++;
                }
            }
            return kolvoOtriz;
        }
        static int[] FindMaxNegativePerColumn(int[,] matrix)
        {            
            int[] elements = new int[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int elemaxOtriz = -999;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0 && elemaxOtriz < matrix[i, j])
                    {
                        elemaxOtriz = matrix[i, j];
                    }
                }
                if (elemaxOtriz != -999) { elements[j] = elemaxOtriz; }                    
                else { elements[j] = 0; }
            }
            return elements;
        }

        rows = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            rows[i] = CountNegativeInRow(matrix, i);
        }
        
        cols = FindMaxNegativePerColumn(matrix);
        
        Console.Write("rows: ");
        for (int i = 0; i < rows.Length; i++)
        {
            Console.Write(rows[i] + " ");
        }
        Console.WriteLine();
        Console.Write("cols: ");
        for (int i = 0; i < cols.Length; i++)
        {
            Console.Write(cols[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        // end
    }

    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here

        // create and use MatrixValuesChange(matrix);

        // end
    }

    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here
        // use FindMaxIndex(matrix, out row, out column); like in 2_1
        // create and use SwapColumnDiagonal(matrix, columnIndex);

        if (A.GetLength(0) != A.GetLength(1) || B.GetLength(0) != B.GetLength(1))
        {
            Console.WriteLine("Error");
            return;
        }
        
        static void FindMaxIndex(int[,] matrix, out int row, out int column)
        {
            row = 0; column = 0;
            int elemax = -999;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > elemax)
                    {
                        elemax = matrix[i, j];
                        row = i; 
                        column = j; 
                    }
                }
            }
        }
        static int[,] SwapColumnDiagonal(int[,] matrix, int columnIndex)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int reserv = matrix[i, i];
                matrix[i, i] = matrix[i, columnIndex];
                matrix[i, columnIndex] = reserv;
            }
            return matrix;
        }

        int imaxA, jmaxA, imaxB, jmaxB;
        FindMaxIndex(A, out imaxA, out jmaxA);
        FindMaxIndex(B, out imaxB, out jmaxB);

        A = SwapColumnDiagonal(A, jmaxA);
        B = SwapColumnDiagonal(B, jmaxB);

        Console.WriteLine("First: ");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Second: ");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }

        // end
    }

    public void Task_2_25(int[,] A, int[,] B, out int maxA, out int maxB)
    {
        maxA = 0;
        maxB = 0;

        // code here

        // create and use FindRowWithMaxNegativeCount(matrix);
        // in FindRowWithMaxNegativeCount create and use CountNegativeInRow(matrix, rowIndex); like in 2_22

        // end
    }

    public void Task_2_26(int[,] A, int[,] B)
    {
        // code here
        // create and use FindRowWithMaxNegativeCount(matrix); like in 2_25
        // in FindRowWithMaxNegativeCount use CountNegativeInRow(matrix, rowIndex); from 2_22
        //В двух заданных матрицах одинакового размера поменять строки, содержащие
        //максимальное количество отрицательных элементов. Нахождение количества
        //отрицательных элементов заданной строки матрицы осуществлять в методе.
        //Определение номера строки, содержащей максимальное количество отрицательных
        //элементов, осуществлять в методе.

        if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
        {
            Console.WriteLine("Error");
            return;
        }

        static int CountNegativeInRow(int[,] matrix, int rowIndex)
        {
            int kolvoOtriz = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[rowIndex, j] < 0)
                {
                    kolvoOtriz++;
                }
            }
            return kolvoOtriz;
        }
        static int FindRowWithMaxNegativeCount(int[,] matrix)
        {
            int stroka = 0, kolvomax = -999;
            int[] rows = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                rows[i] = CountNegativeInRow(matrix, i);
            }
            for (int e = 0; e < rows.Length; e++)
            {
                if (rows[e] > kolvomax)
                {
                    kolvomax = rows[e];
                    stroka = e;
                }
            }
            return stroka;
        }

        int iA = FindRowWithMaxNegativeCount(A);
        int iB = FindRowWithMaxNegativeCount(B);

        for (int j = 0; j < A.GetLength(0); j++)
        {
            int reserv = A[iA, j];
            A[iA, j] = B[iB, j];
            B[iB, j] = reserv;
        }

        Console.WriteLine("First: ");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Second: ");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }

        // end
    }

    public void Task_2_27(int[,] A, int[,] B)
    {
        // code here

        // create and use FindRowMaxIndex(matrix, rowIndex, out columnIndex);
        // create and use ReplaceMaxElementOdd(matrix, row, column);
        // create and use ReplaceMaxElementEven(matrix, row, column);

        // end
    }

    static int FindSequence(int[] array, int A, int B)
    {
        if (array[B] >= array[A])
        {
            int count = 0;
            for (int i = A + 1; i <= B; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return 0;
                }
                else if (array[i - 1] <= array[i])
                {
                    count++;
                }
            }
            if (count == (B - A)) 
            {
                return 1;
            }
        }
        else if (array[B] < array[A])
        {
            int count = 0;
            for (int i = A + 1; i <= B; i++)
            {
                if (array[i - 1] < array[i])
                {
                    return 0;
                }
                else if (array[i - 1] >= array[i])
                {
                    count++;
                }
            }
            if (count == (B - A))
            {
                return -1;
            }
        }
        return 0;
    }
    public void Task_2_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here
        // create and use FindSequence(array, A, B); // 1 - increasing, 0 - no sequence, -1 - decreasing
        // A and B - start and end indexes of elements from array for search        

        answerFirst = FindSequence(first, 0, first.Length - 1);
        answerSecond = FindSequence(second, 0, second.Length - 1);

        Console.WriteLine(answerFirst + " " + answerSecond);

        // end
    }

    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here
        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a
        // A and B - start and end indexes of elements from array for search

        int kolvo = 0;
        for (int i = 0; i < first.Length - 1; i++)
        {
            for (int j = i + 1; j < first.Length; j++)
            {
                int a = FindSequence(first, i, j);
                if (a == 1 || a == -1) { kolvo++; }
                else if (a == 0) { break; }
            }            
        }
        answerFirst = new int[kolvo, 2];
        kolvo = 0;
        for (int i = 0; i < second.Length - 1; i++)
        {
            for (int j = i + 1; j < second.Length; j++)
            {
                int a = FindSequence(second, i, j);
                if (a == 1 || a == -1) { kolvo++; }
                else if (a == 0) { break; }
            }
        }
        answerSecond = new int[kolvo, 2];

        int index = 0;
        for (int i = 0; i < first.Length - 1; i++)
        {
            for (int j = i + 1; j < first.Length; j++)
            {
                int a = FindSequence(first, i, j);
                if (a == 1 || a == -1) 
                {
                    answerFirst[index, 0] = i;
                    answerFirst[index, 1] = j;
                    index++;
                }
                else if (a == 0) { break; }
            }
        }
        index = 0;
        for (int i = 0; i < second.Length - 1; i++)
        {
            for (int j = i + 1; j < second.Length; j++)
            {
                int a = FindSequence(second, i, j);
                if (a == 1 || a == -1) 
                {
                    answerSecond[index, 0] = i;
                    answerSecond[index, 1] = j;
                    index++;
                }
                else if (a == 0) { break; }
            }
        }

        Console.WriteLine("28(b):");
        Console.WriteLine("First: ");
        for (int i = 0; i < answerFirst.GetLength(0); i++)
        {
            for (int j = 0; j < answerFirst.GetLength(1); j++)
            {
                Console.Write(answerFirst[i, j] + " ");
            }
            Console.Write("), (");
        }
        Console.WriteLine();
        Console.WriteLine("Second: ");
        for (int i = 0; i < answerSecond.GetLength(0); i++)
        {
            for (int j = 0; j < answerSecond.GetLength(1); j++)
            {
                Console.Write(answerSecond[i, j] + " ");
            }
            Console.Write("), (");
        }
        Console.WriteLine();
        Console.WriteLine();

        // end
    }

    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here
        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
        // A and B - start and end indexes of elements from array for search

        int[,] matrixF = null;
        int[,] matrixS = null;

        Task_2_28b(first, second, ref matrixF, ref matrixS);

        int elemax = -999;
        for (int i = 0; i < matrixF.GetLength(0); i++)
        {
            if (elemax < matrixF[i, 1] - matrixF[i, 0])
            {
                elemax = matrixF[i, 1] - matrixF[i, 0];
                answerFirst = new int[] { matrixF[i, 0], matrixF[i, 1] };
            }
        }
        elemax = -999;
        for (int i = 0; i < matrixS.GetLength(0); i++)
        {
            if (elemax < matrixS[i, 1] - matrixS[i, 0])
            {
                elemax = matrixS[i, 1] - matrixS[i, 0];
                answerSecond = new int[] { matrixS[i, 0], matrixS[i, 1] };
            }
        }

        Console.WriteLine("28(c):");
        Console.WriteLine("First: ");
        for (int i = 0; i < answerFirst.GetLength(0); i++)
        {
            Console.Write(answerFirst[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Second: ");
        for (int i = 0; i < answerSecond.GetLength(0); i++)
        {
            Console.Write(answerSecond[i] + " ");
        }
        Console.WriteLine();

        // end
    }
    #endregion

    #region Level 3
    public void Task_3_1(ref double[,] firstSumAndY, ref double[,] secondSumAndY)
    {
        // code here

        // create and use public delegate SumFunction(x) and public delegate YFunction(x)
        // create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        // create and use 2 methods for both functions calculating at specific x

        // end
    }


    delegate void SortRowStyle(ref int[,] matrix, int rowIndex);
    public void Task_3_2(int[,] matrix)
    {
        // code here
        // create and use public delegate SortRowStyle(matrix, rowIndex);
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        // change method in variable sortStyle in the loop here and use it for row sorting

        static void SortAscending(ref int[,] matrix, int rowIndex)
        {
            int[] m = new int[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                m[j] = matrix[rowIndex, j];
            }
            for (int i = 1; i < m.Length; i++)
            {
                int current = m[i], j = i - 1;
                while (j >= 0 && m[j] > current)
                {
                    m[j + 1] = m[j];
                    j--;
                }
                m[j + 1] = current;
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[rowIndex, j] = m[j];
            }
        }
        static void SortDescending(ref int[,] matrix, int rowIndex)
        {
            int[] m = new int[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                m[j] = matrix[rowIndex, j];
            }
            for (int i = 1; i < m.Length; i++)
            {
                int current = m[i], j = i - 1;
                while (j >= 0 && m[j] < current)
                {
                    m[j + 1] = m[j];
                    j--;
                }
                m[j + 1] = current;
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[rowIndex, j] = m[j];
            }
        }

        SortRowStyle sortStyle = default(SortRowStyle);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            { sortStyle = SortAscending; }
            else
            { sortStyle = SortDescending; }

            sortStyle(ref matrix, i);
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();            
        }
        Console.WriteLine();

        // end
    }


    public double Task_3_3(double[] array)
    {
        double answer = 0;
        // SwapDirection swapper = default(SwapDirection); - uncomment me

        // code here

        // create and use public delegate SwapDirection(array);
        // create and use methods SwapRight(array) and SwapLeft(array)
        // create and use method GetSum(array, start, h) that sum elements with a negative indexes
        // change method in variable swapper in the if/else and than use swapper(matrix)

        // end

        return answer;
    }


    delegate int[] GetTriangle(int[,] matrix);
    public int Task_3_4(int[,] matrix, bool isUpperTriangle)
    {
        int answer = 0;
        
        // code here
        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // create and use GetSum(GetTriangle, matrix)

        static int[] GetUpperTriangle(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int dlina = (n * n - n) / 2 + n;
            int[] array = new int[dlina];

            for (int i = 0, k = 0 ; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i <= j)
                    {
                        array[k] = matrix[i, j];
                        k++;
                    }
                }
            }
            return array;
        }
        static int[] GetLowerTriangle(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int dlina = (n * n - n) / 2 + n;
            int[] array = new int[dlina];

            for (int i = 0, k = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j)
                    {
                        array[k] = matrix[i, j];
                        k++;
                    }
                }
            }
            return array;
        }
        int GetSum(GetTriangle treygolnik, int[,] matrix)
        {
            int sum = 0;
            int[] array;
            if (isUpperTriangle) { treygolnik = GetUpperTriangle; }
            else
            { treygolnik = GetLowerTriangle; }
            array = treygolnik(matrix);

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i] * array[i]; 
            }
            return sum;
        }

        GetTriangle treygolnik = default(GetTriangle);
        answer = GetSum(treygolnik, matrix);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // end

        return answer;
    }


    public void Task_3_5(out int func1, out int func2)
    {
        func1 = 0;
        func2 = 0;

        // code here

        // use public delegate YFunction(x, a, b, h) from Task_3_1
        // create and use method CountSignFlips(YFunction, a, b, h);
        // create and use 2 methods for both functions

        // end
    }


    delegate int FindElementDelegate(int[,] matrix);
    public void Task_3_6(int[,] matrix)
    {
        // code here
        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) like in Task_2_3;
        // create and use method FindFirstRowMaxIndex(matrix);
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);

        static int FindDiagonalMaxIndex(int[,] matrix)
        {
            int elemax = -999, indmax = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (elemax < matrix[i, i])
                {
                    elemax = matrix[i, i];
                    indmax = i;
                }
            }            
            return indmax;
        }
        static int FindFirstRowMaxIndex(int[,] matrix)
        {
            int elemax = -999, indmax = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (elemax < matrix[0, j])
                {
                    elemax = matrix[0, j];
                    indmax = j;
                }
            }
            return indmax;
        }
        static int[,] SwapColumns(int[,] matrix, FindElementDelegate find)
        {
            find = FindDiagonalMaxIndex;
            int FindDiagonal = find(matrix);
            find = FindFirstRowMaxIndex;
            int FindFirstRow = find(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int reserv = matrix[i, FindDiagonal];
                matrix[i, FindDiagonal] = matrix[i, FindFirstRow];
                matrix[i, FindFirstRow] = reserv;
            }
            return matrix;
        }

        FindElementDelegate find = default(FindElementDelegate);

        SwapColumns(matrix, find);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // end
    }


    delegate int CountPositive(int[,] matrix, int index);
    public void Task_3_7(ref int[,] B, int[,] C)
    {
        // code here
        // create and use public delegate CountPositive(matrix, index);
        // use CountRowPositive(matrix, rowIndex) from Task_2_7
        // use CountColumnPositive(matrix, colIndex) from Task_2_7
        // create and use method InsertColumn(matrixB, CountRow, matrixC, CountColumn);

        static int CountRowPositive(int[,] matrix, int rowIndex)
        {            
            int kolvo = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[rowIndex, j] > 0) { kolvo++; }
            }                          
            return kolvo;
        }
        static int CountColumnPositive(int[,] matrix, int colIndex)
        {
            int kolvo = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, colIndex] > 0) { kolvo++; }
            }
            return kolvo;
        }
        static void InsertColumn(ref int[,] matrixB, int CountRow, int[,] matrixC, int CountColumn)
        {
            int[,] newmatrix = new int[matrixB.GetLength(0) + 1, matrixB.GetLength(1)];
            for (int i = 0; i < newmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newmatrix.GetLength(1); j++)
                {
                    if (i < (CountRow + 1)) 
                    { 
                        newmatrix[i, j] = matrixB[i, j]; 
                    }
                    else if (i == (CountRow + 1)) 
                    { 
                        newmatrix[i, j] = matrixC[j, CountColumn]; 
                    }
                    else if (i > (CountRow + 1)) 
                    { 
                        newmatrix[i, j] = matrixB[i - 1, j]; 
                    }
                }
            }
            matrixB = newmatrix;
        }

        CountPositive count = CountRowPositive;
        int kolvomaxB = 0, kolvomaxC = 0;
        int indB = 0, indC = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            if (kolvomaxB < count(B, i))
            {
                kolvomaxB = count(B, i);
                indB = i;
            }
        }
        count = CountColumnPositive;
        for (int j = 0; j < C.GetLength(1); j++)
        {
            if (kolvomaxC < count(C, j))
            {
                kolvomaxC = count(C, j);
                indC = j;
            }
        }

        InsertColumn(ref B, indB, C, indC);

        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }

        // end
    }


    delegate int FindIndex(int[,] matrix);
    public void Task_3_10(ref int[,] matrix)
    {
        // code here
        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        // create and use method FindMinAboveDiagonalIndex(matrix);
        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)

        FindIndex searchArea = default(FindIndex);

        if (matrix.GetLength(0) != matrix.GetLength(1)) { Console.WriteLine("Error"); return; }
        
        static int FindMaxBelowDiagonalIndex(int[,] matrix)
        {
            int elemax = -999, jndmax = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i >= j && elemax < matrix[i, j])
                    {
                        elemax = matrix[i, j];
                        jndmax = j;
                    }
                }
            }
            return jndmax;
        }
        static int FindMinAboveDiagonalIndex(int[,] matrix)
        {
            int elemin = 999, jndmin = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j && elemin > matrix[i, j])
                    {
                        elemin = matrix[i, j];
                        jndmin = j;
                    }
                }
            }
            return jndmin;
        }
        static int[,] RemoveColumn(int[,] matrix, int columnIndex)
        {
            int strok = matrix.GetLength(0), stolb = matrix.GetLength(1);
            int[,] newmatrix = new int[strok, stolb - 1];
            int jj = 0;
            for (int j = 0; j < stolb; j++, jj++)
            {
                for (int i = 0; i < strok; i++)
                {
                    if (j != columnIndex)
                    {
                        newmatrix[i, jj] = matrix[i, j];
                    }
                    else { jj--; break; }
                }
            }
            return newmatrix;
        }
        static void RemoveColumns(ref int[,] matrix, FindIndex findMaxBelowDiagonalIndex, FindIndex findMinAboveDiagonalIndex)
        {
            int jndmax = findMaxBelowDiagonalIndex(matrix);
            int jndmin = findMinAboveDiagonalIndex(matrix);
            if (jndmax < jndmin)
            {
                matrix = RemoveColumn(matrix, jndmax);
                matrix = RemoveColumn(matrix, jndmin - 1);
            }
            else if (jndmax > jndmin)
            {
                matrix = RemoveColumn(matrix, jndmin);
                matrix = RemoveColumn(matrix, jndmax - 1);
            }
            else if (jndmax == jndmin)
            {
                matrix = RemoveColumn(matrix, jndmax);
            }
        }

        RemoveColumns(ref matrix, FindMaxBelowDiagonalIndex, FindMinAboveDiagonalIndex);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // end
    }


    public void Task_3_13(ref int[,] matrix)
    {
        // code here
        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)

        FindElementDelegate find = default(FindElementDelegate);

        static int findMax(int[,] matrix)
        {
            int elemax = -999, rowIndex = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > elemax) { elemax = matrix[i, j]; rowIndex = i; }
                }
            }
            return rowIndex;
        }
        static int findMin(int[,] matrix)
        {
            int elemin = 999, rowIndex = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < elemin) { elemin = matrix[i, j]; rowIndex = i; }
                }
            }
            return rowIndex;
        }
        static void RemoveRows(ref int[,] matrix, FindElementDelegate findMax, FindElementDelegate findMin)
        {
            int elemaxRow = findMax(matrix), eleminRow = findMin(matrix);
            int[,] newmatrix = default(int[,]);
            if (elemaxRow != eleminRow) 
            { 
                newmatrix = new int[matrix.GetLength(0) - 2, matrix.GetLength(1)];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (Math.Min(elemaxRow, eleminRow) > i)
                        {
                            newmatrix[i, j] = matrix[i, j];
                        }
                        else if (Math.Min(elemaxRow, eleminRow) < i && Math.Max(elemaxRow, eleminRow) > i)
                        {
                            newmatrix[i - 1, j] = matrix[i, j];
                        }
                        else if (Math.Max(elemaxRow, eleminRow) < i)
                        {
                            newmatrix[i - 2, j] = matrix[i, j];
                        }
                    }
                }

            }
            else if (elemaxRow == eleminRow) 
            { 
                newmatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)]; 
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (elemaxRow > i)
                        {
                            newmatrix[i, j] = matrix[i, j];
                        }
                        else if(elemaxRow < i)
                        {
                            newmatrix[i - 1, j] = matrix[i, j];
                        }
                    }
                }
            }
            matrix = newmatrix;
        }

        RemoveRows(ref matrix, findMax, findMin);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // end
    }


    delegate int[] GetNegativeArray(int[,] matrix);
    public void Task_3_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;

        // code here
        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22
        // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);

        static int[] GetNegativeCountPerRow(int[,] matrix)
        {
            int[] array = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int kolvoOtriz = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        kolvoOtriz++;
                    }
                }
                array[i] = kolvoOtriz;
            }
            return array;
        }
        static int[] GetMaxNegativePerColumn(int[,] matrix)
        {
            int[] elements = new int[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int elemaxOtriz = -999;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0 && elemaxOtriz < matrix[i, j])
                    {
                        elemaxOtriz = matrix[i, j];
                    }
                }
                if (elemaxOtriz != -999) { elements[j] = elemaxOtriz; }
                else { elements[j] = 0; }
            }
            return elements;
        }
        static void FindNegatives(int[,] matrix, GetNegativeArray searcherRows, GetNegativeArray searcherCols, out int[] rows, out int[] cols)
        {
            rows = searcherRows(matrix);
            cols = searcherCols(matrix);
        }

        FindNegatives(matrix, GetNegativeCountPerRow, GetMaxNegativePerColumn, out rows, out cols);

        Console.Write("rows: ");
        for (int i = 0; i < rows.Length; i++)
        {
            Console.Write(rows[i] + " ");
        }
        Console.WriteLine();
        Console.Write("cols: ");
        for (int i = 0; i < cols.Length; i++)
        {
            Console.Write(cols[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        // end
    }


    delegate void ReplaceMaxElement(ref int[,] matrix, int rowIndex, int max);
    public void Task_3_27(int[,] A, int[,] B)
    {
        // code here
        // create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        // use ReplaceMaxElementOdd(matrix, rowIndex, max) from Task_2_27
        // use ReplaceMaxElementEven(matrix, rowIndex, max) from Task_2_27
        // create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);

        static void ReplaceMaxElementOdd(ref int[,] matrix, int rowIndex, int max)
        {            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[rowIndex, j] == max)
                {
                    matrix[rowIndex, j] *= (j+1);
                    break;
                }
            }            
        }
        static void ReplaceMaxElementEven(ref int[,] matrix, int rowIndex, int max)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[rowIndex, j] == max)
                {
                    matrix[rowIndex, j] = 0;
                    break;
                }
            }
        }

        static void EvenOddRowsTransform(ref int[,] matrix, ReplaceMaxElement replaceMaxElementOdd, ReplaceMaxElement replaceMaxElementEven)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int elemax = -999;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (elemax < matrix[i, j]) { elemax = matrix[i, j]; }
                }
                if (i % 2 == 1) { replaceMaxElementEven(ref matrix, i, elemax); }
                if (i % 2 == 0) { replaceMaxElementOdd(ref matrix, i, elemax); }
            }
        }

        EvenOddRowsTransform(ref A, ReplaceMaxElementOdd, ReplaceMaxElementEven);
        EvenOddRowsTransform(ref B, ReplaceMaxElementOdd, ReplaceMaxElementEven);

        Console.WriteLine("First: ");
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Second: ");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }

        // end
    }


    delegate bool IsSequence(int [] array, int left, int right);
    static bool FindDecreasingSequence(int[] array, int A, int B)
    {
        int count = 0;
        for (int i = A + 1; i <= B; i++)
        {
            if (array[i - 1] < array[i])
            {
                return false;
            }
            else if (array[i - 1] >= array[i])
            {
                count++;
            }
        }
        if (count == (B - A))
        {
            return true;
        }
        return false;
    }
    static bool FindIncreasingSequence(int[] array, int A, int B)
    {
        int count = 0;
        for (int i = A + 1; i <= B; i++)
        {
            if (array[i - 1] > array[i])
            {
                return false;
            }
            else if (array[i - 1] <= array[i])
            {
                count++;
            }
        }
        if (count == (B - A))
        {
            return true;
        }
        return false;
    }
    public void Task_3_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here
        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);

        static int DefineSequence(int[] array, IsSequence findIncreasingSequence, IsSequence findDecreasingSequence)
        {
            if (findDecreasingSequence(array, 0, array.Length - 1))
            {
                return -1;
            } 
            else if (findIncreasingSequence(array, 0, array.Length - 1))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        answerFirst = DefineSequence(first, FindIncreasingSequence, FindDecreasingSequence);
        answerSecond = DefineSequence(second, FindIncreasingSequence, FindDecreasingSequence);

        Console.WriteLine(answerFirst + " " + answerSecond);

        // end
    }

    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here
        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);

        static int[] FindLongestSequence(int [] array, IsSequence sequence)
        {
            int[] answer = new int[2];

            int elemax = -999;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (sequence(array, i, j) && (j - i) > elemax)
                    {
                        elemax = j - i;
                        answer = new int[2] { i, j };
                    }
                }
            }
            return answer;
        }

        answerFirstIncrease = FindLongestSequence(first, FindIncreasingSequence);
        answerFirstDecrease = FindLongestSequence(first, FindDecreasingSequence);
        answerSecondIncrease = FindLongestSequence(second, FindIncreasingSequence);
        answerSecondDecrease = FindLongestSequence(second, FindDecreasingSequence);

        Console.WriteLine("FirstIncrease: ");
        for (int i = 0; i < answerFirstIncrease.GetLength(0); i++)
        {
            Console.Write(answerFirstIncrease[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("FirstDecrease: ");
        for (int i = 0; i < answerFirstDecrease.GetLength(0); i++)
        {
            Console.Write(answerFirstDecrease[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("SecondIncrease: ");
        for (int i = 0; i < answerSecondIncrease.GetLength(0); i++)
        {
            Console.Write(answerSecondIncrease[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("SecondDecrease: ");
        for (int i = 0; i < answerSecondDecrease.GetLength(0); i++)
        {
            Console.Write(answerSecondDecrease[i] + " ");
        }
        Console.WriteLine();

        // end
    }
    #endregion

    #region bonus part
    static double[,] ElementaryTransform(double[,] matrix, int indexAddedLine, int indexToAddLine, double coefficient)
    {
        double[] array = new double[matrix.GetLength(0)];
        double[,] newmatrix = matrix;
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {
            array[j] = newmatrix[indexAddedLine, j];
        }
        for (int j = 0; j < array.Length; j++)
        {
            array[j] = (array[j] * coefficient);
        }
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {
            newmatrix[indexToAddLine, j] = Math.Round(newmatrix[indexToAddLine, j] + array[j], 8);
        }
        return newmatrix;
    }

    delegate double[,] MatrixConverter(double[,] matrix);
    public double[,] Task_4(double[,] matrix, int index)
    {
        MatrixConverter[] mc = new MatrixConverter[4];

        // code here
        // create public delegate MatrixConverter(matrix);
        // create and use method ToUpperTriangular(matrix);
        // create and use method ToLowerTriangular(matrix);
        // create and use method ToLeftDiagonal(matrix); - start from the left top angle
        // create and use method ToRightDiagonal(matrix); - start from the right bottom angle

        mc[0] = ToUpperTriangular;
        mc[1] = ToLowerTriangularr;
        mc[2] = ToLeftDiagonal;
        mc[3] = ToRightDiagonal;

        static double[,] ToUpperTriangular(double[,] matrix)
        {
            double[,] newmatrix = matrix;
            for (int j = 0; j < newmatrix.GetLength(1); j++)
            {
                for (int i = j + 1; i < newmatrix.GetLength(0); i++)
                {
                    if (newmatrix[j, j] != 0)
                    {
                        newmatrix = ElementaryTransform(newmatrix, j, i, (-1) * newmatrix[i, j] / newmatrix[j, j]);
                    }
                }
            }
            for (int i = 0; i < newmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newmatrix.GetLength(1); j++)
                {
                    Console.Write(newmatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return newmatrix;
        }

        static double[,] ToLowerTriangularr(double[,] matrix)
        {
            double[,] newmatrix = matrix;
            for (int j = newmatrix.GetLength(1) - 1; j >= 0; j--)
            {
                for (int i = j - 1; i >= 0; i--)
                {
                    if (newmatrix[j, j] != 0)
                    {
                        newmatrix = ElementaryTransform(newmatrix, j, i, (-1) * newmatrix[i, j] / newmatrix[j, j]);
                    }
                }
            }
            for (int i = 0; i < newmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newmatrix.GetLength(1); j++)
                {
                    Console.Write(newmatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return newmatrix;
        }

        static double[,] ToLeftDiagonal(double[,] matrix) 
        {
            double[,] newmatrix = matrix;
            newmatrix = ToUpperTriangular(matrix);
            newmatrix = ToLowerTriangularr(matrix);
            for (int i = 0; i < newmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newmatrix.GetLength(1); j++)
                {
                    Console.Write(newmatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return newmatrix;
        }
        static double[,] ToRightDiagonal(double[,] matrix) 
        {
            double[,] newmatrix = matrix;
            newmatrix = ToLowerTriangularr(matrix);
            newmatrix = ToUpperTriangular(matrix);
            for (int i = 0; i < newmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newmatrix.GetLength(1); j++)
                {
                    Console.Write(newmatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return newmatrix;
        }

        mc[index](matrix);

        // end

        return matrix;
    }
    #endregion
}
