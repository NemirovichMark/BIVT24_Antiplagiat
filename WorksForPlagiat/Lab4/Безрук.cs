using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                answer += A[i, j];
            }
        }
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here
        int minValue = int.MaxValue;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < minValue)
                {
                    minValue = A[i, j];
                    row = i; col = j;
                }
            }
        }
        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        
        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        answer = new int[A.GetLength(1)];
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) return default;
        int IndAnswer = 0;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxValue = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                }
            }
            answer[IndAnswer] = maxValue;
            IndAnswer++;
        }
        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;
        int maxValue = int.MinValue, ind_i = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 2] > maxValue)
            {
                maxValue = A[i, 2];
                ind_i = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            (A[3, j], A[ind_i, j]) = (A[ind_i, j], A[3, j]);
        }
        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5) return default;
        int maxValue = int.MinValue, ind_i = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > maxValue)
            {
                maxValue = A[i, i];
                ind_i = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            (A[j, 3], A[j, ind_i]) = (A[j, ind_i], A[j, 3]);
        }
        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here
        if (A.GetLength(0) != n || A.GetLength(1) != m) return default;
        int maxValue = int.MinValue, ind_j = 0, znach = 0;
        for (int i = 0; i < n; i++)
        {
            maxValue = int.MinValue;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                    ind_j = j;
                }
            }
            if (ind_j != m - 1)
            {
                znach = A[i, ind_j];
                for (int j = ind_j; j < m - 1; j++)
                {
                    A[i, j] = A[i, j + 1];
                }
                A[i, m - 1] = znach;
            }
        }
        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here
        if (C.GetLength(0) != n || C.GetLength(1) != m) return default;
        for (int i = 0; i < n; i++)
        {
            double maxValue = C[i, 0], ind_j = 0;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > maxValue)
                {
                    maxValue = C[i, j];
                    ind_j = j;
                }
            }
            if (maxValue != 0)
            {
                for (int j = 0; j < ind_j; j++)
                {
                    if (C[i, j] < 0)
                    {
                        C[i, j] /= maxValue;
                    }
                }
            }
        }
        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return default;
        double maxValue = double.MinValue, avarage = 0;
        int count = 0, ind_j = 0, ind_i = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > maxValue)
                {
                    maxValue = Z[i, j];
                    ind_j = j;
                    ind_i = i;
                }

                if (Z[i, j] > 0)
                {
                    avarage += Z[i, j];
                    count++;
                }
            }
        }
        avarage = avarage / count;
        Z[ind_i, ind_j] = avarage;
        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5) return default;
        // n = X.GetLength(0), m = X.GetLength(1)
        int max_n = 0, min_n = X.GetLength(1), max_i = 0, min_i = 0, znach = 0;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int max_count = 0, min_count = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if ((X[i, j] < 0))
                {
                    max_count++;
                    min_count++;

                }
            }
            if (max_count > max_n)
            {
                max_n = max_count;
                min_i = i;
            }
            if (min_count < min_n)
            {
                min_n = min_count;
                max_i = i;
            }
        }
        for (int j = 0; j < X.GetLength(1); j++)
        {
            znach = X[min_i, j];
            X[min_i, j] = X[max_i, j];
            X[max_i, j] = znach;
        }
        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default;
        int maxSumm = int.MinValue, max_i = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int summ = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    summ += A[i, j];
                }

                if (summ > maxSumm)
                {
                    maxSumm = summ;
                    max_i = i;
                }
            }
        }
        if (max_i == -1) return default;
        int count = 0;
        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (i == max_i)
            {
                count++;
                continue;
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                B[i - count, j] = A[i, j];
            }
        }
        A = B;
        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) return default;
        int min4i = A[4, 0], min4j = 0;
        for (int j = 1; j < A.GetLength(1); j++)
        {
            if (A[4, j] < min4i)
            {
                min4i = A[4, j];
                min4j = j;
            }
        }
        for (int j = A.GetLength(1) - 1; j > min4j + 1; j--)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A[i, j] = A[i, j - 1];
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            A[i, min4j + 1] = B[i];
        }
        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double maxValue = A[i, 0];
            int maxInd_i = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                    maxInd_i = j;

                }
            }
            if (maxInd_i == 0) A[i, 1] *= 2;

            if (maxInd_i == A.GetLength(1) - 1) A[i, A.GetLength(1) - 2] *= 2;

            if (maxInd_i != 0 && maxInd_i != A.GetLength(1) - 1)
            {
                if (A[i, maxInd_i - 1] > A[i, maxInd_i + 1])
                {
                    if (A[i, maxInd_i + 1] > 0) A[i, maxInd_i + 1] *= 2;

                    else A[i, maxInd_i + 1] /= 2;
                }
                else
                {
                    if (A[i, maxInd_i - 1] > 0) A[i, maxInd_i - 1] *= 2;

                    else A[i, maxInd_i - 1] /= 2;

                }
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxCount = 0, minCount = 0, maxElem = A[0, j], maxInd_i = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0) minCount++;

                else if (A[i, j] > 0) maxCount++;

                if (A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    maxInd_i = i;
                }
            }
            if (maxCount > minCount) A[maxInd_i, j] = 0;

            else A[maxInd_i, j] = maxInd_i + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return default;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int  maxElem = A[0, j], summ = 0, ind_i = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    ind_i = i;
                }
            }
            if (ind_i < A.GetLength(0) / 2)
            {
                for (int i = ind_i + 1; i < A.GetLength(0); i++)
                {
                    summ += A[i, j];
                }
                A[0, j] = summ;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return default;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxElem = A[0, j], ind_i = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    ind_i = i;
                }
            }
            if (A[ind_i, j] < B[j]) A[ind_i, j] = B[j]; 
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double maxElem = A[0, j], summ = 0;
            int ind_i = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxElem)
                {
                    maxElem = A[i, j];
                    ind_i = i;
                }
            }
            summ = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;

            if (summ > A[ind_i, j]) A[ind_i, j] = summ; 

            else A[ind_i, j] = ind_i + 1; 
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        int n2 = n * 3;
        if (n != 3 || n2 != 9) return default;
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)  answer[i, j] = 1;

                if (i == j) answer[i, j + n] = 1;

                if (i == j) answer[i, j + 2 * n] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return default;
        int max = -100000, ind_i = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];

                    ind_i = i;
                }
            }
        }
        for (int i = 0; i < ind_i; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++)
            {
                A[i, j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return default;
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int maxElem1 = int.MinValue, maxElem2 = int.MinValue, j1 = 0, j2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > maxElem1)
                {
                    maxElem1 = B[i, j];
                    j1 = j;
                }
                if (B[i + 1, j] > maxElem2)
                {
                    maxElem2 = B[i + 1, j];
                    j2 = j;
                }
            }
            (B[i, j1], B[i + 1, j2]) = (B[i + 1, j2], B[i, j1]);
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return default;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                (A[i, j], A[i, A.GetLength(1) - j - 1]) = (A[i, A.GetLength(1) - j - 1], A[i, j]);
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return default;
        int[] array = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int ind_j = 0, minValue = int.MaxValue;
            for (int j = 1; j < matrix.GetLength(1); j++)
                if (matrix[i, j] < minValue)
                {
                    minValue = matrix[i, j];
                    ind_j = j;
                }
            array[i] = matrix[i, ind_j];
        }
        for (int x = 1; x < matrix.GetLength(0); x++)
        {
            int i = x;
            while (i > 0 && array[i - 1] < array[i])
            {
                (array[i - 1], array[i]) = (array[i], array[i - 1]);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    (matrix[i - 1, j], matrix[i, j]) = (matrix[i, j], matrix[i - 1, j]);
                }
                i--;
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here
        int n = matrix.GetLength(0);
        answer = new int[2 * n - 1];
        if (matrix.GetLength(0) != matrix.GetLength(1)) return default;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int ind = j - i + (n - 1);
                answer[ind] += matrix[i, j];
            }
        }
        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1) || k < 1 || k > matrix.GetLength(0)) return default;
        int max = int.MinValue, ind_i = 0, ind_j = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    ind_j = j;
                    ind_i = i;
                }
            }
        }
        if (ind_i == k - 1 && ind_j == k - 1)
            return matrix;
        if (ind_j != k - 1)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                (matrix[k - 1, j],  matrix[ind_i, j]) = (matrix[ind_i, j], matrix[k - 1, j]);
            }
        }
        if (ind_i != k - 1)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                (matrix[i, k - 1], matrix[i, ind_j]) = (matrix[i, ind_j], matrix[i, k - 1]);
            }
        }
        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here

        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here
        if (A.Length <= 0 || B.Length <= 0 || A.Length != B.Length) return default;
        int[,] a = new int[n, n];
        int[,] b = new int[n, n];
        int ind = 0;
        int[] c = new int[n * n];
        for (int i = 0; i < n; i = i + 1)
        {
            for (int j = i; j < n; j = j + 1)
            {
                a[i, j] = A[ind];
                a[j, i] = A[ind];
                b[i, j] = B[ind];
                b[j, i] = B[ind];
                ind++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int f = 0; f < n; f++)
                {
                    c[i * n + j] = c[i * n + j] + a[i, f] * b[f, j];
                }
            }
        }
        answer = c;
        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return default;
        int[] a = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0)
                    count++;
            }
            a[j] = count;
        }
        for (int x = 1; x < matrix.GetLength(1); x++)
        {
            int j = x;
            while (j > 0 && a[j - 1] > a[j])
            {
                (a[j - 1], a[j]) = (a[j], a[j - 1]);
                for (int l = 0; l < matrix.GetLength(0); l++)
                {
                    (matrix[l, j - 1], matrix[l, j]) = (matrix[l, j], matrix[l, j - 1]);
                }
                j--;
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) <= 0 || matrix.GetLength(1) <= 0) return default;
        int n = matrix.GetLength(0) - 1, count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                    break;
                }
            }
        }
        int[,] a = new int[n - count, matrix.GetLength(1)];
        int k = 0;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0) break;
                a[k, j] = matrix[i, j];
            }
            k++;
            if (k >= matrix.GetLength(0) - count)
            {
                break;
            }

        }
        matrix = a;
        // end

        return matrix;
    }
    #endregion
}