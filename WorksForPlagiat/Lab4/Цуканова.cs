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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
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
        if (A.GetLength(0) != 3 || A.GetLength(1) != 6) return (row, col);
        int n = A.GetLength(0);
        int m = A.GetLength(1), k = A[0, 0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] < k)
                {
                    row = i; col = j;
                    k = A[i, j];
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
        int[] answer = new int[A.GetLength(1)];
        // code here
        int r = A.GetLength(0);
        int c = A.GetLength(1);
        int max = int.MinValue;
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < c; j++)
        {
            for (int i = 0; i < r; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                }
            }
            answer[j] = max;
            max = int.MinValue;
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
        int r = A.GetLength(0);
        int c = A.GetLength(1);
        int max = int.MinValue, ind = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < r; i++)
        {
            if (A[i, 2] < max)
            {
                max = A[i, 2];
                ind = i;
            }
        }
        if (ind != 3)
        {
            for (int j = 0; j < c; j++)
            {
                int t = A[ind, j];
                A[ind, j] = A[3, j];
                A[3, j] = t;
            }
        }
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
        int r = A.GetLength(0);
        int c = A.GetLength(1);
        int max = int.MinValue, ind = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5) return null;
        for (int i = 1; i < A.GetLength(1); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                ind = i;
            }
        }
        if (ind != 3)
        {
            for (int j = 0; j < A.GetLength(0); j++)
            {
                int temp = A[j, 3]; 
                A[j, 3] = A[j, ind];
                A[j, ind] = temp;
            }
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
        for (int i = 0; i < n; i++)
        {
            int max = int.MinValue, ind = -1;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = j;
                }
            }
            if (max != m - 1 && ind != -1)
            {
                for (int j = ind; j < m - 1; j++)
                {
                    A[i, j] = A[i, j + 1];
                }
                A[i, m - 1] = max;
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
        for (int i = 0; i < n; i++)
        {
            double max = int.MinValue;
            int ind = -1;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > max)
                {
                    max = C[i, j];
                    ind = j;
                }
            }
            if (ind != 0)
            {
                for (int k = 0; k < ind; k++)
                {
                    if (C[i, k] < 0)
                    {
                        C[i, k] = C[i, k] / max;
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
        int n = Z.GetLength(0);
        int m = Z.GetLength(1);
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return null;
        double sr, sum = 0, kolv = 0;
        double max = int.MinValue;
        int ind = -1, ind1 = -1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (Z[i, j] > max)
                {
                    max = Z[i, j];
                    ind = j;
                    ind1 = i;
                }
                if (Z[i, j] > 0)
                {
                    sum += Z[i, j];
                    kolv += 1;
                }
            }
        }
        if (kolv != 0 && ind1 != -1 && ind != -1)
        {
            sr = sum / kolv;
            Z[ind1, ind] = sr;
        }
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
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5) return null;
        int min1 = int.MaxValue;
        int min2 = 0;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int c = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                {
                    c++;
                }
            }
            if (c < min1)
            {
                min1 = c;
                min2 = i;
            }
        }
        int max1 = int.MinValue;
        int max2 = 0;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int c = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                {
                    c++;
                }
            }
            if (c > max1)
            {
                max1 = c;
                max2 = i;
            }
        }
        for (int i = 0; i < X.GetLength(1); i++)
        {
            int t = X[min2, i];
            X[min2, i] = X[max2, i];
            X[max2, i] = t;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        int maxsum = int.MinValue, ind = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }
            }
            if (sum > maxsum)
            {
                maxsum = sum;
                ind = i;
            }
        }
        int[,] A2 = new int[A.GetLength(0) - 1, A.GetLength(1)];
        int r = 0;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (i != ind)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A2[r, j] = A[i, j];
                }
                r++;
            }
        }
        A = A2;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) return null;
        int ind = -1;
        int min = int.MaxValue;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[4, i] < min)
            {
                min = A[4, i];
                ind = i;
            }
        }
        if (ind == 8) return A;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j < ind + 1)
                {
                    A[i, j] = A[i, j];
                }
                else if (j == ind + 1)
                {
                    A[i, j] = B[i];
                }
                else if (j > ind + 1)
                {
                    A[i, j] = A[i, j - 1];
                }
            }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = double.MinValue;
            int ind = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = j;
                }
            }
            if (ind > 0 && ind < A.GetLength(1) - 1)
            {
                if (A[i, ind - 1] < A[i, ind + 1])
                {
                    if (A[i, ind - 1] < 0)
                    {
                        A[i, ind - 1] -= A[i, ind - 1] / 2;
                    }
                    else
                    {
                        A[i, ind - 1] += A[i, ind - 1];
                    }
                }
                else if (A[i, ind - 1] > A[i, ind + 1])
                {
                    if (A[i, ind + 1] < 0)
                    {
                        A[i, ind + 1] -= A[i, ind + 1] / 2;
                    }
                    else
                    {
                        A[i, ind + 1] += A[i, ind + 1];
                    }
                }
            }
            else if (ind == 0)
            {
                if (A[i, ind + 1] < 0)
                {
                    A[i, ind + 1] -= A[i, ind + 1] / 2;
                }
                else
                {
                    A[i, ind + 1] += A[i, ind + 1];
                }
            }
            else if (ind == A.GetLength(1) - 1)
            {
                if (A[i, ind - 1] < 0)
                {
                    A[i, ind - 1] -= A[i, ind - 1] / 2;
                }
                else
                {
                    A[i, ind - 1] += A[i, ind - 1];
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = double.MinValue;
            int ind = 0;
            double summin = 0, summax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0)
                {
                    summin += 1;
                }
                else if (A[i, j] > 0)
                {
                    summax += 1;
                }
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = i;
                }
            }
            if (summax > summin)
            {
                A[ind, j] = 0;
            }
            else
            {
                A[ind, j] = ind + 1;
            }
        }
            // end

            return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue;
            int ind = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = i;
                }
            }
            if (ind < A.GetLength(0) / 2)
            {
                int sum = 0;
                for (int i = ind + 1; i < A.GetLength(0); i++)
                {
                    sum += A[i, j];
                
                }
                A[0, j] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue;
            int ind = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = i;
                }
            }
            if (B[j] > A[ind, j])
            {
                A[ind, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = double.MinValue;
            int ind = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ind = i;
                }
            }
            if (max < ((A[0, j] + A[A.GetLength(0) - 1, j]) / 2))
            {
                A[ind, j] = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            }
            else
            {
                A[ind, j] = ind + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
        {
            return null;
        }
        answer = new int[n, 3 * n];
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < n; j++)
            {
                answer[j, j + i] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int max = int.MinValue;
        int ind = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                ind = i;
            }
        }
        for (int i = 0; i < ind; i++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6) return null;
        int i1 = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = int.MinValue;
            int ind = 0;
            for (int j = 0;  j < B.GetLength(1); j++)
            {
                if (B[i, j] > max)
                {
                    ind = j;
                    max = B[i, j];
                }
            }
            if (i % 2 == 0 || i == 0)
            {
                i1 = ind;
            }
            else if (i % 2 != 0)
            {
                int t = B[i - 1, i1];
                B[i - 1, i1] = B[i, ind];
                B[i, ind] = t;
                i1 = 0;
            }
        }
            // end

            return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int j1 = 0, j = A.GetLength(1) - 1;
            while (j1 < j)
            {
                int t = A[i, j1];
                A[i, j1] = A[i, j];
                A[i, j] = t;
                j1++;
                j--;
            }
        }
        // end

        return A;
    }
    #endregion

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int[] ind = new int[matrix.GetLength(0)], elements = new int[matrix.GetLength(0)];
        int[,] matrix1 = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = 0;
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min) 
                {
                    min = matrix[i, j];
                }
            }
            ind[i] = i;
            elements[i] = min;
        }
        for (int i = 1, j = i + 1; i < matrix.GetLength(0);)
        {
            if (i == 0 || elements[i] <= elements[i - 1])
            {
                i = j;
                j++;
            }
            else if (elements[i] > elements[i - 1])
            {
                int temp = elements[i], temp1 = ind[i];
                elements[i] = elements[i - 1]; elements[i - 1] = temp;
                ind[i] = ind[i - 1]; ind[i - 1] = temp1;
                i--;
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int temp = ind[i];
                matrix1[i, j] = matrix[temp, j];
            }
        }
        matrix = matrix1;
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        int[] vector = new int[2 * matrix.GetLength(0) - 1];
        for (int i = 0; i < 2 * matrix.GetLength(0) - 1; i++)
        {
            int sum = 0;
            if (i < matrix.GetLength(0))
            {
                for (int d1 = matrix.GetLength(0) - i - 1, d2 = 0; d1 < matrix.GetLength(0); d2++, d1++)
                {
                    sum += matrix[d1, d2];
                }
            }
            else
            {
                for (int d2 = i - matrix.GetLength(0) + 1, d1 = 0; d2 < matrix.GetLength(0); d1++, d2++)
                {
                    sum += matrix[d1, d2];
                }
            }
            vector[i] = sum;
        }
        answer = vector;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || k <= 0) return null;
        int n = matrix.GetLength(0), indi = 0, indj = 0, max = matrix[indi, indj];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0;  j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > Math.Abs(max))
                {
                    max = matrix[i, j];
                    indi = i; indj = j;
                }
            }
        }
        k--;
        if (indj != k)
        {
            for (int i = 0; i < n; i++)
            {
                int tenp = matrix[i, indj];
                matrix[i, indj] = matrix[i, k];
                matrix[i, k] = tenp;
            }
        }
        if (indi != k)
        {
            for (int j = 0; j < n; j++)
            {
                int tenp = matrix[indi, j];
                matrix[indi, j] = matrix[k, j];
                matrix[k, j] = tenp;
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
        if (A.Length + A.Length - n != n * n || B.Length + B.Length - n != n * n) return null;
        int[,] matrix1 = new int[n, n], matrix2 = new int[n, n];
        answer = new int[n * n];
        int ind = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrix1[i, j] = A[ind];matrix1[j, i] = A[ind];
                matrix2[i, j] = B[ind];matrix2[j, i] = B[ind];
                ind++;
            }
        }
        ind = 0;
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += matrix1[i, j] * matrix2[j, k];
                }
                answer[ind] = sum;
                ind++;
            }
        }
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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;
        int[] ind = new int[matrix.GetLength(1)], elements = new int[matrix.GetLength(1)];
        int[,] matrix1 = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int kol = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if (matrix[j, i] < 0)
                {
                    kol++;
                }
            }
            ind[i] = i;
            elements[i] = kol;
        }
        for (int i = 1, j = i + 1; i < matrix.GetLength(1);)
        {
            if (i == 0 || elements[i] >= elements[i - 1])
            {
                i = j;
                j++;
            }
            else if (elements[i] < elements[i - 1])
            {
                int temp = elements[i], temp1 = ind[i];
                elements[i] = elements[i - 1]; elements[i - 1] = temp;
                ind[i] = ind[i - 1]; ind[i - 1] = temp1;
                i--;
            }
        }
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int temp = ind[i];
                matrix1[j, i] = matrix[j, temp];
            }
        }
        matrix = matrix1;
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
        int c = 0;
        int[] index = new int[matrix.GetLength(0)];
        int ind = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool a = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    c++;
                    a = false;
                    break;
                }
            }
            if (!a)
            {
                index[ind++] = i;
            }
        }
        int[,] matrix1 = new int[matrix.GetLength(0) - c, matrix.GetLength(1)];
        ind = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == index[ind]) 
            {
                ind++;
            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix1[i, j] = matrix[i, j];
                }
            }
        }
        matrix = matrix1;
        // end

        return matrix;
    }
    #endregion
}