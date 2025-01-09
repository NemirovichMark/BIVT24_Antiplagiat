using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
        int k = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return answer;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    answer += A[i, j];
                    k++;
                }
            }
        }
        answer /= k;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 4|| A == null) return default;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value += A[i, colIndex];
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
        double[] answer = default(double[]);
        // code here
        if (A.GetLength(0) != 4 || A.GetLength(1) != 6 || A == null) return default;
        answer = new double[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double sum = 0;
            int k = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k++;
                }
            }
            answer[i] = (k > 0) ? sum / k : 0;
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
        if (B.GetLength(0) != n || B.GetLength(1) != m || B == null) return default;
        int[,] nB = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int minInd = 0;
            for (int j = 1; j < m; j++)
            {
                if (B[i, j] < B[i, minInd])
                {
                    minInd = j;
                }
            }
            nB[i, 0] = B[i, minInd];
            int k = 1;
            for (int j = 0; j < m; j++)
            {
                if (j != minInd)
                {
                    nB[i, k] = B[i, j];
                    k++;
                }
            }
        }
        B = nB;
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
        if (G.GetLength(0) != 5 || G.GetLength(1) != 7 || G == null) return default;
        for (int i = 0; i < G.GetLength(0); i++)
        {
            double maxVal = double.MinValue;
            int maxInd = -1;
            for (int j = 0; j < G.GetLength(1) - 1; j++)
            {
                if (G[i, j] > maxVal)
                {
                    maxVal = G[i, j];
                    maxInd = j;
                }
            }
            for (int j =  G.GetLength(1) - 1; j > maxInd; j--)
            {
                G[i, j] = G[i, j - 1];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || A == null || B.Length != 7) return default;
        int maxInd = 0;
        int maxVal = A[0, 5];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] >  maxVal)
            {
                maxVal = A[i, 5];
                maxInd = i;
            }
        }
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[maxInd, j] = B[j];
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
        if (F.GetLength(0) != 5 || F.GetLength(1) != 7 || F == null) return default;
        int minInd = 0;
        int minVal = Math.Abs(F[1, 0]);
        for (int j = 1; j < F.GetLength(1); j++)
        {
            if (Math.Abs(F[1, j]) < minVal)
            {
                minVal = Math.Abs(F[1, j]);
                minInd = j;
            }
        }
        int column = minInd + 1;
        int[,] matrix = new int[F.GetLength(0), F.GetLength(1) - 1];
        for (int i = 0; i < F.GetLength(0); i++)
        {
            int k = 0;
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (j != column)
                {
                    matrix[i, k++] = F[i, j];
                }
            }
        }
        F = matrix;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || A == null) return default;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double maxVal = double.MinValue, sum = 0;
            int maxInd = -1, k = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                    k++;
                }
                if (A[i, j] >maxVal)
                {
                    maxVal = A[i, j];
                    maxInd = j;
                }
            }
            if (k > 0 && maxInd != -1)
            {
                A[i, maxInd] = sum / k;
            }
            else if (maxInd != -1)
            {
                A[i, maxInd] = 0;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7 || A == null) return default;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxInd = 0;
            double maxVal = A[i, 0];
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxInd = j;
                }
            }
            if (maxInd > 0 && maxInd < A.GetLength(1) - 1)
            {
                if (A[i, maxInd - 1] < A[i, maxInd + 1])
                {
                    if (A[i, maxInd - 1] < 0)
                    {
                        A[i, maxInd - 1] /= 2;
                    }
                    else
                    {
                        A[i, maxInd - 1] *= 2;
                    }
                }
                else
                {
                    if (A[i, maxInd + 1] < 0)
                    {
                        A[i, maxInd + 1] /= 2;
                    }
                    else
                    {
                        A[i, maxInd + 1] *= 2;
                    }
                }
            }
            else
            {
                if (maxInd == 0)
                {
                    if (A[i, maxInd + 1] > 0)
                    {
                        A[i, maxInd + 1] *= 2;
                    }
                    else
                    {
                        A[i, maxInd + 1] /= 2;
                    }
                }
                else
                {
                    if (A[i, maxInd - 1] > 0)
                    {
                        A[i, maxInd - 1] *= 2;
                    }
                    else
                    {
                        A[i, maxInd - 1] /= 2;
                    }
                }
            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
            // end

            return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || A == null) return default;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int posCount = 0;
            int negCount = 0;
            int maxInd = 0;
            double maxVal = A[0, j];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > 0)
                {
                    posCount++;
                }
                else if (A[i, j] < 0)
                {
                    negCount++;
                }

                if (A[i, j] > A[maxInd, j])
                {
                    maxInd = i;
                }
            }
            bool posit = posCount > negCount;
            A[maxInd, j] = posit ? 0 : maxInd + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5 || A == null) return default;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxInd = 0;
            double maxVal = A[0, j];
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxInd = i;
                }
            }
            if (maxInd < A.GetLength(0) / 2)
            {
                int sum = 0;

                for (int i = maxInd + 1; i < A.GetLength(0); i++)
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || A == null || B.Length != 5) return default;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxInd = 0;
            double maxVal = A[0, j];
            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxInd = i;
                }
            }
            if (B[j] > maxVal)
            {
                A[maxInd, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || A == null) return default;
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int maxInd = 0;
            double maxVal = A[0, j];

            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, j] > maxVal)
                {
                    maxVal = A[i, j];
                    maxInd = i;
                }
            }
            double halfSum = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
            if (maxVal < halfSum)
            {
                A[maxInd, j] = halfSum;
            }
            else
            {
                A[maxInd, j] = maxInd + 1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return default;
        int[,] matrix = new int[n, 3 * n];
        for (int i = 0; i < n; i++)
        {
            matrix[i, i] = 1;
            matrix[i, i + n] = 1;
            matrix[i, i + 2 * n] = 1;
        }
        answer = matrix;
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6 || A == null) return default;
        int size = 6;
        int maxVal = A[0, 0];
        int maxInd = -1;
        for (int i = 0; i < size; i++)
        {
            if (A[i, i] > maxVal)
            {
                maxVal = A[i, i];
                maxInd = i;
            }
        }
        for (int i = 0; i < maxInd; i++)
        {
            for (int j = i + 1; j < size; j++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6 || B == null) return default;
        int size = 6;
        for (int pair = 0; pair < 3; pair++)
        {
            int row1 = pair * 2;
            int row2 = row1 + 1;

            int maxInd1 = 0;
            int maxInd2 = 0;
            int maxVal1 = B[row1, 0];
            int maxVal2 = B[row2, 0];
            for (int j = 1; j < size; j++)
            {
                if (B[row1, j] > maxVal1)
                {
                    maxVal1 = B[row1, j];
                    maxInd1 = j;
                }

                if (B[row2, j] > maxVal2)
                {
                    maxVal2 = B[row2, j];
                    maxInd2 = j;
                }
            }
            (B[row1, maxInd1], B[row2, maxInd2]) = (B[row2, maxInd2], B[row1, maxInd1]);
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7 || A == null) return default;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1) / 2; j++)
            {
                (A[i, j], A[i, A.GetLength(1) - 1 - j]) = (A[i, A.GetLength(1) - 1 - j], A[i, j]);
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
        int row = matrix.GetLength(0);
        if (row != matrix.GetLength(1)) return default;
        for (int i = 0; i < row; i++)
        {
            matrix[i, 0] = 0;
            matrix[i, row - 1] = 0;
            matrix[0, i] = 0;
            matrix[row - 1, i] = 0;
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
        int row = matrix.GetLength(0);
        if (row != matrix.GetLength(1)) return default;
        for (int i = row / 2; i < row; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (i >= j)
                {
                    matrix[i, j] = 1;
                }
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) return (default, default);
        int n = matrix.GetLength(0);
        int upperCount = (n * (n + 1)) / 2;
        int lowerCount = (n * (n - 1)) / 2;
        upper = new int[upperCount];
        lower = new int[lowerCount];
        int upperInd = 0, lowerInd = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                upper[upperInd++] = matrix[i, j];
            }
        }
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                lower[lowerInd++] = matrix[i, j];
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
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5 || matrix == null) return default;
        int[] posCounts = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 0)
                {
                    posCounts[i]++;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - 1 - i; j++)
            {
                if (posCounts[j] < posCounts[j + 1])
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        (matrix[j, k], matrix[j + 1, k]) = (matrix[j + 1, k], matrix[j, k]);
                    }
                    (posCounts[j], posCounts[j + 1]) = (posCounts[j + 1], posCounts[j]);
                }
            }
        }
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return matrix;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            (matrix[i, k], matrix[i, k + 1]) = (matrix[i, k + 1], matrix[i, k]);
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                    {
                        if (matrix[i, k] > matrix[i, k + 1])
                        {
                            (matrix[i, k], matrix[i, k + 1]) = (matrix[i, k + 1], matrix[i, k]);
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0) return default;
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
            if (hasZero)
            {
                int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
                for (int l = 0; l < matrix.GetLength(0) - 1; l++)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (l < i) newMatrix[l, k] = matrix[l, k];
                        else newMatrix[l, k] = matrix[l + 1, k];
                    }
                }
                matrix = newMatrix;
                i--;
            }
        }
        // end

        return matrix;
    }
    #endregion
}