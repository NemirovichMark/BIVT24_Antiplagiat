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
    public bool IsErrorMatrix(int[,] A)
    {
        bool allZero = true;
        foreach (var x in A) if (x != 0) allZero = false;
        return allZero;
    }
    public bool IsErrorMatrix(double[,] A)
    {
        bool allZero = true;
        foreach (var x in A) if (x != 0) allZero = false;
        return allZero;
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
        double sr = 0, n = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sr += A[i, j];
                    n++;
                }
            }
        }
        if (n == 0) return 0;
        answer = sr / n;
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
        if (A.GetLength(1) <= colIndex) return (0, 0);
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }
        if (rowIndex == -1) return (0, 0);
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
        if (IsErrorMatrix(A)) return null;

        double[] answer = new double[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double sr = 0, n = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0) {
                    sr += A[i, j];
                    n++;
                }
            }
            if (n == 0) answer[i] = 0;
            else answer[i] = sr / n;
        }

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
        if (IsErrorMatrix(A)) return null;

        int minInd = 0;
        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[minInd, 0] > A[i, 0]) minInd = i;
        }
        int[,] ans = new int[A.GetLength(0) - 1, A.GetLength(1)];
        for (int i = 0; i < minInd; i++)
        {
            for (int j = 0; j < A.GetLength(1); j++) ans[i, j] = A[i, j];
        }
        for (int i = minInd + 1; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++) ans[i - 1, j] = A[i, j];
        }
        return ans;
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
        if (IsErrorMatrix(A)) return null;

        int[] answer = new int[A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int count = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] < 0) count++;
            }
            answer[j] = count;
        }
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
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int minInd = 0;
            for (int j = 1; j < B.GetLength(1); j++) if (B[i, minInd] > B[i, j]) minInd = j;
            int temp = B[i, minInd];
            for (int j = minInd; j > 0; j--) B[i, j] = B[i, j - 1];
            B[i, 0] = temp;
        }
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
        for (int i = 0; i < F.GetLength(0); i++)
        {
            int imax = 0;
            int ifirst = -1, ilast = -1;
            for (int j = 0; j < F.GetLength(1); j++) if (F[i, j] > F[i, imax]) imax = j;
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] < 0)
                {
                    ifirst = j;
                    break;
                }
            }
            for (int j = F.GetLength(1) - 1; j >= 0; j--)
            {
                if (F[i, j] < 0)
                {
                    ilast = j;
                    break;
                }
            }
            if (ilast != -1) F[i, imax] = (F[i, ifirst] + F[i, ilast]) / 2;
        }
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
        if (IsErrorMatrix(G)) return null;

        for (int i = 0; i < G.GetLength(0); i++)
        {
            int imax = 0;
            for (int j = 0; j < G.GetLength(1) - 1; j++) if (G[i, j] > G[i, imax]) imax = j;
            for (int j = G.GetLength(1) - 1; j > imax; j--) G[i, j] = G[i, j - 1];
        }
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
        if (IsErrorMatrix(A) || A.GetLength(1) != B.Length) return null;
        int imax = 0;
        for (int i = 1; i < A.GetLength(0); i++) if (A[i, 5] > A[imax, 5]) imax = i;
        for (int i = 0; i < B.GetLength(0); i++) A[imax, i] = B[i];
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
        if (IsErrorMatrix(F)) return null;
        int imin = 0;
        for (int i = 1; i < F.GetLength(1); i++) if (Math.Abs(F[1, imin]) > Math.Abs(F[1, i])) imin = i;
        if (imin == F.GetLength(1) - 1) return F;
        int[,] ans = new int[F.GetLength(0), F.GetLength(1) - 1];
        for (int i = 0; i < F.GetLength(0); i++)
        {
            for (int j = 0; j <= imin; j++) ans[i, j] = F[i, j];
            for (int j = imin + 2; j < F.GetLength(1); j++) ans[i, j - 1] = F[i, j];
        }
        return ans;
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
        if (IsErrorMatrix(A)) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double sr = 0, n = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sr += A[i, j];
                    n++;
                }
            }
            sr = (n > 0) ? sr / n : 0;
            int imax = 0;
            for (int j = 1; j < A.GetLength(1); j++) if (A[i, imax] < A[i, j]) imax = j;
            A[i, imax] = sr;
        }
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
        if (IsErrorMatrix(A)) return null;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int imax = 0;
            for (int j = 1; j < A.GetLength(1); j++) if (A[i, imax] < A[i, j]) imax = j;
            int ind = 0;
            if (imax == 0) ind = 1;
            else if (imax == A.GetLength(1) - 1) ind = A.GetLength(-1) - 2;
            else
            {
                if (A[i, imax - 1] < A[i, imax + 1]) ind = imax - 1;
                else ind = imax + 1;
            }
            if (A[i, ind] < 0) A[i, ind] /= 2;
            else A[i, ind] *= 2;
        }
        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        if (IsErrorMatrix(A)) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int imax = 0, pos = 0, neg = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > A[imax, j]) imax = i;
                if (A[i, j] > 0) pos++;
                else if (A[i, j] < 0) neg++;
            }
            if (pos > neg) A[imax, j] = 0;
            else A[imax, j] = imax;
        }
        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        if (IsErrorMatrix(A)) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int imax = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[imax, j] < A[i, j]) imax = i;
            }
            if (imax < A.GetLength(0) / 2)
            {
                int sum = 0;
                for (int i = imax + 1; i < A.GetLength(0); i++)
                {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }
        }
        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (IsErrorMatrix(A) || A.GetLength(1) != B.Length) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int imax = 0;
            for (int i = 1; i < A.GetLength(0); i++) if (A[imax, j] < A[i, j]) imax = i;
            if (A[imax, j] < B[j]) A[imax, j] = B[j];
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        if (IsErrorMatrix(A)) return null;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int imax = 0;
            for (int i = 1; i < A.GetLength(0); i++) if (A[imax, j] < A[i, j]) imax = i;
            double halfS = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            if (A[imax, j] < halfS) A[imax, j] = halfS;
            else A[imax, j] = imax;
        }
        return A;
    }
    public int[,] Task_2_6(int n)
    {
        if (n <= 0) return null;
        int[,] answer = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            answer[i, i] = 1;
            answer[i, n + i] = 1;
            answer[i, n + n + i] = 1;
        }
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        if (IsErrorMatrix(A)) return null;
        int imax = 0;
        for (int i = 1; i < Math.Min(A.GetLength(0), A.GetLength(1)); i++) if (A[imax, imax] < A[i, i]) imax = i;
        for (int i = 0; i < imax; i++)
        {
            for (int j = i + 1; j < A.GetLength(1); j++) A[i, j] = 0;
        }
        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        if (IsErrorMatrix(B)) return null;
        int[] imaxes = new int[B.GetLength(0)];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            int imax = 0;
            for (int j = 0; j < B.GetLength(1); j++) if (B[i, imax] < B[i, j]) imax = j;
            imaxes[i] = imax;
        }
        for (int i = 0; i < B.GetLength(0) - 1; i += 2)
        {
            (B[i, imaxes[i]], B[i + 1, imaxes[i + 1]]) = (B[i + 1, imaxes[i + 1]], B[i, imaxes[i]]);
        }
        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        if (IsErrorMatrix(A)) return null;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                (A[i, j], A[i, A.GetLength(1) - 1 - j]) = (A[i, A.GetLength(1) - 1 - j], A[i, j]);
            }
        }
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, 0] = 0;
            matrix[0, i] = 0;
            matrix[i, matrix.GetLength(1) - 1] = 0;
            matrix[matrix.GetLength(0) - 1, i] = 0;
        }
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return null;
        for (int i = matrix.GetLength(0) / 2; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j <= i; j++) matrix[i, j] = 1;
        }
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (null, null);
        int n = matrix.GetLength(0);
        int[] upper = new int[n * (n + 1) / 2];
        int[] lower = new int[n * (n - 1) / 2];
        int indUp = 0, indDown = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i > j) lower[indDown++] = matrix[i, j];
                else upper[indUp++] = matrix[i, j];
            } 
        }
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
        if (IsErrorMatrix(matrix)) return null;
        int[][] arr = new int[matrix.GetLength(0)][];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int pos = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0) pos++;
            }
            arr[i] = new int[]{ pos, i };
        }

        // Cool gnom sort
        for (int i = 1; i < arr.Length; i++)
        {
            int j = i;
            var temp = arr[j];
            while (j > 0 && temp[0] > arr[j - 1][0])
            {
                arr[j] = arr[j - 1];
                j--;
            }
            arr[j] = temp;
        }

        foreach (var x in arr)
        {
            Console.WriteLine(x[0] + " " + x[1]);
        }

        int[,] ans = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                ans[i, j] = matrix[arr[i][1], j];
            }
        }

        return ans;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            // Double bubble sort
            for (int j = 0; j < matrix.GetLength(1) / 2; j++)
            {
                for (int k = j, k2 = matrix.GetLength(1) - 1 - j; k < matrix.GetLength(1) - 1 - j; k++, k2--)
                {
                    if (matrix[i, k] > matrix[i, k + 1])
                    {
                        (matrix[i, k], matrix[i, k + 1]) = (matrix[i, k + 1], matrix[i, k]);
                    }
                    if (matrix[i, k2] < matrix[i, k2 - 1])
                    {
                        (matrix[i, k2], matrix[i, k2 - 1]) = (matrix[i, k2 - 1], matrix[i, k2]);
                    }
                }
            }

            if (i % 2 == 0)
            {
                for (int j = 0; j < matrix.GetLength(1) / 2; j++)
                {
                    (matrix[i, j], matrix[i, matrix.GetLength(1) - 1 - j]) = (matrix[i, matrix.GetLength(1) - 1 - j], matrix[i, j]);
                }
            }
        }

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        int n = 0;
        bool[] arrHasZero = new bool[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool hasZero = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (!hasZero) n++;
            arrHasZero[i] = hasZero;
        }

        int[,] ans = new int[n, matrix.GetLength(1)];
        for (int i = 0, k = 0; i < matrix.GetLength(0); i++)
        {
            if (arrHasZero[i]) continue;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                ans[k, j] = matrix[i, j];
            }
            k++;
        }
        return ans;
    }
    #endregion
}