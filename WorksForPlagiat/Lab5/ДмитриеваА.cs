using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using static Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
    }
    #region Level 1
    static long Combinations(int n, int k)
    {
        long c = Factorial(n) / (Factorial(k) * Factorial(n - k));
        return c;
    }
    static long Factorial(int n)
    {
        int t = n;
        long s = 1;
        while (t != 0)
        {
            s *= t;
            t--;
        }
        return s;
    }
    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here
        if (n < 0 || k < 0 || n < k) return 0;
        if (n == 0 || k == 0) return 1;
        // create and use Combinations(n, k);
        // create and use Factorial(n);
        answer = Combinations(n, k);

        // end

        return answer;
    }

    static double GeronArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        if (p < a || p < b || p < c) return 0;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return s;
    }
    static double[] sort(double[] array)
    {
        for (int i1 = 0; i1 < array.Length; i1++)
        {
            for (int i = 1; i < array.Length; i++)
            {
 
                    if (array[i] < array[i - 1])
                    {
                        double t = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = t;

                    }
            }
        }
        return array;
    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here
        first = sort(first);
        second = sort(second);
        if (first[0] + first[1] <= first[2] || second[0] + second[1] <= second[2]) return -1;
        // create and use GeronArea(a, b, c);
        // end
        double mfirst = GeronArea(first[0], first[1], first[2]);
        double msecond = GeronArea(second[0], second[1], second[2]);
        //Console.Write(mfirst + " ");
        //Console.WriteLine(msecond + " ");
        if (mfirst > msecond) answer = 1;
        if (mfirst < msecond) answer = 2;
        // first = 1, second = 2, equal = 0, error = -1

        return answer;
    }

    static double GetDistance(double v, double a, double t)
    {
        double s = v * t + a * t * t / 2;
        return s;
    }

    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here
        // create and use GetDistance(v, a, t); t - hours
        double s1 = GetDistance(v1, a1, time);
        double s2 = GetDistance(v2, a2, time);
        if (s1 > s2) answer = 1;
        if (s1 < s2) answer = 2;
        // end

        // first = 1, second = 2, equal = 0
        return answer;
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here
        int time = 1;
        while (GetDistance(v1, a1, time) > GetDistance(v2, a2, time))
        {
            time++;
        }
        // use GetDistance(v, a, t); t - hours
        answer = time;
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

    static int FindMaxIndex(double[] array)
    {
        double max = -100000000;
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; j = i; }
        }
        return j;
    }
    static double[] AB(int indexA, double[] A)
    {
        double s = 0; int count = 0;
        for (int i = indexA + 1; i < A.Length; i++)
        {
            s += A[i];
            count++;
        }
        s /= count;
        A[indexA] = s;
        return A;
    }

    public void Task_2_2(double[] A, double[] B)
    {
        // code here

        // create and use FindMaxIndex(array);
        int indexA = FindMaxIndex(A);
        int indexB = FindMaxIndex(B);
        double s = 0; int count = 0;
        if (indexA < indexB)
        {
            A = AB(indexA, A);
        }
        else if (indexA > indexB)
        {
            B = AB(indexB, B);
        }
        // only 1 array has to be changed!
        // end
    }

    public void Task_2_3(ref int[,] B, ref int[,] C)
    {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix);

        // end
    }

    static int FindDiagonalMaxIndex(int[,] matrix)
    {
        int max = -1000000, j = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, i] > max) { max = matrix[i, i]; j = i; }
        }
        return j;
    }

    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3
        int i1 = FindDiagonalMaxIndex(A);
        int i2 = FindDiagonalMaxIndex(B);
        int[] arrayA = new int[A.GetLength(0)];
        int[] arrayB = new int[B.GetLength(0)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            arrayA[j] = A[i1, j];
        }
        for (int j = 0; j < B.GetLength(1); j++)
        {
            arrayB[j] = B[j, i2];
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i1, j] = arrayB[j];
            B[j, i2] = arrayA[j];
        }
        // end
    }

    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxInColumn(matrix, columnIndex, out rowIndex);

        // end
    }

    static int FindMax(int[] array)
    {
        int max = -100000000, j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; j = i; }
        }
        return j;
    }
    static int[] DeleteElement(int[] array, int index)
    {
        int[] array1 = new int[array.Length - 1]; int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != array[index])
            {
                array1[j] = array[i];
                j++;
            }

        }
        return array1;
    }

    public void Task_2_6(ref int[] A, int[] B)
    {
        // code here

        // create and use FindMax(matrix, out row, out column); like in Task_2_1
        // create and use DeleteElement(array, index);
        A = DeleteElement(A, FindMax(A));
        B = DeleteElement(B, FindMax(B));
        int[] answerAB = new int[A.Length + B.Length];
        int j = 0;
        for (int i = 0; i < A.Length + B.Length; i++)
        {
            if (i < A.Length)
            {
                answerAB[i] = A[i];
            }
            else
            {
                answerAB[i] = B[j];
                j++;
            }
        }
        A = answerAB;
        // end
    }

    public void Task_2_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);

        // end
    }

    static int[] SortArrayPart(int[] array, int startIndex)
    {
        for (int j1 = startIndex + 1; j1 < array.Length; j1++)
        {
            for (int j = startIndex + 2; j < array.Length; j++)
            {
                if (array[j] < array[j - 1])
                {
                    int t = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = t;
                }
            }
        }
        return array;
    }

    public void Task_2_8(int[] A, int[] B)
    {
        // code here
        int max1 = -100000000, j1 = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > max1) { max1 = A[i]; j1 = i; }
        }
        int max2 = -100000000, j2 = 0;
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] > max2) { max2 = B[i]; j2 = i; }
        }
        // create and use SortArrayPart(array, startIndex);
        A = SortArrayPart(A, j1);
        B = SortArrayPart(B, j2);

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

    static int[,] RemoveColumn(int[,] matrix, int columnIndex)
    {
        int[,] matrix1 = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int j1 = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != columnIndex)
                {
                    matrix1[i, j1] = matrix[i, j];
                    j1++;
                }
            }
        }
        return matrix1;
    }

    public void Task_2_10(ref int[,] matrix)
    {
        // code here
        int min = 1000000000, max = -1000000000, t1 = 0, t2 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j <= i)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        t1 = j;
                    }
                }
                else
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        t2 = j;
                    }
                }
            }
        }
        // create and use RemoveColumn(matrix, columnIndex);
        if (t1 > t2)
        {
            matrix = RemoveColumn(matrix, t1);
            matrix = RemoveColumn(matrix, t2);
        }
        else if (t1 < t2)
        {
            matrix = RemoveColumn(matrix, t2);
            matrix = RemoveColumn(matrix, t1);
        }
        else
        {
            matrix = RemoveColumn(matrix, t1);
        }

        // end
    }

    public void Task_2_11(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); from Task_2_1

        // end
    }
    static int FindMaxColumnIndex(int[,] matrix)
    {
        int max = -1000000, k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max) { max = matrix[i, j]; k = j; }
            }
        }
        return k;
    }
    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxColumnIndex(matrix);
        int j1 = FindMaxColumnIndex(A);
        int j2 = FindMaxColumnIndex(B);
        int[] arrayA = new int[A.GetLength(1)];
        int[] arrayB = new int[B.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            arrayA[i] = A[i, j1];
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            arrayB[i] = B[i, j2];
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            A[i, j1] = arrayB[i];
            B[i, j2] = arrayA[i];
        }
        // end
    }

    public void Task_2_13(ref int[,] matrix)
    {
        // code here

        // create and use RemoveRow(matrix, rowIndex);

        // end
    }

    static int[,] SortRow(int[,] matrix, int rowIndex)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int j1 = 1; j1 < matrix.GetLength(1); j1++)
            {
                if (matrix[rowIndex, j1] < matrix[rowIndex, j1 - 1])
                {
                    int t = matrix[rowIndex, j1];
                    matrix[rowIndex, j1] = matrix[rowIndex, j1 - 1];
                    matrix[rowIndex, j1 - 1] = t;
                }
            }
        }
        return matrix;
    }

    public void Task_2_14(int[,] matrix)
    {
        // code here

        // create and use SortRow(matrix, rowIndex);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix = SortRow(matrix, i);
        }
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

    static int[] SortNegative(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) count++;
        }
        int[] index = new int[count];
        int[] sort = new int[count];
        int f = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                index[f] = i;
                sort[f] = array[i];
                f++;
            }
        }
        for (int j = 0; j < count; j++)
        {
            for (int j1 = 1; j1 < count; j1++)
            {
                if (sort[j1] > sort[j1 - 1])
                {
                    int t = sort[j1];
                    sort[j1] = sort[j1 - 1];
                    sort[j1 - 1] = t;
                }
            }
        }
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (k == count) break;
            if (i == index[k])
            {
                array[i] = sort[k];
                k++;
            }
        }
        return array;
    }

    public void Task_2_16(int[] A, int[] B)
    {
        // code here

        // create and use SortNegative(array);
        A = SortNegative(A);
        B = SortNegative(B);
        // end
    }

    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here

        // create and use SortRowsByMaxElement(matrix);

        // end
    }

    static int[,] SortDiagonal(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int i1 = 1; i1 < matrix.GetLength(0); i1++)
            {
                if (matrix[i1, i1] < matrix[i1 - 1, i1 - 1])
                {
                    int t = matrix[i1, i1];
                    matrix[i1, i1] = matrix[i1 - 1, i1 - 1];
                    matrix[i1 - 1, i1 - 1] = t;
                }
            }
        }
        return matrix;
    }

    public void Task_2_18(int[,] A, int[,] B)
    {
        // code here

        // create and use SortDiagonal(matrix);
        A = SortDiagonal(A);
        B = SortDiagonal(B);
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
        for (int j = A.GetLength(1) - 1; j >= 0; j--)
        {
            int count = 0;
            for (int i = A.GetLength(0) - 1; i >= 0; i--)
            {
                if (A[i, j] == 0) count++;
            }
            if (count == 0)
            {
                A = RemoveColumn(A, j);
            }
        }
        for (int j = B.GetLength(1) - 1; j >= 0; j--)
        {
            int count = 0;
            for (int i = B.GetLength(0) - 1; i >= 0; i--)
            {
                if (B[i, j] == 0) count++;
            }
            if (count == 0)
            {
                B = RemoveColumn(B, j);
            }
        }
        // use RemoveColumn(matrix, columnIndex); from 2_10
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
    static int CountNegativeInRow(int[,] matrix, int rowIndex)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[rowIndex, j] < 0) count++;
        }
        return count;
    }
    static int[] FindMaxNegativePerColumn(int[,] matrix)
    {
        int[] array = new int[matrix.GetLength(0)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = -1000000;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0 && matrix[i, j] > max) max = matrix[i, j];
            }
            array[j] = max;
        }
        return array;
    }

    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;

        // code here
        rows = new int[matrix.GetLength(0)];
        cols = new int[matrix.GetLength(0)];
        // create and use CountNegativeInRow(matrix, rowIndex);
        // create and use FindMaxNegativePerColumn(matrix);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            rows[i] = CountNegativeInRow(matrix, i);
        }
        cols = FindMaxNegativePerColumn(matrix);
        // end
    }

    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here

        // create and use MatrixValuesChange(matrix);

        // end
    }
    static int FindMaxIndex(int[,] matrix, out int row, out int column)
    {
        row = 0;
        column = 0;
        int max = -10000000;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max) { max = matrix[i, j]; row = i; column = j; }
            }
        }
        return column;
    }
    static int[,] SwapColumnDiagonal(int[,] matrix, int columnIndex)
    {
        int[] array1 = new int[matrix.GetLength(1)];
        int[] array2 = new int[matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array2[i] = matrix[i, columnIndex];
            array1[i] = matrix[i, i];
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, columnIndex] = array1[i];
            matrix[i, i] = array2[i];
        }
        return matrix;
    }

    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); like in 2_1
        // create and use SwapColumnDiagonal(matrix, columnIndex);
        int i1 = 0;
        int j1 = 0;
        A = SwapColumnDiagonal(A, FindMaxIndex(A, out i1, out j1));
        B = SwapColumnDiagonal(B, FindMaxIndex(B, out i1, out j1));
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

    static int FindRowWithMaxNegativeCount(int[,] matrix)
    {
        int count1 = 0, max = -1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int count = 0;
            count = CountNegativeInRow(matrix, i);
            if (count > max) { max = count; count1 = i; }
        }
        return count1;
    }

    public void Task_2_26(int[,] A, int[,] B)
    {
        // code here

        int[] arrayA = new int[A.GetLength(0)];
        int[] arrayB = new int[B.GetLength(0)];
        int maxA = FindRowWithMaxNegativeCount(A);
        int maxB = FindRowWithMaxNegativeCount(B);
        for (int j = 0; j < A.GetLength(1); j++)
        {
            arrayA[j] = A[maxA, j];
            arrayB[j] = B[maxB, j];
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[maxA, j] = arrayB[j];
            B[maxB, j] = arrayA[j];
        }
        // create and use FindRowWithMaxNegativeCount(matrix); like in 2_25
        // in FindRowWithMaxNegativeCount use CountNegativeInRow(matrix, rowIndex); from 2_22
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
        bool k = true;
        bool k1 = true;
        for (int i = A; i < B; i++)
        {
            if (array[i] > array[i + 1]) k = false;
            if (array[i] < array[i + 1]) k1 = false;
        }
        if (k1 == true) return -1;
        else if (k == true) return 1;
        else return 0;
    }
    public void Task_2_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here


        answerFirst = FindSequence(first, 0, first.Length - 1);
        answerSecond = FindSequence(second, 0, second.Length - 1);

        // create and use FindSequence(array, A, B); // 1 - increasing, 0 - no sequence,  -1 - decreasing
        // A and B - start and end indexes of elements from array for search
        // end
    }

    static int[,] FindSequenceAAAAA(int[] array, int A, int B)
    {
        int k = 0;
        for (int i = A; i < B; i++)
        {
            for (int j = i + 1; j <= B; j++)
            {
                if (FindSequence(array, i, j) != 0) k++;
            }
        }
        int[,] matrix = new int[k, 2];
        int t = 0;
        for (int i = A; i < B; i++)
        {
            for (int j = i + 1; j <= B; j++)
            {
                if (FindSequence(array, i, j) != 0)
                {
                    matrix[t, 0] = i;
                    matrix[t, 1] = j;
                    t++;
                }
            }
        }
        return matrix;
    }
    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here

        answerFirst = FindSequenceAAAAA(first, 0, first.Length - 1);
        answerSecond = FindSequenceAAAAA(second, 0, second.Length - 1);
        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a
        // A and B - start and end indexes of elements from array for search
        // end
    }
    static int[] FindMaxSequence(int[,] array)
    {
        int countL = -1000000, t = -1000000, j = -1000000;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int t1 = array[i, 0], j1 = array[i, 1], count = j1 - t1;
            if (count > countL)
            {
                countL = count;
                t = t1;
                j = j1;
            }
        }
        int[] max = new int[] { t, j };
        return max;
    }
    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here

        int[,] f = FindSequenceAAAAA(first, 0, first.Length - 1);
        answerFirst = FindMaxSequence(f);
        int[,] s = FindSequenceAAAAA(second, 0, second.Length - 1);
        answerSecond = FindMaxSequence(s);
        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
        // A and B - start and end indexes of elements from array for search

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

    public delegate void SortRowStyle(ref int[,] matrix, int rowIndex);

    static void SortAscending(ref int[,] matrix, int rowIndex)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int j1 = 1; j1 < matrix.GetLength(1); j1++)
            {
                if (matrix[rowIndex, j1] < matrix[rowIndex, j1 - 1])
                {
                    int t = matrix[rowIndex, j1];
                    matrix[rowIndex, j1] = matrix[rowIndex, j1 - 1];
                    matrix[rowIndex, j1 - 1] = t;
                }
            }
        }
    }
    static void SortDescending(ref int[,] matrix, int rowIndex)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int j1 = 1; j1 < matrix.GetLength(1); j1++)
            {
                if (matrix[rowIndex, j1] > matrix[rowIndex, j1 - 1])
                {
                    int t = matrix[rowIndex, j1];
                    matrix[rowIndex, j1] = matrix[rowIndex, j1 - 1];
                    matrix[rowIndex, j1 - 1] = t;
                }
            }
        }
    }
    public void Task_3_2(int[,] matrix)
    {
        SortRowStyle sortStyle = default(SortRowStyle);

        // code here
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0) sortStyle = SortAscending;
            else sortStyle = SortDescending;
            sortStyle(ref matrix, i);
        }
        // create and use public delegate SortRowStyle(matrix, rowIndex);
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        // change method in variable sortStyle in the loop here and use it for row sorting

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

    public delegate int[] GetTriangle(int[,] matrix);
    static int[] GetUpperTriange(int[,] matrix)
    {
        int c = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++) c++;
        }
        int[] arr = new int[c];
        c = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j >= i)
                {
                    arr[c] = matrix[i, j] * matrix[i, j];
                    c++;
                }
            }
        }
        return arr;
    }
    static int[] GetLowerTriange(int[,] matrix)
    {
        int c = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++) c++;
        }
        int[] arr = new int[c];
        c = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j <= i)
                {
                    arr[c] = matrix[i, j] * matrix[i, j];
                    c++;
                }
            }
        }
        return arr;
    }
    static int GetSum(GetTriangle t, int[,] matrix)
    {
        int s = 0;
        int[] arr = t(matrix);
        for (int i = 0; i < arr.Length; i++)
        {
            s += arr[i];
        }
        return s;
    }
    public int Task_3_4(int[,] matrix, bool isUpperTriangle)
    {
        int answer = 0;

        // code here
        GetTriangle t;
        if (isUpperTriangle) t = GetUpperTriange;
        else t = GetLowerTriange;
        answer = GetSum(t, matrix);
        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // create and use GetSum(GetTriangle, matrix)

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

    public delegate int FindElementDelegate(int[,] matrix);
    static int FindDiagonalMaxIndex1(int[,] matrix)
    {
        int max = -1000000;
        int j = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, i] > max)
            {
                max = matrix[i, i];
                j = i;
            }
        }
        return j;
    }
    static int FindFirstRowMaxIndex(int[,] matrix)
    {
        int max = -100000;
        int i1 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    i1 = j;
                }
            }
        }
        return i1;
    }
    static int[,] SwapColumns(int[,] matrix, FindElementDelegate f, FindElementDelegate s)
    {
        int d = f(matrix);
        int i1 = s(matrix);
        int[] array1 = new int[matrix.GetLength(1)];
        int[] array2 = new int[matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array1[i] = matrix[i, i1];
            array2[i] = matrix[i, d];
        }
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[i, d] = array1[i];
            matrix[i, i1] = array2[i];
        }
        return matrix;
    }
    public void Task_3_6(int[,] matrix)
    {
        // code here
        FindElementDelegate f = FindDiagonalMaxIndex1;
        FindElementDelegate s = FindFirstRowMaxIndex;
        SwapColumns(matrix, f, s);
        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) like in Task_2_3;
        // create and use method FindFirstRowMaxIndex(matrix);
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);

        // end
    }

    public void Task_3_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use public delegate CountPositive(matrix, index);
        // use CountRowPositive(matrix, rowIndex) from Task_2_7
        // use CountColumnPositive(matrix, colIndex) from Task_2_7
        // create and use method InsertColumn(matrixB, CountRow, matrixC, CountColumn);

        // end
    }
    public delegate int FindIndex(int[,] matrix);
    static int FindMaxBelowDiagonalIndex(int[,] matrix)
    {
        int max1 = -1000000000, t1 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j <= i)
                {
                    if (matrix[i, j] > max1)
                    {
                        max1 = matrix[i, j];
                        t1 = j;
                    }
                }
            }
        }
        return t1;
    }
    static int FindMinAboveDiagonalIndex(int[,] matrix)
    {
        int min1 = 1000000000, t2 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j > i)
                {
                    if (matrix[i, j] < min1)
                    {
                        min1 = matrix[i, j];
                        t2 = j;
                    }
                }
            }
        }
        return t2;
    }
    static int[,] RemoveColumns(int[,] matrix, FindIndex max, FindIndex min)
    {
        int t1 = max(matrix);
        int t2 = min(matrix);
        if (t1 > t2)
        {
            matrix = RemoveColumn(matrix, t1);
            matrix = RemoveColumn(matrix, t2);
        }
        else if (t1 < t2)
        {
            matrix = RemoveColumn(matrix, t2);
            matrix = RemoveColumn(matrix, t1);
        }
        else
        {
            matrix = RemoveColumn(matrix, t1);
        }
        return matrix;
    }
    public void Task_3_10(ref int[,] matrix)
    {
        FindIndex searchArea = default(FindIndex);

        // code here
        FindIndex max = FindMaxBelowDiagonalIndex;
        FindIndex min = FindMinAboveDiagonalIndex;
        matrix = RemoveColumns(matrix, max, min);
        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        // create and use method FindMinAboveDiagonalIndex(matrix);
        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)

        // end
    }

    public void Task_3_13(ref int[,] matrix)
    {
        // code here

        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)

        // end
    }
    public delegate int[] GetNegativeArray(int[,] matrix);
    static int[] GetNegativeCountPerRow(int[,] matrix)
    {
        int[] array = new int[matrix.GetLength(0)];
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0) count++;
            }
            array[i] = count;
        }
        return array;
    }
    static int[] GetMaxNegativePerColumn(int[,] matrix)
    {
        int[] array = new int[matrix.GetLength(0)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = -1000000;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0 && matrix[i, j] > max) max = matrix[i, j];
            }
            array[j] = max;
        }
        return array;
    }
    static void FindNegatives(int[,] matrix, GetNegativeArray searcherRows, GetNegativeArray searcherCols, out int[] rows, out int[] cols)
    {
        rows = new int[matrix.GetLength(0)];
        cols = new int[matrix.GetLength(0)];
        // create and use CountNegativeInRow(matrix, rowIndex);
        // create and use FindMaxNegativePerColumn(matrix);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            rows[i] = CountNegativeInRow(matrix, i);
        }
        cols = FindMaxNegativePerColumn(matrix);
    }


    public void Task_3_22(int[,] matrix, out int[] rows, out int[] cols)
    {

        rows = null;
        cols = null;

        // code here
        GetNegativeArray searcherRows = GetNegativeCountPerRow;
        GetNegativeArray searcherCols = GetMaxNegativePerColumn;
        FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);
        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22
        // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);

        // end
    }

    public void Task_3_27(int[,] A, int[,] B)
    {
        // code here

        // create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        // use ReplaceMaxElementOdd(matrix) from Task_2_27
        // use ReplaceMaxElementEven(matrix) from Task_2_27
        // create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);

        // end
    }
    public delegate bool IsSequence(int[] array, int left, int right);
    static bool FindIncreasingSequence(int[] array, int A, int B)
    {
        bool k = true;
        for (int i = A; i < B; i++)
        {
            if (array[i] > array[i + 1]) k = false;
        }
        return k;
    }
    static bool FindDecreasingSequence(int[] array, int A, int B)
    {
        bool k1 = true;
        for (int i = A; i < B; i++)
        {
            if (array[i] < array[i + 1]) k1 = false;
        }
        return k1;
    }
    static int DefineSequence(int[] array, IsSequence FindIncreasingSequence, IsSequence FindDecreasingSequence)
    {
        if (FindIncreasingSequence(array, 0, array.Length - 1)) return 1;
        if (FindDecreasingSequence(array, 0, array.Length - 1)) return -1;
        return 0;
    }
    public void Task_3_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here
        IsSequence t = FindIncreasingSequence;
        IsSequence t1 = FindDecreasingSequence;
        answerFirst = DefineSequence(first, t, t1);
        answerSecond = DefineSequence(second, t, t1);
        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);

        // end
    }
    static int[] FindLongestSequence(int[] array, IsSequence sequence)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (sequence(array, i, j)) k++;
            }
        }
        int[,] matrix = new int[k, 2];
        int t = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (sequence(array, i, j))
                {
                    matrix[t, 0] = i;
                    matrix[t, 1] = j;
                    t++;
                }
            }
        }
        int countL = -1000000, t2 = -1000000, j2 = -1000000;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int t1 = matrix[i, 0], j1 = matrix[i, 1], count = j1 - t1;
            if (count > countL)
            {
                countL = count;
                t2 = t1;
                j2 = j1;
            }
        }
        int[] max = new int[] { t2, j2 };
        return max;
    }

    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here
        IsSequence sequence1 = FindIncreasingSequence;
        IsSequence sequence2 = FindDecreasingSequence;
        answerFirstIncrease = FindLongestSequence(first, sequence1);
        answerFirstDecrease = FindLongestSequence(first, sequence2);
        answerSecondIncrease = FindLongestSequence(second, sequence1);
        answerSecondDecrease = FindLongestSequence(second, sequence2);
        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);

        // end
    }
    #endregion
    #region bonus part
    public delegate int[,]  MatrixConverter(int[,] matrix);
    public double[,] Task_4(double[,] matrix, int index)
    {
        MatrixConverter[] mc = new MatrixConverter[4];

        // code here

        // create public delegate MatrixConverter(matrix);
        // create and use method ToUpperTriangular(matrix);
        // create and use method ToLowerTriangular(matrix);
        // create and use method ToLeftDiagonal(matrix); - start from the left top angle
        // create and use method ToRightDiagonal(matrix); - start from the right bottom angle

        // end

        return matrix;
    }
    #endregion
}
