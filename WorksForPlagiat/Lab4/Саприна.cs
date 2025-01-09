using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.Sockets;
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

        int row = A.GetLength(0);
        int col = A.GetLength(1);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
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

        int r = A.GetLength(0), c = A.GetLength(1);
        int min = 100000;
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
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
        int[] answer = new int[A.GetLength(1)];
        // code here

        int row = A.GetLength(0), col = A.GetLength(1);
        int max = -1000;
        if (row != 3 || col != 5) return null;
        for (int i = 0; i < col; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (A[j, i] > max) max = A[j, i];
            }
            answer[i] = max;
            max = -1000;
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

        int row = A.GetLength(0), col = A.GetLength(1);
        int min = 0, st = 0;
        if (row != 5 || col != 7) return null;
        for (int i = 0; i < row; i++)
        {
            if (A[i, 2] > min)
            {
                min = A[i, 2];
                st = i;
            }
        }
        int n = 0;
        for (int j = 0; j < col; j++)
        {
            n = A[st, j];
            A[st, j] = A[3, j];
            A[3, j] = n;
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

        int row = A.GetLength(0), col = A.GetLength(1);
        int max = -1000, st = 0;
        if (row != 5 || col != 5) return null;
        for (int i = 0; i < row; i++)
        {
            if (A[i,i] > max)
            {
                max = A[i,i];
                st = i;
            }
        }
        int n = 0;
        for (int i = 0; i < row; i++)
        {
            n = A[i, st];
            A[i, st] = A[i, 3];
            A[i, 3] = n;
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
        int row = A.GetLength(0), col = A.GetLength(1);
        int max = -10000, imax = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = j;
                }
            }
            int nu = 0;
            for (int j = imax; j < col-1; j++)
            {
                nu = A[i, j + 1];
                A[i, j] = nu;
            }
            A[i, col-1] = max;
            max = -10000;
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

        int row = C.GetLength(0), col = C.GetLength(1);
        double max = -10000;
        int c = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (C[i, j] > max)
                {
                    max = C[i, j];
                    c = j;
                }
            }
            for (int j = 0; j < c; j++)
            {
                if (C[i, j] < 0) C[i, j] /= max;
            }
            max = -1000;
            c = 0;
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

        int row = Z.GetLength(0), col = Z.GetLength(1);
        double sum = 0, sr, max = -10000;
        int k = 0, r = 0, c = 0;
        if (row != 6 || col != 8) return null;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (Z[i, j] > 0)
                {
                    sum += Z[i, j];
                    k++;
                }
                if (Z[i, j] > max)
                {
                    max = Z[i, j];
                    r = i;
                    c = j;
                }
            }
        }
        sr = sum / k;
        sr = Math.Round(sr, 2);
        Z[r, c] = sr;
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

        int row = X.GetLength(0), col = X.GetLength(1);
        int kmax = 0, kmin = 100, k = 0, imax = 0, imin = 0;
        if (row != 6 || col != 5) return null;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (X[i, j] < 0)
                {
                    k++;
                }
            }
            if (k > kmax)
            {
                kmax = k;
                imax = i;
            }
            if (k < kmin)
            {
                kmin = k;
                imin = i;
            }
            k = 0;
        }
        int n = 0;
        for (int j = 0; j < col; j++)
        {
            n = X[imax, j];
            X[imax, j] = X[imin, j];
            X[imin, j] = n;
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

        int row = A.GetLength(0), col = A.GetLength(1);
        int sum = 0, msum = -10000, imax = 0;
        if (row != 7 || col != 5) return null;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }
            }
            if (sum > msum)
            {
                msum = sum;
                imax = i;
            }
            sum = 0;
        }
        int[,] answer = new int[A.GetLength(0) - 1, A.GetLength(1)];
        int n = 0;
        for (int i = 0; i < row; i++)
        {
            if (i == imax) continue;
            for (int j = 0; j < col; j++)
            {
                answer[n,j] = A[i, j];

            }
            n++;
        }
        // end

        return answer;
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

        int row = A.GetLength(0), col = A.GetLength(1);
        int min = 10000, jmin = 0;
        if (row != 5 || col != 8 || B.Length != 5) return null;
        for (int j = 0; j < col; j++)
        {
            if (A[4, j] < min)
            {
                min = A[4, j];
                jmin = j;
            }
        }
        if (jmin != A.GetLength(1) - 1)
        {
            for (int i = 0; i < row; i++)
            {
                A[i, jmin + 1] = B[i];
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
        int row = A.GetLength(0), col = A.GetLength(1);
        double max = -10000;
        int imax = 0;
        if (row != 5 || col != 7) return null;
        for (int i = 0; i < row; i++)
        {
            max = -10000;
            for (int j = 0; j < col; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = j;
                }
            }
            if (imax == 0)
            {
                if (A[i, 1] > 0) A[i, 1] *= 2;
                else A[i, 1] /= 2;
            }
            else if (imax == (col - 1))
            {
                if (A[i, imax - 1] > 0) A[i, imax - 1] *= 2;
                else A[i, imax - 1] /= 2;
            }
            else if (A[i, imax + 1] > A[i, imax - 1])
            {
                if (A[i, imax - 1] > 0) A[i, imax - 1] *= 2;
                else A[i, imax - 1] /= 2;
            }
            else if (A[i, imax + 1] < A[i, imax - 1])
            {
                if (A[i, imax + 1] > 0) A[i, imax + 1] *= 2;
                else A[i, imax + 1] /= 2;
            }
        }

        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        int row = A.GetLength(0), col = A.GetLength(1);
        if (row != 7 || col != 5) return null;
        for (int j = 0; j < col; j++)
        {
            double max = -10000;
            int imax = 0, kp = 0, ko = 0;
            for (int i = 0; i <  row; i++)
            {
                if (A[i, j] > 0) kp++;
                if (A[i,j] < 0) ko++;
                if (A[i,j] > max)
                {
                    max = A[i,j];
                    imax = i;
                }
            }
            if (kp > ko) A[imax, j] = 0;
            else A[imax, j] = imax+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        int row = A.GetLength(0), col = A.GetLength(1);
        if (row != 10 || col != 5) return null;
        for (int j = 0; j < col; j++)
        {
            int max = -10000, sum = 0, imax = 0;
            for (int i = 0; i < row; i++)
            {
                if (A[i,j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (imax > 5) break;
            for (int i = imax + 1; i < row; i++)
            {
                sum += A[i, j];
            }
            A[0, j] = sum;
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        int row = A.GetLength(0), col = A.GetLength(1);
        if (row != 7 || col != 5 || B.Length != 5) return null;
        for (int j = 0; j < col;j++)
        {
            int max = -1000, imax = 0;
            for (int i = 0; i < row;i++)
            {
                if (A[i,j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (A[imax, j] < B[j]) A[imax, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        int row = A.GetLength(0), col = A.GetLength(1);
        if (row != 7 || col != 5) return null;
        for (int j = 0; j < col; j++)
        {
            double max = -1000, n = (A[0, j] + A[row-1, j]) / 2; 
            int imax = 0;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (A[imax, j] < n) A[imax, j] = n;
            else A[imax, j] = imax+1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) return null;
        int[,] answer = new int[n, 3 * n];
        // code here

        int k = 0;
        for (int j = 0; j < answer.GetLength(1); j++)
        {
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                answer[i, j] = 0;
            }
            answer[k, j] = 1;
            k++;
            if (k == 3) k = 0;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int row = A.GetLength(0), col = A.GetLength(1);
        int imax = 0;
        for (int i = 0; i < row; i++)
        {
            if (A[i,i] > A[imax,imax])
            {
                imax = i;
            }
        }
        for (int i = 0; i < imax;i++)
        {
            for (int j = i+1; j < col; j++)
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

        int row = B.GetLength(0), col = B.GetLength(1);
        if (row != 6 || col != 6) return null;
        int imax1 = 0, imax2 = 0, k = 0;
        for (int i = 0; i < row; i++)
        {
            int max1 = -10000, max2 = -10000;
            k++;
            for (int j=0; j < col; j++)
            {
                if (k == 1)
                {
                    if (B[i,j] > max1)
                    {
                        max1 = B[i,j];
                        imax1 = j;
                    }
                }
                if (k == 2)
                {
                    if (B[i, j] > max2)
                    {
                        max2 = B[i, j];
                        imax2 = j;
                    }
                }
            }
            int n = 0;
            if (k == 2)
            {
                n = B[i-1, imax1];
                B[i - 1, imax1] = B[i, imax2];
                B[i, imax2] = n;
                k = 0;
            }
        }
            // end

            return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        int row = A.GetLength(0), col = A.GetLength(1);
        if (row != 6 || col != 7) return null;
        int[,] B = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            int k = 0;
            for (int j = col-1; j >= 0; j--)
            {
                B[i, k] = A[i, j];
                k++;
            }
        }
        // end

        return B;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        if (row != col || row <= 0 || col <= 0) return null;
        for (int i = 0; i < col * row; i++)
        {
            int m = i / col, n = i % col;
            if (m == 0 || m == col -1 || n == 0 || n == col - 1)
            {
                matrix[m, n] = 0;
            }
        }
        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        if (row != col || row <= 0 || col <= 0) return null;
        for (int i = row/2; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (j == i + 1) break;
                else matrix[i, j] = 1;
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here

        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        if (row != col || row <= 0 || col <= 0) return (null, null);
        int m = 0;
        for (int i = 0; i <= col; i++)
        {
            m += i;
        }
        int n = row * col - m;
        int[] a = new int[m], b = new int[n];
        int a1 = 0, b1 = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (j >= i)
                {
                    a[a1] = matrix[i, j];
                    a1++;
                }
                else
                {
                    b[b1] = matrix[i, j];
                    b1++;
                }
            }
        }
        upper = a;
        lower = b;
        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        int[,] a = new int[row, col];
        int[] b = new int[row];
        int bj = 0, ai = 0;
        for (int i = 0; i < row; i++)
        {
            int k = 0;
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] > 0) k++;
            }
            b[bj] = k;
            bj++;
        }
        for (int c = 5; c >= 0; c--)
        {
            for (int i = 0; i < row; i++)
            {
                if (b[i] == c)
                {
                    for (int j = 0; j < col; j++)
                    {
                        a[ai, j] = matrix[i, j];
                    }
                    ai++;
                }
            }
        }
        matrix = a;
        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here
        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        if (row <= 0 || col <= 0) return null;
        for (int i = 0; i < row; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 1, m = 2; j < col;)
                {
                    if (j == 0 || matrix[i, j] <= matrix[i, j - 1])
                    {
                        j = m;
                        m++;
                    }
                    else
                    {
                        int n = matrix[i, j];
                        matrix[i, j] = matrix[i, j - 1];
                        matrix[i, j - 1] = n;
                        j--;
                    }
                }
            }
            if (i % 2 == 1)
            {
                for (int j = 1, m = 2; j < col;)
                {
                    if (j == 0 || matrix[i, j] >= matrix[i, j - 1])
                    {
                        j = m;
                        m++;
                    }
                    else
                    {
                        int n = matrix[i, j];
                        matrix[i, j] = matrix[i, j - 1];
                        matrix[i, j - 1] = n;
                        j--;
                    }
                }
            }
        }

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        int row = matrix.GetLength(0), col = matrix.GetLength(1);
        if (row <= 0 || col <= 0) return null;
        int k = 0, n = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] == 0) k++;
            }
            if (k == 0) n++;
            k = 0;
        }
        int[,] a = new int[n, col];
        int h = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (matrix[i,j] == 0) k++;
            }
            if (k == 0)
            {
                for (int j = 0; j < col; j++)
                {
                    a[h,j] = matrix[i,j];
                }
                h++;
            }
        }
        matrix = a;
        // end

        return matrix;
    }
    #endregion
}