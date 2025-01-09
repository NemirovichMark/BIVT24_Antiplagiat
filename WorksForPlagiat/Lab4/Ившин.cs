using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return answer;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
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
        int sum = 0;
        double k = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return answer;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k++;
                }
            }
        }
        answer = sum / k;
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4) return answer;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j) answer += A[i, j];
            }
        }
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here
        if (A.GetLength(0) != 3 || A.GetLength(1) != 6) return (row, col);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (A[i, j] < A[row, col])
                {
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4 || colIndex > 4 || colIndex < 0) return (0, 0);
        for (int i = 0; i < 5; i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
            }
        }
        if (value == 0) return (0, 0);
        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return answer;
        answer = new int[4];
        int col = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < A[i, col])
                {
                    col = j;
                }
            }
            answer[i] = col;
        }
        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) return answer;
        int row = 0;
        answer = new int[5];
        for (int j = 0; j < 5; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (A[i, j] > A[row, j])
                {
                    row = i;
                }
            }
            answer[j] = A[row, j];
        }
        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6) return answer;
        int row = 0;
        answer = new double[4];
        for (int i = 0; i < 4; i++)
        {
            double sum = 0, k = 0;
            for (int j = 0; j < 6; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k++;
                }
            }
            if (k == 0) answer[i] = 0;
            else answer[i] = sum / k;
        }
        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            int jmax = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > A[i, jmax])
                {
                    jmax = j;
                }
            }
            var p = A[i, jmax];
            A[i, jmax] = A[i, 0];
            A[i, 0] = p;
        }
        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int imax = 0;
        for (int i = 0; i < 5; i++)
        {
            if (A[i, 2] > A[imax, 2])
            {
                imax = i;
            }
        }
        for (int j = 0; j < 7; j++)
        {
            var p = A[3, j];
            A[3, j] = A[imax, j];
            A[imax, j] = p;
        }
        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int[,] B = new int[4, 7];
        int imin = 0;
        for (int i = 0; i < 5; i++)
        {
            if (A[i, 0] < A[imin, 0])
            {
                imin = i;
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (i < imin)
                {
                    B[i, j] = A[i, j];
                }
                else
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
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int[,] B = new int[5, 6];
        int imax = 0, jmax = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > A[imax, jmax])
                {
                    imax = i;
                    jmax = j;
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (i < imax && j < jmax)
                {
                    B[i, j] = A[i, j];
                }
                else if (i >= imax && j < jmax)
                {
                    B[i, j] = A[i + 1, j];
                }
                else if (i < imax && j >= jmax)
                {
                    B[i, j] = A[i, j + 1];
                }
                else
                {
                    B[i, j] = A[i + 1, j + 1];
                }
            }
        }
        A = B;
        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5) return null;
        int jmax = 0;
        for (int i = 1; i < 5; i++)
        {
            if (A[i, i] > A[jmax, jmax]) jmax = i;
        }
        for (int i = 0; i < 5; i++)
        {
            var p = A[i, jmax];
            A[i, jmax] = A[i, 3];
            A[i, 3] = p;
        }
        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 3) return null;
        answer = new int[3];
        for (int j = 0; j < 3; j++)
        {
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                if (A[i, j] < 0) k++;
            }
            answer[j] = k;
        }
        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 5; i++)
        {
            int jmax = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > A[i, jmax])
                {
                    jmax = j;
                }
            }
            A[i, jmax] *= i + 1;
        }
        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here
        if (A.GetLength(0) != n || A.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > A[i, jmax])
                {
                    jmax = j;
                }
            }
            var p = A[i, jmax];
            for (int j = jmax; j < m - 1; j++)
            {
                A[i, j] = A[i, j + 1];
            }
            A[i, m - 1] = p;
        }
        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here
        if (B.GetLength(0) != n || B.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int jmin = 0;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] < B[i, jmin])
                {
                    jmin = j;
                }
            }
            var p = B[i, jmin];
            for (int j = jmin; j > 0; j--)
            {
                B[i, j] = B[i, j - 1];
            }
            B[i, 0] = p;
        }
        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here
        if (D.GetLength(0) != n || D.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int jmax = 0, jotr = -1, jjotr = -1;
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    jotr = j;
                    break;
                }
            }
            if (jotr == -1 || jotr == 0) continue;
            for (int j = m - 1; j >= 0; j--)
            {
                if (D[i, j] < 0)
                {
                    jjotr = j;
                    break;
                }
            }
            for (int j = 0; j < jotr; j++)
            {
                if (D[i, j] > D[i, jmax])
                {
                    jmax = j;
                }
            }
            var p = D[i, jmax];
            D[i, jmax] = D[i, jjotr];
            D[i, jjotr] = p;
        }
        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here
        if (C.GetLength(0) != n || C.GetLength(1) != m) return null;
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > C[i, jmax])
                {
                    jmax = j;
                }
            }
            for (int j = 0; j < jmax; j++)
            {
                if (C[i, j] < 0) C[i, j] /= C[i, jmax];
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return null;
        int imax = 0, jmax = 0, k = 0;
        double sum = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (Z[i, j] > Z[imax, jmax])
                {
                    imax = i;
                    jmax = j;
                }
                if (Z[i, j] > 0)
                {
                    sum += Z[i, j];
                    k++;
                }
            }
        }
        if (k != 0) Z[imax, jmax] = sum / k;
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
        int kmin = 100, kmax = -100, imin = -1, imax = -1;
        for (int i = 0; i < 6; i++)
        {
            int k = 0;
            for (int j = 0; j < 5; j++)
            {
                if (X[i, j] < 0) k++;
            }
            if (k < kmin)
            {
                kmin = k;
                imin = i;
            }
            if (k > kmax)
            {
                kmax = k;
                imax = i;
            }
        }
        for (int j = 0; j < 5; j++)
        {
            var p = X[imin, j];
            X[imin, j] = X[imax, j];
            X[imax, j] = p;
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
        int imax = -1, summax = -1;
        int[,] B = new int[6, 5];
        for (int i = 0; i < 7; i++)
        {
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                if (A[i, j] > 0) sum += A[i, j];
            }
            if (sum > summax)
            {
                summax = sum;
                imax = i;
            }
        }
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i < imax) B[i, j] = A[i, j];
                else B[i, j] = A[i + 1, j];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5) return null;
        int jmin = 0;
        for (int j = 0; j < 7; j++)
        {
            if (A[4, j] < A[4, jmin])
            {
                jmin = j;
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 7; j > jmin + 1; j--)
            {
                A[i, j] = A[i, j - 1];
            }
            A[i, jmin + 1] = B[i];
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
        for (int i = 0; i < 5; i++)
        {
            int jmax = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > A[i, jmax])
                {
                    jmax = j;
                }
            }
            if (jmax == 0 && A[i, 1] > 0) A[i, 1] *= 2;
            else if (jmax == 0 && A[i, 1] < 0) A[i, 1] /= 2;
            else if (jmax == 6 && A[i, 5] > 0) A[i, 5] *= 2;
            else if (jmax == 6 && A[i, 5] < 0) A[i, 5] /= 2;
            else if (A[i, jmax - 1] <= A[i, jmax + 1] && A[i, jmax - 1] > 0) A[i, jmax - 1] *= 2;
            else if (A[i, jmax - 1] <= A[i, jmax + 1] && A[i, jmax - 1] < 0) A[i, jmax - 1] /= 2;
            else if (A[i, jmax - 1] > A[i, jmax + 1] && A[i, jmax - 1] > 0) A[i, jmax + 1] *= 2;
            else A[i, jmax + 1] /= 2;
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < 5; j++)
        {
            int imax = 0, kpol = 0, kotr = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > 0) kpol++;
                if (A[i, j] < 0) kotr++;
                if (A[i, j] > A[imax, j])
                {
                    imax = i;
                }
            }
            if (kpol > kotr) A[imax, j] = 0;
            else A[imax, j] = imax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < 5; j++)
        {
            int imax = 0, sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (A[i, j] > A[imax, j])
                {
                    imax = i;
                }
            }
            if (imax <= 4)
            {
                for (int i = imax + 1; i < 10; i++)
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
        for (int j = 0; j < 5; j++)
        {
            int imax = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > A[imax, j])
                {
                    imax = i;
                }
            }
            if (B[j] > A[imax, j]) A[imax, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < 5; j++)
        {
            int imax = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > A[imax, j])
                {
                    imax = i;
                }
            }
            double polusum = (A[0, j] + A[6, j]) / 2.0;
            if (A[imax, j] < polusum) A[imax, j] = polusum;
            else A[imax, j] = imax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return null;
        answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if ((j - i) % n == 0) answer[i, j] = 1;
                else answer[i, j] = 0;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int imax = 0;
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > A[imax, imax]) imax = i;
        }
        for (int i = 0; i < imax; i++)
        {
            for (int j = i + 1; j < 6; j++)
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
        for (int i = 0; i < 6; i += 2)
        {
            int jmax1 = 0, jmax2 = 0;
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > B[i, jmax1]) jmax1 = j;
                if (B[i + 1, j] > B[i + 1, jmax2]) jmax2 = j;
            }
            var p = B[i, jmax1];
            B[i, jmax1] = B[i + 1, jmax2];
            B[i + 1, jmax2] = p;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                var p = A[i, j];
                A[i, j] = A[i, 6 - j];
                A[i, 6 - j] = p;
            }
        }
        // end

        return A;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        for (int i = 0, j = 0; i < matrix.GetLength(0); i++)
        {
            if (i == 0 || i == matrix.GetLength(0) - 1)
            {
                matrix[i, j] = 0;
                j++;
                if (j == matrix.GetLength(0))
                {
                    j = 0;
                }
                else i--;
            }
            else
            {
                matrix[i, 0] = 0;
                matrix[i, matrix.GetLength(1) - 1] = 0;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return null;
        int n = matrix.GetLength(0);
        for (int i = n / 2; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                matrix[i, j] = 1;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return (null, null);
        int n = matrix.GetLength(0);
        upper = new int[n * (n + 1) / 2];
        lower = new int[n * (n - 1) / 2];
        int u = 0, v = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j < i) lower[u++] = matrix[i, j];
                else upper[v++] = matrix[i, j];
            }
        }
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
        int[] A = new int[7];
        int[] B = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
        int[,] matrix1 = new int[7, 5];
        for (int i = 0; i < 7; i++)
        {
            int k = 0;
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] > 0) k++;
            }
            A[i] = k;
        }
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7 - i - 1; j++)
            {
                if (A[j] < A[j + 1])
                {
                    var p = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = p;

                    var t = B[j];
                    B[j] = B[j + 1];
                    B[j + 1] = t;
                }
            }
        }
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix1[i, j] = matrix[B[i], j];
            }
        }
        matrix = matrix1;
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
        int m = matrix.GetLength(1);
        int n = matrix.GetLength(0);
        if (n == 0 || m == 0) return null;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int k = 0; k < m; k++)
                {
                    for (int j = 0; j < m - k - 1; j++)
                    {
                        if (matrix[i, j] < matrix[i, j + 1])
                        {
                            var p = matrix[i, j + 1];
                            matrix[i, j + 1] = matrix[i, j];
                            matrix[i, j] = p;
                        }
                    }
                }
            }
            else
            {
                for (int k = 0; k < m; k++)
                {
                    for (int j = 0; j < m - k - 1; j++)
                    {
                        if (matrix[i, j] > matrix[i, j + 1])
                        {
                            var p = matrix[i, j + 1];
                            matrix[i, j + 1] = matrix[i, j];
                            matrix[i, j] = p;
                        }
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
        int m = matrix.GetLength(1);
        int n = matrix.GetLength(0);
        if (n == 0 || m == 0) return null;
        int num = 0;
        int[,] A = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int k = 0;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    k++;
                    break;
                }
            }
            if (k == 0)
            {
                for (int j = 0; j < m; j++)
                {
                    A[num, j] = matrix[i, j];
                }
                num++;
            }
        }
        matrix = new int[num, m];
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = A[i, j];
            }
        }
        // end

        return matrix;
    }
    #endregion
}