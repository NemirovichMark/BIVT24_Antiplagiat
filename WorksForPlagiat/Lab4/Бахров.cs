using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO.Pipes;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        double[,] A = {
            { 1, 2, -3, 7, -5, 7, 7 },
            { 5, 6, -7, 8, 9, 9, -11 },
            { 9, 10, 11, 12, 13, 15, 15 },
            { -13, -30, 25, 25, 16, 17, -19 },
            { -6, -5, -1, -2, -3, -4, -6 }
        };
        program.Task_2_1(A);


    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        int m = 5, n = 7, s = 0;
        foreach(int elem in A)
        {
            s += elem;
        }
        answer = s;
        Console.WriteLine(answer);

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
        int m = A.GetLength(0);
        int n = A.GetLength(1);
        int min = int.MaxValue;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    row = i;
                    col = j;
                }
            }
        }
        Console.WriteLine($"row = {row}  col = {col}");
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
        //code here
        int m = A.GetLength(0);
        int n = A.GetLength(1);
        if (m != 3 || n != 5)
        {
            return null;
        }
        int k = 0, max = int.MinValue;
        int[] b = new int[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                }
            }
            b[k] = max;
            k++;
            max = int.MinValue;
        }
        answer = b;
        foreach (int elem in answer)
        {
            Console.WriteLine(elem);
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
        int m = A.GetLength(0);
        int n = A.GetLength(1);
        if (m != 5 || n != 7)
        {
            return null;
        }
        int max = int.MinValue, indexmax = 0;
        for (int i = 0; i < m; i++)
        {
            if (A[i, 2] > max)
            {
                max = A[i, 2];
                indexmax = i;
            }
        }
        if (indexmax == 3)
        {
            return A;
        }
        else
        {
            for (int j = 0; j < n; j++)
            {
                int p = A[3, j];
                A[3, j] = A[indexmax, j];
                A[indexmax, j] = p;
            }

        }
        foreach (int elem in A)
        {
            Console.WriteLine(elem);
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
        int m = A.GetLength(0);
        int n = A.GetLength(1);
        if (m != 5 || n != 5)
        {
            return null;
        }
        int max = int.MinValue, indexmax = 0;
        for(int i = 0; i < 5; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                indexmax = i;
            }
        }
        for (int j = 0; j < m; j++)
        {
            int p = A[j, 3];
            A[j, 3] = A[j, indexmax];
            A[j, indexmax] = p;
        }
        foreach (int elem in A)
        {
            Console.WriteLine(elem);
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
        for(int i = 0; i < n; i++)
        {
            int max = int.MinValue, indexcol = 0, temp;
            for(int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    indexcol = j;
                }
            }
            temp = A[i, indexcol];
            for (int k = indexcol; k < m; k++)
            {
                if (m - 1 != k)
                {
                    A[i, k] = A[i, k + 1];
                }
                else
                {
                    A[i, k] = temp;
                }
            }
        }
        foreach(int elem in A)
        {
            Console.WriteLine(elem);
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

        int i = -1;
        for (int x = 0; x < n; x++)
        {
            double ma = -9999;
            i = -1;
            for (int y = 0; y < m; y++)
            {
                if (C[x, y] > ma)
                {
                    ma = C[x, y];
                    i = y;
                }
            }
            if (ma == 0) continue;
            for (int k = 0; k < i; k++)
            {
                if (C[x, k] < 0)
                {
                    C[x, k] = C[x, k] / ma;
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
        int m = Z.GetLength(0);
        int n = Z.GetLength(1);
        if (m != 6 || n != 8)
        {
            return null;
        }
        double max = double.MinValue, s = 0, k = 0;
        int indexst = 0, indexcol = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Z[i,j] > 0)
                {
                    s += Z[i, j];
                    k++;
                }
                if(Z[i, j] > max)
                {
                    max = Z[i, j];
                    indexst = i;
                    indexcol = j;
                }
            }
        }
        Z[indexst, indexcol] = Math.Round(s / k, 2);
        foreach(double elem in Z)
        {
            Console.WriteLine(elem);
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
        int m = X.GetLength(0);
        int n = X.GetLength(1);
        if (m != 6 || n != 5)
        {
            return null;
        }
        int min = int.MaxValue, max = int.MinValue, k = 0 , indexmin = 0, indexmax = 0;
        for(int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (X[i, j] < 0)
                {
                    k++;
                }
            }
            if (k < min)
            {
                min = k;
                indexmin = i;
            }
            if (k > max)
            {
                max = k;
                indexmax = i;
            }
            k = 0;
        }
        for (int j = 0; j < n; j++)
        {
            int temp = X[indexmin, j];
            X[indexmin, j] = X[indexmax, j];
            X[indexmax, j] = temp;
        }
        foreach (int elem in X)
        {
            Console.WriteLine(elem);
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
        int m = A.GetLength(0);
        int n = A.GetLength(1);
        if (m != 7 || n != 5)
        {
            return null;
        }
        int max = int.MinValue, k = 0, index = 0;
        int[,] b = new int[m - 1,n];
        for (int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (A[i, j] > 0)
                {
                    k++;
                }
            }
            if(k > max)
            {
                max = k;
                index = i;
            }
            k = 0;
        }
        for (int i = 0; i < m - 1; i++)
            if (i < index + 1)
                for (int j = 0; j < n; j++)
                    b[i, j] = A[i, j];
            else
                for (int j = 0; j < n; j++)
                    b[i, j] = A[i + 1, j];
        A = b;
        foreach (int elem in A)
        {
            Console.WriteLine(elem);
        }

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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8)
        {
            return null;
        }
        if (B.Length != 5)
        {
            return null;
        }
        int min = int.MaxValue, i = -1;
        for (int y = 0; y < A.GetLength(1); y++)
        {
            if (A[4, y] < min)
            {
                min = A[4, y];
                i = y;
            }
        }
        for (int x = 0; x < A.GetLength(0); x++)
        {
            A[x, 7] = A[x, i + 1];
            A[x, i + 1] = B[x];
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 5 || m != 7)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            double amax = -100;
            int jmax = -1;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    jmax = j;
                }
            }
            if (jmax != 0 && jmax != m - 1)
            {
                if (A[i, jmax - 1] > A[i, jmax + 1])
                {
                    if (A[i, jmax + 1] > 0)
                    {
                        A[i, jmax + 1] *= 2;
                    }
                    else if (A[i, jmax + 1] < 0)
                    {
                        A[i, jmax + 1] /= 2;
                    }
                }
                else if (A[i, jmax - 1] < A[i, jmax + 1])
                {
                    if (A[i, jmax - 1] > 0)
                    {
                        A[i, jmax - 1] *= 2;
                    }
                    else if (A[i, jmax - 1] < 0)
                    {
                        A[i, jmax - 1] /= 2;
                    }
                }
                else if (jmax == 0 || jmax == m - 1)
                {
                    if (jmax == m - 1)
                    {
                        if (A[i, jmax - 1] > 0)
                        {
                            A[i, jmax - 1] *= 2;
                        }
                        else if (A[i, jmax - 1] < 0)
                        {
                            A[i, jmax - 1] /= 2;
                        }
                    }
                    else if (jmax == 0)
                    {
                        if (A[i, jmax + 1] > 0)
                        {
                            A[i, jmax + 1] *= 2;
                        }
                        else if (A[i, jmax + 1] < 0)
                        {
                            A[i, jmax + 1] /= 2;
                        }
                    }
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
        int m = A.GetLength(0);
        int n = A.GetLength(1);
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for(int i = 0; i < n; i++)
        {
            int kp = 0, kn = 0, max = int.MinValue, index = 0; 
            for(int j = 0; j < m; j++)
            {
                if(A[j, i] > 0)
                {
                    kp++;
                }
                else
                {
                    kn++;
                }
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    index = j;
                }
            }
            if(kp > kn)
            {
                A[index, i] = 0;
            }
            else
            {
                A[index, i] = index + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int y = 0; y < 5; y++)
        {
            int m = 0, i = -1, su = 0;
            for (int x = 0; x < 10; x++)
            {
                su += A[x, y];
                if (A[x, y] > m) { m = A[x, y]; i = x; su = 0; }
            }
            if (i <= 4)
            {
                A[0, y] = su;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        {
            return null;
        }
        for (int y = 0; y < 5; y++)
        {
            int m = -9999, i = -1;
            for (int x = 0; x < 7; x++)
            {
                if (A[x, y] > m)
                {
                    m = A[x, y]; i = x;
                }
            }
            if (m < B[y]) { A[i, y] = B[y]; }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int y = 0; y < 5; y++)
        {
            double m = -9999;
            int i = -1;
            for (int x = 0; x < 7; x++)
            {
                if (A[x, y] > m)
                {
                    m = A[x, y]; i = x;
                }
            }
            if (m < (A[0, y] + A[6, y]) / 2)
            {
                A[i, y] = (A[0, y] + A[6, y]) / 2;
            }
            else
            {
                A[i, y] = i + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) { return null; }
        int[,] A = new int[n, 3 * n];
        int k = 2;
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < 3 * n; y++)
            {
                A[x, y] = ((y + k) % 3) / 2;
            }
            k--;
        }
        answer = A;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1);
        if (m != 6 || n != 6) return null;
        int ma = -9999, i = -1;
        for (int j = 0; j < 6; j++)
        {
            if (A[j, j] > ma)
            {
                ma = A[j, j];
                i = j;
            }
        }
        if (i == -1) return null;
        for (int x = 0; x < i; x++)
        {
            for (int y = x + 1; y < 6; y++)
            {
                A[x, y] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (6 != B.GetLength(0) || 6 != B.GetLength(1)) return null;
        int i1 = -1, i2 = -1;
        for (int x = 0; x < 6; x += 2)
        {
            int ma1 = -9999, ma2 = -9999, o = 0;
            for (int y = 0; y < 6; y += 1)
            {
                if (B[x, y] > ma1)
                {
                    i1 = y;
                    ma1 = B[x, y];
                }
            }
            for (int j = 0; j < 6; j += 1)
            {
                if (B[x + 1, j] > ma2)
                {
                    i2 = j;
                    ma2 = B[x + 1, j];
                }
            }
            o = B[x, i1];
            B[x, i1] = B[x + 1, i2];
            B[x + 1, i2] = o;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (6 != A.GetLength(0) || 7 != A.GetLength(1)) return null;
        int k;
        int[] s;
        for (int x = 0; x < 6; x++)
        {
            k = 6;
            s = new int[7];
            for (int y = 0; y < 7; y += 1)
            {
                s[y] = A[x, k];
                k--;
            }
            for (int y = 0; y < 7; y += 1)
            {
                A[x, y] = s[y];
            }

        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        if (matrix == null || n != 7 || m != 5)
        {
            return null;
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int imin = 100000, jmin = 100000;
                for (int k = 0; k < m; k++)
                {
                    if (matrix[i, k] < imin)
                    {
                        imin = matrix[i, k];
                    }
                    if (matrix[j, k] < jmin)
                    {
                        jmin = matrix[j, k];
                    }
                }
                if (imin < jmin)
                {
                    for (int k = 0; k < m; k++)
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[j, k];
                        matrix[j, k] = temp;
                    }
                }
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
        int m = matrix.GetLength(1);

        if (n != m)
        {
            return answer;
        }
        answer = new int[n * 2 - 1];
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (matrix == null || n != m || k < 1 || k > n)
        {
            return null;
        }

        int amax = -100000, imax = 0, jmax = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (amax < Math.Abs(matrix[i, j]))
                {
                    amax = Math.Abs(matrix[i, j]);
                    imax = i;
                    jmax = j;
                }
            }
        }
        if (jmax != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, jmax];
                matrix[i, jmax] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
            }
        }
        if (imax != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[imax, i];
                matrix[imax, i] = matrix[k - 1, i];
                matrix[k - 1, i] = temp;
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
        answer = new int[n * n];
        int[,] mA = new int[n, n];
        int[,] mB = new int[n, n];
        int k = 0;
        int c = 0;
        if (n <= 0 || A.Length / 2 != n || B.Length / 2 != n)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                mA[i, j] = A[k];
                mB[i, j] = B[k];
                k++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mA[j, i] = mA[i, j];
                mB[j, i] = mB[i, j];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int s = 0;
                for (int q = 0; q < n; q++)
                {
                    s += (mA[i, q] * mB[q, j]);
                }
                answer[c++] = s;
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
        int[] array = new int[7];
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int k = 0;
        int c = 0;

        if (n != 5 && m != 7)
        {
            return null;
        }

        for (int j = 0; j < 7; j++)
        {
            int g = 0;
            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, j] < 0)
                {
                    g++;
                }
            }
            array[j] = g;
        }
        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                if (array[i] > array[i + 1])
                {
                    c = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = c;

                    for (int q = 0; q < 5; q++)
                    {
                        c = matrix[q, i];
                        matrix[q, i] = matrix[q, i + 1];
                        matrix[q, i + 1] = c;
                    }
                }
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int z = n;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    z--;
                    matrix[i, 0] = 0;
                    break;
                }
            }
        }
        int[,] A = new int[z, m];
        int q = 0;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, 0] != 0)
            {
                for (int j = 0; j < m; j++)
                {
                    A[q, j] = matrix[i, j];
                }
                q++;
            }
        }
        matrix = A;
        // end

        return matrix;
    }
    #endregion
}