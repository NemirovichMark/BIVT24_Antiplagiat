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
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
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
        int ans = 1000;
        if (A.GetLength(0) == 3 && A.GetLength(1) == 6)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] < ans)
                    {
                        ans = A[i, j];
                        row = i;
                        col = j;
                    }
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
        // code here
        int j = 0;
        int n = 0;
        int[] answer = new int[5];
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5)
        {
            return null;
        }
        else
        {
            while (n != 5)
            {
                int max_j = -1000;
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    if (A[i, j] > max_j)
                        max_j = A[i, j];
                }
                j++;
                answer[n] = max_j;
                n++;
            }
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
        int n = 4;
        int max_i = 0;
        int max_j = int.MinValue;
        if (A.GetLength(0) == 5 && A.GetLength(1) == 7)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, n] > max_j)
                {
                    max_j = A[i, n];
                    max_i = i;
                }
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                int temp = A[max_i, j];
                A[max_i, j] = A[3, j];
                A[3, j] = temp;
            }
            return A;
        }
        else
            return null;
        // end
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
        int max_j = int.MinValue;
        int max_i = 0;
        if (A.GetLength(0) == 5 && A.GetLength(1) == 5)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if ((i == j || i == j - 1 - i) && A[i, j] > max_j)
                    {
                        max_j = A[i, j];
                        max_i = i;
                    }
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int a = A[i, 3];
                A[i, 3] = A[i, max_i];
                A[i, max_i] = a;
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            return A;
        }
        else
        {
            return null;
        }
        // end
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
        int b = 0;
        while (b != n)
        {
            int max_j = int.MinValue;
            int max_i = 0;
            int[] a = new int[m];
            for (int i = 0; i < m; i++)
            {
                a[i] = A[b, i];
            }
            for (int i = 0; i < m; i++)
            {
                if (a[i] > max_j)
                {
                    max_j = a[i];
                    max_i = i;
                }
            }
            for (int i = max_i; i < m - 1; i++)
            {
                a[i] = a[i + 1];
            }
            a[m - 1] = max_j;
            for (int i = 0; i < m; i++)
            {
                A[b, i] = a[i];
            }
            b++;
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
            double max_j = double.MinValue;
            int maxi = 0;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > max_j)
                {
                    max_j = C[i, j];
                    maxi = j;
                }
            }
            for (int k = 0; k < m; k++)
            {
                if (C[i, k] < 0 && k < maxi && max_j != 0)
                    C[i, k] /= max_j;
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
        if (Z.GetLength(0) == 6 && Z.GetLength(1) == 8)
        {
            int count = 0;
            double sum = 0;
            double max_j = double.MinValue;
            int max_ii = 0;
            int max_ij = 0;
            for (int i = 0; i < Z.GetLength(0); i++)
            {
                for (int j = 0; j < Z.GetLength(1); j++)
                {
                    if (Z[i, j] > 0)
                    {
                        count++;
                        sum += Z[i, j];
                    }
                    if (Z[i, j] > max_j)
                    {
                        max_j = Z[i, j];
                        max_ii = i;
                        max_ij = j;
                    }
                }
            }
            double a = sum / count;
            Z[max_ii, max_ij] = a;
            return Z;
        }
        else
            return null;
        // end
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
        int itog_i = 0;
        int max_min = 0;
        int itog_k = 0;
        int min_min = 10;
        if (X.GetLength(0) == 6 && X.GetLength(1) == 5)
        {
            int icount = 0;
            for (int i = 0; i < X.GetLength(0); i++)
            {
                icount = 0;
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    if (X[i, j] < 0)
                        icount++;
                }
                if (icount > max_min)
                {
                    itog_i = i;
                    max_min = icount;
                }
                if (min_min > icount)
                {
                    itog_k = i;
                    min_min = icount;
                }
            }
            for (int j = 0; j < X.GetLength(1); j++)
            {
                int ans = X[itog_i, j];
                X[itog_i, j] = X[itog_k, j];
                X[itog_k, j] = ans;
            }
            return X;
        }
        else
            return null;
        // end
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
        if (A.GetLength(0) == 7 && A.GetLength(1) == 5)
        {
            int max = 0;
            int n = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > 0)
                        count += A[i, j];
                }
                if (count > max)
                {
                    max = count;
                    n = i;
                }
            }
            int[,] Z = new int[A.GetLength(0) - 1, A.GetLength(1)];
            for (int i = 0; i < Z.GetLength(0); i++)
            {
                if (i < n)
                {
                    for (int j = 0; j < Z.GetLength(1); j++)
                    {
                        Z[i, j] = A[i, j];
                    }
                }
                else
                {
                    for (int j = 0; j < Z.GetLength(1); j++)
                    {
                        Z[i, j] = A[i + 1, j];
                    }
                }
            }
            return Z;
        }
        else
            return null;
        // end
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
        if (A.GetLength(0) == 5 && A.GetLength(1) == 8 && B.Length == 5)
        {
            int min_j= int.MaxValue;
            int min_i = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[4, j] < min_j)
                {
                    min_j = A[4, j];
                    min_i = j;
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
                A[i, min_i + 1] = B[i];
            return A;
        }
        else
            return null;
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
        double[,] B = default(double[,]);
        bool nenol = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    nenol = true;
                    break;
                }
            }
            if (nenol) break;
        }
        if (!nenol) return B;
        B = new double[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double m = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (m < A[i, j]) m = A[i, j];
                B[i, j] = A[i, j];
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if ((j == 0) && (B[i, j] == m))
                {
                    if (B[i, j + 1] > 0) 
                        B[i, j + 1] *= 2; 
                    else 
                        B[i, j + 1] /= 2; 
                    break;
                }
                else if ((j == A.GetLength(1) - 1) && (B[i, j] == m))
                {
                    if (B[i, j - 1] > 0) 
                        B[i, j - 1] *= 2; 
                    else 
                        B[i, j - 1] /= 2;
                    break;
                }
                else if (B[i, j] == m)
                {
                    if (B[i, j - 1] < B[i, j + 1])
                    {
                        if (B[i, j - 1] > 0) 
                            B[i, j - 1] *= 2;
                        else 
                            B[i, j - 1] /= 2;
                        break;
                    }
                    else
                    {
                        if (B[i, j + 1] > 0) 
                            B[i, j + 1] *= 2;
                        else 
                            B[i, j + 1] /= 2;
                        break;
                    }
                }
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) 
            return null;
        for (int j = 0; j < 5; j++)
        {
            int maxVal = int.MinValue;
            int maxp = -1;
            int row = 0;
            int col = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i, j] > 0) 
                    row++;
                else if (A[i, j] < 0) 
                    col++;

                if (maxVal < A[i, j])
                {
                    maxVal = A[i, j];
                    maxp = i;
                }
            }
            if (row > col) 
                A[maxp, j] = 0;
            else 
                A[maxp, j] = maxp + 1;
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 10 || A.GetLength(1) != 5)
            return null;
        for (int i = 0; i < 5; i++)
        {
            int max = int.MinValue;
            int ij = 0;
            int sum = 0;
            for (int j = 0; j < 10; j++)
            {
                if (A[j, i] > max) 
                { 
                    max = A[j, i]; 
                    ij = j; 
                }
            }
            if (ij < 5)
            {
                for (int j = ij + 1; j < 10; j++)
                    sum += A[j, i];
                A[0, i] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) 
            return null;
        if (B.Length != 5) 
            return null;
        for (int j = 0; j < 5; j++)
        {
            int max = int.MinValue;
            int maxp = -1;
            for (int i = 0; i < 7; i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    maxp = i;
                }
            }
            if (B[j] > A[maxp, j]) 
                A[maxp, j] = B[j];
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5) 
            return null;
        for (int j = 0; j < 5; j++)
        {
            double max = double.MinValue;
            int maxp = -1;
            for (int i = 0; i < 7; i++)
            {
                if (max < A[i, j])
                {
                    max = A[i, j];
                    maxp = i;
                }
            }
            double sum = (A[0, j] + A[6, j]) / 2.0;
            if (max < sum)
                A[maxp, j] = sum;
            else
                A[maxp, j] = maxp + 1;
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
        answer = new int[n, 3 * n];
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < n; j++)
                answer[j, j + i] = 1;
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 6) 
            return null;
        int maxd = int.MinValue;
        int maxdp = -1;
        for (int i = 0; i < 6; i++)
        {
            if (maxd < A[i, i])
            {
                maxd = A[i, i];
                maxdp = i;
            }
        }
        for (int i = 0; i < maxdp; i++)
        {
            for (int j = 0; j < 6; j++)
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
        if (B.GetLength(0) != 6 || B.GetLength(1) != 6)
            return null;
        for (int k = 0; k < 6; k += 2)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int ij1 = 0;
            int ij2 = 0;
            for (int j = 0; j < 6; j++)
            {
                if (B[k, j] > max1) 
                { 
                    max1 = B[k, j]; 
                    ij1 = j; 
                }
                if (B[k + 1, j] > max2) 
                { 
                    max2 = B[k + 1, j]; 
                    ij2 = j; 
                }
            }
            B[k, ij1] = max2;
            B[k + 1, ij2] = max1;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7)
            return null;
        for (int i = 0; i < 6; i++)
        {
            int ans;
            for (int j = 0; j < 7 / 2; j++)
            {
                ans = A[i, j];
                A[i, j] = A[i, 6 - j];
                A[i, 6 - j] = ans;
            }
        }
        // end

        return A;
    }
    #endregion
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
        if (matrix.GetLength(0) != matrix.GetLength(1)) 
            return default;
        for (int i = 0; i < matrix.Length; i++)
        {
            int row = i / matrix.GetLength(1);
            int col = i % matrix.GetLength(1);
            if (row == 0 || row == matrix.GetLength(0) - 1 || col == 0 || col == matrix.GetLength(1) - 1)
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        if (row != col) 
            return default;
        for (int i = row / 2; i < row; i++)
        {
            for (int j = 0; j <= i; j++)
                matrix[i, j] = 1;
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
        int a = matrix.GetLength(0);
        if (a <= 0 || a != matrix.GetLength(1))
            return (null, null);
        int n = 0;
        int g = 0;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                if (j >= i) 
                    n++;
                else 
                    g++;
            }
        }
        upper = new int[n];
        lower = new int[g];
        int n1 = 0;
        int g1 = 0;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                if (j >= i) 
                { 
                    upper[n1] = matrix[i, j]; 
                    n1++; 
                }
                else 
                { 
                    lower[g1] = matrix[i, j]; 
                    g1++; 
                }
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        if (row != 7 || col != 5) 
            return default;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6 - i; j++)
            {
                int cnt1 = 0;
                int cnt2 = 0;
                for (int k = 0; k < col; k++)
                {
                    if (matrix[j, k] > 0) 
                        cnt1++;
                    if (matrix[j + 1, k] > 0) 
                        cnt2++;
                }
                if (cnt1 < cnt2)
                {
                    for (int k = 0; k < col; k++)
                    {
                        int ans = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = ans;
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
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        for (int k = 0; k < row; k++)
        {
            int[] array = new int[col];
            for (int j = 0; j < col; j++)
                array[j] = matrix[k, j];
            int n = col, gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int key = array[i], j = i - gap;
                    while (j >= 0 && array[j] > key)
                    {
                        array[j + gap] = array[j];
                        j -= gap;
                    }
                    array[j + gap] = key;
                }
                gap /= 2;
                if (k % 2 == 0)
                {
                    for (int j = 0; j < col / 2; j++)
                    {
                        int p = array[j];
                        array[j] = array[col - 1 - j];
                        array[col - 1 - j] = p;
                    }
                }
                for (int j = 0; j < col; j++)
                    matrix[k, j] = array[j];
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
        int out_row = row;
        bool flag;
        int crow = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] == 0)
                {
                    out_row--;
                    break;
                }
            }
        }
        int[,] outp = new int[out_row, col];
        for (int i = 0; i < row; i++)
        {
            flag = true;
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (!flag)
                continue;
            for (int j = 0; j < col; j++)
                outp[crow, j] = matrix[i, j];
            crow++;
        }
        // end

        return outp;
    }
    #endregion
}