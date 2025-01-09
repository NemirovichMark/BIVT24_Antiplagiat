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
        int[,] matrix = {
                { 1, 2, -3, 7, 7, 0 },
                { 5, 6, -7, 9, -11, 1 },
                { 9, 10, 11, 15, 15, 2 },
                { -13, 14, 5, 25, -19, 3 },
                { 5, 6, -7, 8, -99, 4},
                { 0, 0, -1, -2, -3, 5 }
            };
        int k = 2;
        program.Task_3_5(matrix, k);

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
        int q = 0;
        int nom = 0;
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    nom = A[i, j];
                    if (nom > 0)
                    {
                        q++;
                        answer += A[i, j];
                    }
                }

            }
            answer = answer / q;
        }

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
        if ((A.GetLength(0) == 5) && (colIndex <= 4))
        {
            for (int i = 0; i < 5; i++)
            {
                if (A[i, colIndex] < 0)
                {
                    value = A[i, colIndex];
                    rowIndex = i;
                    break;
                }
            }
        }
        if (rowIndex == -1)
        {
            value = 0;
            rowIndex = 0;
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 4 || m != 6)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            int s = 0;
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count++;
                }
            }
            if (count > 0)
            {
                answer[i] = (double)s / count;
            }
            else
            {
                answer[i] = 0;
            }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || A == null) return default;
        int minInd = 0;
        int minVal = A[0, 0];
        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, 0] < minVal)
            {
                minVal = A[i, 0];
                minInd = i;
            }
        }
        int[,] matrix = new int[A.GetLength(0) - 1, A.GetLength(1)];
        int k = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (i != minInd)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    matrix[k, j] = A[i, j];
                }
                k++;
            }
        }
        A = matrix;

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
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3 || A == null) return default;
        answer = new int[A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0)
                {
                    answer[j]++;
                }
            }
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
        int max = int.MaxValue;
        int nom = 0;
        int[,] A = new int[B.GetLength(0), B.GetLength(1)];
        if ((B.GetLength(0) == n) && (B.GetLength(1) == m))
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (B[i, j] < max)
                    {
                        max = B[i, j];
                        nom = j;
                    }
                }
                A[i, 0] = B[i, nom];
                for (int j = 0; j < nom; j++)
                {
                    A[i, j + 1] = B[i, j];
                }
                for (int j = nom + 1; j < m; j++)
                {
                    A[i, j] = B[i, j];
                }
                nom = 0;
                max = int.MaxValue;

            }
        }
        else
            A = null;


        // end

        return A;
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
        if (F.GetLength(0) != n || F.GetLength(1) != m || F == null) return default;
        for (int i = 0; i < n; i++)
        {
            double maxVal = int.MinValue;
            int maxInd = -1, firstNeg = -1, lastNeg = -1;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > maxVal)
                {
                    maxVal = F[i, j];
                    maxInd = j;
                }
                if (F[i, j] < 0)
                {
                    if (firstNeg == -1)
                    {
                        firstNeg = j;
                    }
                    lastNeg = j;
                }
            }
            if (firstNeg != -1 && lastNeg != -1 && maxInd != -1)
            {
                double sum = (F[i, firstNeg] + F[i, lastNeg]) / 2;
                F[i, maxInd] = sum;
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
        double max = double.MinValue;
        int nom = 0;
        int[,] F = new int[5, 7];
        if ((G.GetLength(0) == 5) && (G.GetLength(1) == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (G[i, j] > max)
                    {
                        max = G[i, j];
                        nom = j;
                    }
                }
                for (int j = 0; j < nom; j++)
                {
                    F[i, j] = G[i, j];
                }
                F[i, nom] = G[i, nom];
                F[i, nom + 1] = G[i, nom];
                for (int j = nom + 2; j < 7; j++)
                {
                    F[i, j] = G[i, j - 1];
                }
                nom = 0;
                max = double.MinValue;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    G[i, j] = F[i, j];
                }
            }



        }
        else
        {
            G = null;
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
        double max = double.MinValue;
        int nom = 0;
        if ((A.GetLength(0) == 5) && (A.GetLength(1) == 7) && (B.Length == 7))
        {
            for (int i = 0; i < 5; i++)
            {
                if (A[i, 6] > max)
                {
                    max = A[i, 6];
                    nom = i;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                A[nom + 1, i] = B[i];
            }


        }
        else
        {
            A = null;
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
        int[,] A = new int[5, 6];
        int n = F.GetLength(0);
        int m = F.GetLength(1);
        if (n != 5 || m != 7)
        {
            return null;
        }
        int amin = 10000, jmin = 0;
        for (int j = 0; j < m; j++)
        {
            if (Math.Abs(F[1, j]) < amin)
            {
                amin = Math.Abs(F[1, j]);
                jmin = j;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= jmin; j++)
            {
                A[i, j] = F[i, j];
            }
            for (int j = jmin + 2; j < m; j++)
            {
                A[i, j - 1] = F[i, j];
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 5 || m != 7)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            double amax = -1000;
            int jmax = 0;
            double s = 0;
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > amax)
                {
                    amax = A[i, j];
                    jmax = j;
                }
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    count++;
                }
            }
            if (count > 0)
            {
                double k = s / count;
                A[i, jmax] = k;
            }
            else
            {
                A[i, jmax] = 0;
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
        int n = 5, m = 7;
        double max = double.MinValue;
        int[] index = new int[n];
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 0; j < m; j++)
                if (A[i, j] > max)
                {
                    jmax = j;
                    max = A[i, j];
                }
            switch (jmax)
            {
                case 0:
                    if (A[i, jmax + 1] > 0)
                        A[i, jmax + 1] *= 2;
                    else A[i, jmax + 1] /= 2;
                    break;
                case 6:
                    if (A[i, jmax - 1] > 0)
                        A[i, jmax - 1] *= 2;
                    else A[i, jmax - 1] /= 2;
                    break;
                default:
                    if (A[i, jmax - 1] < A[i, jmax + 1])
                    {
                        if (A[i, jmax - 1] < 0) A[i, jmax - 1] /= 2;
                        else A[i, jmax - 1] *= 2;
                    }
                    else
                    {
                        if (A[i, jmax + 1] < 0) A[i, jmax + 1] /= 2;
                        else A[i, jmax + 1] *= 2;
                    }
                    break;
            }
        }

        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5) { return null; }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int polcount = 0, otrcount = 0, max = -10000, maxin1 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0) { polcount++; }
                if (A[i, j] < 0) { otrcount++; }
                if (A[i, j] > max) { max = A[i, j]; maxin1 = i; }
            }
            if (polcount > otrcount) { A[maxin1, j] = 0; } else { A[maxin1, j] = maxin1 + 1; }
        }


        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 10 || m != 5) return null;
        int inmax = 0;
        for (int j = 0; j < m; j++)
        {
            int max = -100000, sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    inmax = i;
                }
            }
            if (inmax > 5) break;
            for (int i = inmax + 1; i < n; i++)
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
        if (A == null || A.GetLength(0) != 7 || A.GetLength(1) != 5 || B == null || B.Length != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = -1000000, maxi = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    maxi = i;
                }
            }
            if (A[maxi, j] < B[j]) A[maxi, j] = B[j];
        }

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
        int indmax = 0;
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > A[indmax, j])
                    indmax = i;

            }
            double s = (A[0, j] + A[n - 1, j]) / 2;
            if (A[indmax, j] < s)
                A[indmax, j] = s;
            else
                A[indmax, j] = indmax + 1;

        }


        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        answer = new int[n, n * 3];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 3; j++)
            {
                if (i == j % 3) answer[i, j] = 1;
            }
        }


        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight < 3 || AHeight != AWeight)
            return default(int[,]);

        int maxValue = A[0, 0], iMax = 0;
        for (int i = 0; i < AHeight; i++)
        {
            if (A[i, i] > maxValue)
            {
                iMax = i;
                maxValue = A[i, i];
            }
        }

        for (int i = 0; i < iMax; i++)
        {
            for (int j = 0; j < AWeight; j++)
            {
                if (j > i)
                    A[i, j] = 0;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B == null || B.GetLength(0) != 6 || B.GetLength(1) != 6) { return null; }
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int max1 = -10000, max2 = -10000, maxin1 = 0, maxin2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max1) { max1 = B[i, j]; maxin1 = j; }
                if (B[i + 1, j] > max2) { max2 = B[i + 1, j]; maxin2 = j; }
            }
            B[i, maxin1] = max2;
            B[i + 1, maxin2] = max1;
        }

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A == null || A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < (A.GetLength(1) - 1) / 2; j++)
            {
                int t = A[i, j];
                A[i, j] = A[i, A.GetLength(1) - 1 - j];
                A[i, A.GetLength(1) - 1 - j] = t;
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
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            int ind = 0, min = 1000000000;
            for (int j = 1; j < m; j++)
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    ind = j;
                }
            a[i] = matrix[i, ind];
        }
        for (int x = 1; x < n; x++)
        {
            int i = x;
            while (i > 0 && a[i - 1] < a[i])
            {
                int p = a[i - 1];
                a[i - 1] = a[i];
                a[i] = p;
                for (int j = 0; j < m; j++)
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
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight != AWeight || AHeight < 3)
            return answer;

        answer = new int[AHeight * 2 - 1];

        for (int i = 0; i < AHeight; i++)
        {
            for (int j = 0; j < AHeight; j++)
            {
                int ind = j - i + AHeight - 1;
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != 5 || m != 7) return default;
        int[] a = new int[m];
        for (int j = 0; j < m; j++)
        {
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] < 0)
                    k++;
            }
            a[j] = k;
        }
        for (int x = 1; x < m; x++)
        {
            int j = x;
            while (j > 0 && a[j - 1] > a[j])
            {
                int p = a[j - 1];
                a[j - 1] = a[j];
                a[j] = p;
                for (int line = 0; line < n; line++)
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
        if (matrix == null || matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7) return null;
        bool[] a = new bool[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    a[i] = true;
                    break;
                }
            }
        }
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (a[i] == false) k++;
        }
        int[,] matrix1 = new int[k, matrix.GetLength(1)];
        for (int i1 = 0, ik = 0; i1 < matrix.GetLength(0); i1++, ik++)
        {
            if (a[i1] == true)
            {
                ik--;
                continue;
            }
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                matrix1[ik, j1] = matrix[i1, j1];
            }
        }
        matrix = matrix1;


        // end

        return matrix;
    }
    #endregion
}