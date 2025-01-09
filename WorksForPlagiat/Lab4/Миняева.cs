using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return 0;
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
        // code here
        if (A.GetLength(0) != 3 || A.GetLength(1) != 6) return (0, 0);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
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
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) return null;
        int[] answer = new int[A.GetLength(1)];
        int max = int.MinValue;
        // code here

        for (int i = 0; i < A.GetLength(1); i++)
        {
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > max) max = A[j, i];
            }
            answer[i] = max;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int min = int.MaxValue;
        int rowmin = 0;
        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, 2] > A[rowmin, 2]) rowmin = i;
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int temp = A[rowmin, j];
            A[rowmin, j] = A[3, j];
            A[3, j] = temp;
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
        if (A.GetLength(0) != A.GetLength(1) & A.GetLength(0) != 5) return null;
        int amax = A[0, 0], imax = 0;
        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, i] > amax)
            {
                amax = A[i, i];
                imax = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int p = A[j, imax];
            A[j, imax] = A[j, 3];
            A[j, 3] = p;
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
        int[,] answer = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int max = int.MinValue;
            int colmax = -1;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    colmax = j;
                }
            }
            if (colmax != -1 && colmax != m - 1)
            {
                for (int k = colmax; k < m - 1; k++)
                {
                    A[i, k] = A[i, k + 1];
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
            double max = double.MinValue;
            int colmax = -1;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > max)
                {
                    max = C[i, j];
                    colmax = j;
                }
            }
            for (int k = 0; k < colmax; k++)
            {
                if (C[i, k] < 0)
                {
                    C[i, k] /= max;
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return null;
        double max = Z[0, 0];
        int n = 0, m = 0;
        double s = 0;
        int cnt = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > 0)
                {
                    s += Z[i, j];
                    cnt++;
                }
                if (Z[i, j] > max)
                {
                    max = Z[i, j];
                    n = i;
                    m = j;
                }
            }
        }
        Z[n, m] = s / cnt;
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
        int mincnt = int.MaxValue;
        int minrow = 0;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int cnt = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0) cnt++;
            }
            if (cnt < mincnt)
            {
                mincnt = cnt;
                minrow = i;
            }
        }
        int maxcnt = int.MinValue;
        int maxrow = 0;
        for (int i = 0; i < X.GetLength(0); i++)
        {
            int cnt = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0) cnt++;
            }
            if (cnt > maxcnt)
            {
                maxcnt = cnt;
                maxrow = i;
            }
        }
        for (int i = 0; i < X.GetLength(1); i++)
        {
            int p = X[minrow, i];
            X[minrow, i] = X[maxrow, i];
            X[maxrow, i] = p;
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
        int[,] answer = new int[A.GetLength(0) - 1, A.GetLength(1)];
        int maxsum = int.MinValue;
        int maxrow = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }
                if (sum > maxsum)
                {
                    maxsum = sum;
                    maxrow = i;
                }
            }
        }
        for (int i = 0; i < (A.GetLength(0) - 1); i++)
        {
            if (i < maxrow)
                for (int j = 0; j < A.GetLength(1); j++)
                    answer[i, j] = A[i, j];
            else
                for (int j = 0; j < A.GetLength(1); j++)
                    answer[i, j] = A[i + 1, j];
        }
        A = answer;
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
        int min = int.MaxValue;
        int col = 0;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            if (A[4, i] < min)
            {
                min = A[4, i];
                col = i;
            }
        }
        if (col == 8) return A;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < col + 1; j++)
            {
                A[i, j] = A[i, j];
            }
            for (int j = col + 1; j < A.GetLength(1); j++)
            {
                if (j == col + 1)
                {
                    A[i, j] = B[i];
                }
                else
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
            int colmax = 0;
            double max = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    colmax = j;
                }
            }
            if (colmax == 0)
            {
                if (A[i, colmax + 1] > 0) A[i, colmax + 1] *= 2;
                else A[i, colmax + 1] /= 2;
            }
            else if (colmax == A.GetLength(1) - 1)
            {
                if (A[i, colmax - 1] > 0) A[i, colmax - 1] *= 2;
                else A[i, colmax - 1] /= 2;
            }
            else
            {
                if (A[i, colmax - 1] > A[i, colmax + 1])
                {
                    if (A[i, colmax + 1] > 0) A[i, colmax + 1] *= 2;
                    else A[i, colmax + 1] /= 2;
                }
                else
                {
                    if (A[i, colmax - 1] > 0) A[i, colmax - 1] *= 2;
                    else A[i, colmax - 1] /= 2;
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxincol = int.MinValue;
            int imaxincolrow = 0;
            int cntpol = 0;
            int cntotr = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxincol)
                {
                    maxincol = A[i, j];
                    imaxincolrow = i;
                }
                if (A[i, j] > 0) cntpol++;
                else cntotr++;
            }
            if (cntpol > cntotr)
            {
                A[imaxincolrow, j] = 0;
            }
            else A[imaxincolrow, j] = imaxincolrow + 1;

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
            int sum = 0;
            int rowmax = 0;
            int max = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    rowmax = i;
                }
            }
            if (rowmax < (A.GetLength(0) / 2))
            {
                for (int k = rowmax + 1; k < A.GetLength(0); k++)
                {
                    sum += A[k, j];
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
            int imax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
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
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int rowmax = 0;
            double max = double.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    rowmax = i;
                }
            }
            if (A[rowmax, j] < ((A[0, j] + A[A.GetLength(0) - 1, j]) / 2))
            {
                A[rowmax, j] = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            }
            else A[rowmax, j] = rowmax + 1;
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        if (n <= 0) return answer;
        answer = new int[n, n * 3];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                answer[i, j] = 0;
            }
        }
        int cnt = -1;
        for (int i = 0; i < n; i++)
        {
            cnt++;
            for (int j = cnt; j < 3 * n; j += 3)
            {
                answer[i, j] = 1;
            }
        }

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) return null;
        int amax = A[0, 0];
        int imax = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, i] > amax)
            {
                amax = A[i, i];
                imax = i;
            }
        }
        for (int i = 0; i < imax; i++)
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
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int imax1 = 0, imax2 = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > B[i, imax1]) imax1 = j;
                if (B[i + 1, j] > B[i + 1, imax2]) imax2 = j;
            }
            int temp = B[i, imax1];
            B[i, imax1] = B[i + 1, imax2];
            B[i + 1, imax2] = temp;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int[,] temp = new int[A.GetLength(0), A.GetLength(1)];
        for (int j = 0; j < A.GetLength(0); j++)
        {
            int k = 0;
            for (int i = A.GetLength(1) - 1; i >= 0; i--)
            {
                temp[j, k++] = A[j, i];
            }
        }
        A = temp;
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5) return null;
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        int[] rows = new int[row];
        for (int i = 0; i < row; i++) rows[i] = i;

        for (int i = 0; i < row - 1; i++)
        {
            for (int j = 0; j < row - i - 1; j++)
            {
                int min1 = int.MaxValue;
                for (int k = 0; k < col; k++)
                    if (matrix[rows[j], k] < min1) min1 = matrix[rows[j], k];

                int min2 = int.MaxValue;
                for (int k = 0; k < col; k++)
                    if (matrix[rows[j + 1], k] < min2) min2 = matrix[rows[j + 1], k];

                if (min1 < min2)
                {
                    int temp = rows[j];
                    rows[j] = rows[j + 1];
                    rows[j + 1] = temp;
                }
            }
        }

        int[,] sortedMatrix = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                sortedMatrix[i, j] = matrix[rows[i], j];
            }
        }

        // end

        return sortedMatrix;
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        if (row != col) return null;
        answer = new int[2 * row - 1];

        if (row == col)
        {
            for (int k = 0; k < 2 * row - 1; k++)
            {
                int sum = 0;
                if (k < row)
                {
                    for (int i = row - k - 1, j = 0; i < row; i++, j++)
                    {
                        sum += matrix[i, j];
                    }
                }
                else
                {
                    for (int i = k - row + 1, j = 0; i < row; j++, i++)
                    {
                        sum += matrix[j, i];
                    }
                }
                answer[k] = sum;

            }
            return answer;
        }
        else
            return default;
        // end
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0 || k > matrix.GetLength(0) || k < 1) return null;
        int n = matrix.GetLength(0);
        int maxcol = 0;
        int maxrow = 0;
        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    maxrow = i; maxcol = j;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            int temp = matrix[i, maxcol];
            matrix[i, maxcol] = matrix[i, k - 1];
            matrix[i, k - 1] = temp;
        }
        for (int j = 0; j < n; j++)
        {
            int temp = matrix[maxrow, j];
            matrix[maxrow, j] = matrix[k - 1, j];
            matrix[k - 1, j] = temp;
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
        if (A.Length + A.Length - n != n * n || B.Length + B.Length - n != n * n) return null;
        int[] answer = new int[n * n];
        // code here
        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrixA[i, j] = A[k];
                matrixA[j, i] = A[k];
                matrixB[i, j] = B[k];
                matrixB[j, i] = B[k];
                k++;
            }
        }
        int[,] matrixanswer = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int s = 0;
                for (int m = 0; m < n; m++)
                {
                    s += matrixA[i, m] * matrixB[m, j];
                }
                matrixanswer[i, j] = s;
            }
        }
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[index++] = matrixanswer[i, j];
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
        int[] cols = new int[matrix.GetLength(1)];
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        for (int i = 0; i < cols.Length; i++) cols[i] = i;
        for (int i = 0; i < col - 1; i++)
        {
            for (int j = 0; j < col - i - 1; j++)
            {
                int cnt1 = 0;
                int cnt2 = 0;
                for (int k = 0; k < row; k++)
                    if (matrix[k, cols[j]] < 0) cnt1++;
                for (int k = 0; k < row; k++)
                    if (matrix[k, cols[j + 1]] < 0) cnt2++;

                if (cnt1 > cnt2)
                {
                    int temp = cols[j];
                    cols[j] = cols[j + 1];
                    cols[j + 1] = temp;
                }
            }
        }
        int[,] sortedMatrix = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                sortedMatrix[i, j] = matrix[i, cols[j]];
            }
        }
        matrix = sortedMatrix;
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
        if (matrix.GetLength(0) == 0) return null;
        int cnt = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool nol = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    nol = true;
                    break;
                }
            }
            if (nol == false) cnt++;
        }
        if (cnt == 0) return new int[0, 0];
        int[,] newmatrix = new int[cnt, matrix.GetLength(1)];
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool nol = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    nol = true;
                    break;
                }
            }
            if (nol == false)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newmatrix[index, j] = matrix[i, j];
                }
                index++;
            }
        }
        matrix = newmatrix;
        // end

        return matrix;
    }
    #endregion
}
