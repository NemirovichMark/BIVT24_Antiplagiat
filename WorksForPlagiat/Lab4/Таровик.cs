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

        int n = A.GetLength(0);
        int m = A.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        int min = 10000;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
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
        int[] answer = default(int[]);
        // code here
         int k = 0;
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) return default;
        answer= new int[A.GetLength(1)];
        for ( int j = 0; j< A.GetLength(1); j++)
        {
            int maximum = -1000000;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if ((A[i, j] > maximum))
                {
                    maximum = A[i, j];
                }
            }
            answer[k] = maximum;
            k++;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 7) return default;
        int max = -100000, ii = 0, p = 0;
        for (int j = 1; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (A[i, 2] > max)
                {
                    max = A[i, 2];
                    ii = i;
                }
            }
        }
        for (int j = 0; j < m; j++)
        {
            p = A[3, j];
            A[3, j] = A[ii, j];
            A[ii, j] = p;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 5) return default;
        int max = -1000000, ii = 0, p = 0;
        for (int i = 1; i < n; i++)
        {
            if (A[i, i] > max)
            {
                max = A[i, i];
                ii = i;
            }
        }
        for (int j = 0; j < m; j++)
        {
            p = A[j, 3];
            A[j, 3] = A[j, ii];
            A[j, ii] = p;
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
        int max = int.MinValue, ii = 0, jj = 0;
        int p = 0;
        if (A.GetLength(0) != n || A.GetLength(1) != m) return default;
        for (int i = 0; i < n; i++)
        {
            max = int.MinValue;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    jj = j;
                }
            }
            if (jj != m - 1)
            {
                p = A[i, jj];
                for (int j = jj; j < m - 1; j++)
                {
                    A[i, j] = A[i, j + 1];
                }
                A[i, m - 1] = p;
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
        if (C.GetLength(0) != n || C.GetLength(1) != m) return default;
        for (int i = 0; i < n; i++)
        {
            double max = C[i, 0], jj = 0;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > max)
                {
                    max = C[i, j];
                    jj = j;
                }
            }
            if (max != 0)
            {
                for (int j = 0; j < jj; j++)
                {
                    if (C[i, j] < 0)
                    {
                        C[i, j] /= max;
                    }
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
        double max = 0, s = 0, k = 0;
        int jj = 0, ii = 0;
        int n = Z.GetLength(0), m = Z.GetLength(1);
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return default;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if ((Z[i, j] > max))
                {
                    max = Z[i, j];
                    jj = j;
                    ii = i;
                }
                if (Z[i, j] > 0)
                {
                    s += Z[i, j];
                    k++;
                }
            }
        }
        Z[ii, jj] = s / k;
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
        int n = X.GetLength(0), m = X.GetLength(1);
        if (n != 6 || m != 5) return default;
        int maxn = 0, minn = m, maxi = 0, maxj = 0, mini = 0, minj = 0, p = 0;
        for (int i = 0; i < n; i++)
        {
            int max = 0, min = 0;
            for (int j = 0; j < m; j++)
            {
                if ((X[i, j] < 0))
                {
                    max++;
                    min++;

                }
            }
            if (max > maxn)
            {
                maxn = max;
                mini = i;
            }
            if (min < minn)
            {
                minn = min;
                maxi = i;
            }
        }
        for (int j = 0; j < m; j++)
        {
            p = X[mini, j];
            X[mini, j] = X[maxi, j];
            X[maxi, j] = p;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) return default;

        int maxsum = -1, maxsumi = -1;

        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }
            }
            if (sum > maxsum)
            {
                maxsum = sum;
                maxsumi = i;
            }
        }

        if (maxsumi == -1) return default;
        int[,] newA = new int[n - 1, m];
        int k = 0;

        for (int i = 0; i < n; i++)
        {
            if (i == maxsumi)
            {
                k++;
                continue;
            }
            for (int j = 0; j < m; j++)
            {
                newA[i - k, j] = A[i, j];
            }
        }
        A = newA;
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
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 5 || m != 8 || B.Length != 5) return default;
        int mini = A[4, 0], minj = 0;
        for (int j = 1; j < m; j++)
        {
            if (A[4, j] < mini)
            {
                mini = A[4, j];
                minj = j;
            }
        }
        for (int j = m - 1; j > minj + 1; j--)
        {
            for (int i = 0; i < n; i++)
            {
                A[i, j] = A[i, j - 1];
            }
        }
        for (int i = 0; i < n; i++)
        {
            A[i, minj + 1] = B[i];
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
        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 5 || m != 7)
            return null;



        for (int i = 0; i < n; i++)
        {
            double max = double.MinValue;
            int jmax = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    jmax = j;
                }
            }

            if (jmax == 0 || A[i, jmax - 1] > A[i, jmax + 1])
            {
                if (A[i, jmax + 1] > 0)
                    A[i, jmax + 1] *= 2;
                else if (A[i, jmax + 1] < 0)
                    A[i, jmax + 1] /= 2;
            }
            else if (jmax == m - 1 || A[i, jmax - 1] < A[i, jmax + 1])
            {
                if (A[i, jmax - 1] > 0)
                    A[i, jmax - 1] *= 2;
                else if (A[i, jmax - 1] < 0)
                    A[i, jmax - 1] /= 2;
            }
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight < 3)
            return default(int[,]);

        for (int j = 0; j < AWeight; j++)
        {
            int countPos = 0, countDif = 0;
            int maxValue = A[0, j], indMax = 0;
            for (int i = 0; i < AHeight; i++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                    indMax = i;
                }

                if (A[i, j] > 0)
                    countPos++;
                else if (A[i, j] != 0)
                    countDif++;
            }

            if (countPos > countDif)
                A[indMax, j] = 0;
            else
                A[indMax, j] = indMax + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 10 || m != 5)
            return null;



        for (int j = 0; j < m; j++)
        {
            int max = int.MinValue, imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            if (imax < (n / 2))
            {
                int sum = 0;
                for (int i = imax + 1; i < n; i++)
                    sum += A[i, j];

                A[0, j] = sum;
            }

        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1), BLenght = B.Length;

        if (AHeight < 3 || BLenght != AWeight)
            return default(int[,]);

        for (int j = 0; j < AWeight; j++)
        {
            int maxValue = A[0, j], indMax = 0;
            for (int i = 0; i < AHeight; i++)
            {
                if (A[i, j] > maxValue)
                {
                    maxValue = A[i, j];
                    indMax = i;
                }
            }

            if (A[indMax, j] < B[j])
                A[indMax, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);

        if (n != 7 || m != 5)
            return null;


        for (int j = 0; j < m; j++)
        {
            double max = double.MinValue;
            int imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    imax = i;
                }
            }
            double p = (A[0, j] + A[n - 1, j]) / 2;
            if (p > max)
                A[imax, j] = p;
            else
                A[imax, j] = imax + 1;
        }

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 3)
            return answer;

        int[,] A = new int[n, n * 3];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 3; j++)
            {
                if (i == j || i == j - 3 || i == j - 6)
                    A[i, j] = 1;
                else
                    A[i, j] = 0;
            }
        }
        answer = A;
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
        int n = B.GetLength(0), m = B.GetLength(1), max1 = int.MinValue, imax1 = -1, max2 = int.MinValue, imax2 = -1;

        if (n != 6 || m != 6)
            return null;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i % 2 == 0)
                {
                    if (B[i, j] > max1)
                    {
                        max1 = B[i, j];
                        imax1 = j;
                    }
                }

                if (i % 2 != 0)
                {
                    if (B[i, j] > max2)
                    {
                        max2 = B[i, j];
                        imax2 = j;
                    }
                }
            }
            if (i % 2 != 0)
            {
                B[i - 1, imax1] = max2;
                B[i, imax2] = max1;
                max1 = max2 = int.MinValue;
                imax1 = imax2 = 0;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int AHeight = A.GetLength(0), AWeight = A.GetLength(1);

        if (AHeight != 6 && AWeight != 7)
            return default(int[,]);

        for (int i = 0; i < AHeight; i++)
        {
            for (int j = 0; j < AWeight / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, AWeight - j - 1];
                A[i, AWeight - j - 1] = temp;
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

        if (n != 7 && m != 5)
            return null;


        int[,] newmatrix = new int[n, 2];

        const int min = int.MaxValue;


        for (int i = 0; i < n; i++)
        {
            newmatrix[i, 0] = i;
            newmatrix[i, 1] = min;

            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < newmatrix[i, 1])
                    newmatrix[i, 1] = matrix[i, j];
            }
        }

        for (int i = 1, j = 2; i < n;)
        {
            if (i == 0 || newmatrix[i, 1] <= newmatrix[i - 1, 1])
            {
                i = j;
                j++;
            }
            else
            {
                int temp = newmatrix[i, 1],
                itemp = newmatrix[i, 0],
                inext = newmatrix[i - 1, 0];

                for (int k = 0; k < m; k++)
                {
                    int temp1 = matrix[i, k];
                    matrix[i, k] = matrix[i - 1, k];
                    matrix[i - 1, k] = temp1;
                }

                newmatrix[i, 1] = newmatrix[i - 1, 1];
                newmatrix[i, 0] = newmatrix[i - 1, 0];

                newmatrix[i - 1, 1] = temp;
                newmatrix[i - 1, 0] = itemp;
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
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || n < 3)
            return answer;

        answer = new int[n * 2 - 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int index = j - i + n - 1;
                answer[index] += matrix[i, j];
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

        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m || k < 1) 
            return null;
        int[] max = new int[] { 0, 0 };

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            { 
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[max[0], max[1]])) 
                { 
                    max[0] = i; 
                    max[1] = j;
                } 
            }
        }

        if (max[1] != k - 1)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[max[0], j];
                matrix[max[0], j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (max[0] != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, max[1]];
                matrix[i, max[1]] = matrix[i, k - 1];
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
        int l1 = A.Length, l2 = B.Length, index = 0;
        if (l1 < 2 || l2 < 2) return answer;

        int[,] matrix1 = new int[n, n], matrix2 = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrix1[i, j] = A[index];
                matrix2[i, j] = B[index];
                matrix1[j, i] = A[index];
                matrix2[j, i] = B[index];
                index++;
            }
        }

        int[] matrix3 = new int[n * n];

        int index3 = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                    matrix3[index3] += matrix1[i, k] * matrix2[k, j];
                index3++;
            }
        }
        answer = matrix3;

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
        bool an;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            an = false;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int ci = 0, cj = 0;
                for (int z = 0; z < matrix.GetLength(0); z++)
                {
                    if (matrix[z, j] < 0)
                        ci++;
                    if (matrix[z, j + 1] < 0)
                        cj++;
                }
                if (ci > cj)
                {
                    for (int z = 0; z < matrix.GetLength(0); z++)
                    {
                        int temp = matrix[z, j];
                        matrix[z, j] = matrix[z, j + 1];
                        matrix[z, j + 1] = temp;
                    }
                    an = true;
                }
            }
            if (an == false)
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
        int AHeight = matrix.GetLength(0), AWeight = matrix.GetLength(1);

        if (AHeight < 2)
            return default(int[,]);

        int nonZeroRowsCount = 0;
        for (int i = 0; i < AHeight; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < AWeight; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }

            if (hasZero == false)
                nonZeroRowsCount++;
        }

        int[,] filteredMatrix = new int[nonZeroRowsCount, AWeight];
        int currentRow = 0;

        for (int i = 0; i < AHeight; i++)
        {
            bool hasZero = false;

            for (int j = 0; j < AWeight; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (hasZero == false)
            {
                for (int j = 0; j < AWeight; j++)
                {
                    filteredMatrix[currentRow, j] = matrix[i, j];
                }
                currentRow++;
            }
        }
        matrix = filteredMatrix;
        // end

        return matrix;
    }
    #endregion
}