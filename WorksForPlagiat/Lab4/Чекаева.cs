using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return 0;
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    answer += A[i, j];
                }
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
        int minel = A[0, 0];
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < minel)
                {
                    minel = A[i, j];
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
        int k = 0;
        if (A.GetLength(0) == 0 || A == null)
        {
            return null;
        }
        // code here
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int maxel = A[0, i];
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > maxel)
                {
                    maxel = A[j, i];
                }
            }
            answer[k++] = maxel;
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
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }
        int row = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxel = A[i, 0];
            int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxel)
                {
                    maxel = A[i, j];
                    index = j;
                }
                if (index == 3)
                {
                    row = i;
                }
            }
        }

        for (int i = 0; i < A.GetLength(1); i++)
        {
            int temp = A[row, i];
            A[row, i] = A[3, i];
            A[3, i] = temp;
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
        int maxElement = A[0, 0];
        int indexOfMax = 0;

        for (int i = 1; i < 5; i++)
        {
            if (A[i, i] > maxElement)
            {
                maxElement = A[i, i];
                indexOfMax = i;
            }
        }


        int colWithMax = indexOfMax;


        for (int k = 0; k < 5; k++)
        {
            int temp = A[k, 3];
            A[k, 3] = A[k, colWithMax];
            A[k, colWithMax] = temp;
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
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int maxel = A[i, 0];
            int index = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > maxel)
                {
                    maxel = A[i, j];
                    index = j;
                }
            }
            for (int k = index + 1; k < A.GetLength(1); k++)
            {
                A[i, k - 1] = A[i, k];
            }
            A[i, A.GetLength(1) - 1] = maxel;
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
        for (int i = 0; i < C.GetLength(0); i++)
        {
            double maxel = C[i, 0];
            int index = 0;
            for (int j = 0; j < C.GetLength(1); j++)
            {
                if (C[i, j] > maxel)
                {
                    maxel = C[i, j];
                    index = j;
                }
            }
            for (int k = 0; k < index; k++)
            {
                if (C[i, k] < 0)
                {
                    C[i, k] /= maxel;
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8)
        {
            return null;
        }
        double maxel = Z[0, 0];
        int[] index = new int[2];
        double sum = 0;
        int count = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (Z[i, j] > maxel)
                {
                    maxel = Z[i, j];
                    index[0] = i;
                    index[1] = j;
                }
                if (Z[i, j] > 0)
                {
                    count++;
                    sum += Z[i, j];
                }
            }
        }
        Z[index[0], index[1]] = sum / count;
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
        int maxcol = 0;
        int mincol = 10000;
        int rowmax = 0;
        int rowmin = 0;
        for (int i = 0; i < 6; i++)
        {
            int countotr = 0;
            for (int j = 0; j < 5; j++)
            {
                if (X[i, j] < 0)
                {
                    countotr++;
                }
            }
            if (countotr > maxcol)
            {
                maxcol = countotr;
                rowmax = i;
            }
            if (countotr < mincol)
            {
                mincol = countotr;
                rowmin = i;
            }
        }
        for (int i = 0; i < X.GetLength(1); i++)
        {
            int temp = X[rowmax, i];
            X[rowmax, i] = X[rowmin, i];
            X[rowmin, i] = temp;
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
        int[,] NewA = new int[A.GetLength(0) - 1, A.GetLength(1)];
        int maxs = 0;
        int index = 0;
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
            if (sum > maxs)
            {
                maxs = sum;
                index = i;
            }
        }
        for (int i = 0; i < NewA.GetLength(0); i++)
        {
            for (int j = 0; j < NewA.GetLength(1); j++)
            {
                if (i < index)
                {
                    NewA[i, j] = A[i, j];
                }
                if (i >= index)
                {
                    NewA[i, j] = A[i + 1, j];
                }
            }
        }
        // end

        return NewA;
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

        int index = 0;
        int mn = A[4, 0];
        for (int j = 0; j < 7; j++)
        {
            if (mn > A[4, j])
            {
                index = j;
                mn = A[4, j];
            }
        }
        int[,] NewA = new int[5, 8];
        for (int j = 0; j < index + 1; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                NewA[i, j] = A[i, j];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            NewA[i, index + 1] = B[i];
        }
        for (int j = index + 2; j < 8; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                NewA[i, j] = A[i, j - 1];
            }
        }
        A = NewA;
        return A;

        // end


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
        for (int i = 0; i < 5; i++)
        {
            double maxel = A[i, 0];
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxel)
                {
                    maxel = A[i, j];
                    index = j;
                }
            }
            if (index == 0)
            {
                if (A[i, index + 1] > 0)
                {
                    A[i, index + 1] *= 2;
                }
                else
                {
                    A[i, index + 1] /= 2;
                }
            }
            else if (index == 6)
            {
                if (A[i, index - 1] > 0)
                {
                    A[i, index - 1] *= 2;
                }
                else
                {
                    A[i, index - 1] /= 2;
                }
            }
            else
            {
                if (A[i, index - 1] > A[i, index + 1])
                {
                    if (A[i, index + 1] > 0)
                    {
                        A[i, index + 1] *= 2;
                    }
                    else
                    {
                        A[i, index + 1] /= 2;
                    }
                }
                else
                {
                    if (A[i, index - 1] > 0)
                    {
                        A[i, index - 1] *= 2;
                    }
                    else
                    {
                        A[i, index - 1] /= 2;
                    }
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
            int countp = 0;
            int countotr = 0;
            int maxel = A[0, i];
            int index = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > 0)
                {
                    countp++;
                }
                if (A[j, i] < 0)
                {
                    countotr++;
                }
                if (A[j, i] > maxel)
                {
                    maxel = A[j, i];
                    index = j;
                }
            }
            if (countp > countotr)
            {
                A[index, i] = 0;
            }
            else
            {
                A[index, i] = index + 1;
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
            int maxel = A[0, i];
            int index = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > maxel)
                {
                    maxel = A[j, i];
                    index = j;
                }
                if (j <= 4)
                {
                    int sum = 0;
                    for (int k = index + 1; k < A.GetLength(0); k++)
                    {
                        sum += A[k, i];
                    }
                    A[0, i] = sum;
                }

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
            int maxel = A[0, i];
            int index = 0;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > maxel)
                {
                    maxel = A[j, i];
                    index = j;
                }
            }
            if (B[i] > maxel)
            {
                A[index, i] = B[i];
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
            double maxel = A[0, i];
            int index = 0;
            double sr = (A[0, i] + A[6, i]) / 2;
            for (int j = 0; j < A.GetLength(0); j++)
            {
                if (A[j, i] > maxel)
                {
                    maxel = A[j, i];
                    index = j;
                }
            }
            if (maxel < sr)
            {
                A[index, i] = sr;
            }
            else
            {
                A[index, i] = index + 1;
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
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3 * n; j++)
            {
                if (j == i || j % n == i)
                {
                    answer[i, j] = 1;
                }
                else
                {
                    answer[i, j] = 0;
                }
            }
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
        int row = 0;
        int maxel = A[0, 0];
        int index = 0;
        for (int i = 0; i < 6; i++)
        {
            if (A[i, i] > maxel)
            {
                maxel = A[i, i];
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            for (int j = 0; j < 6; j++)
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
        for (int i = 0; i < 6; i += 2)
        {
            int maxel1 = B[i, 0];
            int maxel2 = B[i + 1, 0];
            int index1 = 0;
            int index2 = 0;
            for (int j = 0; j < 6; j++)
            {
                if (B[i, j] > maxel1)
                {
                    maxel1 = B[i, j];
                    index1 = j;
                }
                if (B[i + 1, j] > maxel2)
                {
                    maxel2 = B[i + 1, j];
                    index2 = j;
                }
            }
            int temp = B[i, index1];
            B[i, index1] = B[i + 1, index2];
            B[i + 1, index2] = temp;
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
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, 6 - j];
                A[i, 6 - j] = temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
        {
            return null;
        }
        int[] minel = new int[7];
        for (int i = 0; i < 7; i++)
        {
            int minelem = matrix[i, 0];
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] < minelem)
                {
                    minelem = matrix[i, j];
                }
            }
            minel[i] = minelem;
        }

        for (int i = 0; i < 6; i++)
        {
            for (int j = i + 1; j < 7; j++)
            {
                if (minel[i] < minel[j])
                {
                    int temp = minel[i];
                    minel[i] = minel[j];
                    minel[j] = temp;

                    for (int k = 0; k < 5; k++)
                    {
                        int temp1 = matrix[i, k];
                        matrix[i, k] = matrix[j, k];
                        matrix[j, k] = temp1;
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) <= 1)
        {
            return null;
        }
        // code here

        int[] answer = new int[2 * matrix.GetLength(0) - 1];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int index = j - i + (matrix.GetLength(0) - 1);
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
        if (matrix.GetLength(0) != matrix.GetLength(1) || k < 1 || k > matrix.GetLength(0))
        {
            return null;
        }
        // code here
        int maxel = matrix[0, 0];
        int index1 = 0;
        int index2 = 0;
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > maxel)
                {
                    maxel = Math.Abs(matrix[i, j]);
                    index1 = i;
                    index2 = j;
                }
            }
        }
        if (index1 != k - 1)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = matrix[index1, j];
                matrix[index1, j] = matrix[k - 1, j];
                matrix[k - 1, j] = temp;
            }
        }
        if (index2 != k - 1)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = matrix[i, index2];
                matrix[i, index2] = matrix[i, k - 1];
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
        int[] answer = new int[n * n];

        // code here
        if (n < 1 || A.Length != n * n / 2 + n / 2 + n % 2 || B.Length != n * n / 2 + n / 2 + n % 2)
            return null;
        int[,] NewA = new int[n, n];
        int[,] NewB = new int[n, n];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                NewA[i, j] = A[k];
                NewB[i, j] = B[k];
                k++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > j)
                {
                    NewA[i, j] = NewA[j, i];
                    NewB[i, j] = NewB[j, i];
                }
            }
        }
        int q = 0;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sum = 0;
                for (int l = 0; l < n; l++)
                {
                    sum += NewA[i, l] * NewB[l, j];
                }
                answer[q++] = sum;
            }
        }
        return answer;
    }
    // end

    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 7)
        {
            return null;
        }
        int[,] NewM = new int[7, 2];
        int k = 0;
        for (int j = 0; j < 7; j++)
        {
            k = 0;
            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, j] < 0)
                {
                    k++;
                }

            }
            NewM[j, 0] = k;
            NewM[j, 1] = j;
        }
        int[,] Ans = new int[5, 7];
        int temp = 0;
        for (int i = 1; i < 7; i++)
        {
            for (int j = 0; j < 7 - i; j++)
            {
                if (NewM[j, 0] > NewM[j + 1, 0])
                {
                    temp = NewM[j, 0];
                    NewM[j, 0] = NewM[j + 1, 0];
                    NewM[j + 1, 0] = temp;

                    temp = NewM[j, 1];
                    NewM[j, 1] = NewM[j + 1, 1];
                    NewM[j + 1, 1] = temp;
                }
            }
        }
        for (int j = 0; j < 7; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                Ans[i, j] = matrix[i, NewM[j, 1]];
            }
        }
        matrix = Ans;
        return matrix;
    }

        // end

 
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            return null;
        }
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int[] row = new int[cols];
        
            for (int j = 0; j < cols; j++)
            {
                row[j] = matrix[i, j];
            }

            if (i % 2 == 0) 
            {
                for (int j = 0; j < row.Length - 1; j++)
                {
                    for (int k = 0; k < row.Length - 1 - j; k++)
                    {
                        if (row[k] < row[k + 1]) 
                        {
                            int temp = row[k];
                            row[k] = row[k + 1];
                            row[k + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j < row.Length - 1; j++)
                {
                    for (int k = 0; k < row.Length - 1 - j; k++)
                    {
                        if (row[k] > row[k + 1]) 
                        {
                            int temp = row[k];
                            row[k] = row[k + 1];
                            row[k + 1] = temp;
                        }
                    }
                }
            }
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = row[j];
            }
        
        }
        // end
        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            return null;
        }

        int nozero = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool haszero = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    haszero = true;
                    break; 
                }
            }
            if (haszero == false)
            {
                nozero++;
            }
        }

        int[,] newM = new int[nozero, matrix.GetLength(1)];
        int index = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool haszero = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    haszero = true;
                    break; 
                }
            }
            if (haszero == false)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newM[index, j] = matrix[i, j];
                }
                index++; 
            }
        }

        return newM;
    }
        // end


    #endregion
}