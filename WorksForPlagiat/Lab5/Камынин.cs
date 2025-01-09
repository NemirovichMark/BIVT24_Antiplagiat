using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        bool tri = true;
        int[] rows = null;
        int[] cols = null;
        int[,] a1 = null;
        int[,] a2 = null;
        int[] arr7 = new int[] { 1, 2, 13, 4, -5, 6, 7 };
        int[] arr7b = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int[] arr8 = new int[] { 1, 8, -3, 5, 5, 1, 0, 4 };
        int[] arr9 = new int[] { 1, 12, 3, 4, 5, -6, 7, 0, 9 };
        int[] arr10 = new int[] { 1, -8, -3, 5, -5, 1, 0, -4, -1, 2 };
        int[] arr11 = new int[] { 1, 12, 13, 0, 9, 1, 5, -6, 7, 12, 14 };
        int[,] matrix4x4 = new int[,] {
            { 1, 2, 3, 4 },
            { 5, -5, 5, -5 },
            { 6, 7, 8, 9 },
            { -6, -5, -8, 0 }};
        int[,] matrix5x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix6x6 = new int[,] {
            { 1,    2,  3,  4,  5,  -1 },
            { 6,    7,  8,  9,  10, -2 },
            { 11,   12, 13, 14, 15, -3 },
            { -1,   -2, -3, -4, -5, -1 },
            { 6,    7,  8,  9,  20, -2 },
            { 1,    3,  3,  1,  5, 5 }};
        int[,] matrix5x5v1 = new int[,] {
            { 100, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix5x5v2 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 50, 15 },
            { -1, -2, -3, -4, -5 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix5x5v3 = new int[,] {
            { -1, 2, -3, 4, -5 },
            { 6, -7, 8, 9, 10 },
            { -1, 2, -3, 4, 5 },
            { 6, 7, 8, -9, 10 },
            { 11, 12, 13, -14, 15 } };
        int[,] matrix7x4 = new int[,] {
            { 1, 2, 3, 4 },
            { 5, 5, 4, 6 },
            { 5, -5, 5, -5 },
            { 6, 7, 8, 9 },
            { -6, -5, -8, 0 },
            { 11, 12, 13, 14 },
            { 6, 5, 8, 0 }};
        int[,] matrix6x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 },
            { 0, 1, 0, 2, 0 },
            { 6, 7, 8, 9, 0 }};
        //program.Task_2_8(arr9, arr11);
        //program.Task_2_10(ref matrix6x6);
        //program.Task_2_12(matrix5x5v1, matrix5x5);
        //program.Task_2_16(arr8, arr10);
        //program.Task_2_20(ref matrix7x4, ref matrix6x5);
        //program.Task_2_22(matrix4x4, out rows, out cols);
        //program.Task_2_26(matrix5x5, matrix5x5v3);
        //program.Task_2_28b(arr7, arr7b, ref a1, ref a2);
        //program.Task_3_4(matrix5x5, tri);
        //program.Task_3_6(matrix5x5);
    }
    #region Level 1
    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here

        // create and use Combinations(n, k);
        // create and use Factorial(n);
        //static long Factorial(int n)
        //{
        //    long output = 1;
        //    for (int i = 1; i<n+1;i++) output*= i;
        //    return output;
        //}
        //static long Combinations(int n, int k)
        //{
        //    long output = 1;
        //    output*=Factorial(n)/(Factorial(k)*Factorial(n-k));
        //    return output;
        //}
        if (k < 0 || k > n) return answer = 0;
        answer = Combinations(n, k);
        // end

        return answer;
    }
    static long Factorial(int n)
    {
        long output = 1;
        for (int i = 1; i < n + 1; i++) output *= i;
        return output;
    }
    static long Combinations(int n, int k)
    {
        long output = 1;
        output *= Factorial(n) / (Factorial(k) * Factorial(n - k));
        return output;
    }

    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;

        // code here

        // create and use GeronArea(a, b, c);
        //static double GeronArea(double a, double b, double c)
        //{
        //    double output, p=(a+b+c)/2;
        //    output = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        //    return output;
        //}
        if (first.Length != 3 || second.Length != 3)
        {
            return answer = -1;
        }
        double a1 = first[0], b1 = first[1], c1 = first[2], a2 = second[0], b2 = second[1], c2 = second[2];
        if (a1 >= b1 + c1 || b1 >= a1 + c1 || c1 >= a1 + b1 || a2 >= b2 + c2 || b2 >= a2 + c2 || c2 >= a2 + b2) return answer = -1;
        if (GeronArea(first[0], first[1], first[2]) > GeronArea(second[0], second[1], second[2]))
        {
            answer = 1;
        }
        else
        {
            if (GeronArea(first[0], first[1], first[2]) == GeronArea(second[0], second[1], second[2]))
            {
                answer = 0;
            }
            else answer = 2;
        }
        // end

        // first = 1, second = 2, equal = 0, error = -1
        return answer;
    }
    static double GeronArea(double a, double b, double c)
    {
        double output, p = (a + b + c) / 2;
        output = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return output;
    }

    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here

        // create and use GetDistance(v, a, t); t - hours
        //static double Getdistance(double v, double a, double t)
        //{
        //    double distance;
        //    distance = v * t + a * t * t / 2;
        //    return distance;
        //}
        if(Getdistance(v1, a1, time)>Getdistance(v2, a2, time))
        {
            answer = 1;
        }
        else
        {
            if (Getdistance(v1, a1, time) == Getdistance(v2, a2, time)) answer = 0;
            else answer = 2;
        }
        // end

        // first = 1, second = 2, equal = 0
        return answer;
    }
    static double Getdistance(double v, double a, double t)
    {
        double distance;
        distance = v * t + a * t * t / 2;
        return distance;
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here

        // use GetDistance(v, a, t); t - hours
        //static double Getdistance(double v, double a, int t)
        //{
        //    double distance;
        //    distance = v * t + a * t * t / 2;
        //    return distance;
        //}
        int time = 1;
        while (Getdistance(v1, a1, time) > Getdistance(v2, a2, time))
        {
            time++;
        }
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

    public void Task_2_2(double[] A, double[] B)
    {
        // code here

        // create and use FindMaxIndex(array);
        // only 1 array has to be changed!
        //static int FindMaxIndex(double[] array)
        //{
        //    int i_max = 0;
        //    double max = array[0];
        //    for(int i=0; i < array.Length; i++)
        //    {
        //        if (array[i] > max)
        //        {
        //            max = array[i];
        //            i_max = i;
        //        }
        //    }
        //    return i_max;
        //}
        if (A.Length != 7 || B.Length != 9) return;
        double summ = 0;
        int count = 0;
        if (A.Length - FindMaxIndex(A) >= B.Length - FindMaxIndex(B))
        {
            for(int i=FindMaxIndex(A)+1; i<A.Length; i++)
            {
                count++;
                summ += A[i];
            }
            if (count != 0) summ /= count;
            A[FindMaxIndex(A)] = summ;
        }
        else
        {
            for (int i = FindMaxIndex(B) + 1; i < B.Length; i++)
            {
                count++;
                summ += B[i];
            }
            if (count != 0) summ /= count;
            B[FindMaxIndex(B)] = summ;
        }
        // end
    }
    static int FindMaxIndex(double[] array)
    {
        int i_max = 0;
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                i_max = i;
            }
        }
        return i_max;
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
        //static int FindDiagonalMaxIndex(int[,] matrix)
        //{
        //    int i_max = 0, max = matrix[0, 0];
        //    for(int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        if (matrix[i, i] > max)
        //        {
        //            i_max = i;
        //            max= matrix[i, i];
        //        }
        //    }
        //    return i_max;
        //}
        for(int i=0;i<B.GetLength(0); i++)
        {
            int t = A[FindDiagonalMaxIndex(A), i];
            A[FindDiagonalMaxIndex(A), i] = B[i, FindDiagonalMaxIndex(B)];
            B[i, FindDiagonalMaxIndex(B)] = t;
        }
        // end
    }
    static int FindDiagonalMaxIndex(int[,] matrix)
    {
        int i_max = 0, max = matrix[0, 0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, i] > max)
            {
                i_max = i;
                max = matrix[i, i];
            }
        }
        return i_max;
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
        //static int FindMax(int[] array)
        //{
        //    int i_max = 0, max = array[0];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] > max)
        //        {
        //            i_max = i;
        //            max = array[i];
        //        }
        //    }
        //    return i_max;
        //}
        //static int[] DeleteElement(int[] array, int index)
        //{
        //    int[] arr = new int[array.Length-1];
        //    int control = 0;
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        if (i == index)
        //        {
        //            control++;
        //        }
        //        arr[i] = array[i + control];
        //    }
        //    return arr;
        //}
        int A_max=FindMax(A), B_max=FindMax(B);
        A=DeleteElement(A, A_max);
        B=DeleteElement(B, B_max);
        int[] answer = new int[A.Length + B.Length];
        for(int i = 0; i < A.Length; i++)
        {
            answer[i] = A[i];
        }
        for(int i=0; i<B.Length; i++)
        {
            answer[i + A.Length] = B[i];
        }
        A = answer;
        // end
    }
    static int FindMax(int[] array)
    {
        int i_max = 0, max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                i_max = i;
                max = array[i];
            }
        }
        return i_max;
    }
    static int[] DeleteElement(int[] array, int index)
    {
        int[] arr = new int[array.Length - 1];
        int control = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == index)
            {
                control++;
            }
            arr[i] = array[i + control];
        }
        return arr;
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
        //static int[] SortArrayPart(int[] array, int startIndex)
        //{
        //    int[] output = array;
        //    for(int i = startIndex; i < output.Length; i++)
        //    {
        //        for (int j = startIndex; j < output.Length - 1; j++)
        //        {
        //            if (output[j] > output[j + 1])
        //            {
        //                int t=output[j];
        //                output[j]=output[j + 1];
        //                output[j+1]=t;
        //            }
        //        }
        //    }
        //    return output;
        //}
        //static int FindMax(int[] array)
        //{
        //    int i_max = 0, max = array[0];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] > max)
        //        {
        //            i_max = i;
        //            max = array[i];
        //        }
        //    }
        //    return i_max;
        //}
        if (A.Length != 9 || B.Length != 11) return;
        A = SortArrayPart(A, FindMax(A)+1);
        B=SortArrayPart(B, FindMax(B)+1);
        foreach (int i in A) Console.Write($"{i} ");
        return;
        // end
    }
    static int[] SortArrayPart(int[] array, int startIndex)
    {
        int[] output = array;
        for (int i = startIndex; i < output.Length; i++)
        {
            for (int j = startIndex; j < output.Length - 1; j++)
            {
                if (output[j] > output[j + 1])
                {
                    int t = output[j];
                    output[j] = output[j + 1];
                    output[j + 1] = t;
                }
            }
        }
        return output;
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
        //static int[,] RemoveColumn(int[,] matrix, int columnIndex)
        //{
        //    int[,] output= new int[matrix.GetLength(0), matrix.GetLength(1)-1];
        //    for(int i = 0; i < output.GetLength(0); i++)
        //    {
        //        int control = 0;
        //        for(int j = 0; j < output.GetLength(1); j++)
        //        {
        //            if (j == columnIndex) control++;
        //            output[i,j]= matrix[i,j+control];
        //        }
        //    }
        //    return output;
        //}
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(0) != matrix.GetLength(1)) return;
        int j_low_max=0, j_high_min = 1, low_max = matrix[0,0], high_min= matrix[0,1], first, second;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (matrix[i, j] > low_max)
                {
                    j_low_max = j;
                    low_max = matrix[i, j];
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i+1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < high_min)
                {
                    j_high_min = j;
                    high_min = matrix[i, j];
                }
            }
        }
        //Console.WriteLine($"{j_low_max} {high_max}");
        if (j_low_max < j_high_min)
        {
            first=j_high_min;
            second=j_low_max;
        }
        else
        {
            first=j_low_max;
            second=j_high_min;
        }
        if (first == second)
        {
            matrix=RemoveColumn(matrix, first);
        }
        else
        {
            matrix=RemoveColumn(matrix, first);
            matrix= RemoveColumn(matrix, second);
        }
        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        Console.Write($"{matrix[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
        // end
    }
    static int[,] RemoveColumn(int[,] matrix, int columnIndex)
    {
        int[,] output = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        for (int i = 0; i < output.GetLength(0); i++)
        {
            int control = 0;
            for (int j = 0; j < output.GetLength(1); j++)
            {
                if (j == columnIndex) control++;
                output[i, j] = matrix[i, j + control];
            }
        }
        return output;
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
        //static int FindMaxColumnIndex(int[,] matrix)
        //{
        //    int j_max = 0, max = matrix[0, 0];
        //    for(int i=0; i < matrix.GetLength(0); i++)
        //    {
        //        for(int j = 0;j < matrix.GetLength(1); j++)
        //        {
        //            if (matrix[i, j] > max)
        //            {
        //                max = matrix[i, j];
        //                j_max = j;
        //            }
        //        }
        //    }
        //    return j_max;
        //}
        if (A == null || B == null || A.GetLength(0) == 0 || A.GetLength(1) == 0 || A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1)) return;
        int j_max_A= FindMaxColumnIndex(A), j_max_B= FindMaxColumnIndex(B);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int t = A[i, j_max_A];
            A[i, j_max_A] = B[i, j_max_B];
            B[i, j_max_B] = t;
        }
        //for (int i = 0; i < A.GetLength(0); i++)
        //{
        //    for (int j = 0; j < A.GetLength(1); j++)
        //    {
        //        Console.Write($"{A[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
        //for (int i = 0; i < B.GetLength(0); i++)
        //{
        //    for (int j = 0; j < B.GetLength(1); j++)
        //    {
        //        Console.Write($"{B[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
        // end
    }
    static int FindMaxColumnIndex(int[,] matrix)
    {
        int j_max = 0, max = matrix[0, 0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    j_max = j;
                }
            }
        }
        return j_max;
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
        //static int[,] SortRow(int[,] matrix, int rowIndex)
        //{
        //    int[,] output = matrix;
        //    for(int i = 0; i < matrix.GetLength(1); i++)
        //    {
        //        for(int j=0;  j < matrix.GetLength(1)-i-1; j++)
        //        {
        //            if (output[rowIndex, j] > output[rowIndex, j + 1])
        //            {
        //                int t = output[rowIndex, j + 1];
        //                output[rowIndex, j + 1] = output[rowIndex, j];
        //                output[rowIndex, j] = t;
        //            }
        //        }
        //    }
        //    return output;
        //}
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix=SortRow(matrix, i);
        }
        // end
    }
    static int[,] SortRow(int[,] matrix, int rowIndex)
    {
        int[,] output = matrix;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
            {
                if (output[rowIndex, j] > output[rowIndex, j + 1])
                {
                    int t = output[rowIndex, j + 1];
                    output[rowIndex, j + 1] = output[rowIndex, j];
                    output[rowIndex, j] = t;
                }
            }
        }
        return output;
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
        //static int[] SortNegative(int[] array)
        //{
        //    int[] output = array;
        //    int number = 0, count=0;
        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] < 0) number++;
        //    }
        //    int[] neg= new int[number];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] < 0)
        //        {
        //            neg[count] = i;
        //            count++;
        //        }
        //    }
        //    for (int i = 0; i < neg.Length; i++)
        //    {
        //        for (int j = 0; j < neg.Length - i - 1; j++)
        //        {
        //            if (output[neg[j]] < output[neg[j + 1]])
        //            {
        //                int t = output[neg[j]];
        //                output[neg[j]] = output[neg[j + 1]];
        //                output[neg[j + 1]] = t;
        //            }
        //        }
        //    }
        //    return output;
        //}
        if (A == null || B == null || A.Length == 0 || B.Length == 0) return;
        A = SortNegative(A);
        B=SortNegative(B);
        //foreach(int i in A) Console.WriteLine($"{i} ");
        // end
    }
    static int[] SortNegative(int[] array)
    {
        int[] output = array;
        int number = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) number++;
        }
        int[] neg = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                neg[count] = i;
                count++;
            }
        }
        for (int i = 0; i < neg.Length; i++)
        {
            for (int j = 0; j < neg.Length - i - 1; j++)
            {
                if (output[neg[j]] < output[neg[j + 1]])
                {
                    int t = output[neg[j]];
                    output[neg[j]] = output[neg[j + 1]];
                    output[neg[j + 1]] = t;
                }
            }
        }
        return output;
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
        //static int[,] SortDiagonal(int[,] matrix)
        //{
        //    int[,] output = matrix;
        //    for(int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for(int j = 0; j < matrix.GetLength(0) - i - 1; j++)
        //        {
        //            if (output[j, j] > output[j + 1, j + 1])
        //            {
        //                int t = output[j, j];
        //                output[j, j] = output[j + 1, j + 1];
        //                output[j + 1, j + 1] = t;
        //            }
        //        }
        //    }
        //    return output;
        //}
        A=SortDiagonal(A); B=SortDiagonal(B);
        // end
    }
    static int[,] SortDiagonal(int[,] matrix)
    {
        int[,] output = matrix;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
            {
                if (output[j, j] > output[j + 1, j + 1])
                {
                    int t = output[j, j];
                    output[j, j] = output[j + 1, j + 1];
                    output[j + 1, j + 1] = t;
                }
            }
        }
        return output;
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
        //static int[,] RemoveColumn(int[,] matrix, int columnIndex)
        //{
        //    int[,] output = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        //    for (int i = 0; i < output.GetLength(0); i++)
        //    {
        //        int control = 0;
        //        for (int j = 0; j < output.GetLength(1); j++)
        //        {
        //            if (j == columnIndex) control++;
        //            output[i, j] = matrix[i, j + control];
        //        }
        //    }
        //    return output;
        //}
        int control = 0;
        for(int j=0; j < A.GetLength(1); j++)
        {
            for(int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i,j]==0) control++;
            }
            if(control == 0)
            {
                A=RemoveColumn(A, j);
                j--;
            }
            control = 0;
        }
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (B[i, j] == 0) control++;
            }
            if (control == 0)
            {
                B = RemoveColumn(B, j);
                j--;
            }
            control = 0;
        }
        //for (int i = 0; i < A.GetLength(0); i++)
        //{
        //    for (int j = 0; j < A.GetLength(1); j++)
        //    {
        //        Console.Write($"{A[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
        //for (int i = 0; i < B.GetLength(0); i++)
        //{
        //    for (int j = 0; j < B.GetLength(1); j++)
        //    {
        //        Console.Write($"{B[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
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
        //static int CountNegativeInRow(int[,] matrix, int rowIndex)
        //{
        //    int count = 0;
        //    for(int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        if (matrix[rowIndex, j] < 0) count++;
        //    }
        //    return count;
        //}
        //static int[] FindMaxNegativePerColumn(int[,] matrix)
        //{
        //    int[] output=new int[matrix.GetLength(1)];
        //    for(int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        int max=0;
        //        for(int i = 0; i < matrix.GetLength(0); i++)
        //        {
        //            if (matrix[i, j] < 0)
        //            {
        //                max = matrix[i, j];
        //                break;
        //            }
        //        }
        //        for(int i = 0; i < matrix.GetLength(0); i++)
        //        {
        //            if (matrix[i, j] < 0 && matrix[i, j] > max)
        //            {
        //                max=matrix[i, j];
        //            }
        //        }
        //        output[j] = max;
        //    }
        //    return output;
        //}
        rows = new int[matrix.GetLength(0)];
        cols=new int[matrix.GetLength(1)];
        for(int i=0; i<matrix.GetLength(0); i++)
        {
            rows[i]=CountNegativeInRow(matrix,i);
        }
        cols = FindMaxNegativePerColumn(matrix);
        //foreach (int i in rows) Console.Write($"{i} ");
        //Console.WriteLine();
        //foreach (int j in cols) Console.Write($"{j} ");
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
        int[] output = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0)
                {
                    max = matrix[i, j];
                    break;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0 && matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
            output[j] = max;
        }
        return output;
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
        //static int FindMaxColumnIndex(int[,] matrix)
        //{
        //    int j_max = 0, max = matrix[0, 0];
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            if (matrix[i, j] > max)
        //            {
        //                max = matrix[i, j];
        //                j_max = j;
        //            }
        //        }
        //    }
        //    return j_max;
        //}
        //static int[,] SwapColumnDiagonal(int[,] matrix, int columnIndex)
        //{
        //    int[,] output = matrix;
        //    for(int i=0; i<matrix.GetLength(0); i++)
        //    {
        //        int t = output[i, i];
        //        output[i, i] = output[i, columnIndex];
        //        output[i, columnIndex] = t;
        //    }
        //    return output;
        //}
        A=SwapColumnDiagonal(A, FindMaxColumnIndex(A));
        B=SwapColumnDiagonal(B, FindMaxColumnIndex(B));
        // end
    }
    static int[,] SwapColumnDiagonal(int[,] matrix, int columnIndex)
    {
        int[,] output = matrix;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int t = output[i, i];
            output[i, i] = output[i, columnIndex];
            output[i, columnIndex] = t;
        }
        return output;
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
        //static int CountNegativeInRow(int[,] matrix, int rowIndex)
        //{
        //    int count = 0;
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        if (matrix[rowIndex, j] < 0) count++;
        //    }
        //    return count;
        //}
        //static int FindRowWithMaxNegativeCount(int[,] matrix)
        //{
        //    int output = 0, count=0;
        //    for(int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        if (CountNegativeInRow(matrix, i) > count)
        //        {
        //            output = i;
        //            count = CountNegativeInRow(matrix, i);
        //        }
        //    }
        //    return output;
        //}
        for(int j=0;j<A.GetLength(1); j++)
        {
            int t = A[FindRowWithMaxNegativeCount(A), j];
            A[FindRowWithMaxNegativeCount(A), j] = B[FindRowWithMaxNegativeCount(B), j];
            B[FindRowWithMaxNegativeCount(B), j] = t;
        }
        // end
    }
    static int FindRowWithMaxNegativeCount(int[,] matrix)
    {
        int output = 0, count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (CountNegativeInRow(matrix, i) > count)
            {
                output = i;
                count = CountNegativeInRow(matrix, i);
            }
        }
        return output;
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
        //static int FindSequence(int[] array, int A, int B)
        //{
        //    int output, count1=0, count2=0;
        //    for(int i=A; i <= B-1; i++)
        //    {
        //        if (array[i] >= array[i + 1]) count1++;
        //        if (array[i] <= array[i + 1]) count2++;
        //    }
        //    if (count1 == B-A) return output = -1;
        //    if (count2 == B-A) return output = 1;
        //    return output = 0;
        //}
        answerFirst = FindSequence(first, 0, first.Length-1);
        answerSecond = FindSequence(second, 0, second.Length-1);
        // end
    }
    static int FindSequence(int[] array, int A, int B)
    {
        int output, count1 = 0, count2 = 0;
        for (int i = A; i <= B - 1; i++)
        {
            if (array[i] >= array[i + 1]) count1++;
            if (array[i] <= array[i + 1]) count2++;
        }
        if (count1 == B - A) return output = -1;
        if (count2 == B - A) return output = 1;
        return output = 0;
    }
    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a
        // A and B - start and end indexes of elements from array for search
        //static int FindSequence(int[] array, int A, int B)
        //{
        //    int output, count1 = 0, count2 = 0;
        //    for (int i = A; i <= B - 1; i++)
        //    {
        //        if (array[i] >= array[i + 1]) count1++;
        //        if (array[i] <= array[i + 1]) count2++;
        //    }
        //    if (count1 == B-A) return output = -1;
        //    if (count2 == B-A) return output = 1;
        //    return output = 0;
        //}
        //static int[,] AllIntervalsOfMonotonicity(int[] array)
        //{
        //    int[,] matrix = new int[(array.Length-1)*array.Length/2, 2];
        //    int count = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = i + 1; j < array.Length; j++)
        //        {
        //            if (FindSequence(array, i, j) != 0)
        //            {
        //                matrix[count, 0] = i;
        //                matrix[count, 1] = j;
        //                count++;
        //            }
        //        }
        //    }
        //    int[,] output = new int[count, 2];
        //    for(int i = 0; i < count; i++)
        //    {
        //        output[i, 0] = matrix[i, 0];
        //        output[i,1]=matrix[i, 1];

        //    }
        //    return output;
        //}
        answerFirst = AllIntervalsOfMonotonicity(first);
        answerSecond= AllIntervalsOfMonotonicity(second);
        //Console.WriteLine(answerFirst.GetLength(0));
        //for (int i = 0; i < answerFirst.GetLength(0); i++)
        //{
        //    for (int j = 0; j < answerFirst.GetLength(1); j++)
        //    {
        //        Console.Write($"{answerFirst[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
        //for (int i = 0; i < answerSecond.GetLength(0); i++)
        //{
        //    for (int j = 0; j < answerSecond.GetLength(1); j++)
        //    {
        //        Console.Write($"{answerSecond[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
        // end
    }
    //static int FindSequence(int[] array, int A, int B)
    //{
    //    int output, count1 = 0, count2 = 0;
    //    for (int i = A; i <= B - 1; i++)
    //    {
    //        if (array[i] >= array[i + 1]) count1++;
    //        if (array[i] <= array[i + 1]) count2++;
    //    }
    //    if (count1 == B - A) return output = -1;
    //    if (count2 == B - A) return output = 1;
    //    return output = 0;
    //}
    static int[,] AllIntervalsOfMonotonicity(int[] array)
    {
        int[,] matrix = new int[(array.Length - 1) * array.Length / 2, 2];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (FindSequence(array, i, j) != 0)
                {
                    matrix[count, 0] = i;
                    matrix[count, 1] = j;
                    count++;
                }
            }
        }
        int[,] output = new int[count, 2];
        for (int i = 0; i < count; i++)
        {
            output[i, 0] = matrix[i, 0];
            output[i, 1] = matrix[i, 1];

        }
        return output;
    }
    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here

        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
        // A and B - start and end indexes of elements from array for search
        static int FindSequence(int[] array, int A, int B)
        {
            int output, count1 = 0, count2 = 0;
            for (int i = A; i <= B - 1; i++)
            {
                if (array[i] >= array[i + 1]) count1++;
                if (array[i] <= array[i + 1]) count2++;
            }
            if (count1 == B - A) return output = -1;
            if (count2 == B - A) return output = 1;
            return output = 0;
        }
        static int[] LongestIntervalOfMonotonicity(int[] array)
        {
            int[] output = new int[2];
            int count = 0, max_length=0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (FindSequence(array, i, j) != 0)
                    {
                        if (j - i > max_length)
                        {
                            output[0] = i;
                            output[1] = j;
                            max_length = j - i;
                        }
                    }
                }
            }
            return output;
        }
        answerFirst = LongestIntervalOfMonotonicity(first);
        answerSecond = LongestIntervalOfMonotonicity(second);
        // end
    }
    static int[] LongestIntervalOfMonotonicity(int[] array)
    {
        int[] output = new int[2];
        int count = 0, max_length = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (FindSequence(array, i, j) != 0)
                {
                    if (j - i > max_length)
                    {
                        output[0] = i;
                        output[1] = j;
                        max_length = j - i;
                    }
                }
            }
        }
        return output;
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

    public delegate int[,] SortRowStyle(int[,] matrix, int rowIndex);
    public void Task_3_2(int[,] matrix)
    {
        SortRowStyle sortStyle = default(SortRowStyle);

        // code here

        // create and use public delegate SortRowStyle(matrix, rowIndex);
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        // change method in variable sortStyle in the loop here and use it for row sorting
        //delegate int[,] SortRowStyle(int[,] matrix, int rowIndex);
        //static int[,] SortAscending(int[,] matrix, int rowIndex)
        //{
        //    int[,] output = matrix;
        //    for(int i = 0; i < matrix.GetLength(1); i++)
        //    {
        //        for(int j = 0; j < matrix.GetLength(1)-i-1; j++)
        //        {
        //            if (matrix[rowIndex, j] > matrix[rowIndex, j + 1])
        //            {
        //                int t = matrix[rowIndex, j];
        //                matrix[rowIndex, j] = matrix[rowIndex, j + 1];
        //                matrix[rowIndex, j + 1] = t;
        //            }
        //        }
        //    }
        //    return output;
        //}
        //static int[,] SortDescending(int[,] matrix, int rowIndex)
        //{
        //    int[,] output = matrix;
        //    for (int i = 0; i < matrix.GetLength(1); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
        //        {
        //            if (matrix[rowIndex, j] < matrix[rowIndex, j + 1])
        //            {
        //                int t = matrix[rowIndex, j];
        //                matrix[rowIndex, j] = matrix[rowIndex, j + 1];
        //                matrix[rowIndex, j + 1] = t;
        //            }
        //        }
        //    }
        //    return output;
        //}
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0) sortStyle = SortAscending;
            else sortStyle = SortDescending;
            matrix = sortStyle(matrix, i);
        }
        // end
    }
    static int[,] SortAscending(int[,] matrix, int rowIndex)
    {
        int[,] output = matrix;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
            {
                if (matrix[rowIndex, j] > matrix[rowIndex, j + 1])
                {
                    int t = matrix[rowIndex, j];
                    matrix[rowIndex, j] = matrix[rowIndex, j + 1];
                    matrix[rowIndex, j + 1] = t;
                }
            }
        }
        return output;
    }
    static int[,] SortDescending(int[,] matrix, int rowIndex)
    {
        int[,] output = matrix;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
            {
                if (matrix[rowIndex, j] < matrix[rowIndex, j + 1])
                {
                    int t = matrix[rowIndex, j];
                    matrix[rowIndex, j] = matrix[rowIndex, j + 1];
                    matrix[rowIndex, j + 1] = t;
                }
            }
        }
        return output;
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
    public int Task_3_4(int[,] matrix, bool isUpperTriangle)
    {
        int answer = 0;

        // code here

        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // create and use GetSum(GetTriangle, matrix)
        GetTriangle triangleType=default(GetTriangle);
        //static int[] GetUpperTriangle(int[,] matrix)
        //{
        //    int[] output = new int[matrix.GetLength(0)*(matrix.GetLength(0)+1)/2];
        //    int count = 0;
        //    for (int i = 0; i < matrix.GetLength(0); i++) 
        //    {
        //        for (int j = i; j < matrix.GetLength(1); j++)
        //        {
        //            output[count] = matrix[i, j];
        //            count++;
        //        }
        //    }
        //    return output;
        //}
        //static int[] GetLowerTriangle(int[,] matrix)
        //{
        //    int[] output = new int[matrix.GetLength(0) * (matrix.GetLength(0) + 1) / 2];
        //    int count = 0;
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j <= i; j++)
        //        {
        //            output[count] = matrix[i, j];
        //            count++;
        //        }
        //    }
        //    return output;
        //}
        //static int GetSum(GetTriangle triangle, int[,] matrix)
        //{
        //    int sum = 0;
        //    foreach (int x in triangle(matrix)) sum += x * x;
        //    return sum;
        //}
        if (isUpperTriangle) triangleType = GetUpperTriangle;
        else triangleType = GetLowerTriangle;
        answer = GetSum(triangleType, matrix);
        // end

        return answer;
    }
    static int[] GetUpperTriangle(int[,] matrix)
    {
        int[] output = new int[matrix.GetLength(0) * (matrix.GetLength(0) + 1) / 2];
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                output[count] = matrix[i, j];
                count++;
            }
        }
        return output;
    }
    static int[] GetLowerTriangle(int[,] matrix)
    {
        int[] output = new int[matrix.GetLength(0) * (matrix.GetLength(0) + 1) / 2];
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j <= i; j++)
            {
                output[count] = matrix[i, j];
                count++;
            }
        }
        return output;
    }
    static int GetSum(GetTriangle triangle, int[,] matrix)
    {
        int sum = 0;
        foreach (int x in triangle(matrix)) sum += x * x;
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

    public delegate int FindElementDelegate(int[,] matrix);
    public void Task_3_6(int[,] matrix)
    {
        // code here

        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) like in Task_2_3;
        // create and use method FindFirstRowMaxIndex(matrix);
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);
        //static int FindDiagonalMaxIndex(int[,] matrix)
        //{
        //    int output = 0, max = matrix[0, 0];
        //    for(int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        if (matrix[i, i] > max)
        //        {
        //            max = matrix[i, i];
        //            output = i;
        //        }
        //    }
        //    return output;
        //}
        //static int FindFirstRowlMaxIndex(int[,] matrix)
        //{
        //    int output = 0, max = matrix[0, 0];
        //    for (int i = 0; i < matrix.GetLength(1); i++)
        //    {
        //        if (matrix[0, i] > max)
        //        {
        //            max = matrix[0, i];
        //            output = i;
        //        }
        //    }
        //    return output;
        //}
        //static int[,] SwapColumns(int[,] matrix, FindElementDelegate col1, FindElementDelegate col2)
        //{
        //    int[,] output = matrix;
        //    int column1=col1(matrix), column2=col2(matrix);
        //    for(int i=0; i < matrix.GetLength(0); i++)
        //    {
        //        int t = output[i, column1];
        //        output[i, column1] = output[i, column2];
        //        output[i, column2] = t;
        //    }
        //    return output;
        //}
        matrix = SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowlMaxIndex);
        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        Console.Write($"{matrix[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
        // end
    }
    //static int FindDiagonalMaxIndex(int[,] matrix)
    //{
    //    int output = 0, max = matrix[0, 0];
    //    for (int i = 0; i < matrix.GetLength(0); i++)
    //    {
    //        if (matrix[i, i] > max)
    //        {
    //            max = matrix[i, i];
    //            output = i;
    //        }
    //    }
    //    return output;
    //}
    static int FindFirstRowlMaxIndex(int[,] matrix)
    {
        int output = 0, max = matrix[0, 0];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (matrix[0, i] > max)
            {
                max = matrix[0, i];
                output = i;
            }
        }
        return output;
    }
    static int[,] SwapColumns(int[,] matrix, FindElementDelegate col1, FindElementDelegate col2)
    {
        int[,] output = matrix;
        int column1 = col1(matrix), column2 = col2(matrix);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int t = output[i, column1];
            output[i, column1] = output[i, column2];
            output[i, column2] = t;
        }
        return output;
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
    public void Task_3_10(ref int[,] matrix)
    {
        // FindIndex searchArea = default(FindIndex); - uncomment me

        // code here

        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        // create and use method FindMinAboveDiagonalIndex(matrix);
        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)
        //static int[,] RemoveColumn(int[,] matrix, int columnIndex)
        //{
        //    int[,] output = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        //    for (int i = 0; i < output.GetLength(0); i++)
        //    {
        //        int control = 0;
        //        for (int j = 0; j < output.GetLength(1); j++)
        //        {
        //            if (j == columnIndex) control++;
        //            output[i, j] = matrix[i, j + control];
        //        }
        //    }
        //    return output;
        //}
        //static int FindMaxBelowDiagonalIndex(int[,] matrix)
        //{
        //    int j_low_max = 0, low_max = matrix[0, 0];
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j <= i; j++)
        //        {
        //            if (matrix[i, j] > low_max)
        //            {
        //                j_low_max = j;
        //                low_max = matrix[i, j];
        //            }
        //        }
        //    }
        //    return j_low_max;
        //}
        //static int FindMinAboveDiagonalIndex(int[,] matrix)
        //{
        //    int j_high_min=1, high_min=matrix[0, 1];
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = i + 1; j < matrix.GetLength(1); j++)
        //        {
        //            if (matrix[i, j] < high_min)
        //            {
        //                j_high_min = j;
        //                high_min = matrix[i, j];
        //            }
        //        }
        //    }
        //    return j_high_min;
        //}
        //static int[,] RemoveColumns(int[,] matrix, FindIndex col1, FindIndex col2)
        //{
        //    int[,] output = matrix;
        //    int column1=col1(matrix), column2=col2(matrix), first, second;
        //    if (column1 > column2)
        //    {
        //        first = column1;
        //        second=column2;
        //    }
        //    else
        //    {
        //        second = column1;
        //        first = column2;
        //    }
        //    if (first == second) output = RemoveColumn(matrix, first);
        //    else
        //    {
        //        output = RemoveColumn(output, first);
        //        output=RemoveColumn(output, second);
        //    }
        //    return output;
        //}
        matrix = RemoveColumns(matrix, FindMaxBelowDiagonalIndex, FindMinAboveDiagonalIndex);
        //static int[,] RemoveColumns(int[,] matrix, )
        // end
    }
    static int FindMaxBelowDiagonalIndex(int[,] matrix)
    {
        int j_low_max = 0, low_max = matrix[0, 0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (matrix[i, j] > low_max)
                {
                    j_low_max = j;
                    low_max = matrix[i, j];
                }
            }
        }
        return j_low_max;
    }
    static int FindMinAboveDiagonalIndex(int[,] matrix)
    {
        int j_high_min = 1, high_min = matrix[0, 1];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < high_min)
                {
                    j_high_min = j;
                    high_min = matrix[i, j];
                }
            }
        }
        return j_high_min;
    }
    static int[,] RemoveColumns(int[,] matrix, FindIndex col1, FindIndex col2)
    {
        int[,] output = matrix;
        int column1 = col1(matrix), column2 = col2(matrix), first, second;
        if (column1 > column2)
        {
            first = column1;
            second = column2;
        }
        else
        {
            second = column1;
            first = column2;
        }
        if (first == second) output = RemoveColumn(matrix, first);
        else
        {
            output = RemoveColumn(output, first);
            output = RemoveColumn(output, second);
        }
        return output;
    }
    public void Task_3_13(ref int[,] matrix)
    {
        // code here

        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)

        // end
    }

    public delegate int[] GetNegativeArray(int[,] matrix);
    public void Task_3_22(int[,] matrix, out int[] rows, out int[] cols)
    {

        rows = null;
        cols = null;

        // code here

        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22
        // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);
        //static int[] GetNegativeCountPerRow(int[,] matrix)
        //{
        //    int[] output = new int[matrix.GetLength(0)];
        //    for(int i=0; i < matrix.GetLength(0); i++)
        //    {
        //        int count = 0;
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            if (matrix[i, j] < 0) count++;
        //        }
        //        output[i] = count;
        //    }
        //    return output;
        //}
        //static int[] GetMaxNegativePerColumn(int[,] matrix)
        //{
        //    int[] output = new int[matrix.GetLength(1)];
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        int max = 0;
        //        for (int i = 0; i < matrix.GetLength(0); i++)
        //        {
        //            if (matrix[i, j] < 0)
        //            {
        //                max = matrix[i, j];
        //                break;
        //            }
        //        }
        //        for (int i = 0; i < matrix.GetLength(0); i++)
        //        {
        //            if (matrix[i, j] < 0 && matrix[i, j] > max)
        //            {
        //                max = matrix[i, j];
        //            }
        //        }
        //        output[j] = max;
        //    }
        //    return output;
        //}
        //static void FindNegatives(int[,] matrix, GetNegativeArray searcherRows,  GetNegativeArray searcherCols, out int[] rows, out int[] cols)
        //{
        //    rows = searcherRows(matrix);
        //    cols = searcherCols(matrix);
        //}
        FindNegatives(matrix, GetNegativeCountPerRow, GetMaxNegativePerColumn, out rows, out cols);
        // end
    }
    static int[] GetNegativeCountPerRow(int[,] matrix)
    {
        int[] output = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0) count++;
            }
            output[i] = count;
        }
        return output;
    }
    static int[] GetMaxNegativePerColumn(int[,] matrix)
    {
        int[] output = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0)
                {
                    max = matrix[i, j];
                    break;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0 && matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
            output[j] = max;
        }
        return output;
    }
    static void FindNegatives(int[,] matrix, GetNegativeArray searcherRows, GetNegativeArray searcherCols, out int[] rows, out int[] cols)
    {
        rows = searcherRows(matrix);
        cols = searcherCols(matrix);
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

    public delegate int IsSequence(int[] array, int left, int right);
    public void Task_3_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here

        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);
        //static int FindIncreasingSequence(int[] array, int A, int B)
        //{
        //    int output, count2 = 0 ;
        //    for (int i = A; i <= B - 1; i++)
        //    {
        //        if (array[i] <= array[i + 1]) count2++;
        //    }
        //    if (count2 == B - A) return output = 1;
        //    return output = 0;
        //}
        //static int FindDecreasingSequence(int[] array, int A, int B)
        //{
        //    int output, count2 = 0;
        //    for (int i = A; i <= B - 1; i++)
        //    {
        //        if (array[i] >= array[i + 1]) count2++;
        //    }
        //    if (count2 == B - A) return output = -1;
        //    return output = 0;
        //}
        //static int DefineSequence(int[] array, IsSequence Incr, IsSequence Decr)
        //{
        //    int output;
        //    if (Incr(array, 0, array.Length - 1) == 1) return output = 1;
        //    if (Decr(array, 0, array.Length - 1) == -1) return output = -1;
        //    return output = 0;
        //}
        answerFirst = DefineSequence(first, FindIncreasingSequence, FindDecreasingSequence);
        answerSecond = DefineSequence(second, FindIncreasingSequence, FindDecreasingSequence);
        // end
    }
    static int FindIncreasingSequence(int[] array, int A, int B)
    {
        int output, count2 = 0;
        for (int i = A; i <= B - 1; i++)
        {
            if (array[i] <= array[i + 1]) count2++;
        }
        if (count2 == B - A) return output = 1;
        return output = 0;
    }
    static int FindDecreasingSequence(int[] array, int A, int B)
    {
        int output, count2 = 0;
        for (int i = A; i <= B - 1; i++)
        {
            if (array[i] >= array[i + 1]) count2++;
        }
        if (count2 == B - A) return output = -1;
        return output = 0;
    }
    static int DefineSequence(int[] array, IsSequence Incr, IsSequence Decr)
    {
        int output;
        if (Incr(array, 0, array.Length - 1) == 1) return output = 1;
        if (Decr(array, 0, array.Length - 1) == -1) return output = -1;
        return output = 0;
    }
    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here

        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);
        //static int FindIncreasingSequence(int[] array, int A, int B)
        //{
        //    int output, count2 = 0;
        //    for (int i = A; i <= B - 1; i++)
        //    {
        //        if (array[i] <= array[i + 1]) count2++;
        //    }
        //    if (count2 == B - A) return output = 1;
        //    return output = 0;
        //}
        //static int FindDecreasingSequence(int[] array, int A, int B)
        //{
        //    int output, count2 = 0;
        //    for (int i = A; i <= B - 1; i++)
        //    {
        //        if (array[i] >= array[i + 1]) count2++;
        //    }
        //    if (count2 == B - A) return output = -1;
        //    return output = 0;
        //}
        //static int[] FindLongestSequence(int[] array, IsSequence seq)
        //{
        //    int[] output = new int[2];
        //    int count = 0, max_length = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = i + 1; j < array.Length; j++)
        //        {
        //            if (seq(array, i, j) != 0)
        //            {
        //                if (j - i > max_length)
        //                {
        //                    output[0] = i;
        //                    output[1] = j;
        //                    max_length = j - i;
        //                }
        //            }
        //        }
        //    }
        //    return output;
        //}
        answerFirstIncrease = FindLongestSequence(first, FindIncreasingSequence);
        answerFirstDecrease= FindLongestSequence(first, FindDecreasingSequence);
        answerSecondIncrease= FindLongestSequence(second, FindIncreasingSequence);
        answerSecondDecrease= FindLongestSequence(second,FindDecreasingSequence);
        // end
    }
    static int[] FindLongestSequence(int[] array, IsSequence seq)
    {
        int[] output = new int[2];
        int count = 0, max_length = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (seq(array, i, j) != 0)
                {
                    if (j - i > max_length)
                    {
                        output[0] = i;
                        output[1] = j;
                        max_length = j - i;
                    }
                }
            }
        }
        return output;
    }
    #endregion
    #region bonus part
    public double[,] Task_4(double[,] matrix, int index)
    {
        // MatrixConverter[] mc = new MatrixConverter[4]; - uncomment me

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
