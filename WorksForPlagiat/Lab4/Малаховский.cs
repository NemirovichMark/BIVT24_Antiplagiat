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
        double s = 0;
        int count = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return 0;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count++;
                }
            }
        }
        answer = s / count;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4)
        {
            return (0, 0);

        }
        for (int i = 0; i < A.GetLength(0); i++)
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
        if (A.GetLength(0) == 4 || A.GetLength(1) == 6)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                double s = 0;
                double count = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                    {
                        s += A[i, j];
                        count++;
                    }
                }
                if (count == 0)
                {
                    s = 0;
                }
                else
                {
                    s = Math.Round(s / count, 2);
                }
                answer[i] = s;
                s = 0;
            }
        }
        else
        {
            answer = null;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int[,] B = new int[A.GetLength(0) - 1, A.GetLength(1)];
        double min = A[0, 0];
        double count = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < min)
            {
                min = A[i, 0];
                count = i;
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i < count)
                {
                    B[i, j] = A[i, j];
                }
                else if (i > count)
                {
                    B[i - 1, j] = A[i, j];
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
        int[] answer = new int[A.GetLength(1)];
        // code here
        if (A.GetLength(0) != 4 && A.GetLength(1) != 3)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int count = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] < 0)
                {
                    count++;
                }
            }
            answer[i] = count;
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
        int[,] A = new int[n, m];
        if (B.GetLength(0) != n || B.GetLength(1) != m)
        {
            return null;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int min = B[i, 0];
            int count = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] < min)
                {
                    min = B[i, j];
                    count = j;
                }
            }
            A[i, 0] = min;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j < count)
                {
                    A[i, j + 1] = B[i, j];
                }
                else if (j > count)
                {
                    A[i, j] = B[i, j];
                }
            }
        }
        B = A;
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
        {
            return null;
        }
        for (int i = 0; i < F.GetLength(0); i++)
        {
            int count = 0;
            double max = F[i, 0];
            double ch1 = 0;
            double ch2 = 0;
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] > max)
                {
                    max = F[i, j];
                    count = j;
                }
                if (ch1 == 0 && F[i, j] < 0)
                {
                    ch1 = F[i, j];
                }
                if (F[i, j] < 0)
                {
                    ch2 = F[i, j];
                }
            }
            if (ch1 != 0 || ch2 != 0)
            {
                F[i, count] = (ch1 + ch2) / 2;
            }
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
        int[,] A = new int[G.GetLength(0), G.GetLength(1)];
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < G.GetLength(0); i++)
        {
            int count = 0;
            int max = G[i, 0];
            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (G[i, j] > max)
                {
                    count = j;
                    max = G[i, j];
                }
            }
            A[i, count] = max;
            A[i, count + 1] = max;
            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (j < count)
                {
                    A[i, j] = G[i, j];
                }
                if (j > count + 1)
                {
                    A[i, j] = G[i, j - 1];
                }
            }
        }
        G = A;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || B.Length != 7)
        {
            return null;
        }
        int max = A[0, 5];
        int indexmax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] > 0)
            {
                max = A[i, 5];
                indexmax = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[indexmax, j] = B[j];
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
        {
            return null;
        }
        int[,] A = new int[F.GetLength(0), F.GetLength(1) - 1];
        int minn = Math.Abs(F[1, 0]);
        int jmin = 0;
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < minn)
            {
                minn = Math.Abs(F[1, j]);
                jmin = j;
            }
        }
        for (int i = 0; i < F.GetLength(0); i++)
        {
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (j <= jmin)
                {
                    A[i, j] = F[i, j];
                }
                else if (j > jmin + 1)
                {
                    A[i, j - 1] = F[i, j];
                }
            }
        }
        F = A;
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
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = A[i, 0];
            int jmax = 0;
            double s = 0;
            double count = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    jmax = j;
                }
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count++;
                }
            }
            if (count == 0)
            {
                A[i, jmax] = 0;
            }
            else
            {
                A[i, jmax] = s / count;
            }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double max = A[i, 0];
            int jmax = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    jmax = j;
                }
            }
            if (jmax == 0)
            {
                if (A[i, jmax + 1] >= 0)
                {
                    A[i, jmax + 1] *= 2;
                }
                else
                {
                    A[i, jmax + 1] /= 2;
                }
            }
            else if (jmax == A.GetLength(1) - 1)
            {
                if (A[i, jmax - 1] >= 0)
                {
                    A[i, jmax - 1] *= 2;
                }
                else
                {
                    A[i, jmax - 1] /= 2;
                }
            }
            else if (A[i, jmax - 1] > A[i, jmax + 1])
            {
                if (A[i, jmax + 1] >= 0)
                {
                    A[i, jmax + 1] *= 2;
                }
                else
                {
                    A[i, jmax + 1] /= 2;
                }
            }
            else if (A[i, jmax - 1] < A[i, jmax + 1])
            {
                if (A[i, jmax - 1] >= 0)
                {
                    A[i, jmax - 1] *= 2;
                }
                else
                {
                    A[i, jmax - 1] /= 2;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int cpol = 0;
            int cotr = 0;
            int jmax = 0;
            int max = A[0, i];
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    jmax = j;
                }
                if (A[j, i] > 0)
                {
                    cpol++;
                }
                if (A[j, i] < 0)
                {
                    cotr++;
                }
            }
            if (cpol > cotr)
            {
                A[jmax, i] = 0;
            }
            else
            {
                A[jmax, i] = jmax + 1;
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
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int max = A[0, i];
            int jmax = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    jmax = j;
                }
            }
            if (jmax < (A.GetLength(0) - 1) / 2)
            {
                int s = 0;
                for (int j = jmax + 1; j < A.GetLength(0); j++)
                {
                    s += A[j, i];
                }
                A[0, i] = s;
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
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int max = A[0, i];
            int jmax = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    jmax = j;
                }
            }
            if (B[i] > max)
            {
                A[jmax, i] = B[i];
            }
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
        for (int i = 0; i < A.GetLength(1); i++)
        {
            double max = A[0, i];
            int jmax = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max)
                {
                    max = A[j, i];
                    jmax = j;
                }
            }
            double s = (A[0, i] + A[A.GetLength(0) - 1, i]) / 2;
            if (A[jmax, i] < s)
            {
                A[jmax, i] = s;
            }
            else
            {
                A[jmax, i] = jmax + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0)
        {
            return null;
        }
        int[,] answer = new int[n, 3 * n];
        // code here
        double count = 0;
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                if (j == count || j == n + i || j == 2 * n + i)
                {
                    answer[i, j] = 1;
                }
                else
                {
                    answer[i, j] = 0;
                }
            }
            count++;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6)
        {
            return null;
        }
        int max = A[0, 0];
        int imax = 0;
        int jmax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i == j && A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                    jmax = j;
                }
            }
        }
        for (int i = 0; i < imax; i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (j > i)
                {
                    A[i, j] = 0;
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
        {
            return null;
        }
        int max1 = B[0, 0];
        int max2 = B[1, 0];
        int jmax1 = 0;
        int jmax2 = 0;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (i % 2 == 0 && B[i, j] > max1)
                {
                    max1 = B[i, j];
                    jmax1 = j;
                }
                else if (B[i, j] > max2)
                {
                    max2 = B[i, j];
                    jmax2 = j;
                }
            }
            if (i % 2 != 0)
            {
                int temp = B[i - 1, jmax1];
                B[i - 1, jmax1] = B[i, jmax2];
                B[i, jmax2] = temp;
                if (i < 5)
                {
                    max1 = B[i + 1, 0];
                    max2 = B[i + 2, 0];
                }
                jmax1 = 0;
                jmax2 = 0;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
        {
            return null;
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - j - 1];
                A[i, A.GetLength(1) - j - 1] = temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        for (int k = 0; k < A.GetLength(0); k++)
        {
            for (int i = 0; i < A.GetLength(0) - 1 - k; i++)
            {
                int min1 = A[i, 0];
                int min2 = A[i + 1, 0];
                int jmin1 = 0;
                int jmin2 = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < min1)
                    {
                        min1 = A[i, j];
                        jmin1 = j;
                    }
                    if (A[i + 1, j] < min2)
                    {
                        min2 = A[i + 1, j];
                        jmin2 = j;
                    }
                }
                if (min1 < min2)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        int temp = A[i, j];
                        A[i, j] = A[i + 1, j];
                        A[i + 1, j] = temp;
                    }
                }
            }
        }
        // end

        return A;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) <= 0) return answer;
        answer = new int[2 * matrix.GetLength(0) - 1];
        for (int i = 0; i < 2 * matrix.GetLength(0) - 1; i++)
        {
            answer[i] = 0;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                answer[j - i + (matrix.GetLength(0) - 1)] += matrix[i, j];
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
    public int[,] Task_3_5(int[,] A, int k)
    {
        // code here
        if (A.GetLength(0) != A.GetLength(1) || k <= 0)
        {
            return null;
        }
        k = k - 1;
        int imax = 0;
        int jmax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
                if (Math.Abs(A[i, j]) > Math.Abs(A[imax, jmax]))
                {
                    imax = i;
                    jmax = j;
                }
        }
        if (imax != k)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                int temp = A[imax, j];
                A[imax, j] = A[k, j];
                A[k, j] = temp;
            }
        }
        if (jmax != k)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int temp = A[i, jmax];
                A[i, jmax] = A[i, k];
                A[i, k] = temp;
            }
        }
        // end

        return A;
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
        int[] answer = new int[n*n];

        // code here
        int rows = A.Length, cols = B.Length;
        if ((A.Length + A.Length - n != n * n) || (B.Length + B.Length - n != n * n))
        {
            return null;
        }
        int[,] A1 = new int[n, n];
        int[,] A2 = new int[n, n];
        for (int i = 0, num = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                A1[i, j] = A[num];
                A1[j, i] = A[num];
                A2[i, j] = B[num];
                A2[j, i] = B[num];
                num++;
            }
        }
        for (int i = 0, num = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                {
                    s += A1[i, j] * A2[j, k];
                }
                answer[num] = s;
                num++;
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
    public int[,] Task_3_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        int[] numbers = new int[A.GetLength(1)];
        int[] countotr = new int[A.GetLength(1)];
        int[,] A1 = new int[A.GetLength(0), A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0) count++;
            }
            numbers[j] = j; 
            countotr[j] = count;
        }
        for (int i = 1, j = i + 1; i < A.GetLength(1);)
        {
            if (i == 0 || countotr[i] >= countotr[i - 1])
            {
                i = j;
                j++;
            }
            else if (countotr[i] < countotr[i - 1])
            {
                int temp = countotr[i];
                countotr[i] = countotr[i - 1];
                countotr[i - 1] = temp;
                int temp_num = numbers[i];
                numbers[i] = numbers[i - 1];
                numbers[i - 1] = temp_num;
                i--;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                A1[i, j] = A[i, numbers[j]];
            }
        }
        // end
        A = A1;
        return A;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] A)
    {
        // code here
        int count0 = 0;
        int[] numbers = new int[A.GetLength(0)];
        for (int i = 0, num = 0; i < A.GetLength(0); i++)
        {
            bool flag = true;
            for (int j = 0; j < A.GetLength(1); j++)
                if (A[i, j] == 0)
                {
                    count0++;
                    flag = false;
                    break;
                }
            if (flag == false)
            {
                numbers[num++] = i;
            }
        }
        int[,] A1 = new int[A.GetLength(0) - count0, A.GetLength(1)];
        for (int i = 0, num = 0; i < A.GetLength(0); i++)
        {
            if (i == numbers[num])
            {
                num++;
            }
            else
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A1[i, j] = A[i, j];
                }
            }

        }
        A = A1;
        // end

        return A;
    }
    #endregion
}