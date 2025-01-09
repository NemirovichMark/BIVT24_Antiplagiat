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

        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        double sum =0, avg=0;
        int cnt = 0;
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7)
            return 0;
        for (int i=0; i< A.GetLength(0); i++)
        {
            for (int j=0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    cnt++;
                }
            }
        }
        avg = sum / cnt;
        answer = avg;
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

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here
        if (rowIndex == -1)
        {
            value = 0;
            rowIndex = 0;
        }
        for (int i=0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }
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

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = new double[A.GetLength(0)];
        // code here
        double sum = 0, cnt = 0, avg = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) 
            return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    cnt++;
                }
            }
            if (cnt == 0)
                avg = 0;
            else
                avg = sum / cnt;
            answer[i] = avg;
            sum = 0; cnt = 0; avg = 0;
        }
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

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here
        double min = A[0, 0];
        int k = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                k = i;
            }
        }
        for (int i = 0; i < A.GetLength(0) - 1; i++)
        {
            if (i < k)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i, j];
                }
            }
            else
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i + 1, j];
                }
            }
        }
        A = B;
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

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        answer = new int[A.GetLength(1)];
        int cnt = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3)
            return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0)
                    cnt++;
            }
            answer[j] = cnt;
            cnt = 0;
        }
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

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here
        if (B.GetLength(0) != n || B.GetLength(1) != m)
            return null;
        for (int i = 0; i < n; i++)
        {
            int min = B[i, 0], k = 0;
            for (int j = 1; j < m; j++)
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    k = j;
                }
            }
            int[] p = new int[B.GetLength(1)];
            p[0] = min;
            int i2 = 1;
            for (int j = 0; j < m; j++)
            {
                if (j != k)
                {
                    p[i2] = B[i, j];
                    i2++;
                }
            }
            for (int j = 0; j < m; j++)
            {
                B[i, j] = p[j];
            }
        }
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

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here
        if (F.GetLength(0) != n || F.GetLength(1) != m)
            return null;
        for (int i = 0; i < n; i++)
        {
            double s = 0, s2 = 0, sum = 0;
            int k = 0, p = -1;
            double max = F[i, 0];
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    k = j;
                }
                if (F[i, j] < 0)
                {
                    s = F[i, j];
                    p++;
                }
            }
            if (p == -1)
                continue;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] < 0)
                {
                    s2 = F[i, j];
                    break;
                }
            }
            sum = (s + s2) / 2;
            F[i, k] = sum;
        }
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

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7)
            return null;
        int n = G.GetLength(0), m = G.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            int max = G[i, 0], k = 0;
            for (int j = 1; j < m; j++)
            {
                if (G[i, j] > max)
                {
                    max = G[i, j];
                    k = j;
                }
            }
            int[] p = new int[G.GetLength(1)];
            for (int j = 0; j < m; j++)
            {
                if (j <= k)
                {
                    p[j] = G[i, j];
                }
                else if (j == k + 1)
                    p[j] = max;
                else
                    p[j] = G[i, j - 1];

            }
            for (int j = 0; j < m; j++)
            {
                G[i, j] = p[j];
            }
        }
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

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        if (B.Length != 7)
            return null;
        int k = 0, max = A[0, 5]; ;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > max)
            {
                max = A[i, 5];
                k = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[k, j] = B[j];
        }
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

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7)
            return null;
        int min = Math.Abs(F[1, 0]), k = 0;
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < min)
            {
                min = Math.Abs(F[1, j]);
                k = j;
            }
        }
        int[,] b = new int[F.GetLength(0), F.GetLength(1) - 1];
        for (int j = 0; j < F.GetLength(1) - 1; j++)
        {
            if (j < k + 1)
            {
                for (int i = 0; i < F.GetLength(0); i++)
                {
                    b[i, j] = F[i, j];
                }
            }
            else
            {
                for (int i = 0; i < F.GetLength(0); i++)
                {
                    b[i, j] = F[i, j + 1];
                }
            }
        }
        F = b;
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

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return null;
        int k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double sum = 0, avg = 0;
            int cnt = 0;
            double max = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    k = j;
                }
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    cnt++;
                }
            }
            if (cnt == 0)
                avg = 0;
            else
            {
                avg = sum / cnt;
            }
            A[i, k] = avg;
        }
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
        if (A.GetLength(0)!=5 || A.GetLength(1)!=7)
            return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = double.MinValue;
            int k = -1;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    k = j;
                }
            }
            if (i == 0)
            {
                if (A[i, k + 1] >= 0)
                    A[i, k + 1] = 2 * A[i, k + 1];
                else A[i, k + 1] = A[i, k + 1] / 2;
            }
            else if (i == 6)
            {
                if (A[i, k - 1] >= 0)
                    A[i, k - 1] = 2 * A[i, k - 1];
                else
                    A[i, k - 1] = A[i, k - 1] / 2;
            }
            else if (A[i, k + 1] > A[i, k - 1])
            {
                if (A[i, k - 1] >= 0)
                    A[i, k - 1] = 2 * A[i, k - 1];
                else
                    A[i, k - 1] = A[i, k - 1] / 2;
            }
            else
            {
                if (A[i, k - 1] >= 0)
                    A[i, k + 1] = 2 * A[i, k + 1];
                else
                    A[i, k + 1] = A[i, k + 1] / 2;
            }
        }

        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int a = 0;
            int b = 0;
            double max = double.MinValue;
            int k = -1;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    k = j;
                }
                if (A[j, i] > 0) a++;
                else b++;
            }
            if (a > b)
                A[k, i] = 0;
            else
                A[k, i] = k+1; // приавляю единичку, так как номер больше индекса на "1"
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return null;

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int m = int.MinValue;
            int k = -1, sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                sum += A[i, j];
                if (A[i, j] > m)
                {
                    m = A[i, j];
                    k = i;
                    sum = 0;
                }
                if (k < 5)
                    A[0, j] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
            return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = int.MinValue, k = -1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    k = i;
                }
            }
            if (max < B[j])
            {
                A[k, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
            return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double max = double.MinValue;
            int k = -1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    k = i;
                }
            }
            if (max < (A[0, j] + A[6, j]) / 2)
                A[k, j] = (A[0, j] + A[6, j]) / 2;
            else 
                A[k, j] = k + 1; // приавляю единичку, так как номер больше индекса на "1"
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
            return null;
        int[,] A = new int[n, 3 * n];
        int k=2;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                A[i, j] = ((j + k) % 3) / 2;
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
            return null;
        int max = int.MinValue, k = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                k = i;
            }
        }
        if (k == -1) 
            return null;
        for (int i = 0; i < k; i++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
            return null;
        int ind_1 = -1, ind_2 = -1;
        for (int i = 0; i < 6; i += 2)
        {
            int max_1 = int.MinValue, max_2 = int.MinValue, temp = 0;
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > max_1)
                {
                    max_1 = B[i, j];
                    ind_1 = j;
                }
            }
            for (int j = 0; j < 6; j++)
            {
                if (B[i + 1, j] > max_2)
                {
                    max_2 = B[i + 1, j];
                    ind_2 = j;
                }
            }
            temp = B[i, ind_1];
            B[i, ind_1] = B[i + 1, ind_2];
            B[i + 1, ind_2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;
        for(int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1)/2 ; j++)
            {
                int k = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - j - 1];
                A[i, A.GetLength(1) - j - 1] = k;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix == null || matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
            return default;
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < matrix.GetLength(0); j++)
            {
                int min_i = 1000, min_j = 1000;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] < min_i)
                        min_i = matrix[i, k];
                    if (matrix[j, k] < min_j)
                        min_j = matrix[j, k];
                }
                if (min_i < min_j)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
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
        answer = new int[2 * matrix.GetLength(0) - 1];
        int x = matrix.GetLength(0), y = matrix.GetLength(1);
        if (matrix == null || x != y || matrix.GetLength(0) == 0)
            return default;
        for (int a = -x + 1; a < y; a++)
        {
            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                int j = i + a;
                if (j >= 0 && j < x)
                    sum += matrix[i, j];
            }
            answer[a + x - 1] = sum;
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
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(0) || k < 1 || k > matrix.GetLength(0))
            return default;
        int x = matrix.GetLength(0), y = matrix.GetLength(1), n = x;
        int max = -1000, max_i = 0, max_j = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    max_i = i;
                    max_j = j;
                }
            }
        }
        if (max_i != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[max_i, i];
                matrix[max_i, i] = matrix[k - 1, i];
                matrix[k - 1, i] = temp;
            }
        }
        if (max_j != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, max_j];
                matrix[i, max_j] = matrix[i, k - 1];
                matrix[i, k - 1] = temp;
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
        int[,] matrixa = new int[n, n];
        int[,] matrixb = new int[n, n];
        int ind = 0;
        if (A == null || B == null || n <= 0 || A.Length != n * (n + 1) / 2 || B.Length != n * (n + 1) / 2)
            return default;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrixa[i, j] = A[ind];
                matrixb[i, j] = B[ind];
                ind++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrixa[j, i] = matrixa[i, j];
                matrixb[j, i] = matrixb[i, j];
            }
        }
        ind = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += matrixa[i, k] * matrixb[k, j];
                }
                answer[ind++] = sum;
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
        if (matrix == null || matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7)
            return default;
        bool fl;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            fl = false;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int cnt_i = 0, cnt_j = 0;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[k, j] < 0)
                        cnt_i++;
                    if (matrix[k, j + 1] < 0)
                        cnt_j++;
                }
                if (cnt_i > cnt_j)
                {
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        int temp = matrix[k, j];
                        matrix[k, j] = matrix[k, j + 1];
                        matrix[k, j + 1] = temp;
                    }
                    fl = true;
                }
            }
            if (fl == false)
                break;
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
        int cnt = 0;
        int[] a = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int count = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                a[cnt] = i;
                cnt++;
            }
        }
        int[,] b = new int[cnt, matrix.GetLength(1)];
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                b[i, j] = matrix[a[i], j];
            }
        }
        matrix = b;
        // end

        return matrix;
    }
    #endregion
}