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
        if (n != 5 || m != 7) return answer;
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
        if (n != 3 || m != 6) return (row, col);
        int min = 1000;
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
        int[] answer = new int[5];
        // code here
        int n=A.GetLength(0);
        int m=A.GetLength(1);
        if (n != 3 || m != 5) return null;
        for (int j = 0; j < m; j++)
        {
            int max = -1000;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max) 
                {
                    max = A[i, j];
                }
            }
            answer[j] = max;
            
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
        int n= A.GetLength(0);
        int m=A.GetLength(1);
        if (n != 5 || m != 7) return null;
        int max = -1000;
        int index = -1;
        for (int i = 0; i < n; i++)
        {
            
            if (A[i, 2] > max)
            {
                max= A[i, 2];
                index = i;
            }
        }
        for (int j = 0; j < m; j++)
        {
            int temp = A[3, j];
            A[3, j] = A[index, j];
            A[index, j] = temp;
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
        int n= A.GetLength(0);
        int m= A.GetLength(1);
        if (n != 5 || m != 5) return null;
        int max = -1000, index = -1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max && i == j)
                {
                    max = A[i, j];
                    index = j;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            int temp = A[i, 3];
            A[i,3] = A[i, index];
            A[i, index] = temp;
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
        n= A.GetLength(0);
        m= A.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            int max = -1000, index = -1;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max)
                {
                    max= A[i, j];
                    index = j;
                }
            }
            int temp = A[i, index];
            for (int j = index; j < m - 1; j++)
            {
                A[i, j] = A[i, j + 1];
            }
            A[i, m - 1] = temp;
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
        n= C.GetLength(0);
        m = C.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            double max = -1000;
            int index = -1;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > max)
                {
                    max = C[i, j];  
                    index = j;
                }
            }
            for (int j = 0; j < index; j++)
            {
                if (C[i, j] < 0)
                {
                    C[i, j]/= max;
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
        int n= Z.GetLength(0);
        int m= Z.GetLength(1);
        if (n != 6 || m != 8) return null;
        double summ = 0, sredn = 0,max = -1000;
        int k = 0, indexi = -1, indexj = -1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (Z[i, j] > 0)
                {
                    summ += Z[i, j];
                    k++;
                }
                if (Z[i, j] > max)
                {
                    max = Z[i, j];
                    indexi=i;
                    indexj=j;
                }
            }
        }
        sredn = summ/k;
        Z[indexi, indexj] = sredn;
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
        int n = X.GetLength(0);
        int m = X.GetLength(1);
        if (n != 6 || m != 5) return null;
        int indexmax = -1, indexmin = -1, kmin = 100, kmax = -100;
        for (int i = 0; i < n; i++)
        {
            int k = 0;
            for (int j = 0; j < m; j++)
            {
                if (X[i, j] < 0)
                {
                    k++;
                }
            }
            if (k > kmax)
            {
                kmax = k;
                indexmax = i;
            }
            if (k < kmin)
            {
                kmin = k;
                indexmin = i;
            }
        }
        for (int j = 0; j < m; j++)
        {
            int temp = X[indexmax, j];
            X[indexmax, j] = X[indexmin, j];
            X[indexmin,j] = temp;
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
        int index = -1, max = -1000, summ;
        for (int i = 0; i < n; i++)
        {
            summ = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i,j]>0) summ += A[i, j];
            }
            if (max < summ)
            {
                max = summ;
                index = i;
            }
        }
        int[,] B = new int[6, 5];
        for (int i = 0; i < index; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                B[i, j] = A[i, j];
            }
        }
        for (int i = index + 1; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                B[i - 1, j] = A[i, j];
            }
        }

        // end

        return B;
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        int p=B.Length;
        if (n != 5 || m != 8 || p!=5) return null;
        int index = -1, min = 1000;
        for (int j = 0; j < 8; j++)
        {
            if (A[4, j] < min)
            {
                index = j;
                min = A[4, j];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            A[i, index + 1] = B[i];
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
        int n = A.GetLength(0); 
        int m = A.GetLength(1);
        if (n != 5 || m != 7) return null;
        for (int i = 0; i < n; i++)
        {
            double maxi = -1000;
            int max = 0;
            for (int j = 0; j < m; j++)
            {
                if (maxi < A[i, j])
                {
                    maxi = A[i, j];
                    max = j;
                }
            }
            if (max == 0 && A[i, 1] > 0) A[i, 1] *= 2;
            else if (max == 0 && A[i, 1] < 0) A[i, 1] /= 2;
            else if (max == 6 && A[i, 5] > 0) A[i, 5] *= 2;
            else if (max == 6 && A[i, 5] < 0) A[i, 5] /= 2;
            else if (A[i, max - 1] <= A[i, max + 1] && A[i, max - 1] > 0) A[i, max - 1] *= 2;
            else if (A[i, max - 1] <= A[i, max + 1] && A[i, max - 1] < 0) A[i, max - 1] /= 2;
            else if (A[i, max - 1] > A[i, max + 1] && A[i, max - 1] > 0) A[i, max + 1] *= 2;
            else A[i, max + 1] /= 2;
        }
            // end

            return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 7 || m != 5) return null;
        for (int j = 0; j < m; j++)
        {
            int k_pol = 0, k_otr = 0, max = -1000, indexi = -1, indexj = -1;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] < 0) k_otr++;
                if (A[i, j] > 0) k_pol++;
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    indexi = i;

                }
            }
            if (k_pol > k_otr)
            {
                A[indexi, j] = 0;
            }
            else A[indexi, j] = indexi + 1;

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
        for (int j = 0; j < m; j++)
        {
            int max = -1000, index = 0, sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }
            if (index <= 4)
            {
                for (int i = index + 1; i < 10; i++)
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
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        int p = B.Length;
        if (n != 7 || m != 5 || p != 5) return null;
        for (int j = 0; j < m; j++)
        {
            int index = 0, max = -1000;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }
            if (B[j] > A[index, j]) A[index, j] = B[j];
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
        for (int j = 0; j < m; j++)
        {
            double max = -1000;
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }
            if (A[index, j] < (A[0, j] + A[n - 1, j]) / 2)
            {
                A[index, j] = (A[0, j] + A[n - 1, j]) / 2;
            }
            else A[index, j] = index + 1;
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
                if ((j - i) % n == 0)
                {
                    answer[i, j] = 1;
                }
                else answer[i, j] = 0;
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
        int index = 0; 
        double max = -1000;
        if (n != 6 || m != 6) return null;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > max && i == j)
                {
                    max = A[i, j];
                    index = i;
                }
            }
        }
        for (int i = 0; i < index; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i < j)
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
        int n = B.GetLength(0);
        int m = B.GetLength(1);
        if (n != 6 || m != 6) return null;
        int max1, max2, index1 = 0, index2 = 0;
        for (int i = 0; i < n - 1; i += 2)
        {
            max1 = B[i, 0];
            max2 = B[i + 1, 0];
            index1 = 0;
            index2 = 0;
            for (int j = 0; j < m; j++)
            {
                if (max1 < B[i, j])
                {
                    max1 = B[i, j];
                    index1 = j;
                }
                if (max2 < B[i + 1, j])
                {
                    max2 = B[i + 1, j];
                    index2 = j;
                }
            }
            B[i, index1] = max2;
            B[i + 1, index2] = max1;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 6 || m != 7) return null;
        int t;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m / 2; j++)
            {
                t = A[i, m - 1 - j];
                A[i, m - 1 - j] = A[i, j];
                A[i, j] = t;
            }

        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != 7 || m != 5) return null;
        int[] a = new int[n];
        int index = -1, k;
        for (int i = 0; i < n; i++)
        {
            int min = 1000;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j]; index = j;
                }
            }
            a[i] = min;
        }
        for (int i = n - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (a[j] < a[j + 1])
                {
                    k = a[j + 1];
                    a[j + 1] = a[j];
                    a[j] = k;
                    swapRows(ref matrix, j, j + 1);
                }
            }
        }
        // end

        return matrix;
    }
    public void swapRows(ref int[,] A, int row1, int row2)
    {
        int m = A.GetLength(1);
        int temp;
        for (int j = 0; j < m; j++)
        {
            temp = A[row1, j];
            A[row1, j] = A[row2, j];
            A[row2, j] = temp;
        }
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != m) return null;
        answer = new int[2 * n - 1];
        for (int i = 0; i < 2 * n - 1; i++)
        {
            answer[i] = 0;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[j - i + (n - 1)] += matrix[i, j];
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
        if (n != m || k <= 0) return null;
        int row = 0, col = 0;
        int x;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[row, col]))
                {
                    row = i;
                    col = j;
                }
        }
        for (int i = 0; i < m; i++)
        {
            x = matrix[i, col];
            matrix[i, col] = matrix[i, k - 1];
            matrix[i, k - 1] = x;
        }
        for (int j = 0; j < m; j++)
        {
            x = matrix[row, j];
            matrix[row, j] = matrix[k - 1, j];
            matrix[k - 1, j] = x;
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
        answer= new int[n*n];
        int rows = A.Length;
        int cols = B.Length;
        if (2 * rows - n != n * n || 2 * cols - n != n * n) return null;
        int[,] matrix1 = new int[n, n];
        int [,] matrix2 = new int[n, n];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                matrix1[i, j] = A[index];
                matrix1[j, i] = A[index];
                matrix2[i, j] = B[index];
                matrix2[j, i] = B[index];
                index++;
            }
        }
        index = 0;
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n; k++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                {
                    s += matrix1[i, j] * matrix2[j, k];
                }
                answer[index] = s;
                index++;
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != 5 || m != 7) return null;
        int[,] m1 = new int[m, 2];
        for (int i = 0; i < m; i++)
        {
            int k_otr = 0;
            for (int j = 0; j < n; j++)
            {
                if (matrix[j, i] < 0) k_otr++;
            }
            m1[i, 0] = i;
            m1[i, 1] = k_otr;
        }
        for (int i = 0; i < m - 1; i++)
        {
            for (int j = 0; j < m - i - 1; j++)
            {
                if (m1[j, 1] > m1[j + 1, 1])
                {
                    int tmp1 = m1[j, 0];
                    int tmp2 = m1[j, 1];

                    m1[j, 0] = m1[j + 1, 0];
                    m1[j, 1] = m1[j + 1, 1];

                    m1[j + 1, 0] = tmp1;
                    m1[j + 1, 1] = tmp2;
                }
            }
        }
        int[,] newMatrix = new int[n, m];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                newMatrix[j, i] = matrix[j, m1[i, 0]];
            }
        }
        matrix = newMatrix;
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int[] array = new int[n];
        int index = 0, f = 1, k = 0;
        for (int i = 0; i < n; i++)
        {
            f = 1;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    k++;
                    f = 0;
                    break;
                }
            }
            if (f == 0)
            {
                array [index] = i;
                index++;
            }
        }
        int[,] newMatrix = new int[n - k, m];
        index = 0;
        for (int i = 0; i < n; i++)
        {
            if (i == array [index]) index++;
            else
            {
                for (int j = 0; j < m; j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }
        }
        matrix = newMatrix;
        // end

        return matrix;
    }
    #endregion
}