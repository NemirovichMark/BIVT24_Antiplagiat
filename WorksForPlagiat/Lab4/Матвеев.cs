using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Reflection.Emit;
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
        int sum = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
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
        int minn = 10000;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < minn)
                {
                    minn = A[i, j];
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
        int[] answer = default(int[]);
        // code here

        if (A == null || A.GetLength(0) != 3 || A.GetLength(1) != 5)
        {
            return null;
        }

        answer = new int[A.GetLength(1)];

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int mx = A[0, j];

            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, j] > mx) mx = A[i, j];
            }

            answer[j] = mx;
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

        if (A.GetLength(0) < 5 || A.GetLength(1) < 7)
        {
            return null;
        }

        int maxind = 0;
        int maxel = A[0, 2];
        for (int i = 1; i < A.GetLength(0); i++)
        {
            if (A[i, 2] > maxel)
            {
                maxel = A[i, 2];
                maxind = i; 
            }
        }
        if (maxind != 3)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                int temp = A[maxind, j];
                A[maxind, j] = A[3, j];
                A[3, j] = temp;
            }
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5)
        {
            return null;
        }

        int mx = A[0, 0];
        int mxind = -1;
        for (int i = 1; i < 5; i++)
        {
            if (A[i, i] > mx)
            {
                mx = A[i, i];
                mxind = i;
            }
        }

        if (mxind != 3)
        {
            for (int i = 0; i < A.GetLength(1); i++)
            {
                int temp = A[i, 3];
                A[i, 3] = A[i, mxind];
                A[i, mxind] = temp;
            }
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
        for (int i = 0; i < n; i++)
        {
            int mx = -100000;
            int ind = -1;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    ind = j;
                }
            }
            
            if (ind != m - 1) 
            {
                int maxel = A[i, ind];
                for (int p = ind; p < m - 1; p++)
                {
                    A[i, p] = A[i, p + 1];
                }
                A[i, m - 1] = maxel;
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
            double mx = -100000;
            int ind = -1;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > mx)
                {
                    mx = C[i, j];
                    ind = j;
                }
            }

            for (int p = 0; p < ind; p++)
            {
                if (C[i, p] < 0) C[i, p] /= mx;
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8)
        {
            return null;
        }

        int I = 0;
        int J = 0;
        double mx = -1000;
        int cnt = 0;
        double sum = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {

            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > 0)
                {
                    cnt ++;
                    sum += Z[i, j];
                }
                if (Z[i, j] > mx)
                {
                    mx = Z[i, j];
                    I = i;
                    J = j;
                }
            }
        }
        double kvasik = sum / cnt;
        Z[I, J] = kvasik;
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

        if (X.GetLength(0) != 6 || X.GetLength(1) != 5)
        {
            return null;
        }
        int minNegatives = 7;
        int maxNegatives = -1;
        int minRow = -1;
        int maxRow = -1;

        for (int i = 0; i < X.GetLength(0); i++)
        {
            int negativeCount = 0;
            for (int j = 0; j < X.GetLength(1); j++)
            {
                if (X[i, j] < 0)
                    negativeCount++;
            }

            if (negativeCount < minNegatives)
            {
                minNegatives = negativeCount;
                minRow = i;
            }
            if (negativeCount > maxNegatives)
            {
                maxNegatives = negativeCount;
                maxRow = i;
            }
        }
        if (minRow != -1 && maxRow != -1 && minRow != maxRow)
        {
            for (int j = 0; j < X.GetLength(1); j++)
            {
                int temp = X[minRow, j];
                X[minRow, j] = X[maxRow, j];
                X[maxRow, j] = temp;
            }
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }

        int maxSum = 0;
        int maxRow = -1;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                maxRow = i;
            }
        }
        int[,] result = new int[A.GetLength(0) - 1, A.GetLength(1)];
        if (maxRow != -1)
        {
            int newRow = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (i == maxRow) continue;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    result[newRow, j] = A[i, j];
                }
                newRow++;
            }
        }
        A = result;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5)
        {
            return null;
        }

        int minIndex = 0;
        int minValue = A[4, 0];
        for (int j = 1; j < 7; j++)
        {
            if (A[4, j] < minValue)
            {
                minValue = A[4, j];
                minIndex = j;
            }
        }

        for (int j = 7; j > minIndex + 1; j--)
        {
            for (int i = 0; i < 5; i++)
            {
                A[i, j] = A[i, j - 1];
            }
        }

        for (int i = 0; i < 5; i++)
        {
            A[i, minIndex + 1] = B[i];
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int inmax = 0;
            double nmax = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > nmax)
                {
                    nmax = A[i, j];
                    inmax = j;
                }

            }
            if (inmax == 0)
            {
                if (A[i, 1] > 0) A[i, 1] *= 2;
                else A[i, 1] /= 2;
            }
            else if (inmax == A.GetLength(1) - 1)
            {
                if (A[i, A.GetLength(1) - 2] > 0) A[i, A.GetLength(1) - 2] *= 2;
                else A[i, A.GetLength(1) - 2] /= 2;
            }
            else
            {
                if (A[i, inmax - 1] <= A[i, inmax + 1])
                {
                    if (A[i, inmax - 1] > 0) A[i, inmax - 1] *= 2;
                    else A[i, inmax - 1] /= 2;
                }
                else
                {
                    if (A[i, inmax + 1] > 0) A[i, inmax + 1] *= 2;
                    else A[i, inmax + 1] /= 2;

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

        int row = A.GetLength(0);
        int col = A.GetLength(1);

        for (int j = 0; j < col; j++)
        {
            int pikmi = 0, shovel = 0;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > 0) pikmi++;
                else if (A[i, j] < 0) shovel++;
            }
            int imax = 0;
            double nmax = double.MinValue;
            for (int i = 0; i < row; i++)
            {
                if (A[i, j] > nmax)
                {
                    nmax = A[i, j];
                    imax = i;
                }
            }
            if (pikmi > shovel)
            {
                A[imax, j] = 0;
            }
            else
            {
                A[imax, j] = imax + 1;
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

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            int index = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }

            if (A.GetLength(0) / 2 > index)
            {
                int sum = 0;
                for (int i = index + 1; i < A.GetLength(0); i++)
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
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5)
        {
            return null;
        }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            int index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }

            if (A[index, j] < B[j])
            {
                A[index, j] = B[j];
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

        for (int j = 0; j < A.GetLength(1); j++)
        {
            double kirkorov = (A[0, j] + A[6, j]) / 2;

            double barabarabara = A[0, j];
            int maxIndex = 0;

            for (int i = 1; i < A.GetLength(0); i++)
            {
                if (A[i, j] > barabarabara)
                {
                    barabarabara = A[i, j];
                    maxIndex = i;
                }
            }
            if (barabarabara < kirkorov)
            {
                A[maxIndex, j] = kirkorov;
            }
            else
            {
                A[maxIndex, j] = maxIndex + 1; 
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        if (n <= 0)
        {
            return answer;
        }

        answer = new int[n, n * 3];

        for (int i = 0; i < answer.GetLength(0); i++)
        {
            for (int j = 0; j < answer.GetLength(1); j++)
            {
                answer[i, j] = 0;
            }
        }

        int count = -1;

        for (int i = 0; i < answer.GetLength(0); i++)
        {
            count++;
            for (int j = count; j < answer.GetLength(1);)
            {
                answer[i, j] = 1;
                j += 3;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 6 || m != 6)
        {
            return null;
        }

        int ii = 0;
        int max = A[0, 0];

        for (int i = 0; i < n; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                ii = i;
            }
        }
        for (int i = 0; i < ii; i++)
        {
            for (int j = i + 1; j < m; j++) 
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
        int n = B.GetLength(0);
        int m = B.GetLength(1);

        if (n != 6 || m != 6)
        {
            return null;
        }

        for (int i = 0; i < n; i+=2)
        {
            int maxim1 = B[i, 0];
            int indexmaxim1 = 0;
            int maxim2 = B[i + 1, 0];
            int indexmaxim2 = 0;

            for (int j = 0; j < m; j++)
            {
                if (B[i, j] > maxim1)
                {
                    maxim1 = B[i, j];
                    indexmaxim1 = j;
                }
            }

            for (int j = 0; j < m; j++)
            {
                if (B[i + 1, j] > maxim2)
                {
                    maxim2 = B[i + 1, j];
                    indexmaxim2 = j;
                }
            }

            int temp = B[i, indexmaxim1];
            B[i, indexmaxim1] = B[i + 1, indexmaxim2];
            B[i + 1, indexmaxim2] = temp;
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
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(1) != matrix.GetLength(0))
        {
            return null;
        }
        int n = matrix.GetLength(0);

        for (int i = 0; i < n * 4 - 4; i++)
        {
            int row, col;

            if (i < n)
            {
                row = 0;
                col = i;
            }
            else if (i < n * 2 - 1)
            {
                row = i - n + 1;
                col = n - 1;
            }
            else if (i < n * 3 - 2)
            {
                row = n - 1;
                col = n - 1 - (i - (n * 2 - 2));
            }
            else
            {
                row = n - 1 - (i - (n * 3 - 3));
                col = 0;
            }
            matrix[row, col] = 0;
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
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return null;
        }

        int n = matrix.GetLength(0);

        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j <= i; j++) 
            {
                if (i >= n / 2)
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
        // code here
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            return (null, null);
        }
        int n = matrix.GetLength(0);
        int khurma = 0;
        int kamen = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                khurma++;
            }
        }
        kamen = n * n - khurma;

        int[] upper = new int[khurma];
        int[] lower = new int[kamen];
        khurma = 0; kamen = 0;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j <= i - 1; j++)
            {
                lower[kamen++] = matrix[i, j];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                upper[khurma++] = matrix[i, j];
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
        if (matrix.GetLength(0) != 7 && matrix.GetLength(1) != 5)
        {
            return null;
        }

        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < row - i - 1; j++)
            {
                int salfetka = 0;
                int salfetka2 = 0;
                for (int l = 0; l < col; l++)
                {
                    if (matrix[j, l] > 0) salfetka++;
                    if (matrix[j + 1, l] > 0) salfetka2++;
                }
                if (salfetka < salfetka2)
                {
                    for (int l = 0; l < col; l++)
                    {
                        (matrix[j, l], matrix[j + 1, l]) = (matrix[j + 1, l], matrix[j, l]);
                    }
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
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            return null;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - c - 1; j++)
                    {
                        if (matrix[i, j] < matrix[i, j + 1])
                            (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
                    }
                }
            }
            else
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - c - 1; j++)
                    {
                        if (matrix[i, j] > matrix[i, j + 1])
                            (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
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
        int count = 0;
        int[] temp = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int banan = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    banan++;
                }
            }
            if (banan == 0)
            {
                temp[i] = 1;
                count++;
            }
            else
            {
                temp[i] = 0;
            }
        }
        int[,] B = new int[count, matrix.GetLength(1)];
        int chesnok = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (temp[i] == 1)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    B[chesnok, j] = matrix[i, j];
                }
                chesnok++;
            }
        }
        matrix = B;
        // end

        return matrix;
    }
    #endregion
}