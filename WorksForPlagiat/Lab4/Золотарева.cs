using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 4 || m != 4) return default;
        for (int i = 0; i < n; i = i + 1) answer = answer + A[i, i];
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here

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
        int k = 0;
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 4 || m != 7) return default;
        int[] B = new int[n];
        for (int i = 0; i < n; i = i + 1)
        {
            int min = A[i, 0], imin = 0;

            for (int j = 0; j < m; j = j + 1)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    imin = j;
                }
            }
            B[k] = imin;
            k = k + 1;
        }
        answer = B;
        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

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
        int t = 0;
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i = i + 1)
        {
            int max = A[i, 0], imax = 0;

            for (int j = 0; j < m; j = j + 1)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = j;
                }
            }
            t = max;
            A[i, imax] = A[i, 0];
            A[i, 0] = t;
        }
        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here

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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 7) return default;
        else
        {
            int[,] b = new int[n - 1, m];
            int[,] c = new int[n - 1, m - 1];
            int max = A[0, 0], imaxi = 0, imaxj = 0;
            for (int i = 0; i < n; i = i + 1)
            {
                for (int j = 0; j < m; j = j + 1)
                {
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        imaxj = j;
                        imaxi = i;
                    }
                }
            }
            for (int i = 0; i < n - 1; i = i + 1)
            {
                if (i < imaxi)
                    for (int j = 0; j < m; j = j + 1)
                        b[i, j] = A[i, j];
                else
                    for (int j = 0; j < m; j = j + 1)
                        b[i, j] = A[i + 1, j];
            }
            for (int i = 0; i < n - 1; i = i + 1)
            {
                for (int j = 0; j < m - 1; j = j + 1)
                    if (j < imaxj)
                        c[i, j] = b[i, j];
                    else
                        for (int k = imaxj; k < m - 1; k = k + 1)
                            c[i, k] = b[i, k + 1];
            }
            A = c;
        }

        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here

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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i = i + 1)
        {
            int max = A[i, 0], imax = 0;

            for (int j = 0; j < m; j = j + 1)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = j;
                }
            }
            A[i, imax] = A[i, imax] * (i + 1);
        }
        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here

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
        for (int i = 0; i < n; i = i + 1)
        {
            int imax = 0, ineg1 = 0, ineg2 = 0;
            for (int j = m - 1; j >= 0; j = j - 1) if (D[i, j] < 0) ineg1 = j;
            for (int j = 0; j < m; j = j + 1) if (D[i, j] < 0) ineg2 = j;

            if (ineg1 != 0)
            {
                int max = D[i, 0];
                for (int j = 0; j < ineg1; j = j + 1)
                {
                    if (D[i, j] > max)
                    {
                        max = D[i, j];
                        imax = j;
                    }
                }
                int p = 0;
                p = D[i, imax];
                D[i, imax] = D[i, ineg2];
                D[i, ineg2] = p;
            }
        }

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here

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
        int n = H.GetLength(0), m = H.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i = i + 1)
        {
            int max = H[i, 0], imax = 0;

            for (int j = 0; j < m; j = j + 1)
            {
                if (H[i, j] >= max)
                {
                    max = H[i, j];
                    imax = j;
                }
            }
            H[i, 6] = H[i, 5];
            H[i, 5] = max;
        }
        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here

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
        int n = Y.GetLength(0), m = Y.GetLength(1);
        if (n != 6 || m != 5) return default;
        double[,] b = new double[n, m];
        for (int i = 0; i < n; i = i + 1)
        {
            int imax = 0;
            double max = Y[i, 0];

            for (int j = 0; j < m; j = j + 1)
            {
                if (Y[i, j] >= max)
                {
                    max = Y[i, j];
                    imax = j;
                }
            }
            if (imax != 0)
            {
                double s = 0, sr = 0;
                int kpoz = 0;
                if (imax != m - 1)
                {
                    for (int j = imax + 1; j < m; j = j + 1)
                        if (Y[i, j] > 0)
                        {
                            s = s + Y[i, j];
                            kpoz = kpoz + 1;
                        }
                    if (kpoz != 0)
                    {
                        sr = s / kpoz;
                        for (int j = 0; j < imax; j = j + 1)
                            if (Y[i, j] < 0) b[i, j] = sr;
                            else b[i, j] = Y[i, j];
                        for (int j = imax; j < m; j = j + 1) b[i, j] = Y[i, j];
                    }
                    else
                    {
                        for (int j = 0; j < imax; j = j + 1) if (Y[i, j] < 0) b[i, j] = 0; else b[i, j] = Y[i, j];
                        for (int j = imax; j < m; j = j + 1) b[i, j] = Y[i, j];
                    }
                }
                else
                {
                    for (int j = 0; j < m - 1; j = j + 1) if (Y[i, j] < 0) b[i, j] = 0;
                        else b[i, j] = Y[i, j];
                    b[i, m - 1] = Y[i, m - 1];
                }

            }
            else for (int j = 0; j < m; j = j + 1) b[i, j] = Y[i, j];
        }
        Y = b;
        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here

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
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 5 || m != 7) return default;
        int k = 0;
        int[] a = new int[5];
        for (int i = n - 1; i >= 0; i = i - 1)
        {
            int max = B[i, 0];
            for (int j = 0; j < m; j = j + 1) if (B[i, j] >= max) max = B[i, j];
            a[k] = max;
            k = k + 1;
        }
        k = 0;
        for (int i = 0; i < n; i = i + 1)
        {
            B[i, 3] = a[k];
            k = k + 1;
        }

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here

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
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 5 || m != 5) return default;
        int max = B[0, 0], imax = 0;
        for (int i = 0; i < n; i = i + 1)
            if (B[i, i] >= max)
            {
                max = B[i, i];
                imax = i;
            }
        int ineg = 0;
        for (int i = n - 1; i >= 0; i = i - 1)
            if (B[i, 2] < 0) ineg = i;
        int p = 0;
        for (int i = 0; i < n; i = i + 1)
        {
            p = B[imax, i];
            B[imax, i] = B[ineg, i];
            B[ineg, i] = p;
        }
        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here

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
        int k = 0;
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i = i + 1)
            for (int j = 0; j < m; j = j + 1) if (A[i, j] < 0) k = k + 1;
        int[] B = new int[k];
        k = 0;
        for (int i = 0; i < n; i = i + 1)
            for (int j = 0; j < m; j = j + 1)
            {
                if (A[i, j] < 0)
                {
                    B[k] = A[i, j];
                    k = k + 1;
                }
            }
        answer = B;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int i = 0; i < n; i = i + 1)
        {
            int imax = 0;
            double max = A[i, 0];

            for (int j = 0; j < m; j = j + 1)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = j;
                }
            }
            if (imax != 0 || imax != m - 1)
            {
                if (A[i, imax - 1] > A[i, imax + 1])
                {
                    if (A[i, imax + 1] < 0) A[i, imax + 1] = A[i, imax + 1] / 2;
                    else A[i, imax + 1] = A[i, imax + 1] * 2;
                }
                else
                {
                    if (A[i, imax - 1] < 0) A[i, imax - 1] = A[i, imax - 1] / 2;
                    else A[i, imax - 1] = A[i, imax - 1] * 2;
                }
            }
            else
            {
                if (imax == 0)
                {
                    if (A[i, imax + 1] < 0) A[i, imax + 1] = A[i, imax + 1] / 2;
                    else A[i, imax + 1] = A[i, imax + 1] * 2;
                }
                if (imax == m - 1)
                {
                    if (A[i, imax - 1] < 0) A[i, imax - 1] = A[i, imax - 1] / 2;
                    else A[i, imax - 1] = A[i, imax - 1] * 2;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return default;
        int[,] b = new int[m, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                b[m - 1 - j, i] = A[i, j];
            }
        }
        for (int i = 0; i < m; i = i + 1)
        {
            int imax = 0, kpoz = 0, kneg = 0;
            int max = b[i, 0];
            for (int j = 0; j < n; j = j + 1)
            {
                if (b[i, j] > 0) kpoz = kpoz + 1;
                if (b[i, j] < 0) kneg = kneg + 1;
                if (b[i, j] > max)
                {
                    max = b[i, j];
                    imax = j;
                }
            }
            if (kpoz > kneg) b[i, imax] = 0;
            else b[i, imax] = imax + 1;
        }
        int[,] c = new int[n, m];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                c[j, m - 1 - i] = b[i, j];
            }
        }
        A = c;
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5) return default;
        int[,] b = new int[m, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                b[m - 1 - j, i] = A[i, j];
            }
        }
        for (int i = 0; i < m; i = i + 1)
        {
            int imax = 0;
            int max = b[i, 0];
            for (int j = 0; j < n; j = j + 1)
            {
                if (b[i, j] > max)
                {
                    max = b[i, j];
                    imax = j;
                }
            }
            if (imax < 5)
            {
                int s = 0;
                for (int j = imax + 1; j < n; j = j + 1) s = s + b[i, j];
                b[i, 0] = s;
            }
        }
        int[,] c = new int[n, m];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                c[j, m - 1 - i] = b[i, j];
            }
        }
        A = c;
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (B.Length != 5) return default;
        else
        {
            int n = A.GetLength(0), m = A.GetLength(1);
            if (n != 7 || m != 5) return default;
            for (int i = 0; i < m; i = i + 1)
            {
                int imax = 0;
                int max = A[i, 0];
                for (int j = 0; j < n; j = j + 1)
                {
                    if (A[j, i] > max)
                    {
                        max = A[j, i];
                        imax = j;
                    }
                }
                if (B[i] > max) A[imax, i] = B[i];
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("{0:d}", A[i, j]);
                Console.WriteLine();
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return default;
        for (int i = 0; i < m; i = i + 1)
        {
            int imax = 0;
            double max = A[i, 0], s = 0;
            for (int j = 0; j < n; j = j + 1)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    imax = j;
                }
            }
            s = (A[0, i] + A[6, i]) / 2;
            if (max < s) A[imax, i] = s;
            else A[imax, i] = imax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return default;
        int[,] c = new int[n, 3 * n];
        for (int i = 0; i < n; i = i + 1)
            for (int j = 0; j < 3 * n; j = j + 1)
                if (j % 3 == 0) c[i, j] = 1;
                else c[i, j] = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < 3 * n; j++)
        //        Console.Write("{0:d}", c[i, j]);
        //    Console.WriteLine();
        //}
        int s = 1;
        for (int i = 1; i < n; i = i + 1)
        {
            for (int j = 0; j < s % (3 * n); j = j + 1)
            {
                int t = c[i, 3 * n - 1];
                for (int k = 3 * n - 1; k > 0; k = k - 1)
                    c[i, k] = c[i, k - 1];
                c[i, 0] = t;
            }
            s = s + 1;
        }
        answer = c;

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 6) return default;
        int imax = 0;
        int max = A[0, 0];
        for (int i = 0; i < n; i = i + 1)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                imax = i;
            }
        }
        for (int i = 0; i < imax; i = i + 1)
            for (int j = 0; j < n; j = j + 1)
                if (j > i) A[i, j] = 0;
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 6 || m != 6) return default;
        int imax1 = 0;
        int max1 = B[0, 0];
        int imax2 = 0;
        int max2 = B[0, 0];
        for (int i = 0; i < n; i = i + 1)
        {
            for (int j = 0; j < m; j = j + 1)
            {
                if (i % 2 == 0)
                {
                    if (B[i, j] > max1)
                    {
                        max1 = B[i, j];
                        imax1 = j;
                    }
                }
                if (i % 2 != 0)
                {
                    if (B[i, j] > max2)
                    {
                        max2 = B[i, j];
                        imax2 = j;
                    }
                }
            }
            int t;
            if (i % 2 != 0)
            {
                t = B[i, imax2];
                B[i, imax2] = B[i - 1, imax1];
                B[i - 1, imax1] = t;
                imax1 = 0;
                max1 = B[i, 0];
                imax2 = 0;
                max2 = B[i, 0];
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 7) return default;
        for (int i = 0; i < n; i = i + 1)
        {
            int t;
            for (int j = 0; j < m / 2; j = j + 1)
            {
                t = A[i, j];
                A[i, j] = A[i, m - j - 1];
                A[i, m - j - 1] = t;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 7 || m != 5) return default;
        for (int i = 1; i < n;)
        {
            int min1 = 100000, min2 = 100000;
            for (int j = 0; j < m; j++)
            {
                if (i!=0)
                {
                    if (matrix[i, j] <= min2) min2 = matrix[i, j];
                    if (matrix[i - 1, j] <= min1) min1 = matrix[i - 1, j];
                }
            }
            if (i == 0 || min1>=min2)
                i++;
            else
            {
                for (int j = 0; j < m; j++)
                {
                    int t = matrix[i, j];
                    matrix[i, j] = matrix[i-1, j];
                    matrix[i-1, j] = t;
                }
                i--;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(matrix[i, j]);
            Console.WriteLine();
        }
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n <= 0 || m <= 0 || n!=m) return default;
        int o = 0;
        int[] b = new int[2*n-1];
        for (int j = 0; j < n; j = j + 1)
        {
            int k = n-1;
            int l = j, s=0;
            while (l>=0)
            {
                s = s + matrix[k, l];
                l = l - 1;
                k= k - 1;
            }
            b[o] = s;
            o = o + 1;
        }
        for (int j = n-2; j >=0; j = j - 1)
        {
            int s = 0, k=j, l=n-1;
            while (k >= 0)
            {
                s = s + matrix[k, l];
                l = l - 1;
                k = k - 1;
            }
            b[o] = s;
            o = o + 1;
        }
        answer = b;
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
        if (n <= 0 || m <= 0 || n != m || k<1 || k>n) return default;
        int ii = 0, jj = 0;
        int max = matrix[0, 0];
        for (int i = 0; i < n; i = i + 1)
        {
            for (int j = 0; j < n; j = j + 1)
            {
                if (Math.Abs(matrix[j, i]) > max)
                {
                    max = Math.Abs(matrix[j, i]);
                    ii = i;
                    jj = j;
                }
            }
        }
        for (int i = 0; i < n; i = i + 1)
        {
            int t = matrix[i, k-1];
            matrix[i, k-1] = matrix[i, jj];
            matrix[i, jj] = t;
        }
        for (int j = 0; j < n; j = j + 1)
        {
            int t = matrix[k-1, j];
            matrix[k-1, j] = matrix[ii, j];
            matrix[ii, j] = t;
        }
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //        Console.Write("{0:d}", matrix[i, j]);
        //    Console.WriteLine();
        //}
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
        int l = A.Length, m = B.Length;
        if (l <= 0|| m<=0 || l!=m) return default;
        int[,] a = new int[n, n];
        int[,] b = new int[n, n];
        int k = 0;
        int[] c = new int[n*n];
        for (int i = 0; i < n; i = i + 1)
            for (int j = i; j < n; j = j + 1)
            {
                a[i, j] = A[k];
                a[j, i] = A[k];
                b[i, j] = B[k];
                b[j, i] = B[k];
                k = k + 1;
            }
        for (int i = 0; i < n; i = i + 1)
            for (int j = 0; j < n; j = j + 1)
                for (int p = 0; p < n; p = p + 1)
                {
                    c[i * n + j] = c[i * n + j] + a[i, p] * b[p, j];
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 5 || m != 7) return default;
        for (int j = 1; j < m;)
        {
            int k2 = 0, k1 = 0;
            for (int k = 0; k < n; k++)
            {
                if (j!=0)
                {
                    if (matrix[k, j] < 0) k2++;
                    if (matrix[k, j - 1] < 0) k1++;
                }
            }
            if (j == 0 || k2 >= k1)
                j++;
            else
            {
                for (int k = 0; k < n; k++)
                {
                    int t = matrix[k, j];
                    matrix[k, j] = matrix[k, j - 1];
                    matrix[k, j - 1] = t;
                }
                j--;
            }
        }
        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n <=0 || m <=0) return default;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 1; j < m;)
                {
                    if (j == 0 || matrix[i, j] <= matrix[i, j - 1])
                        j = j + 1;
                    else
                    {
                        int t = matrix[i, j];
                        matrix[i, j] = matrix[i, j - 1];
                        matrix[i, j - 1] = t;
                        j = j - 1;
                    }
                }
            }
            else
            {
                for (int j = 1; j < m;)
                {
                    if (j == 0 || matrix[i, j] >= matrix[i, j - 1])
                        j = j + 1;
                    else
                    {
                        int t = matrix[i, j];
                        matrix[i, j] = matrix[i, j - 1];
                        matrix[i, j - 1] = t;
                        j = j - 1;
                    }
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(matrix[i, j]);
            Console.WriteLine();
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n <= 0 || m <= 0) return default;
        int l = 0;
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            int k = 0;
            for (int j = 0; j < m; j++)
                if (matrix[i, j] == 0) k++;
            a[i] = k;
        }
        for (int i = 0; i < n; i++)
            if (a[i] == 0) l++;
        int[,] b = new int[l, m];
        l = -1;
        for (int i = 0; i < n; i++)
        {
            if (a[i] == 0)
            {
                l++;
                for (int j = 0; j < m; j++)
                    b[l, j]=matrix[i, j];
            }
        }
        matrix = b;

            // end

            return matrix;
    }
    #endregion
}