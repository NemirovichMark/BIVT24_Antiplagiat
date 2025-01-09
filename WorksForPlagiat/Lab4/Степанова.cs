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
                answer += A[i, j];
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
        int mn = A[0, 0];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < mn)
                {
                    mn = A[i, j];
                    row = i;
                    col = j;
                }
            }
        }

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

        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = new int[5];
        if (A.GetLength(0) < 3 || A.GetLength(1) < 5 || A.GetLength(1) > 5||A.GetLength(0) > 3)
            return null;
        int mx = 0;
        for (int j = 0; j < 5; j++)
        {
            mx = A[0, j];
            for (int i = 0; i < 3; i++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                }
            }
            answer[j] = mx;
        }
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
        int mx = A[0,2];
        int k = 0;
        if (A.GetLength(0) < 5 || A.GetLength(1) < 7 || A.GetLength(1) > 7 ||A.GetLength(0) > 5)
            return null;
        for (int i = 0; i < 5; i++)
        {
            if (A[i, 2] > mx)
            {
                mx = A[i, 2];
                k = i;
            }
        }
        int t = 0;
        for (int j = 0; j < 7; j++)
        {
            t = A[3, j];
            A[3, j] = A[k, j];
            A[k, j] = t;
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
        int mx = A[0,0];
        int k = 0;
        int t = 0;
        if (A.GetLength(0) < 5 || A.GetLength(1) < 5 || A.GetLength(1) > 5||A.GetLength(0) > 5)
            return null;
        for (int i = 0; i < 5; i++)
        {
            if (A[i, i] > mx)
            {
                mx = A[i, i];
                k = i;
            }
               
        }
        for (int i = 0; i < 5; i++)
        {
            t = A[i, 3];
            A[i, 3] = A[i, k];
            A[i, k] = t;
        }
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
        int mx = 0;
        int k = 0;
        int t = 0;
        if (A.GetLength(0) < n || A.GetLength(1) < m || A.GetLength(1) > m||A.GetLength(0) > n)
            return null;
        for (int i = 0; i < n; i++)
        {
            mx = A[i, 0];
            k = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > mx)
                {
                    k = j;
                    mx = A[i, j];
                }
            }
            for (int j = k; j < m - 1; j++)
            {
                A[i, j] = A[i, j + 1];
            }
            A[i, m - 1] = mx;
        }
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
        if (C.GetLength(0) < n || C.GetLength(1) < m || C.GetLength(1) > m|| C.GetLength(0) > n)
            return null;
        double mx = 0;
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            mx = C[i, 0];
            k = 0;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > mx)
                {
                    k = j;
                    mx = C[i, j];
                }
            }
            for (int j = 0; j < k; j++)
            {
                if (C[i, j] < 0)
                    C[i, j] = C[i, j] / mx;
            }
        }
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8)
            return null;
        double mx = Z[0, 0];
        int k = 0;
        double s = 0;
        int ti = 0, tj = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (Z[i, j] > 0)
                {
                    s += Z[i, j];
                    k += 1;
                }
                if (Z[i, j] > mx)
                {
                    mx = Z[i, j];
                    ti = i;
                    tj = j;
                }
            }
        }
        s = s/k * 1.0;
        Z[ti, tj] = s;
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
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5)
            return null;
        int mx = 0;
        int k = 0;
        int mxs = 0;
        int mns = 0;
        int mn = int.MaxValue;
        for (int i = 0; i < 6; i++)
        {
            k = 0;
            for (int j = 0; j < 5; j++)
            {
                if (X[i, j] < 0)
                {
                    k += 1;
                }
            }
            if (k > mx)
            {
                mx = k;
                mxs = i;
            }
            if (k < mn)
            {
                mn = k;
                mns = i;
            }
        }
        int l = 0;
        for (int j = 0; j < 5; j++)
        {
            l = X[mxs, j];
            X[mxs, j] = X[mns, j];
            X[mns, j] = l;
        }

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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        int mx = 0;
        int k = 0;
        int mxs = 0;
        for (int i = 0; i < 7; i++)
        {
            k = 0;
            for (int j = 0; j < 5; j++)
            {
                if (A[i, j] > 0)
                {
                    k += A[i, j];
                }
            }
            if (k > mx)
            {
                mx = k;
                mxs = i;
            }
        }
        int[,] B = new int[6, 5];
        for (int j = 0; j < 5; j++)
        {
            for (int i = 0; i < mxs; i++)
                B[i, j] = A[i, j];
            for (int i = mxs; i < 6; i++)
                B[i, j] = A[i + 1, j];
        }
        A = B;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5)
            return null;
        int t = 0;
        int mn = A[4, 0];
        for (int j = 0; j < 7; j++)
        {
            if (mn > A[4, j])
            {
                t = j;
                mn = A[4, j];
            }
        }
        int[,] AA = new int[5, 8];
        for (int j = 0; j < t + 1; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                AA[i, j] = A[i, j];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            AA[i, t+ 1] = B[i];
        }
        for (int j = t + 2; j < 8; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                AA[i, j] = A[i, j - 1];
            }
        }
        A = AA;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        double mx = 0;
        int k = 0;
        for (int i = 0; i < 5; i++)
        {
            mx = A[i, 0];
            k = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    k = j;
                }
            }
            if (k == 0)
            {
                A[i, k + 1] = A[i, k + 1] * 2;
            }
            else if (k == 6)
            {
                A[i, k - 1] = A[i, k - 1] * 2;
            }
            else
            {
                if (A[i, k + 1] > A[i, k - 1])
                {
                    if (A[i, k - 1] > 0)
                        A[i, k - 1] = A[i, k - 1] * 2;
                    else
                        A[i, k - 1] =A[i, k - 1] * 0.5;
                }
                else
                {
                    if (A[i, k + 1] > 0)
                        A[i, k + 1] = A[i, k + 1] * 2;
                    else
                        A[i, k + 1] = A[i, k + 1] * 0.5;
                }
            }
        }

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        int mx = 0;
        int kp = 0;
        int ko = 0;
        int imx = 0;
        for (int j = 0; j < 5; j++)
        {
            mx = A[0, j]; 
            kp = 0;
            ko = 0;
            imx = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > 0)
                    kp++;
                else if (A[i, j] < 0)
                    ko++;
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    imx = i;
                }
            }
            if (kp > ko)
                A[imx, j] = 0;
            else
                A[imx, j] = imx + 1;
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return null;
        int mx = 0;
        int kp = 0;
        int ko = 0;
        int imx = 0;
        int sm = 0;
        for (int j = 0; j < 5; j++)
        {
            mx = A[0, j];
            imx = 0;
            sm = 0;
            for (int i = 0; i < 10; i++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    imx = i;
                }
            }
            for (int i = imx+ 1 ; i < 10; i++)
            {
                sm += A[i, j];
            }
            if (imx < 5)
                A[0, j] = sm;
        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
            return null;
        int mx = 0;
        int imx = 0;
        for (int j = 0; j < 5; j++)
        {
            mx = A[0, j];
            imx = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    imx = i;
                }
            }
            if (mx < B[j])
                A[imx, j] = B[j];
        }

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        double mx = 0;
        int imx = 0;
        double ps = 0;
        for (int j = 0; j < 5; j++)
        {
            mx = A[0, j];
            imx = 0;
            ps = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    imx = i;
                }
            }
            ps = (A[0, j] + A[6, j]) / 2 * 1.0;
            if (mx < ps)
                A[imx, j] = ps;
            else
                A[imx, j] = imx + 1;
        }
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n < 0)
            return null;
        int[,] answer = new int [n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if (i == j|| j - 3 == i || j - 6 == i)
                    answer[i, j] = 1;
                else
                    answer[i, j] = 0;
            }
        }
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
            return null;
        int mx = A[0, 0];
        int t = 0;
        for (int i = 0; i < 6; i++)
            if (A[i, i] > mx)
            {
                t = i;
                mx = A[i, i];
            }
        for (int i = 0; i < t; i++)
        {
            for (int j = i + 1; j < 6; j++)
                A[i, j] = 0;
        }
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
            return null;
        int mx1 = B[0, 0];
        int mx2 = B[1, 0];
        int i1 = 0;
        int i2 = 0;
        int s = 0;
        for (int i = 0; i < 5; i += 2)
        {
            mx1 = B[i, 0];
            i1 = 0;
            i2 = 0;
            mx2 = B[i + 1, 0];
            for (int j = 0; j < 6; j++)
            {
                if (mx1 < B[i, j])
                {
                    mx1 = B[i, j];
                    i1 = j;
                }
                if (mx2 < B[i + 1, j])
                {
                    mx2 = B[i + 1, j];
                    i2 = j;
                }
            }
            s = B[i, i1];
            B[i, i1] = B[i + 1, i2];
            B[i + 1, i2] = s;
        }

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;
        int[,] B = new int[6, 7];
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
                B[i, j] = A[i, 6 - j];
        }
        A = B;
        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
            return null;
        int[,] B = new int[7, 2];
        int mn = 0;
        for (int i = 0; i < 7; i++)
        {
            mn = matrix[i, 0];
            for (int j = 0; j < 5; j++)
            {
                if (mn > matrix[i, j])
                    mn = matrix[i, j];
            }
            B[i, 0] = mn;
            B[i, 1] = i;
        }
        int[,] A = new int[7, 5];
        int t = 0;
        for (int i = 1; i < 7; i++)
        {
            for (int j = 0; j < 7 - i; j++)
            {
                if (B[j, 0] < B[j + 1, 0])
                {
                    t = B[j, 0];
                    B[j, 0] = B[j + 1, 0];
                    B[j + 1, 0] = t;
                    t = B[j, 1];
                    B[j, 1] = B[j + 1, 1];
                    B[j + 1, 1] = t;
                }
            }
        }
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                A[i, j] = matrix[B[i, 1], j];
            }
        }
        matrix = A;
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
        if (matrix.GetLength(0) < 1 || matrix.GetLength(1) < 1)
            return null;
        int sm = 0;
        int k = 0;
        int[] answer = new int[2*matrix.GetLength(0) - 1];
        for (int i = matrix.GetLength(0) - 1; i > -1 * matrix.GetLength(0); i--)
        {
            sm = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j + i >= 0 && j + i < matrix.GetLength(0))
                    sm += matrix[i + j, j];
            }
            answer[k] = sm;
            k++;
        }
        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        if (matrix.GetLength(0) < 1 || matrix.GetLength(1) < 1|| k > matrix.GetLength(1) ||k >  matrix.GetLength(0)|| matrix.GetLength(0) != matrix.GetLength(1) || k < 1)
            return null;
        int mx = matrix[0, 0];
        int ii = 0;
        int ij = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (Math.Abs(matrix[i, j]) > mx)
                {
                    mx = Math.Abs(matrix[i, j]);
                    ii = i;
                    ij = j;
                }
            }
        }
        int t = 0;
        k = k - 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            t = matrix[i, k];
            matrix[i, k] = matrix[i, ij];
            matrix[i, ij] = t;
        }
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            t = matrix[k, j];
            matrix[k, j] = matrix[ii, j];
            matrix[ii, j] = t;
        }
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
        if (n < 1|| A.Length != n * n / 2 + n / 2 + n % 2 || B.Length != n * n / 2 + n / 2 + n % 2)
            return null;
        int[]answer = new int[n * n];
        int[,] AA = new int[n, n];
        int[,] BB = new int[n, n];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                AA[i, j] = A[k];
                BB[i, j] = B[k];
                k++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > j)
                {
                    AA[i, j] = AA[j, i];
                    BB[i, j] = BB[j, i];
                }
            }
        }
        k = 0;
        int sm = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sm = 0;
                for (int l = 0; l < n; l++)
                {
                    sm += AA[i, l] * BB[l, j];
                }
                answer[k] = sm;
                k++;
            }
        }
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
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7)
            return null;
        int[,] B = new int[7, 2];
        int k = 0;
        for (int j = 0; j < 7; j++)
        {
            k = 0;
            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, j] < 0)
                    k++;
            }
            B[j, 0] = k;
            B[j, 1] = j;
        }
        int[,] A = new int[5, 7];
        int t = 0;
        for (int i = 1; i < 7; i++)
        {
            for (int j = 0; j < 7 - i; j++)
            {
                if (B[j, 0] > B[j + 1, 0])
                {
                    t = B[j, 0];
                    B[j, 0] = B[j + 1, 0];
                    B[j + 1, 0] = t;
                    t = B[j, 1];
                    B[j, 1] = B[j + 1, 1];
                    B[j + 1, 1] = t;
                }
            }
        }
        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                A[i, j] = matrix[i, B[j, 1]];
            }
        }
        matrix = A;
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
        if (matrix.GetLength(0) < 1 || matrix.GetLength(1) < 1)
            return null;
        int f = 0;
        int kol = 0;
        int[] spi = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            f = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    f = 1;
                    kol++;
                    break;
                }
            }
            spi[i] = f;
        }
        if (matrix.GetLength(0) - kol <= 0)
            return null;
        int[,] A = new int[matrix.GetLength(0) - kol, matrix.GetLength(1)];
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (spi[i] == 0)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    A[k, j] = matrix[i, j];
                }
                k++;
            }
        }
        matrix = A;
        return matrix;
    }
    #endregion
}