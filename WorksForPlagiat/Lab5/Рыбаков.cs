using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        double[] array7 = new double[] { 1, 2, 13, 4, -5, 6, 7 };
        int[] arr6 = new int[] { -3, 5, 5, 1, 0, 4 };
        int[] arr6b = new int[] { 13, 10, 1, 0, -2, -4 };
        int[] arr7 = new int[] { 1, 2, 13, 4, -5, 6, 7 };
        int[] arr7b = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int[] arr8 = new int[] { 1, 8, -3, 5, 5, 1, 0, 4 };
        int[] arr10 = new int[] { 1, -8, -3, 5, -5, 1, 0, -4, -1, 2 };
        double[] array9 = new double[] { 1, 12, 3, 4, 5, -6, 7, 0, 9 };
        int[,] matrix7x4 = new int[,] {
            { 1, 2, 3, 4 },
            { 5, 5, 4, 6 },
            { 5, -5, 5, -5 },
            { 6, 7, 8, 9 },
            { -6, -5, -8, 0 },
            { 11, 12, 13, 14 },
            { 6, 5, 8, 0 }};
        int[,] matrix5x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix6x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 },
            { 0, 1, 0, 2, 0 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix6x6 = new int[,] {
            { 1,    2,  3,  4,  5,  -1 },
            { 6,    7,  8,  9,  10, -2 },
            { 11,   12, 13, 14, 15, -3 },
            { -1,   -2, -3, -4, -5, -1 },
            { 6,    7,  8,  9,  20, -2 },
            { 1,    3,  3,  1,  5, 5 }};
        int[,] resultA = null, resultB = null, resultC = null, resultD = null;
        program.Task_2_2(array7, array9);
        program.Task_2_6(ref arr7, arr8);
        program.Task_2_10(ref matrix5x5);
        program.Task_2_14(matrix7x4);
        program.Task_2_16(arr8, arr10);
        program.Task_2_20(ref matrix7x4, ref matrix6x5);
        program.Task_2_28b(arr6, arr6b, ref resultC, ref resultD);
        program.Task_3_10(ref matrix6x6);
    }
    #region Level 1
    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here

        // create and use Combinations(n, k);
        // create and use Factorial(n);
    
        answer = Combinations(n, k);
        // end

        return answer;
    }
    public static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }
    public static int Combinations(int n, int k)
    {
        int c = Factorial(n) / (Factorial(k) * Factorial(n - k));
        return c;
    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here

        // create and use GeronArea(a, b, c);
        double a1 = first[0], b1 = first[1], c1 = first[2], a2 = second[0], b2 = second[1], c2 = second[2];
        if (a1 + b1 <= c1 || a1 + c1 <= b1 || b1 + c1 <= a1 || a2 + b2 <= c2 || a2 + c2 <= b2 || b2 + c2 <= a2 || a1 < 0 || b1 < 0 || c1 < 0 || a2 < 0 || b2 < 0 || c2 < 0) 
        {
            answer = -1;
        }
    
        if (answer == -1)
        {
            return answer;
        }
        double g1 = GeronArea(a1, b1, c1), g2 = GeronArea(a2, b2, c2);
        if (g1 > g2)
        {
            answer = 1;
        }
        else if (g1 < g2)
        {
            answer = 2;
        }
        else
        {
            answer = 0;
        }
        System.Console.WriteLine(answer);
                //0, 2, -1, 2, 2, 1, 0, 2, -1,
         //       1, 1, -1, 1, 0, 1, 1, 1, -1,
           //     -1, 2, -1, -1, 2, -1, -1, 2, -1
        // end

        // first = 1, second = 2, equal = 0, error = -1
        return answer;
    }
    public static double GeronArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;
        
        // code here
        if (v1 < 0 || v2 < 0 || a1 < 0 || a2 < 0 || time < 0)
        {
            return -1;
        }
        double dist1, dist2;
        dist1 = GetDistance(v1, a1, time); 
        dist2 = GetDistance(v2, a2, time);
        if (dist1 > dist2) answer = 1;
        else if (dist1 < dist2) answer = 2;
        else answer = 0;
        // create and use GetDistance(v, a, t); t - hours

        // end

        // first = 1, second = 2, equal = 0
        return answer;
    }
    public static double GetDistance(double v, double a, double t)
    {
        return v * t + (a * t * t / 2);
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here
        double dist1, dist2;
        if (v1 > 0 && v2 > 0)
        {for (int i = 1;;i++)
        {
            dist1 = GetDistance(v1, a1, i);
            dist2 = GetDistance(v2, a2, i);
            if (dist2 >= dist1)
            {
                answer = i;
                break;
            }
        }}
        System.Console.WriteLine(answer);
        // use GetDistance(v, a, t); t - hours

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
        int Amax = FindMaxIndex(A), Bmax = FindMaxIndex(B);
        if (A.Length - Amax < B.Length - Bmax)
        {
            double mid = 0;
            int c = 0;
            for (int i = Bmax + 1; i < B.Length; i++)
            {
                mid += B[i];
                c++;
            }
            mid /= c;
            B[Bmax] = mid;
        }
        else if (A.Length - Amax > B.Length - Bmax)
        {
            double mid = 0;
            int c = 0;
            for (int i = Amax + 1; i < A.Length; i++)
            {
                mid += A[i];
                c++;
            }
            mid /= c;
            A[Amax] = mid;
        }
        for (int i = 0; i < A.Length; i++)
        {
            System.Console.Write($"{A[i]} ");
        }
        System.Console.WriteLine();
        for (int i = 0; i < B.Length; i++)
        {
            System.Console.Write($"{B[i]} ");
        }
        // end
    }
    public static int FindMaxIndex(double[] array)
    {
        int max_i = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[max_i])
            {
                max_i = i;
            }
        }
        return max_i;
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
        int na = A.GetLength(0), ma = A.GetLength(1);
        int nb = B.GetLength(0), mb = B.GetLength(1);
        if (na != 5 || ma != 5 || nb != 5 || mb != 5) return;
        //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3
        int max_a = FindDiagonalMaxIndex(A), max_b = FindDiagonalMaxIndex(B);
        for (int i = 0; i < na; i++)
        {
            int temp = B[i, max_b];
            B[i, max_b] = A[max_a, i];
            A[max_a, i] = temp;
        }
        // end
    }
    public static int FindDiagonalMaxIndex(int[,] matrix)
    {
        int max_i = 0, n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == j)
                {
                    if (matrix[i, j] > matrix[max_i, max_i])
                    {
                        max_i = i;
                    }
                }
            }
        }
        return max_i;
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
        if (A.Length != 7 || B.Length != 8) return;
        // create and use FindMax(matrix, out row, out column); like in Task_2_1
        // create and use DeleteElement(array, index);
        int max_a, max_b;
        FindMax(A, out max_a);
        FindMax(B, out max_b);
        DeleteElement(ref A, max_a);
        DeleteElement(ref B, max_b);
        int[] temp = new int[A.Length + B.Length];
        for (int i = 0; i < A.Length; i++)
        {
            temp[i] = A[i];
            System.Console.WriteLine(temp[i]);
        }
        for (int j = 0, t = A.Length; j < B.Length; j++, t++)
        {
            temp[t] = B[j];
            System.Console.WriteLine(temp[t]);
        }
        A = temp;
        // end
    }
    public static void FindMax(int[] array, out int index)
    {
        int max_i = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[max_i])
            {
                max_i = i;
            }
        }
        index = max_i;
    }
    public static void DeleteElement(ref int[] array, int index)
    {
        int[] temp = new int[array.Length - 1];
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (i < index)
            {
                temp[i] = array[i];
            }
            else
            {
                temp[i] = array[i + 1];
            }
        }
        array = temp;
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
        if (A.Length != 9 || B.Length != 11) return;
        // create and use SortArrayPart(array, startIndex);
        int max_a, max_b;
        FindMax(A, out max_a);
        FindMax(B, out max_b);
        SortArrayPart(ref A, max_a);
        SortArrayPart(ref B, max_b);
        // end
    }
    public static void SortArrayPart(ref int[] array, int startIndex)
    {
        int n = array.Length;
        int gap = (n - startIndex) / 2;
        while (gap > 0)
        {
            for (int i = 1 + startIndex + gap; i < n; i++)
            {
                int key = array[i], j = i - gap;
                while (j >= 1 + startIndex && array[j] > key)
                {
                    array[j + gap] = array[j];
                    j -= gap;
                }
                array[j + gap] = key;
            }
            gap /= 2;
        }
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m) return;
        // create and use RemoveColumn(matrix, columnIndex);
        int max_j = 0, min_j = 0;
        int max = matrix[0, 0], min = matrix[0, 0];
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (i >= j)
                {
                    if (max < matrix[i, j])
                    {
                        max_j = j;
                        max = matrix[i, j];
                    }
                }
                else
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        min_j = j;
                    }
                }
            }
        }
        if (max_j == min_j)
        {
            RemoveColumn(ref matrix, max_j);
        }
        else
        {
            RemoveColumn(ref matrix, max_j);
            RemoveColumn(ref matrix, min_j - 1);
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j]} ");
            }
            System.Console.WriteLine();
        }
        // end
    }
    public static void RemoveColumn(ref int[,] matrix, int columnIndex)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[,] temp = new int[n, m - 1];
        for (int j = 0; j < m - 1; j++)
        {
            if (j < columnIndex)
            {
                for (int i = 0; i < n; i++)
                {
                    temp[i, j] = matrix[i, j];
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    temp[i, j] = matrix[i, j + 1];
                }
            }
        }
        matrix = temp;
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
        int na = A.GetLength(0), ma = A.GetLength(1);
        int nb = B.GetLength(0), mb = B.GetLength(1);
        if (na != nb && ma != mb) return; 
        // create and use FindMaxColumnIndex(matrix);
        int max_a = FindMaxColumnIndex(A), max_b = FindMaxColumnIndex(B);
        for (int i = 0; i < na; i++)
        {
            int temp = A[i, max_a];
            A[i, max_a] = B[i, max_b];
            B[i, max_b] = temp;
        }
        // end
    }
    public static int FindMaxColumnIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int max_j = 0, max = matrix[0, 0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (max < matrix[i, j])
                {
                    max = matrix[i, j];
                    max_j = j;
                }
            }
        }
        return max_j;
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
        int n = matrix.GetLength(0);
        // create and use SortRow(matrix, rowIndex);
        for (int i = 0; i < n; i++)
        {
            SortRow(matrix, i);
        }
        // end
    }
    public static void SortRow(int[,] matrix, int rowIndex)
    {
        int m = matrix.GetLength(1);
        int gap = m / 2;
        while (gap > 0)
        {
            for (int j = gap; j < m; j++)
            {
                int key = matrix[rowIndex, j], c = j - gap;
                while (c >= 0 && matrix[rowIndex, c] > key)
                {
                    matrix[rowIndex, c + gap] = matrix[rowIndex, c];
                    c -= gap;
                }
                matrix[rowIndex, c + gap] = key;
            }
            gap /= 2;
        }
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
        SortNegative(A);
        SortNegative(B);
        // end
    }
    public static void SortNegative(int[] array)
    {
        for (int i = 1; i < array.Length;i++)
        {
            if (array[i] < 0)
            {
                int key = array[i], j = i - 1;
                while (j >= 0)
                {
                    if (key > array[j])
                    {
                        array[i] = array[j];
                        array[j] = key;
                        i = j;
                    }
                    j--;
                }
            }
        }
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
        SortDiagonal(A);
        SortDiagonal(B);
        // end
    }
    public static void SortDiagonal(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[] temp = new int[n];
        for (int t = 0; t < n; t++)
        {
            temp[t] = matrix[t, t];
        }
        int gap = n / 2;
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int key = temp[i], j = i - gap;
                while (j >= 0 && temp[j] > key)
                {
                    temp[j + gap] = temp[j];
                    j -= gap;
                }
                temp[j + gap] = key;
            }
            gap /= 2;
        }
        for (int t = 0; t < n; t++)
        {
            matrix[t, t] = temp[t];
        }
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
        int na = A.GetLength(0), nb = B.GetLength(0), index;
        bool flag = true;
        // use RemoveColumn(matrix, columnIndex); from 2_10
        for (int j = 0; j < A.GetLength(1);)
        {
            for (int i = 0; i < na; i++)
            {
                if (A[i, j] == 0)
                {
                    flag = false;
                    j++;
                    break;
                }
            }
            if (flag)
            {
                RemoveColumn(ref A, j);
                j = 0;
            }
            flag = true;
        }
        for (int j = 0; j < B.GetLength(1);)
        {
            for (int i = 0; i < nb; i++)
            {
                if (B[i, j] == 0)
                {
                    flag = false;
                    j++;
                    break;
                }
            }
            if (flag)
            {
                RemoveColumn(ref B, j);
                j = 0;
            }
            flag = true;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                System.Console.Write($"{A[i, j]} ");
            }
            System.Console.WriteLine();
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        // create and use CountNegativeInRow(matrix, rowIndex);
        // create and use FindMaxNegativePerColumn(matrix);
        rows = new int[n];
        cols = new int[m];
        for (int i = 0; i < n; i++)
        {
            rows[i] = CountNegativeInRow(matrix, i);
        }
        for (int j = 0; j < m; j++)
        {
            cols[j] = FindMaxNegativePerColumn(matrix, j);
        }
        // end
    }
    public static int CountNegativeInRow(int[,] matrix, int rowIndex)
    {
        int m = matrix.GetLength(1);
        int c = 0;
        for (int j = 0; j < m; j++)
        {
            if (matrix[rowIndex, j] < 0)
            {
                c++;
            }
        }
        return c;
    }
    public static int FindMaxNegativePerColumn(int[,] matrix, int columnIndex)
    {
        int n = matrix.GetLength(0);
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, columnIndex] < 0)
            {
                if (matrix[i, columnIndex] > max || max == 0)
                {
                    max = matrix[i, columnIndex];
                }
            }
        }
        return max;
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
        int row_a, column_a, row_b, column_b;
        int na = A.GetLength(0), ma = A.GetLength(1);
        int nb = B.GetLength(0), mb = B.GetLength(1);
        // use FindMaxIndex(matrix, out row, out column); like in 2_1
        // create and use SwapColumnDiagonal(matrix, columnIndex);
        FindMaxIndexMatrix(A, out row_a, out column_a);
        FindMaxIndexMatrix(B, out row_b, out column_b);
        SwapColumnDiagonal(A, column_a);
        SwapColumnDiagonal(B, column_b);
        // end
    }
    public static void FindMaxIndexMatrix(int[,] matrix, out int row, out int column)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        row = 0;
        column = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[row, column] < matrix[i, j])
                {
                    row = i;
                    column = j;
                }
            }
        }
    }
    public static void SwapColumnDiagonal(int[,] matrix, int columnIndex)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            int temp = matrix[i, columnIndex];
            matrix[i, columnIndex] = matrix[i, i];
            matrix[i, i] = temp;
        }
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
        int ma = A.GetLength(1), mb = B.GetLength(1);
        // create and use FindRowWithMaxNegativeCount(matrix); like in 2_25
        // in FindRowWithMaxNegativeCount use CountNegativeInRow(matrix, rowIndex); from 2_22
        int row_a = FindRowWithMaxNegativeCount(A);
        int row_b = FindRowWithMaxNegativeCount(B);
        for (int j = 0; j < ma; j++)
        {
            int temp = A[row_a, j];
            A[row_a, j] = B[row_b, j];
            B[row_b, j] = temp;
        }
        // end
    }
    public static int FindRowWithMaxNegativeCount(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int row = 0;
        for (int i = 0; i < n; i++)
        {
            int c1 = CountNegativeInRow(matrix, row);
            int c2 = CountNegativeInRow(matrix, i);
            if (c1 < c2) row = i;
        }
        return row;
    }

    public void Task_2_27(int[,] A, int[,] B)
    {
        // code here

        // create and use FindRowMaxIndex(matrix, rowIndex, out columnIndex);
        // create and use ReplaceMaxElementOdd(matrix, row, column);
        // create and use ReplaceMaxElementEven(matrix, row, column);

        // end
    }

    public void Task_2_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here

        // create and use FindSequence(array, A, B); // 1 - increasing, 0 - no sequence,  -1 - decreasing
        // A and B - start and end indexes of elements from array for search
        answerFirst = FindSequence(first, 0, first.Length - 1);
        answerSecond = FindSequence(second, 0, second.Length - 1);
        // end
    }
    public static int FindSequence(int[] array, int A, int B)
    {
        bool flag = true;
        for (int i = A; i < B; i++)
        {
            if (array[i + 1] < array[i])
            {
                flag = false;
                break;
            }
        }
        if (flag) return 1;
        flag = true;
        for (int i = A; i < B; i++)
        {
            if (array[i + 1] > array[i])
            {
                flag = false;
                break;
            }
        }
        if (flag) return -1;
        else return 0;
    }

    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a
        // A and B - start and end indexes of elements from array for search
        int i_a = 0, i_b = 0, c_a = 0, c_b = 0;
        for (int i = 0; i < first.Length - 1; i++)
        {
            for (int j = i + 1; j < first.Length; j++)
            {
                if (FindSequence(first, i, j) == 1 || FindSequence(first, i, j) == -1)
                {
                    c_a++;
                }
                else
                {
                    break;
                }
            }
        }
        answerFirst = new int[c_a, 2];
        for (int i = 0; i < first.Length - 1; i++)
        {
            for (int j = i + 1; j < first.Length; j++)
            {
                if (FindSequence(first, i, j) == 1 || FindSequence(first, i, j) == -1)
                {
                    answerFirst[i_a, 0] = i;
                    answerFirst[i_a, 1] = j;
                    i_a++;
                }
            }
        }
        for (int i = 0; i < second.Length - 1; i++)
        {
            for (int j = i + 1; j < second.Length; j++)
            {
                if (FindSequence(second, i, j) == 1 || FindSequence(second, i, j) == -1)
                {
                    c_b++;
                }
            }
        }
        answerSecond = new int[c_b, 2];
        for (int i = 0; i < second.Length - 1; i++)
        {
            for (int j = i + 1; j < second.Length; j++)
            {
                if (FindSequence(second, i, j) == 1 || FindSequence(second, i, j) == -1)
                {
                    answerSecond[i_b, 0] = i;
                    answerSecond[i_b, 1] = j;
                    i_b++;
                }
            }
        }
        // end
    }

    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here
        answerFirst = new int[2];
        answerSecond = new int[2];
        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
        // A and B - start and end indexes of elements from array for search
        for (int i = 0; i < first.Length; i++)
        {
            for (int j = i + 1; j < first.Length; j++)
            {
                if (FindSequence(first, i, j) == 1 || FindSequence(first, i, j) == -1)
                {
                    if (j - i > answerFirst[1] - answerFirst[0])
                    {
                        answerFirst[0] = i;
                        answerFirst[1] = j;
                    }
                }
            }
        }
        for (int i = 0; i < second.Length; i++)
        {
            for (int j = i + 1; j < second.Length; j++)
            {
                if (FindSequence(second, i, j) == 1 || FindSequence(second, i, j) == -1)
                {
                    if (j - i > answerSecond[1] - answerSecond[0])
                    {
                        answerSecond[0] = i;
                        answerSecond[1] = j;
                    }
                }
            }
        }
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

    public void Task_3_2(int[,] matrix)
    {
        // SortRowStyle sortStyle = default(SortRowStyle); - uncomment me

        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        // create and use public delegate SortRowStyle(matrix, rowIndex);
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        // change method in variable sortStyle in the loop here and use it for row sorting
        SortRowStyle sortStyle;
        for (int i = 0; i < n; i++)
        {
            int[] row = new int[m];
            sortStyle = (i % 2 == 0) ? SortAscending : SortDescending;
            row = sortStyle(matrix, i);
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = row[j];
            }
        }
        // end
    }
    public delegate int[] SortRowStyle(int[,] matrix, int rowIndex);
    public static int[] SortAscending(int[,] matrix, int rowIndex)
    {
        int[] temp = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[j] = matrix[rowIndex, j];
        }
        int n = temp.Length;
        int gap = n / 2;
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int key = temp[i], j = i - gap;
                while (j >= 0 && temp[j] > key)
                {
                    temp[j + gap] = temp[j];
                    j -= gap;
                }
                temp[j + gap] = key;
            }
            gap /= 2;
        }
        return temp;
    }
    public static int[] SortDescending(int[,] matrix, int rowIndex)
    {
        int[] temp = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[j] = matrix[rowIndex, j];
        }
        int n = temp.Length;
        int gap = n / 2;
        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int key = temp[i], j = i - gap;
                while (j >= 0 && temp[j] < key)
                {
                    temp[j + gap] = temp[j];
                    j -= gap;
                }
                temp[j + gap] = key;
            }
            gap /= 2;
        }
        return temp;
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

    public int Task_3_4(int[,] matrix, bool isUpperTriangle)
    {
        int answer = 0;

        // code here
        GetTriangle whichTriangle;
        whichTriangle = (isUpperTriangle) ? GetUpperTriange : GetLowerTriange;
        answer = GetSum(whichTriangle, matrix);
        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // create and use GetSum(GetTriangle, matrix)

        // end

        return answer;
    }
    public delegate int[,] GetTriangle(int[,] matrix);
    public static int[,] GetUpperTriange(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[,] temp = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i <= j)
                {
                    temp[i, j] = matrix[i, j];
                }
            }
        }
        return temp;
    }
    public static int[,] GetLowerTriange(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        int[,] temp = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i >= j)
                {
                    temp[i, j] = matrix[i, j];
                }
                System.Console.Write($"{temp[i, j]} ");
            }
            System.Console.WriteLine();
        }
        return temp;
    }
    public static int GetSum(GetTriangle triangle, int[,] matrix)
    {
        int[,] temp = triangle(matrix);
        int n = temp.GetLength(0), m = temp.GetLength(1);
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                sum += temp[i, j] * temp[i, j];
            }
        }
        return sum;
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

    public void Task_3_6(int[,] matrix)
    {
        // code here

        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) like in Task_2_3;
        // create and use method FindFirstRowMaxIndex(matrix);
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);
        FindElementDelegate rowDelegate;
        FindElementDelegate diagonalDelegate;
        rowDelegate = FindFirstRowMaxIndex;
        diagonalDelegate = FindDiagonalMaxIndex;
        SwapColumns(matrix, rowDelegate, diagonalDelegate);
        // end
    }
    public delegate int FindElementDelegate(int[,] matrix);
    public static int FindFirstRowMaxIndex(int[,] matrix)
    {
        int m = matrix.GetLength(1);
        int max_j = 0;
        for (int j = 0; j < m; j++)
        {
            if (matrix[0, max_j] < matrix[0, j])
            {
                max_j = j;
            }
        }
        return max_j;
    }
    public static void SwapColumns(int[,] matrix, FindElementDelegate rowDelegate, FindElementDelegate diagonalDelegate)
    {
        int n = matrix.GetLength(0);
        int DiagonalMaxIndex = diagonalDelegate(matrix);
        int FirstRowMaxIndex = rowDelegate(matrix);
        for (int i = 0; i < n; i++)
        {
            int temp = matrix[i, DiagonalMaxIndex];
            matrix[i, DiagonalMaxIndex] = matrix[i, FirstRowMaxIndex];
            matrix[i, FirstRowMaxIndex] = temp;
        }
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

    public void Task_3_10(ref int[,] matrix)
    {
        FindIndex searchArea = default(FindIndex);

        // code here
        searchArea = FindMaxBelowDiagonalIndex;
        FindIndex searchArea1 = FindMinAboveDiagonalIndex;
        RemoveColumns(ref matrix, searchArea, searchArea1);
        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        // create and use method FindMinAboveDiagonalIndex(matrix);
        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)

        // end
    }
    public delegate int FindIndex(int[,] matrix);
    public static int FindMaxBelowDiagonalIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1), max_j = 0, max = matrix[0, 0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i >= j)
                {
                    if (max < matrix[i, j])
                    {
                        max_j = j;
                        max = matrix[i, j];
                    }
                }
                else
                {
                    break;
                }
            }
        }
        return max_j;
    }
    public static int FindMinAboveDiagonalIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1), min_j = 0, min = matrix[0, 0];
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (i < j)
                {
                    if (min > matrix[i, j])
                    {
                        min_j = j;
                        min = matrix[i, j];
                    }
                }
                else
                {
                    break;
                }
            }
        }
        return min_j;
    }
    public static void RemoveColumns(ref int[,] matrix, FindIndex findMaxBelowDiagonalIndex, FindIndex findMinAboveDiagonalIndex)
    {
        int col1 = findMaxBelowDiagonalIndex(matrix), col2 = findMinAboveDiagonalIndex(matrix);
        if (col1 == col2)
        {
            RemoveColumn(ref matrix, col1);
        }
        else
        {
            RemoveColumn(ref matrix, col1);
            RemoveColumn(ref matrix, col2 - 1);
        }
    }

    public void Task_3_13(ref int[,] matrix)
    {
        // code here

        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)

        // end
    }

    public void Task_3_22(int[,] matrix, out int[] rows, out int[] cols)
    {

        rows = null;
        cols = null;

        // code here
        GetNegativeArray searcherRows; 
        GetNegativeArray searcherCols; 
        searcherRows = CountNegativeInRow;
        searcherCols = FindMaxNegativePerColumn;
        FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);
        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22
        // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);

        // end
    }
    public delegate int GetNegativeArray(int[,] matrix, int index);
    public static void FindNegatives(int[,] matrix, GetNegativeArray searcherRows, GetNegativeArray searcherCols, out int[] rows, out int[] cols)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        rows = new int[n];
        cols = new int[m];
        for (int i = 0; i < n; i++)
        {
            rows[i] = searcherRows(matrix, i);
        }
        for (int j = 0; j < m; j++)
        {
            cols[j] = searcherCols(matrix, j);
        }
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

    public void Task_3_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here
        IsSequence findIncreasingSequence = FindIncreasingSequence;
        IsSequence findDecreasingSequence = FindDecreasingSequence;
        answerFirst = DefineSequence(first, findIncreasingSequence, findDecreasingSequence);
        answerSecond = DefineSequence(second, findIncreasingSequence, findDecreasingSequence);
        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);

        // end
    }
    public delegate bool IsSequence(int[] array, int left, int right);
    public static bool FindIncreasingSequence(int[] array, int A, int B)
    {
        bool flag = true;
        for (int i = A; i < B; i++)
        {
            if (array[i + 1] < array[i])
            {
                flag = false;
                break;
            }
        }
        return flag;
    }
    public static bool FindDecreasingSequence(int[] array, int A, int B)
    {
        bool flag = true;
        flag = true;
        for (int i = A; i < B; i++)
        {
            if (array[i + 1] > array[i])
            {
                flag = false;
                break;
            }
        }
        return flag;
    }
    public static int DefineSequence(int[] array, IsSequence findIncreasingSequence, IsSequence findDecreasingSequence)
    {
        if (findIncreasingSequence(array, 0, array.Length - 1))
        {
            return 1;
        }
        else if (findDecreasingSequence(array, 0, array.Length - 1))
        {
            return -1;
        }
        return 0;
    }

    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here
        IsSequence findIncreasingSequence = FindIncreasingSequence;
        IsSequence findDecreasingSequence = FindDecreasingSequence;
        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);
        answerFirstIncrease = FindLongestSequence(first, findIncreasingSequence);
        answerFirstDecrease = FindLongestSequence(first, findDecreasingSequence);
        answerSecondIncrease = FindLongestSequence(second, findIncreasingSequence);
        answerSecondDecrease = FindLongestSequence(second, findDecreasingSequence);
        // end
    }
    public static int[] FindLongestSequence(int[] array, IsSequence sequence)
    {
        int[] temp = new int [2];
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (sequence(array, i, j))
                {
                    if (j - i > temp[1] - temp[0])
                    {
                        temp[0] = i;
                        temp[1] = j;
                    }
                }
            }
        }
        return temp;
    }
    #endregion
    #region bonus part
    public double[,] Task_4(double[,] matrix, int index)
    {
        MatrixConverter[] mc = new MatrixConverter[4];

        // code here
        MatrixConverter up = ToUpperTriangular;
        MatrixConverter low = ToLowerTriangular;
        MatrixConverter left = ToLeftDiagonal;
        MatrixConverter right = ToRightDiagonal;
        // create public delegate MatrixConverter(matrix);
        // create and use method ToUpperTriangular(matrix);
        // create and use method ToLowerTriangular(matrix);
        // create and use method ToLeftDiagonal(matrix); - start from the left top angle
        // create and use method ToRightDiagonal(matrix); - start from the right bottom angle
        mc[0] = up;
        mc[1] = low;
        mc[2] = left;
        mc[3] = right;
        // end

        return matrix;
    }
    public delegate void MatrixConverter(double[,] matrix);
    public static void ToUpperTriangular(double[,] matrix)
    {
        ToLeftDiagonal(matrix);
    }
    public static void ToLeftDiagonal(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int j = 0; j <= n - 2; j++)
        {
            for (int k = j + 1; k <= n - 1; k++)
            {
                double p = matrix[k, j] / matrix[j, j];
                for (int m = j; m <= n - 1; m++)
                {
                    matrix[k, m] -= matrix[j, m] * p;
                }
            }
        }
    }
    public static void ToLowerTriangular(double[,] matrix)
    {
        ToRightDiagonal(matrix);
    }
    public static void ToRightDiagonal(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int j = n - 2; j >= 0; j--)
        {
            for (int k = n - 1; k >= j + 1; k--)
            {
                double p = matrix[j, j] / matrix[k, j];
                for (int m = n - 1; m >= j; m--)
                {
                    matrix[k, m] -= matrix[j, m] * p;
                }
            }
        }
    }

    #endregion
}
