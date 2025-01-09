using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
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
                Console.Write("{0:d}  ", A[i, j]);
            Console.WriteLine();
        }
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
        int min = 100000;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    row = i;
                    col = j;
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
        int k = 0;
        for (int i = 0; i < A.GetLength(1); i++)

        {
            int max = int.MinValue;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                }
            }
            answer[k] = max;
            k++;
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
        int max = int.MinValue;
        int stroka = 0, stolb = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return default;
        for (int j = 0; j < A.GetLength(0); j++)
        {
            if (A[j, 2] > max)
            {
                max = A[j, 2];
                stroka = j;

            }
        }

        for (int i = 0; i < A.GetLength(1); i++)
        {
            (A[3, i], A[stroka, i]) = (A[stroka, i], A[3, i]);
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
        int max = int.MinValue;
        int ind = 0;
        for (int j = 0; j < A.GetLength(0); j++)
        {
            if (A[j, j] > max)
            {
                max = A[j, j];
                ind = j;
            }
        }
        for (int j = 0; j < A.GetLength(0); j++)
        {
            (A[j, ind], A[j, 3]) = (A[j, 3], A[j, ind]);
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
        int max = int.MinValue, ii = 0, jj = 0;
        int p = 0;
        if (A.GetLength(0) != n || A.GetLength(1) != m) return default;
        for (int i = 0; i < n; i++)
        {
            max = int.MinValue;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    jj = j;
                }
            }
            if (jj != m - 1)
            {
                p = A[i, jj];
                for (int j = jj; j < m - 1; j++)
                {
                    A[i, j] = A[i, j + 1];
                }
                A[i, m - 1] = p;
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
            double max = C[i, 0], stolb = 0;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > max)
                {
                    max = C[i, j];
                    stolb = j;
                }
            }
            if (max != 0)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (C[i, j] < 0)
                    {
                        C[i, j] /= max;
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
        double sum = 0, k = 0; double max = double.MinValue;
        int str = 0, stolb = 0;
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return default;
        for (int i = 0; i < Z.GetLength(0); i++)
        {


            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > max)
                {
                    max = Z[i, j];
                    str = i;
                    stolb = j;
                }
                if (Z[i, j] > 0) {
                    sum += Z[i, j];
                    k++;
                }
            }
        }
        sum = sum / k;
        Z[str, stolb] = sum;
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
        int kmin = 0; int kmax = 0;
        int n = X.GetLength(0), m = X.GetLength(1);
        if (n != 6 || m != 5) return default;
        int maxn = 0, minn = m, maxi = 0, maxj = 0, mini = 0, minj = 0, p = 0;
        for (int i = 0; i < n; i++)
        {
            int max = 0, min = 0;
            for (int j = 0; j < m; j++)
            {
                if ((X[i, j] < 0))
                {
                    max++;
                    min++;

                }
            }
            if (max > maxn)
            {
                maxn = max;
                mini = i;
            }
            if (min < minn)
            {
                minn = min;
                maxi = i;
            }
        }
        for (int j = 0; j < m; j++)
        {
            p = X[mini, j];
            X[mini, j] = X[maxi, j];
            X[maxi, j] = p;
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

        int max = int.MinValue, maxi = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }

                if (sum > max)
                {
                    max = sum;
                    maxi = i;
                }
            }
        }
        if (maxi == -1) return default;
        int count = 0;
        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (i == maxi)
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
        int mini = A[4, 0], minj = 0;
        for (int j = 1; j < A.GetLength(1); j++)
        {
            if (A[4, j] < mini)
            {
                mini = A[4, j];
                minj = j;
            }
        }
        for (int j = A.GetLength(1) - 1; j > minj + 1; j--)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A[i, j] = A[i, j - 1];
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            A[i, minj + 1] = B[i];
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
            int maxInd = 0;
            for (int j = 1; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                    maxInd = j;

                }
            }

            if (maxInd != 0 && maxInd != A.GetLength(1) - 1)
            {
                if (A[i, maxInd - 1] > A[i, maxInd + 1])
                {
                    if (A[i, maxInd + 1] > 0) A[i, maxInd + 1] *= 2;

                    else A[i, maxInd + 1] /= 2;
                }
                else
                {
                    if (A[i, maxInd - 1] > 0) A[i, maxInd - 1] *= 2;

                    else A[i, maxInd - 1] /= 2;

                }
            }
            if (maxInd == 0) A[i, 1] *= 2;

            if (maxInd == A.GetLength(1) - 1) A[i, A.GetLength(1) - 2] *= 2;

        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return default;

        for (int i = 0; i < A.GetLength(1); i++)
        {
            int maxe = A[0, i], maxi = -1;
            double pol = 0, otr = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > 0)
                {
                    pol++;
                }
                else { otr++; }
                if (A[j, i] > maxe)
                {
                    maxe = A[j, i];
                    maxi = j;
                }
            }
            if (pol > otr)
            {
                A[maxi, i] = 0;
            }
            else
            {
                A[maxi, i] = maxi + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5) return default;
        for (int j = 0; j < m; j++)
        {
            int sum = 0, max = A[0, j], ii = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ii = i;
                }
            }
            if (ii < n / 2)
            {
                for (int i = ii + 1; i < n; i++)
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
            if (A[ind_i, j] < B[j]) { A[ind_i, j] = B[j]; }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double [,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return default;
        for (int j = 0; j < m; j++)
        {
            double max = A[0, j], sum = 0;
            int ii = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    ii = i;
                }
            }
            sum = (A[0, j] + A[n - 1, j]) / 2;
            if (sum > A[ii, j])
            {
                A[ii, j] = sum;
            }
            else
            {
                A[ii, j] = ii + 1;
            }
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
                    if (i == j) answer[i, j] = 1;

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
            int n = A.GetLength(0), m = A.GetLength(1);
            if (n != 6 || m != 6) return default;
            int max = -100000, ii = 0, jj = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];

                        ii = i;
                    }
                }
            }
            for (int i = 0; i < ii; i++)
            {
                for (int j = i + 1; j < m; j++)
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
            int n = A.GetLength(0), m = A.GetLength(1);
            if (n != 6 || m != 7) return default;
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    p = A[i, j];
                    A[i, j] = A[i, m - j - 1];
                    A[i, m - j - 1] = p;
                }
            }
            // end

            return A;
        }

        #region Level 3
        public int[,] Task_3_1(int[,] matrix)
        {
            // code here
            int k = matrix.GetLength(0), l = matrix.GetLength(1);
            if (k != 7 || l != 5) return default;
            int[] a = new int[matrix.GetLength(0)];
            for (int i = 0; i < k; i++)
            {
                int ind = 0, min = 1000000000;
                for (int j = 1; j < l; j++)
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        ind = j;
                    }
                a[i] = matrix[i, ind];
            }
            for (int x = 1; x < k; x++)
            {
                int i = x;
                while (i > 0 && a[i - 1] < a[i])
                {
                    int p = a[i - 1];
                    a[i - 1] = a[i];
                    a[i] = p;
                    for (int j = 0; j < l; j++)
                    {
                        p = matrix[i - 1, j];
                        matrix[i - 1, j] = matrix[i, j];
                        matrix[i, j] = p;
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
        int k = matrix.GetLength(0);
        answer = new int[2 * k - 1];
        if (matrix.GetLength(0) != matrix.GetLength(1)) return default;
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                int ind = j - i + (k - 1);
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || k < 1 || k > n) return default;
        
        int indi = 0, indj = 0, max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    indj = j;
                    indi = i;
                }
            }
        }
        if (indi == k - 1 && indj == k - 1)
            return matrix;
        if (indj != k - 1)
        {
            for (int j = 0; j < n; j++)
            {
                int p = matrix[k - 1, j];
                matrix[k - 1, j] = matrix[indi, j];
                matrix[indi, j] = p;
            }
        }
        if (indi != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int p = matrix[i, k - 1];
                matrix[i, k - 1] = matrix[i, indj];
                matrix[i, indj] = p;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
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
            int[] k = new int[n * n];
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
                        k[i * n + j] = k[i * n + j] + a[i, f] * b[f, j];
                    }
                }
            }
            answer = k;
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
        int t = matrix.GetLength(0), y = matrix.GetLength(1);
        if (t != 5 || y != 7) return default;
        int[] a = new int[y];
        for (int j = 0; j < y; j++)
        {
            int k = 0;
            for (int i = 0; i < t; i++)
            {
                if (matrix[i, j] < 0)
                    k++;
            }
            a[j] = k;
        }
        for (int x = 1; x < y; x++)
        {
            int j = x;
            while (j > 0 && a[j - 1] > a[j])
            {
                int p = a[j - 1];
                a[j - 1] = a[j];
                a[j] = p;
                for (int line = 0; line < t; line++)
                {
                    p = matrix[line, j - 1];
                    matrix[line, j - 1] = matrix[line, j];
                    matrix[line, j] = p;
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
            int z = matrix.GetLength(0), t = matrix.GetLength(1);
            if (z <= 0 || t <= 0) return default;
           
            int k = 0;
            z = z - 1;
        for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        k++;
                        break;
                    }
                }
            }
            int[,] a = new int[z - k, t];
            int c = 0;
            for (int i = 0; i < z - 1; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    if (matrix[i, j] == 0) break;
                    a[c, j] = matrix[i, j];
                }
                c++;
                
            if (c >= matrix.GetLength(0) - k)
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